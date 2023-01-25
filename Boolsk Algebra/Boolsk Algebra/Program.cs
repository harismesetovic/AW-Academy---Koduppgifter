namespace Boolsk_Algebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frukt[] frukter = new Frukt[8];


            Frukt frukt = new Frukt();
            frukt.FruktTyp = "Banan";
            frukt.FruktNamn = "Chiquita";
            frukt.PrisPerKg = 22;
            frukter[0] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Banan";
            frukt.FruktNamn = "Dole";
            frukt.PrisPerKg = 25;
            frukter[1] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Banan";
            frukt.FruktNamn = "Del monte";
            frukt.PrisPerKg = 30;
            frukter[2] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Apelsin";
            frukt.FruktNamn = "Valencia";
            frukt.PrisPerKg = 24;
            frukter[3] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Apelsin";
            frukt.FruktNamn = "Mandarin";
            frukt.PrisPerKg = 30;
            frukter[4] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Apelsin";
            frukt.FruktNamn = "Blod";
            frukt.PrisPerKg = 27;
            frukter[5] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Päron";
            frukt.FruktNamn = "Anjou";
            frukt.PrisPerKg = 19;
            frukter[6] = frukt;

            frukt = new Frukt();
            frukt.FruktTyp = "Päron";
            frukt.FruktNamn = "Bartlett";
            frukt.PrisPerKg = 32;
            frukter[7] = frukt;

            for (int i = 0; i < frukter.Length; i++)
            {
                if (frukter[i].PrisPerKg < 30)
                {
                    Console.WriteLine($"Frukttyp: {frukter[i].FruktTyp}, Fruktnamn: {frukter[i].FruktNamn}, Pris: {frukter[i].PrisPerKg}");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < frukter.Length; i++)
            {
                if (frukter[i].FruktTyp == "Apelsin" && frukter[i].PrisPerKg >= 25)
                {
                    Console.WriteLine($"Frukttyp: {frukter[i].FruktTyp}, Fruktnamn: {frukter[i].FruktNamn}, Pris: {frukter[i].PrisPerKg}");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < frukter.Length; i++)
            {
                if (frukter[i].PrisPerKg > 25 && (frukter[i].FruktTyp == "Banan" || frukter[i].FruktTyp == "Päron"))
                {
                    Console.WriteLine($"Frukttyp: {frukter[i].FruktTyp}, Fruktnamn: {frukter[i].FruktNamn}, Pris: {frukter[i].PrisPerKg}");
                }
;
            }
        }
    }
}