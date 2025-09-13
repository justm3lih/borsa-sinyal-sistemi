@echo off
echo ========================================
echo Borsa Sinyal Sistemi - Veritabanı Kurulumu
echo ========================================
echo.

REM SQL Server LocalDB'nin yüklü olup olmadığını kontrol et
sqlcmd -S "(localdb)\MSSQLLocalDB" -Q "SELECT 1" >nul 2>&1
if errorlevel 1 (
    echo HATA: SQL Server LocalDB yüklü değil!
    echo Lütfen SQL Server LocalDB yükleyin: https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb
    pause
    exit /b 1
)

echo SQL Server LocalDB bulundu!
echo.

REM Veritabanı şemasını oluştur
echo [1/2] Veritabanı şeması oluşturuluyor...
sqlcmd -S "(localdb)\MSSQLLocalDB" -i "%~dp0..\database\schema.sql"
if errorlevel 1 (
    echo HATA: Veritabanı şeması oluşturulamadı!
    pause
    exit /b 1
)

echo Veritabanı şeması başarıyla oluşturuldu!
echo.

REM Örnek verileri ekle
echo [2/2] Örnek veriler ekleniyor...
sqlcmd -S "(localdb)\MSSQLLocalDB" -i "%~dp0..\database\sample_data.sql"
if errorlevel 1 (
    echo HATA: Örnek veriler eklenemedi!
    pause
    exit /b 1
)

echo Örnek veriler başarıyla eklendi!
echo.

echo ========================================
echo Veritabanı kurulumu tamamlandı!
echo ========================================
echo.
echo Artık uygulamayı çalıştırabilirsiniz.
echo Pencereyi kapatmak için herhangi bir tuşa basın...
pause >nul
