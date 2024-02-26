namespace Team_7_Yatzy
{
    internal class Program
    {
        static int SumOfNumberOfEyes(int eyes, int t1, int t2, int t3, int t4, int t5)
        {
            int r = 0;
            if (eyes == t1) r++;
            if (eyes == t2) r++;
            if (eyes == t3) r++;
            if (eyes == t4) r++;
            if (eyes == t5) r++;
            return r;
        }


        static void Main(string[] args)
        {
            int terning1, terning2, terning3, terning4, terning5;
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {

                int sum1 = 0;
                int sum2 = 0;
                int sum3 = 0;
                int sum4 = 0;
                int sum5 = 0;
                int sum6 = 0;
                terning1 = r.Next(1, 7);
                terning2 = r.Next(1, 7);
                terning3 = r.Next(1, 7);
                terning4 = r.Next(1, 7);
                terning5 = r.Next(1, 7);

                sum1 = SumOfNumberOfEyes(1, terning1, terning2, terning3, terning4, terning5);
                sum2 = SumOfNumberOfEyes(2, terning1, terning2, terning3, terning4, terning5);
                sum3 = SumOfNumberOfEyes(3, terning1, terning2, terning3, terning4, terning5);
                sum4 = SumOfNumberOfEyes(4, terning1, terning2, terning3, terning4, terning5);
                sum5 = SumOfNumberOfEyes(5, terning1, terning2, terning3, terning4, terning5);
                sum6 = SumOfNumberOfEyes(6, terning1, terning2, terning3, terning4, terning5);


                Console.WriteLine($"Terninger: {terning1}, {terning2}, {terning3}, {terning4}, {terning5}");

                //
                // Regler
                //

                // Ettere
                 if ((sum1 == 1) || (sum1 == 2) || (sum1 == 3) || (sum1 == 4) || (sum1 == 5))
                    Console.Write("");
                // Toere
                if ((sum2 == 1) || (sum2 == 2) || (sum2 == 3) || (sum2 == 4) || (sum2 == 5))
                    Console.Write("");
                // Treere
                if ((sum3 == 1) || (sum3 == 2) || (sum3 == 3) || (sum3 == 4) || (sum3 == 5))
                    Console.Write("");
                // Firere
                if ((sum4 == 1) || (sum4 == 2) || (sum4 == 3) || (sum4 == 4) || (sum4 == 5))
                    Console.Write("");
                // Femmere
                if ((sum5 == 1) || (sum5 == 2) || (sum5 == 3) || (sum5 == 4) || (sum5 == 5))
                    Console.Write("");
                // Seksere
                if ((sum6 == 1) || (sum6 == 2) || (sum6 == 3) || (sum6 == 4) || (sum6 == 5))
                    Console.Write("");

                // Et par
                if ((sum1 == 2) || (sum2 == 2) || (sum3 == 2) || (sum4 == 2) || (sum5 == 2) || (sum6 == 2))
                    Console.WriteLine("1 par");

                // To par
                if ((sum1 == 2) && (sum2 == 2))
                    Console.WriteLine("2 par");
                if ((sum1 == 2) && (sum3 == 2))
                    Console.WriteLine("2 par");
                if ((sum1 == 2) && (sum4 == 2))
                    Console.WriteLine("2 par");
                if ((sum1 == 2) && (sum5 == 2))
                    Console.WriteLine("2 par");
                if ((sum1 == 2) && (sum6 == 2))
                    Console.WriteLine("2 par");

                if ((sum2 == 2) && (sum3 == 2))
                    Console.WriteLine("2 par");
                if ((sum2 == 2) && (sum4 == 2))
                    Console.WriteLine("2 par");
                if ((sum2 == 2) && (sum5 == 2))
                    Console.WriteLine("2 par");
                if ((sum2 == 2) && (sum6 == 2))
                    Console.WriteLine("2 par");

                if ((sum3 == 2) && (sum4 == 2))
                    Console.WriteLine("2 par");
                if ((sum3 == 2) && (sum5 == 2))
                    Console.WriteLine("2 par");
                if ((sum3 == 2) && (sum6 == 2))
                    Console.WriteLine("2 par");

                if ((sum4 == 2) && (sum5 == 2))
                    Console.WriteLine("2 par");
                if ((sum4 == 2) && (sum6 == 2))
                    Console.WriteLine("2 par");

                if ((sum5 == 2) && (sum6 == 2))
                    Console.WriteLine("2 par");

                // Tre ens
                if ((sum1 == 3) || (sum2 == 3) || (sum3 == 3) || (sum4 == 3) || (sum5 == 3) || (sum6 == 3))
                    Console.WriteLine("3 ens");

                // Fire ens
                if ((sum1 == 4) || (sum2 == 4) || (sum3 == 4) || (sum4 == 4) || (sum5 == 4) || (sum6 == 4))
                    Console.WriteLine("4 ens");

                // Small straight
                if ((sum1 == 1) && (sum2 == 1) && (sum3 == 1) && (sum4 == 1) && (sum5 == 1))
                    Console.WriteLine("Small straight");
                

                //Store straight 
                if ((sum2 == 1) && (sum3 == 1) && (sum4 == 1) && (sum5 == 1) && (sum6 == 1))
                    Console.WriteLine("Store straight");

                // Fuldt Hus
                if ((((sum1 == 2) && (sum2 == 3)) || (sum1 == 3) && (sum2 == 2)))
                    Console.WriteLine("Fuldt hus");
                if ((((sum1 == 2) && (sum3 == 3)) || (sum1 == 3) && (sum3 == 2)))
                    Console.WriteLine("Fuldt hus");
                if ((((sum1 == 2) && (sum4 == 3)) || (sum1 == 3) && (sum4 == 2)))
                    Console.WriteLine("Fuldt hus");
                if ((((sum1 == 2) && (sum5 == 3)) || (sum1 == 3) && (sum5 == 2)))
                    Console.WriteLine("Fuldt hus");
                if ((((sum1 == 2) && (sum6 == 3)) || (sum1 == 3) && (sum6 == 2)))
                    Console.WriteLine("Fuldt hus");

                if ((((sum2 == 2) && (sum3 == 3)) || (sum2 == 3) && (sum3 == 2)))
                    Console.WriteLine("Fuldt hus");
                if ((((sum2 == 2) && (sum4 == 3)) || (sum2 == 3) && (sum4 == 2)))
                    Console.WriteLine("Fuldt hus");
                if ((((sum2 == 2) && (sum5 == 3)) || (sum2 == 3) && (sum5 == 2)))
                    Console.WriteLine("Fuldt hus");
                if ((((sum2 == 2) && (sum6 == 3)) || (sum2 == 3) && (sum6 == 2)))
                    Console.WriteLine("Fuldt hus");

                if ((((sum3 == 2) && (sum4 == 3)) || (sum3 == 3) && (sum4 == 2)))
                    Console.WriteLine("Fuldt hus");
                if ((((sum3 == 2) && (sum5 == 3)) || (sum3 == 3) && (sum5 == 2)))
                    Console.WriteLine("Fuldt hus");
                if ((((sum2 == 2) && (sum6 == 3)) || (sum2 == 3) && (sum6 == 2)))
                    Console.WriteLine("Fuldt hus");

                if ((((sum4 == 2) && (sum5 == 3)) || (sum4 == 3) && (sum5 == 2)))
                    Console.WriteLine("Fuldt hus");
                if ((((sum4 == 2) && (sum6 == 3)) || (sum4 == 3) && (sum6 == 2)))
                    Console.WriteLine("Fuldt hus");

                if ((((sum5 == 2) && (sum6 == 3)) || (sum5 == 3) && (sum6 == 2)))
                    Console.WriteLine("Fuldt hus");

                // Yatzy
                if ((sum1 == 5) || (sum2 == 5) || (sum3 == 5) || (sum4 == 5) || (sum5 == 5))
                    Console.WriteLine("Yatzy");

                // Chancen == Any kombi 

                //Console.ReadKey();
            }

            Console.ReadKey();



            //
            // Vores Menu og scoreboard
            //

            Console.WriteLine("Velkommen til Team 7's Yatzy-spil!");
            Console.WriteLine("\n \nDette Yatzy-spil er for 2 spillere.");
            Console.WriteLine("\n \nTryk på en vilkårlig tast for at starte spillet.");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Hver spiller har 15 runder, med 3 kast. \n \nSpiller 1 skal nu kaste sine 5 terninger.\nTryk på en vilkårlig tast for at kaste terningerne.");
            Console.ReadKey();
            Console.Clear();

                   


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

            int roundCounter = 1;    //variabel der tæller runderne i for-loopet længere nede

            int P1ettere = 0;
            int P2ettere = 0;
            int P1toere = 0;
            int P2toere = 0;
            int P1treere = 0;
            int P2treere = 0;
            int P1firere = 0;
            int P2firere = 0;
            int P1femmere = 0;
            int P2femmere = 0;
            int P1seksere = 0;
            int P2seksere = 0;

            bool player1 = true; // Bestemmer spillers tur
            
            for (int rounds = 0; rounds < 15; rounds++) // 15 runder
            {
                if (player1)
                {
                    for (int P1kast = 0; P1kast < 3; P1kast++) // 3 kast for spiller1
                    {
                        //P1ettere = 0;

                    }
                }

                if (player1 == false) // hvis spiller1 falsk er det spiller2's tur
                {
                    for (int P2kast = 0; P2kast < 3; P2kast++) // 3 kast for spiller2
                    {

                        //P2ettere = 0;

                    }
                }

                Console.WriteLine("Runde: " + roundCounter);
                Console.WriteLine("SCOREBOARD:");
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

            int result1 = 0; //slet disse, kun for at fjerne fejl
            int result2 = 0; //slet disse, kun for at fjerne fejl 

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










//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] diceValues = { 1, 2, 2, 3, 3 }; // Dine terningværdier

//        int count1 = CountOccurrences(diceValues, 1);
//        int count2 = CountOccurrences(diceValues, 2);
//        int count3 = CountOccurrences(diceValues, 3);
//        int count4 = CountOccurrences(diceValues, 4);
//        int count5 = CountOccurrences(diceValues, 5);
//        int count6 = CountOccurrences(diceValues, 6);

//        // Tjek for to par
//        if ((count1 == 2 || count2 == 2 || count3 == 2 || count4 == 2 || count5 == 2 || count6 == 2) &&
//            (count1 + count2 + count3 + count4 + count5 + count6 - Math.Max(count1, Math.Max(count2, Math.Max(count3, Math.Max(count4, Math.Max(count5, count6)))))) == 4))
//        {
//            Console.WriteLine("2 par");
//        }
//        else
//        {
//            Console.WriteLine("Ikke 2 par");
//        }
//    }

//    static int CountOccurrences(int[] array, int value)
//    {
//        int count = 0;
//        foreach (var item in array)
//        {
//            if (item == value)
//            {
//                count++;
//            }
//        }
//        return count;
//    }
//}