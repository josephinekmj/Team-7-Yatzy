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
            bool ettere = false;
            bool toere = false;
            bool treere = false;
            bool firere = false;
            bool femmere = false;
            bool seksere = false;

            bool etPar = false;
            bool toPar = false;
            bool treEns = false;
            bool fireEns = false;
            bool smallStraight = false;

            bool storeStraight = false;
            bool fuldtHus = false;
            bool yatzy = false;

            string diceChoice = "";
            string scoreboardChoice = "";

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            int sum6 = 0;


            int terning1, terning2, terning3, terning4, terning5;

            Random r = new Random();

            terning1 = 0;
            terning2 = 0;
            terning3 = 0;
            terning4 = 0;
            terning5 = 0;

            //SumOfNumberOfEyes(int eyes, int t1, int t2, int t3, int t4, int t5)
            sum1 = SumOfNumberOfEyes(1, terning1, terning2, terning3, terning4, terning5);
            sum2 = SumOfNumberOfEyes(2, terning1, terning2, terning3, terning4, terning5);
            sum3 = SumOfNumberOfEyes(3, terning1, terning2, terning3, terning4, terning5);
            sum4 = SumOfNumberOfEyes(4, terning1, terning2, terning3, terning4, terning5);
            sum5 = SumOfNumberOfEyes(5, terning1, terning2, terning3, terning4, terning5);
            sum6 = SumOfNumberOfEyes(6, terning1, terning2, terning3, terning4, terning5);


            //
            // Regler
            //

            // Ettere
            if (sum1 >= 1)
                ettere = true;

            // Toere
            if (sum2 >= 1)
                toere = true;

            // Treere
            if (sum3 >= 1)
                treere = true;

            // Firere
            if (sum4 >= 1)
                firere = true;

            // Femmere
            if (sum5 >= 1)
                femmere = true;

            // Seksere
            if (sum6 >= 1)
                seksere = true;

            // Et par
            if ((sum1 >= 2) || (sum2 >= 2) || (sum3 >= 2) || (sum4 >= 2) || (sum5 >= 2) || (sum6 >= 2))
            {
                etPar = true;
                Console.WriteLine("1 par");
            }

            // To par
            if (((sum1 >= 2) && (sum2 >= 2)) ||
                ((sum1 >= 2) && (sum3 >= 2)) ||
                ((sum1 >= 2) && (sum4 >= 2)) ||
                ((sum1 >= 2) && (sum5 >= 2)) ||
                ((sum1 >= 2) && (sum6 >= 2)) ||
                ((sum2 >= 2) && (sum3 >= 2)) ||
                ((sum2 >= 2) && (sum4 >= 2)) ||
                ((sum2 >= 2) && (sum5 >= 2)) ||
                ((sum2 >= 2) && (sum6 >= 2)) ||
                ((sum3 >= 2) && (sum4 >= 2)) ||
                ((sum3 >= 2) && (sum5 >= 2)) ||
                ((sum3 >= 2) && (sum6 >= 2)) ||
                ((sum4 >= 2) && (sum5 >= 2)) ||
                ((sum4 >= 2) && (sum6 >= 2)) ||
                ((sum5 >= 2) && (sum6 >= 2)))
            {
                toPar = true;
                Console.WriteLine("2 par");
            }

            // Tre ens
            if ((sum1 >= 3) || (sum2 >= 3) || (sum3 >= 3) || (sum4 >= 3) || (sum5 >= 3) || (sum6 >= 3))
            {
                treEns = true;
                Console.WriteLine("3 ens");
            }

            // Fire ens
            if ((sum1 >= 4) || (sum2 >= 4) || (sum3 >= 4) || (sum4 >= 4) || (sum5 >= 4) || (sum6 >= 4))
            {
                fireEns = true;
                Console.WriteLine("4 ens");
            }

            // Small straight
            if ((sum1 == 1) && (sum2 == 1) && (sum3 == 1) && (sum4 == 1) && (sum5 == 1))
            {
                smallStraight = true;
                Console.WriteLine("Small straight");
            }


            //Store straight 
            if ((sum2 == 1) && (sum3 == 1) && (sum4 == 1) && (sum5 == 1) && (sum6 == 1))
            {
                storeStraight = true;
                Console.WriteLine("Store straight");
            }

            // Fuldt Hus
            if (((sum1 == 2) && (sum2 == 3)) ||
               ((sum1 == 3) && (sum2 == 2)) ||
               ((sum1 == 2) && (sum3 == 3)) ||
               ((sum1 == 3) && (sum3 == 2)) ||
               ((sum1 == 2) && (sum4 == 3)) ||
               ((sum1 == 3) && (sum4 == 2)) ||
               ((sum1 == 2) && (sum5 == 3)) ||
               ((sum1 == 3) && (sum5 == 2)) ||
               ((sum1 == 2) && (sum6 == 3)) ||
               ((sum1 == 3) && (sum6 == 2)) ||
               ((sum2 == 2) && (sum3 == 3)) ||
               ((sum2 == 3) && (sum3 == 2)) ||
               ((sum2 == 2) && (sum4 == 3)) ||
               ((sum2 == 3) && (sum4 == 2)) ||
               ((sum2 == 2) && (sum5 == 3)) ||
               ((sum2 == 3) && (sum5 == 2)) ||
               ((sum2 == 2) && (sum6 == 3)) ||
               ((sum2 == 3) && (sum6 == 2)) ||
               ((sum3 == 2) && (sum4 == 3)) ||
               ((sum3 == 3) && (sum4 == 2)) ||
               ((sum3 == 2) && (sum5 == 3)) ||
               ((sum3 == 3) && (sum5 == 2)) ||
               ((sum2 == 2) && (sum6 == 3)) ||
               ((sum2 == 3) && (sum6 == 2)) ||
               ((sum4 == 2) && (sum5 == 3)) ||
               ((sum4 == 3) && (sum5 == 2)) ||
               ((sum4 == 2) && (sum6 == 3)) ||
               ((sum4 == 3) && (sum6 == 2)) ||
               ((sum5 == 2) && (sum6 == 3)) ||
               ((sum5 == 3) && (sum6 == 2)))
            {
                fuldtHus = true;
                Console.WriteLine("Fuldt hus");
            }


            // Yatzy
            if ((sum1 == 5) || (sum2 == 5) || (sum3 == 5) || (sum4 == 5) || (sum5 == 5))
            {
                yatzy = true;
                Console.WriteLine("Yatzy!");
            }

            // Chancen == Any kombi 

            //Console.ReadKey();


            Console.ReadKey();



            //
            // Vores Menu og scoreboard
            //

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Velkommen til Team 7's Yatzy-spil!");
            Console.WriteLine("\n \nDette Yatzy-spil er for 2 spillere.");
            Console.WriteLine("\n \nTryk på en vilkårlig tast for at starte spillet.");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Hver spiller har 15 runder, med 3 kast i hver. \n \nSpiller 1 skal nu kaste sine 5 terninger.\nTryk på en vilkårlig tast for at kaste terningerne.");
            Console.ReadKey();
            Console.Clear();



            

            // player 1 variable
            int P1ettere = 0, P1toere = 0, P1treere = 0, P1firere = 0, P1femmere = 0, P1seksere = 0;
            int P1etPar = 0, P1toPar = 0, P1treEns = 0, P1fireEns = 0, P1lilleStraight = 0, P1storeStraight = 0;
            int P1fuldtHus = 0, P1chance = 0, P1yatzy = 0; //variabel af datatypen integer, som er erklæret til opbevaring af player1's terninge-øjne 


            //player 2 variable 
            int P2ettere = 0, P2toere = 0, P2treere = 0, P2firere = 0, P2femmere = 0, P2seksere = 0;
            int P2etPar = 0, P2toPar = 0, P2treEns = 0, P2fireEns = 0, P2lilleStraight = 0, P2storeStraight = 0;
            int P2fuldtHus = 0, P2chance = 0, P2yatzy = 0; //erklæret til player2



            bool player1 = true; // Bestemmer spillers tur

            bool gyldigKombi = false; // Er der en gyldig kombination - sat til falsk indtil man får en kombi
            if (ettere || toere || treere || firere || femmere || seksere || etPar || toPar || treEns || fireEns || smallStraight || storeStraight || fuldtHus || yatzy)
            {
                gyldigKombi = true;
            }


