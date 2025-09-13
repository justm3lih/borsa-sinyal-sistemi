@echo off
echo ========================================
echo Borsa Sinyal Sistemi - Veri Besleyicileri
echo ========================================
echo.

REM Python'un yüklü olup olmadığını kontrol et
python --version >nul 2>&1
if errorlevel 1 (
    echo HATA: Python yüklü değil!
    echo Lütfen Python 3.8+ yükleyin: https://www.python.org/downloads/
    pause
    exit /b 1
)

REM Gerekli kütüphanelerin yüklü olup olmadığını kontrol et
echo Python kütüphaneleri kontrol ediliyor...
python -c "import yfinance, pandas, pyodbc" >nul 2>&1
if errorlevel 1 (
    echo Gerekli kütüphaneler yükleniyor...
    pip install yfinance pandas pyodbc
    if errorlevel 1 (
        echo HATA: Kütüphaneler yüklenemedi!
        pause
        exit /b 1
    )
)

echo.
echo Veri besleyicileri başlatılıyor...
echo Durdurmak için Ctrl+C tuşlayın
echo.

REM Veri besleyicilerini başlat
cd /d "%~dp0..\py"

echo [1/2] Anlık fiyat besleyicisi başlatılıyor...
start "Anlık Fiyat Besleyici" cmd /k "python anliy.py"

timeout /t 3 /nobreak >nul

echo [2/2] Mum verisi besleyicisi başlatılıyor...
start "Mum Verisi Besleyici" cmd /k "python feeder_candles.py"

echo.
echo Tüm veri besleyicileri başlatıldı!
echo Pencereyi kapatmak için herhangi bir tuşa basın...
pause >nul
