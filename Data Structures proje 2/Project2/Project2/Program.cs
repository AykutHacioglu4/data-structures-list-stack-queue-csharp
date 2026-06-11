using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class EgeDeniziB
{
    public string BalikAdi { get; set; }
    public string DigerAdi { get; set; }
    public string Boyut { get; set; }
    public string Bilgi { get; set; }
    public List<string> Ortam { get; set; }

    public EgeDeniziB(string balikAdi, string digerAdi, string boyut, string bilgi, List<string> ortam)
    {
        BalikAdi = balikAdi;
        DigerAdi = digerAdi;
        Boyut = boyut;
        Bilgi = bilgi;
        Ortam = ortam;
    }
}

class Program
{
    static void Main()
    {
        string filePath = "Fishs.txt"; // Yüklenen dosyanın yolu
        string[] rawData = File.ReadAllLines(filePath);

        List<EgeDeniziB> egeBaliklari = new List<EgeDeniziB>();
        List<string> denizler = new List<string> { "Ege Denizi", "Akdeniz", "Karadeniz", "Marmara Denizi" };

        for (int i = 0; i < rawData.Length; i++)
        {
            if (!string.IsNullOrWhiteSpace(rawData[i]) && char.IsUpper(rawData[i][0]))
            {
                // Balık adı ve diğer adı ayrıştırılıyor
                string balikAdi = rawData[i].Split('(')[0].Trim(); // Ana balık adı
                string digerAdi = rawData[i].Contains("(") ? rawData[i].Split('(')[1].TrimEnd(')') : ""; // Parantez içindeki diğer ad

                string boyut = ""; 
                string bilgi = ""; 
                List<string> ortam = new List<string>(); 

                int j = i + 1;

                // Balığa ait tüm bilgileri ayrıştır
                while (j < rawData.Length && rawData[j] != "*")
                {
                    if (!string.IsNullOrWhiteSpace(rawData[j]))
                    {
                        string line = rawData[j].Trim();

                        // Boyut bilgileri
                        if (line.IndexOf("cm", StringComparison.OrdinalIgnoreCase) >= 0 ||
                            line.IndexOf("metre", StringComparison.OrdinalIgnoreCase) >= 0 ||
                            line.IndexOf("kg", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            boyut += line + " ";
                        }
                        // Ortam bilgileri
                        else if (denizler.Any(deniz => line.IndexOf(deniz, StringComparison.OrdinalIgnoreCase) >= 0))
                        {
                            foreach (var deniz in denizler)
                            {
                                if (line.IndexOf(deniz, StringComparison.OrdinalIgnoreCase) >= 0 && !ortam.Contains(deniz))
                                {
                                    ortam.Add(deniz);
                                }
                            }
                        }

                        // Geri kalanları bilgi alanına ekle
                        else
                        {
                            bilgi += line + " ";
                        }
                    }
                    j++;
                }

                // Balık nesnesini oluştur ve listeye ekle
                egeBaliklari.Add(new EgeDeniziB(balikAdi, digerAdi, boyut.Trim(), bilgi.Trim(), ortam));
                i = j; // İşlenmiş satırları atla
            }
        }



        // C: 4 gruba ayırma
        List<List<EgeDeniziB>> grupListesi = new List<List<EgeDeniziB>>();
        for (int k = 0; k < egeBaliklari.Count; k += 10)
        {
            grupListesi.Add(egeBaliklari.Skip(k).Take(10).ToList());
        }

        // D: Grupları yazdırma
        Console.WriteLine("Grupların Detayları:");
        for (int g = 0; g < grupListesi.Count; g++)
        {
            Console.WriteLine($"Grup {g + 1}:");
            foreach (var balik in grupListesi[g])
            {
                Console.WriteLine($"Ad: {balik.BalikAdi}");  // Sadece Ad kısmı burada
                Console.WriteLine($"Diğer Ad: {balik.DigerAdi}");
                Console.WriteLine($"Boyut: {balik.Boyut}");
                Console.WriteLine($"Bilgi: {balik.Bilgi}");
                Console.WriteLine($"Ortam: {string.Join(", ", balik.Ortam)}");
                Console.WriteLine(); // Her balık bilgisi arasına boşluk 
            }
            int digerAdSayisi = grupListesi[g].Count(b => !string.IsNullOrEmpty(b.DigerAdi));
            Console.WriteLine($"Bu grupta {digerAdSayisi} balığın diğer adı vardır.");
            Console.WriteLine(); // Gruplar arasına boşluk 
        }

        // YIGIT
        Stack<EgeDeniziB> balikYigiti = new Stack<EgeDeniziB>(egeBaliklari);
        Console.WriteLine("\nYığıttaki Balıklar:");
        while (balikYigiti.Count > 0)
        {
            var balik = balikYigiti.Pop();
            Console.WriteLine($"Ad: {balik.BalikAdi}");  // Sadece Ad kısmı burada
            Console.WriteLine($"Diğer Ad: {balik.DigerAdi}");
            Console.WriteLine($"Boyut: {balik.Boyut}");
            Console.WriteLine($"Bilgi: {balik.Bilgi}");
            Console.WriteLine($"Ortam: {string.Join(", ", balik.Ortam)}");
            Console.WriteLine(); // Her balık bilgisi arasına boşluk ekleniyor
        }

        // KUYRUK
        Queue<EgeDeniziB> balikKuyrugu = new Queue<EgeDeniziB>(egeBaliklari);
        Console.WriteLine("\nKuyruktaki Balıklar:");
        while (balikKuyrugu.Count > 0)
        {
            var balik = balikKuyrugu.Dequeue();
            Console.WriteLine($"Ad: {balik.BalikAdi}");  // Sadece Ad kısmı burada
            Console.WriteLine($"Diğer Ad: {balik.DigerAdi}");
            Console.WriteLine($"Boyut: {balik.Boyut}");
            Console.WriteLine($"Bilgi: {balik.Bilgi}");
            Console.WriteLine($"Ortam: {string.Join(", ", balik.Ortam)}");
            Console.WriteLine(); // Her balık bilgisi arasına boşluk ekleniyor
        }

        // ONCELIKLI KUYRUK
        Console.WriteLine("\nÖncelikli Kuyruk:");
        List<EgeDeniziB> oncelikliKuyruk = new List<EgeDeniziB>(egeBaliklari);
        while (oncelikliKuyruk.Count > 0)
        {
            // Öncelikli kuyruğun ilk elemanını alfabetik sıraya göre bul ve yazdır
            var enOncelikli = oncelikliKuyruk.OrderBy(b => b.BalikAdi).First();
            Console.WriteLine($"Ad: {enOncelikli.BalikAdi}");  // Sadece Ad kısmı burada
            Console.WriteLine($"Diğer Ad: {enOncelikli.DigerAdi}");
            Console.WriteLine($"Boyut: {enOncelikli.Boyut}");
            Console.WriteLine($"Bilgi: {enOncelikli.Bilgi}");
            Console.WriteLine($"Ortam: {string.Join(", ", enOncelikli.Ortam)}");
            Console.WriteLine(); // Her balık bilgisi arasına boşluk

            // Kuyruktan elemanı çıkar
            oncelikliKuyruk.Remove(enOncelikli);
        }
        


        // Verilen müşteri ürün listesi ve işlem süresi
        List<int> urunListesi = new List<int> { 15, 1, 12, 8, 7, 4, 21, 3, 2, 6, 5, 9, 11 };
        double islemSuresi = 3.3; // Her ürün için işlem süresi

        // FIFO Kuyruk Hesaplama
        Console.WriteLine("----- FIFO Kuyruk -----");
        MarketQueue.HesaplaVeYazdir(urunListesi, islemSuresi);

        // Öncelikli Kuyruk Hesaplama
        Console.WriteLine("\n----- Öncelikli Kuyruk (PQ) -----");
        PriorityMarketQueue.HesaplaVeYazdir(urunListesi, islemSuresi);

        // Karşılaştırma Yorumu
        Console.WriteLine("\n----- Kuyruk Türü Karşılaştırması -----");
        Console.WriteLine("Öncelikli Kuyruk (PQ) düzeni, ortalama işlem tamamlanma süresi açısından daha verimlidir.");
        Console.WriteLine("Ancak, ürün sayısı az olan müşteriler daha hızlı işlem görürken, daha önce gelen büyük ürünlü müşteriler beklemek zorunda kalabilir.");

        // Konsolu kapatmak için tuşa basmak
        Console.WriteLine("\nProgramı kapatmak için bir tuşa basın...");
        Console.ReadKey(); 

    }
}

class MarketQueue
{
    public static void HesaplaVeYazdir(List<int> urunListesi, double islemSuresi)
    {
        Queue<int> queue = new Queue<int>(urunListesi);
        double toplamSure = 0;
        double birikmisSure = 0;
        int musteriSayisi = queue.Count;

        Console.WriteLine("Kuyruk (FIFO) İşlem Süreleri:");
        int siradaki = 1;
        while (queue.Count > 0)
        {
            int urunSayisi = queue.Dequeue();
            double islemTamamlamaSuresi = urunSayisi * islemSuresi;
            birikmisSure += islemTamamlamaSuresi; // Birikmiş toplam süre
            toplamSure += birikmisSure; // Her müşterinin toplam işlem süresini ekle

            Console.WriteLine($"Müşteri {siradaki}: {urunSayisi} ürün, işlem tamamlanma süresi: {birikmisSure:F2} saniye");
            siradaki++;
        }

        double ortalamaSure = toplamSure / musteriSayisi;
        Console.WriteLine($"Kasa için ortalama işlem tamamlanma süresi: {ortalamaSure:F2} saniye");
    }
}
class PriorityMarketQueue
{
    public static void HesaplaVeYazdir(List<int> urunListesi, double islemSuresi)
    {
        List<int> priorityQueue = new List<int>(urunListesi);
        priorityQueue.Sort(); // Ürün sayısına göre artan sırada sıralama

        double toplamSure = 0;
        double birikmisSure = 0;
        int musteriSayisi = priorityQueue.Count;

        Console.WriteLine("Öncelikli Kuyruk (PQ) İşlem Süreleri:");
        int siradaki = 1;
        foreach (int urunSayisi in priorityQueue)
        {
            double islemTamamlamaSuresi = urunSayisi * islemSuresi;
            birikmisSure += islemTamamlamaSuresi; // Birikmiş toplam süre
            toplamSure += birikmisSure; // Her müşterinin toplam işlem süresini ekle

            Console.WriteLine($"Müşteri {siradaki}: {urunSayisi} ürün, işlem tamamlanma süresi: {birikmisSure:F2} saniye");
            siradaki++;
        }

        double ortalamaSure = toplamSure / musteriSayisi;
        Console.WriteLine($"Kasa için ortalama işlem tamamlanma süresi: {ortalamaSure:F2} saniye");
    }
}
