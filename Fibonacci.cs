public class Fibonacci
{
    public List<int> DiziElemani(int alt, int ust){
        if (alt<0 || ust<0 || ust<alt){
            throw new ArgumentException("Başlangıç ve bitiş değerleri geçersiz.");
        }

        List<int> fibonacciDizisi=new List<int> {0,1};

        while (fibonacciDizisi.Last() < ust)
        {
            int sonrakiDeger = fibonacciDizisi[fibonacciDizisi.Count - 1] + fibonacciDizisi[fibonacciDizisi.Count - 2];
            fibonacciDizisi.Add(sonrakiDeger);
        }

        return fibonacciDizisi.Where(x => x >= alt && x <= ust).ToList();
    }
}