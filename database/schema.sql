-- =============================================
-- Borsa Sinyal Sistemi - Veritabanı Şeması
-- =============================================

-- Veritabanını oluştur
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'PricesDb')
BEGIN
    CREATE DATABASE [PricesDb]
END
GO

USE [PricesDb]
GO

-- =============================================
-- TicksLatest Tablosu - Anlık Fiyat Verileri
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TicksLatest]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[TicksLatest](
        [Id] [int] IDENTITY(1,1) NOT NULL,
        [Symbol] [nvarchar](20) NOT NULL,
        [TsUtc] [datetime2](7) NOT NULL,
        [Price] [decimal](18, 4) NOT NULL,
        [Source] [nvarchar](50) NULL,
        CONSTRAINT [PK_TicksLatest] PRIMARY KEY CLUSTERED ([Id] ASC)
    )
END
GO

-- TicksLatest için indeksler
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[TicksLatest]') AND name = N'IX_TicksLatest_Symbol')
BEGIN
    CREATE UNIQUE NONCLUSTERED INDEX [IX_TicksLatest_Symbol] ON [dbo].[TicksLatest]
    (
        [Symbol] ASC
    )
END
GO

-- =============================================
-- Candles Tablosu - Mum Verileri (OHLC)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Candles]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Candles](
        [Id] [int] IDENTITY(1,1) NOT NULL,
        [Symbol] [nvarchar](20) NOT NULL,
        [Interval] [nvarchar](10) NOT NULL,
        [TsUtc] [datetime2](7) NOT NULL,
        [Open] [decimal](18, 4) NOT NULL,
        [High] [decimal](18, 4) NOT NULL,
        [Low] [decimal](18, 4) NOT NULL,
        [Close] [decimal](18, 4) NOT NULL,
        [Source] [nvarchar](50) NULL,
        CONSTRAINT [PK_Candles] PRIMARY KEY CLUSTERED ([Id] ASC)
    )
END
GO

-- Candles için indeksler
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Candles]') AND name = N'IX_Candles_Symbol_Interval_TsUtc')
BEGIN
    CREATE UNIQUE NONCLUSTERED INDEX [IX_Candles_Symbol_Interval_TsUtc] ON [dbo].[Candles]
    (
        [Symbol] ASC,
        [Interval] ASC,
        [TsUtc] ASC
    )
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Candles]') AND name = N'IX_Candles_Symbol_Interval')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Candles_Symbol_Interval] ON [dbo].[Candles]
    (
        [Symbol] ASC,
        [Interval] ASC
    )
END
GO

-- =============================================
-- Örnek Veri Ekleme (Opsiyonel)
-- =============================================

-- BIST30 sembolleri için örnek veri
INSERT INTO [dbo].[TicksLatest] ([Symbol], [TsUtc], [Price], [Source])
SELECT 'AKBNK.IS', GETUTCDATE(), 45.50, 'manual'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[TicksLatest] WHERE [Symbol] = 'AKBNK.IS')

INSERT INTO [dbo].[TicksLatest] ([Symbol], [TsUtc], [Price], [Source])
SELECT 'GARAN.IS', GETUTCDATE(), 125.75, 'manual'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[TicksLatest] WHERE [Symbol] = 'GARAN.IS')

-- =============================================
-- Stored Procedure'lar
-- =============================================

-- Son fiyatları getiren procedure
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetLatestPrices]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetLatestPrices]
GO

CREATE PROCEDURE [dbo].[GetLatestPrices]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        [Symbol],
        [TsUtc],
        [Price],
        [Source]
    FROM [dbo].[TicksLatest]
    ORDER BY [Symbol]
END
GO

-- Belirli sembol için mum verilerini getiren procedure
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCandles]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetCandles]
GO

CREATE PROCEDURE [dbo].[GetCandles]
    @Symbol NVARCHAR(20),
    @Interval NVARCHAR(10) = '15m',
    @Count INT = 100
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT TOP (@Count)
        [TsUtc],
        [Open],
        [High],
        [Low],
        [Close],
        [Source]
    FROM [dbo].[Candles]
    WHERE [Symbol] = @Symbol 
      AND [Interval] = @Interval
    ORDER BY [TsUtc] DESC
END
GO

-- =============================================
-- Veritabanı Kurulumu Tamamlandı
-- =============================================
PRINT 'Borsa Sinyal Sistemi veritabanı başarıyla oluşturuldu!'
PRINT 'Tablolar: TicksLatest, Candles'
PRINT 'Prosedürler: GetLatestPrices, GetCandles'
