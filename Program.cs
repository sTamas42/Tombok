namespace Tombok
{
    internal class Program
    {
        static string[] torpok = new string[7];
        static void TorpokLetrehozasa()

        {
            torpok[0] = "Szundi";
            torpok[1] = "Szende";
            torpok[2] = "Hapci";
            torpok[3] = "Morgo";
            torpok[4] = "Tudor";
            torpok[5] = "Vidor";
            torpok[6] = "Kuka";
        }

        static void TorpokKiirasa()
        {
            for (int i = 0; i < torpok.Length; i++)
            {
                Console.WriteLine(torpok[i]);
            }
        }

        static void Csere()
        {
            Console.Write("Melyik törpöt cseréljük le? ");
            string nev = Console.ReadLine();
            int index = 0;
            while (index < torpok.Length && torpok[index] != nev)
            {
                index++;
            }
            if (index < torpok.Length)
            {
                Console.Write("Melyik törpre cseréljük le? ");
                string ujNev = Console.ReadLine();
                torpok[index] = ujNev;
                Console.WriteLine("Lecserélve");
            }
            else
            {
                Console.WriteLine("Nincs ilyen törp a tömben");
            }
        }
        static void Main(string[] args)
        {
            TorpokLetrehozasa();
            TorpokKiirasa();
            Csere();
        }
    }
}
