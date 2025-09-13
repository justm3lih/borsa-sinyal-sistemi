# Borsa Sinyal Sistemi

BIST30 hisselerini takip eden ve teknik analiz sinyalleri üreten Windows uygulaması.

## Özellikler

- **Gerçek Zamanlı Fiyat Takibi**: BIST30 hisselerinin anlık fiyatlarını gösterir
- **Teknik Analiz Göstergeleri**: RSI, SMA, EMA, Bollinger Bantları
- **Sinyal Üretimi**: Al/Sat sinyalleri ve genel değerlendirme
- **Grafik Görünümü**: Seçilen hisse için fiyat grafiği
- **Otomatik Veri Besleme**: Python scriptleri ile sürekli veri güncelleme

## Teknolojiler

- **Frontend**: C# WinForms, MetroFramework UI
- **Backend**: SQL Server LocalDB
- **Veri Kaynağı**: Yahoo Finance API
- **Veri Besleme**: Python (yfinance, pandas, pyodbc)

## Kurulum

### Gereksinimler

- Windows 10/11
- .NET 8.0 Runtime
- SQL Server LocalDB
- Python 3.8+

### Adımlar

1. Projeyi klonlayın:
```bash
git clone https://github.com/justm3lih/borsa-sinyal-sistemi.git
cd borsa-sinyal-sistemi
```

2. Veritabanını kurun:
```bash
# SQL Server Management Studio ile database/schema.sql dosyasını çalıştırın
```

3. Python bağımlılıklarını yükleyin:
```bash
cd src/data-feeders
pip install -r requirements.txt
```

4. Uygulamayı çalıştırın:
```bash
# Visual Studio ile StockSignalApp.sln dosyasını açın ve çalıştırın
```

## Kullanım

1. **Ana Uygulama**: `src/StockSignalApp/` klasöründeki uygulamayı çalıştırın
2. **Veri Besleme**: `scripts/run-feeders.bat` dosyasını çalıştırarak veri besleyicilerini başlatın
3. **Hisse Seçimi**: Sol panelden bir hisse seçin, sağ panelde grafik görünecektir
4. **Sinyal Görüntüleme**: Hisse fiyatına çift tıklayarak teknik analiz sinyallerini görün

## Proje Yapısı

```
borsa-sinyal-sistemi/
├── src/
│   ├── StockSignalApp/          # Ana C# uygulaması
│   └── data-feeders/            # Python veri besleyicileri
├── database/                    # Veritabanı şemaları
├── config/                      # Konfigürasyon dosyaları
├── scripts/                     # Yardımcı scriptler
└── docs/                        # Dokümantasyon
```

## Katkıda Bulunma

1. Fork yapın
2. Feature branch oluşturun (`git checkout -b feature/yeni-ozellik`)
3. Commit yapın (`git commit -am 'Yeni özellik eklendi'`)
4. Push yapın (`git push origin feature/yeni-ozellik`)
5. Pull Request oluşturun

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır.

## İletişim

Sorularınız için issue açabilir, [LinkedIn](https://www.linkedin.com/in/osman-melih-%C3%A7%C4%B1nar-76312332a/) üzerinden veya [mlhcnr1903@icloud.com](mailto:mlhcnr1903@icloud.com) adresine e-posta göndererek iletişime geçebilirsiniz.
