internal class Program
{
    enum Kelurahan
    {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
    }
    private static int KodePos(Kelurahan inputK)
    {
        int[] outKodePos = {40266,40287,40267, 40256 , 40287, 40286, 40286 , 40286 , 40272 , 40274, 40273 };
        return outKodePos[(int)inputK];
    }
    private static void Main(string[] args)
    {
        Kelurahan kelurahan = Kelurahan.Samoja;
        int getKodePos = KodePos(kelurahan);
        Console.WriteLine("kelurahan "+kelurahan+"kode pos "+getKodePos);
    }
}