//              dette loop indeholder:

//              de 15 runder, som er det første 'for' loop,
//              inde i 'for' loop'et, findes et: 'if' loop, som angiver hvilken spiller der har turen/kastet (hvis player1 = true, så er det første spillers tur)
//              inde i 'if' loop'et findes endnu et 'for' loop som generer de 3 kast med 5 terninger for den første spiller.
//              inde i dette 'for' loop findes en switch, hvor forskellige cases angiver terning-kombinationer,
//              som indeholder en betingelse for om kombinationen er sand

            
            for (int rounds = 1; rounds < 16; rounds++) // 15 runder, tælleren er ekskluderende, derfor er værdien sat til 16.
            {
                if (player1) // Første spillers tur, fordi 'player1' bool er true
                {
                    for (int p1Roll = 0; p1Roll < 3; p1Roll++) // 3 kast for første spiller
                    {
                        Console.WriteLine("Spiller 1 kaster sine terninger");

                        // Første spillers tur, det første kast med 5 terninger
                        terning1 = r.Next(1, 7);
                        terning2 = r.Next(1, 7);
                        terning3 = r.Next(1, 7);
                        terning4 = r.Next(1, 7);
                        terning5 = r.Next(1, 7);

                        Console.WriteLine($"Terningekast: {terning1}, {terning2}, {terning3}, {terning4}, {terning5}");

                        Console.WriteLine("\n\nHvad vil du gøre nu?");
                        Console.Write("Vælg om du vil 1) Kaste igen eller 2) Skrive point på scoreboard");
                        diceChoice = Console.ReadLine();

                        switch (diceChoice)
                        {
                            case "1":
                                break;
                            case "2":
                                Console.Write("Tast bogstavet ind, som svarer til din kombination: ");
                                scoreboardChoice = Console.ReadLine();

                                if (gyldigKombi)
                                {
                                    switch (scoreboardChoice)
                                    {
                                        case "A":
                                            if (ettere)
                                                P1ettere = sum1;
                                            break;
                                        case "B":
                                            if (toere)
                                                P1toere = (sum2 * 2);
                                            break;
                                        case "C":
                                            if (treere)
                                                P1treere = (sum3 * 3);
                                            break;
                                        case "D":
                                            if (firere)
                                                P1firere = (sum4 * 4);
                                            break;
                                        case "E":
                                            if (femmere)
                                                P1femmere = (sum5 * 5);
                                            break;
                                        case "F":
                                            if (seksere)
                                                P1seksere = (sum6 * 6);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else if (!gyldigKombi)
                                {
                                    break;
                                }
                                break;
                            default:
                                Console.WriteLine("Du trykkede forkert - game over");
                                player1 = false;
                                break;
                        }
                        break;
                    }
                }

                else if (player1 == false) // hvis spiller1 falsk er det spiller2's tur
                {
                    for (int p2Roll = 0; p2Roll < 3; p2Roll++) // 3 kast for spiller2
                    {

                        //P2ettere = 0;

                    }
                }

                Console.WriteLine("Runde: " + rounds);
                Console.WriteLine("SCOREBOARD:");
                Console.WriteLine("------------------ \t {0,3} \t|\t {1,3}", "P1", "P2");
                Console.WriteLine("---------1 - 1'ere: \t {0,3} \t|\t {1,3}", P1ettere, P2ettere);
                Console.WriteLine("---------2 - 2'ere: \t {0,3} \t|\t {1,3}", P1toere, P2toere);
                Console.WriteLine("---------3 - 3'ere: \t {0,3} \t|\t {1,3}", P1treere, P2treere);
                Console.WriteLine("---------4 - 4'ere: \t {0,3} \t|\t {1,3}", P1firere, P2firere);
                Console.WriteLine("---------5 - 5'ere: \t {0,3} \t|\t {1,3}", P1femmere, P2femmere);
                Console.WriteLine("---------6 - 6'ere: \t {0,3} \t|\t {1,3}", P1seksere, P2seksere);
                Console.WriteLine("______________________________________________________");
                Console.WriteLine("---------------Sum: \t " + (P1ettere + P1toere + P1treere + P1firere + P1femmere + P1seksere) + " \t|\t " + (P2ettere + P2toere + P2treere + P2firere + P2femmere + P2seksere));
                Console.WriteLine("______________________________________________________");
                Console.WriteLine("Bonus v. 63 points: +50 point (ekstra kode indsættes) ");

                Console.WriteLine("--------A - et par: \t {0,3} \t|\t {1,3}", P1etPar, P2etPar);
                Console.WriteLine("--------B - to par: \t {0,3} \t|\t {1,3}", P1toPar, P2toPar);
                Console.WriteLine("-------C - tre ens: \t {0,3} \t|\t {1,3}", P1treEns, P2treEns);
                Console.WriteLine("------D - fire ens: \t {0,3} \t|\t {1,3}", P1fireEns, P2fireEns);

                Console.WriteLine("E - lille straight: \t {0,3} \t|\t {1,3}", P1lilleStraight, P2lilleStraight);
                Console.WriteLine("-F - stor straight: \t {0,3} \t|\t {1,3}", P1storeStraight, P2storeStraight);

                Console.WriteLine("-----G - fuldt hus: \t {0,3} \t|\t {1,3}", P1fuldtHus, P2fuldtHus);
                Console.WriteLine("--------H - CHANCE: \t {0,3} \t|\t {1,3}", P1chance, P2chance);
                Console.WriteLine("---------I - YATZY: \t {0,3} \t|\t {1,3}", P1yatzy, P2yatzy);

                Console.WriteLine("______________________________________________________");
                Console.WriteLine("-------------Total: \t " + (P1ettere + P1toere + P1treere + P1firere + P1femmere + P1seksere + P1etPar + P1toPar + P1treEns + P1fireEns + P1lilleStraight + P1storeStraight + P1fuldtHus + P1chance + P1yatzy) + " \t|\t " + (P2ettere + P2toere + P2treere + P2firere + P2femmere + P2seksere + P2etPar + P2toPar + P2treEns + P2fireEns + P2lilleStraight + P2storeStraight + P2fuldtHus + P2chance + P2yatzy));
                Console.WriteLine("______________________________________________________");


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