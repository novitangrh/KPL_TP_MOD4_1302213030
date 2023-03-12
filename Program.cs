// See https://aka.ms/new-console-template for more information

internal class KodePos
{
    private string[] nama = { "Batununggal", "A. Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
    private int[] kode = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

    public int getKodePos(string name)
    {
        for (int i = 0; i < nama.Length; i++)
        {
            if (nama[i] == name)
            {
                return kode[i];
            }
        }
        return -1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos code = new KodePos();

        Console.WriteLine("Kodepos Batununggal \t: " + code.getKodePos("Batununggal"));
        Console.WriteLine("Kodepos A. Kujangsari \t: " + code.getKodePos("A. Kujangsari"));
        Console.WriteLine("Kodepos Mengger \t: " + code.getKodePos("Mengger"));
        Console.WriteLine("Kodepos Wates \t\t: " + code.getKodePos("Wates"));
        Console.WriteLine("Kodepos Cijaura \t: " + code.getKodePos("Cijaura"));
        Console.WriteLine("Kodepos Jatisari \t: " + code.getKodePos("Jatisari"));
        Console.WriteLine("Kodepos Margasari \t: " + code.getKodePos("Margasari"));
        Console.WriteLine("Kodepos Sekejati \t: " + code.getKodePos("Sekejati"));
        Console.WriteLine("Kodepos Kebonwaru \t: " + code.getKodePos("Kebonwaru"));
        Console.WriteLine("Kodepos Maleer \t\t: " + code.getKodePos("Maleer"));
        Console.WriteLine("Kodepos Samoja \t\t: " + code.getKodePos("Samoja"));

    }
}

