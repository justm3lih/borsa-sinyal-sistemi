-- =============================================
-- Borsa Sinyal Sistemi - Örnek Veri
-- =============================================

USE [PricesDb]
GO

-- =============================================
-- BIST30 Sembolleri için Örnek Anlık Fiyatlar
-- =============================================

-- Mevcut verileri temizle (opsiyonel)
-- DELETE FROM [dbo].[TicksLatest]
-- DELETE FROM [dbo].[Candles]

-- BIST30 hisseleri için örnek anlık fiyatlar
INSERT INTO [dbo].[TicksLatest] ([Symbol], [TsUtc], [Price], [Source]) VALUES
('AKBNK.IS', GETUTCDATE(), 45.50, 'sample'),
('ARCLK.IS', GETUTCDATE(), 78.25, 'sample'),
('ASELS.IS', GETUTCDATE(), 125.80, 'sample'),
('ASTOR.IS', GETUTCDATE(), 12.45, 'sample'),
('BIMAS.IS', GETUTCDATE(), 89.90, 'sample'),
('BRSAN.IS', GETUTCDATE(), 156.75, 'sample'),
('EKGYO.IS', GETUTCDATE(), 23.60, 'sample'),
('ENKAI.IS', GETUTCDATE(), 67.30, 'sample'),
('EREGL.IS', GETUTCDATE(), 45.20, 'sample'),
('FROTO.IS', GETUTCDATE(), 234.50, 'sample'),
('GARAN.IS', GETUTCDATE(), 125.75, 'sample'),
('GUBRF.IS', GETUTCDATE(), 89.40, 'sample'),
('HEKTS.IS', GETUTCDATE(), 34.85, 'sample'),
('ISCTR.IS', GETUTCDATE(), 78.90, 'sample'),
('KCHOL.IS', GETUTCDATE(), 45.60, 'sample'),
('KOZAA.IS', GETUTCDATE(), 67.25, 'sample'),
('KOZAL.IS', GETUTCDATE(), 89.75, 'sample'),
('KRDMD.IS', GETUTCDATE(), 123.40, 'sample'),
('PGSUS.IS', GETUTCDATE(), 56.80, 'sample'),
('PETKM.IS', GETUTCDATE(), 78.45, 'sample'),
('SAHOL.IS', GETUTCDATE(), 45.30, 'sample'),
('SASA.IS', GETUTCDATE(), 67.90, 'sample'),
('SISE.IS', GETUTCDATE(), 89.25, 'sample'),
('SOKM.IS', GETUTCDATE(), 34.60, 'sample'),
('TAKBN.IS', GETUTCDATE(), 56.75, 'sample'),
('TCELL.IS', GETUTCDATE(), 78.30, 'sample'),
('THYAO.IS', GETUTCDATE(), 234.80, 'sample'),
('TOASO.IS', GETUTCDATE(), 123.65, 'sample'),
('TUPRS.IS', GETUTCDATE(), 156.40, 'sample'),
('YKBNK.IS', GETUTCDATE(), 45.85, 'sample')
GO

-- =============================================
-- Örnek Mum Verileri (15 dakikalık)
-- =============================================

-- AKBNK.IS için örnek 15 dakikalık mum verileri
DECLARE @StartTime DATETIME2 = DATEADD(HOUR, -24, GETUTCDATE())
DECLARE @CurrentTime DATETIME2 = @StartTime
DECLARE @BasePrice DECIMAL(18,4) = 45.50

WHILE @CurrentTime < GETUTCDATE()
BEGIN
    -- Rastgele fiyat değişimi (-2% ile +2% arası)
    DECLARE @PriceChange DECIMAL(18,4) = (@BasePrice * (RAND() * 0.04 - 0.02))
    DECLARE @Open DECIMAL(18,4) = @BasePrice + @PriceChange
    DECLARE @High DECIMAL(18,4) = @Open + (RAND() * 0.5)
    DECLARE @Low DECIMAL(18,4) = @Open - (RAND() * 0.5)
    DECLARE @Close DECIMAL(18,4) = @Open + (RAND() * 0.3 - 0.15)
    
    INSERT INTO [dbo].[Candles] ([Symbol], [Interval], [TsUtc], [Open], [High], [Low], [Close], [Source])
    VALUES ('AKBNK.IS', '15m', @CurrentTime, @Open, @High, @Low, @Close, 'sample')
    
    SET @CurrentTime = DATEADD(MINUTE, 15, @CurrentTime)
    SET @BasePrice = @Close
END
GO

-- GARAN.IS için örnek 15 dakikalık mum verileri
DECLARE @StartTime2 DATETIME2 = DATEADD(HOUR, -24, GETUTCDATE())
DECLARE @CurrentTime2 DATETIME2 = @StartTime2
DECLARE @BasePrice2 DECIMAL(18,4) = 125.75

WHILE @CurrentTime2 < GETUTCDATE()
BEGIN
    DECLARE @PriceChange2 DECIMAL(18,4) = (@BasePrice2 * (RAND() * 0.04 - 0.02))
    DECLARE @Open2 DECIMAL(18,4) = @BasePrice2 + @PriceChange2
    DECLARE @High2 DECIMAL(18,4) = @Open2 + (RAND() * 1.0)
    DECLARE @Low2 DECIMAL(18,4) = @Open2 - (RAND() * 1.0)
    DECLARE @Close2 DECIMAL(18,4) = @Open2 + (RAND() * 0.6 - 0.3)
    
    INSERT INTO [dbo].[Candles] ([Symbol], [Interval], [TsUtc], [Open], [High], [Low], [Close], [Source])
    VALUES ('GARAN.IS', '15m', @CurrentTime2, @Open2, @High2, @Low2, @Close2, 'sample')
    
    SET @CurrentTime2 = DATEADD(MINUTE, 15, @CurrentTime2)
    SET @BasePrice2 = @Close2
END
GO

-- =============================================
-- Veri Kontrol Sorguları
-- =============================================

-- Anlık fiyat sayısını kontrol et
SELECT COUNT(*) as 'Anlık Fiyat Sayısı' FROM [dbo].[TicksLatest]

-- Mum verisi sayısını kontrol et
SELECT 
    Symbol,
    Interval,
    COUNT(*) as 'Mum Sayısı',
    MIN(TsUtc) as 'İlk Tarih',
    MAX(TsUtc) as 'Son Tarih'
FROM [dbo].[Candles]
GROUP BY Symbol, Interval
ORDER BY Symbol

-- Son fiyatları göster
SELECT TOP 10 * FROM [dbo].[TicksLatest] ORDER BY TsUtc DESC

-- Son mum verilerini göster
SELECT TOP 10 * FROM [dbo].[Candles] ORDER BY TsUtc DESC

PRINT 'Örnek veriler başarıyla eklendi!'
