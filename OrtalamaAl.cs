public class Ortalama{

    public double OrtalamaHesapla(List<int> dizi){

    double toplam=0;

    foreach (var eleman in dizi)
    {
        toplam+=eleman;
    }
    double ortalama=toplam/dizi.Count;
    return ortalama;
    }
}