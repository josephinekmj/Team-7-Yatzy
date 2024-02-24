namespace Team_7_Yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til Team 7's Yatzy-spil!");
            Console.WriteLine("\n \nDette Yatzy-spil er for 2 spillere.");
            Console.WriteLine("\n \nTryk på en vilkårlig tast for at starte spillet.");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Hver spiller har 15 runder, med 3 kast. \n \nSpiller 1 skal nu kaste sine 5 terninger.\nTryk på en vilkårlig tast for at kaste terningerne.");
            Console.ReadKey();
            Console.Clear();

            int roundCounter = 1;    //variabel der tæller runderne i while loopet længere nede       

            int terning1, terning2, terning3, terning4, terning5;
            Random r = new Random();
            terning1 = r.Next(1, 7);
            terning2 = r.Next(1, 7);
            terning3 = r.Next(1, 7);
            terning4 = r.Next(1, 7);
            terning5 = r.Next(1, 7);
            Console.WriteLine("Sum:" + terning1 + "," + terning2 + "," + terning3 + "," + terning4 + "," + terning5 + "=" + (terning1 + terning2 + terning3 + terning4 + terning5));


            Console.WriteLine("Terning 1: " + terning1);
            Console.WriteLine(terning2);
            Console.WriteLine(terning3);
            Console.WriteLine(terning4);
            Console.WriteLine(terning5);


            while (roundCounter < 16)
            {
                Console.WriteLine("Runde: " + roundCounter);
                Console.WriteLine("SCOREBOARD: - spiller 1");
                Console.WriteLine("A - 1'ere: ");
                Console.WriteLine("B - 2'ere: ");
                Console.WriteLine("C - 3'ere: ");
                Console.WriteLine("D - 4'ere: ");
                Console.WriteLine("E - 5'ere: ");
                Console.WriteLine("F - 6'ere: ");

                Console.WriteLine("Runde: " + roundCounter);
                Console.WriteLine("SCOREBOARD: - spiller 2");
                Console.WriteLine("A - 1'ere: ");
                Console.WriteLine("B - 2'ere: ");
                Console.WriteLine("C - 3'ere: ");
                Console.WriteLine("D - 4'ere: ");
                Console.WriteLine("E - 5'ere: ");
                Console.WriteLine("F - 6'ere: ");

                roundCounter++;
                Console.WriteLine("Tryk på en tast for at gå til næste runde");
                Console.ReadKey();
                Console.Clear();
            }

            if (result1 > result2)
            {
                Console.WriteLine("Spiller 1 har vundet");
            }
            else if (result1 < result2)
            {
                Console.WriteLine("Spiller 2 har vundet");
            }
            else
            {
                Console.WriteLine("Spillet endte uafgjort!");
            }

            Console.WriteLine("");
            Console.WriteLine("Tryk på en vilkårlig tast for at afslutte spillet.");
            Console.ReadKey();
        }
    }
}
