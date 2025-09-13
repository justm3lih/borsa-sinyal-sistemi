# Veritabanı Şeması

Bu klasör Borsa Sinyal Sistemi için gerekli veritabanı dosyalarını içerir.

## Dosyalar

### 1. `schema.sql`
Ana veritabanı şeması dosyası. Bu dosyayı çalıştırarak:
- `PricesDb` veritabanını oluşturur
- `TicksLatest` tablosunu oluşturur (anlık fiyat verileri)
- `Candles` tablosunu oluşturur (mum verileri - OHLC)
- Gerekli indeksleri oluşturur
- Stored procedure'ları oluşturur

### 2. `sample_data.sql`
Örnek veri dosyası. Bu dosyayı çalıştırarak:
- BIST30 hisseleri için örnek anlık fiyatlar ekler
- AKBNK.IS ve GARAN.IS için örnek mum verileri ekler
- Veri kontrol sorgularını çalıştırır

## Kurulum

### 1. SQL Server Management Studio ile:
```sql
-- Önce schema.sql dosyasını çalıştırın
-- Sonra sample_data.sql dosyasını çalıştırın
```

### 2. Komut satırı ile:
```bash
sqlcmd -S "(localdb)\MSSQLLocalDB" -i schema.sql
sqlcmd -S "(localdb)\MSSQLLocalDB" -i sample_data.sql
```

### 3. PowerShell ile:
```powershell
sqlcmd -S "(localdb)\MSSQLLocalDB" -i "database\schema.sql"
sqlcmd -S "(localdb)\MSSQLLocalDB" -i "database\sample_data.sql"
```

## Tablo Yapısı

### TicksLatest Tablosu
| Sütun | Tip | Açıklama |
|-------|-----|----------|
| Id | int IDENTITY | Birincil anahtar |
| Symbol | nvarchar(20) | Hisse sembolü (örn: AKBNK.IS) |
| TsUtc | datetime2(7) | UTC zaman damgası |
| Price | decimal(18,4) | Anlık fiyat |
| Source | nvarchar(50) | Veri kaynağı |

### Candles Tablosu
| Sütun | Tip | Açıklama |
|-------|-----|----------|
| Id | int IDENTITY | Birincil anahtar |
| Symbol | nvarchar(20) | Hisse sembolü |
| Interval | nvarchar(10) | Zaman aralığı (1m, 15m, 1h, 1d) |
| TsUtc | datetime2(7) | UTC zaman damgası |
| Open | decimal(18,4) | Açılış fiyatı |
| High | decimal(18,4) | En yüksek fiyat |
| Low | decimal(18,4) | En düşük fiyat |
| Close | decimal(18,4) | Kapanış fiyatı |
| Source | nvarchar(50) | Veri kaynağı |

## Stored Procedures

### GetLatestPrices
Tüm hisselerin son fiyatlarını getirir.

### GetCandles
Belirli bir hisse ve zaman aralığı için mum verilerini getirir.

**Parametreler:**
- `@Symbol`: Hisse sembolü
- `@Interval`: Zaman aralığı (varsayılan: '15m')
- `@Count`: Getirilecek kayıt sayısı (varsayılan: 100)

## Bağlantı String'i

Uygulama şu bağlantı string'ini kullanır:
```
Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PricesDb;Integrated Security=True
```

## Notlar

- Veritabanı SQL Server LocalDB kullanır
- Tüm zaman damgaları UTC formatındadır
- Fiyatlar decimal(18,4) formatında saklanır
- Indeksler performans için optimize edilmiştir
