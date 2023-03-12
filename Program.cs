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

public class DoorMachine
{
    private DoorState state;

    public DoorMachine()
    {
        state = DoorState.Locked;
        Console.WriteLine("Pintu terkunci");
    }

    public void Unlock()
    {
        state = DoorState.Unlocked;
        Console.WriteLine("Pintu tidak terkunci");
    }

    public void Lock()
    {
        state = DoorState.Locked;
        Console.WriteLine("Pintu terkunci");
    }

    private enum DoorState
    {
        Locked,
        Unlocked
    }
}
class Program
{
    static void Main(string[] args)
    {
        KodePos kodepos = new KodePos();

        Console.WriteLine("Kodepos Batununggal \t: " + kodepos.getKodePos("Batununggal"));
        Console.WriteLine("Kodepos A. Kujangsari \t: " + kodepos.getKodePos("A. Kujangsari"));
        Console.WriteLine("Kodepos Mengger \t: " + kodepos.getKodePos("Mengger"));
        Console.WriteLine("Kodepos Wates \t\t: " + kodepos.getKodePos("Wates"));
        Console.WriteLine("Kodepos Cijaura \t: " + kodepos.getKodePos("Cijaura"));
        Console.WriteLine("Kodepos Jatisari \t: " + kodepos.getKodePos("Jatisari"));
        Console.WriteLine("Kodepos Margasari \t: " + kodepos.getKodePos("Margasari"));
        Console.WriteLine("Kodepos Sekejati \t: " + kodepos.getKodePos("Sekejati"));
        Console.WriteLine("Kodepos Kebonwaru \t: " + kodepos.getKodePos("Kebonwaru"));
        Console.WriteLine("Kodepos Maleer \t\t: " + kodepos.getKodePos("Maleer"));
        Console.WriteLine("Kodepos Samoja \t\t: " + kodepos.getKodePos("Samoja"));

        Console.WriteLine("");
        DoorMachine door = new DoorMachine();
        door.Unlock();
        door.Lock();

    }
}

