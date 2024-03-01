using System;
using System.ComponentModel.Design;

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

            //
            // Known Bugs
            //

            // #4: Kan ikke gemme terninger gennem hvert kast endnu
            // #5: Spiller #2 er ikke med i spillet endnu
            


            //
            // Variabler
            //

            // bools der fortæller om betingelserne for en kombination er opnået - sat til false da ingen spillere har haft en tur endnu
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



            // bool der bestemmer spillernes tur - første spiller starter, falsk når det skal være anden spillers tur
            bool player1 = true;

            // strings brugt til brugerens menu-valg
            string diceChoice = "";
            string scoreboardChoice = "";

            // int variabler brugt til at gemme summen af terninger med x antal øjne
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            int sum6 = 0;

            // Her erklærer vi terningerne som int variable, laver et nyt objekt af Random klassen, men initialisere terning1-5 til 0;
            int terning1, terning2, terning3, terning4, terning5;
            Random r = new Random();
            terning1 = 0;
            terning2 = 0;
            terning3 = 0;
            terning4 = 0;
            terning5 = 0;

            // player 1 variable
            int P1ettere = 0, P1toere = 0, P1treere = 0, P1firere = 0, P1femmere = 0, P1seksere = 0;
            int P1etPar = 0, P1toPar = 0, P1treEns = 0, P1fireEns = 0, P1lilleStraight = 0, P1storeStraight = 0;
            int P1fuldtHus = 0, P1chance = 0, P1yatzy = 0; //variabel af datatypen integer, som er erklæret til opbevaring af player1's terninge-øjne 


            //player 2 variable 
            int P2ettere = 0, P2toere = 0, P2treere = 0, P2firere = 0, P2femmere = 0, P2seksere = 0;
            int P2etPar = 0, P2toPar = 0, P2treEns = 0, P2fireEns = 0, P2lilleStraight = 0, P2storeStraight = 0;
            int P2fuldtHus = 0, P2chance = 0, P2yatzy = 0; //erklæret til player2

            // Variabler der tæller total og bestemmer en vinder
            int P1result = 0;
            int P2result = 0;

            // en tæller, der tæller runderne på scoreboardet
            int roundsCounter = 1;

            // variabler til scoreboard
            int P1sum = 0;
            int P2sum = 0;
            int bonus1 = 0;
            int bonus2 = 0;



            //
            // Vores Start menu
            //

            //Console.BackgroundColor = ConsoleColor.Magenta;
            //Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Velkommen til Team 7's Yatzy-spil!");
            Console.WriteLine("\n\nDette Yatzy-spil er for 2 spillere.");
            Console.WriteLine("\n\nTryk på en vilkårlig tast for at starte spillet.");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Hver spiller har 15 runder, med 3 kast i hver. \n\nTryk på en vilkårlig tast for at kaste terningerne.");
            Console.ReadKey();
            Console.Clear();


            //
            // hoved loop - dette loop indeholder:
            //

            //  Første 'for' loop: 30 runder (15 for hver spiller)
            //      inde i 'for' loop'et, findes et: 'if' loop, som angiver hvilken spiller der har turen/kastet (hvis player1 = true, så er det første spillers tur)
            //          inde i 'if' loop'et findes endnu to 'for' loop, som generer de 3 kast med 5 terninger, ét loop for hver spiller.
            //              inde i dette 'for' loop findes:
            //                  Kald til metode 
            //                  En masse 'if' loops med regler der sætter bools til sandt afhængig af spillerens kast (om en kombination er opnået)
            //                  En switch der angiver brugerens menuvalg mm.


            for (int rounds = 0; rounds < 30; rounds++) // 15 runder for hver spiller
            {
                if (player1) // Første spillers tur, fordi 'player1' bool er true
                {
                    for (int p1Roll = 0; p1Roll < 3; p1Roll++) // 3 kast for første spiller
                    {

                        Console.Clear();

                        Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");



                        Console.WriteLine("Runde: " + roundsCounter);
                        Console.WriteLine("SCOREBOARD:");
                        Console.WriteLine("------------------------------ \t {0,3} \t|\t {1,3}", "P1", "P2");
                        Console.WriteLine("--------------------1 - 1'ere: \t {0,3} \t|\t {1,3}", P1ettere, P2ettere);
                        Console.WriteLine("--------------------2 - 2'ere: \t {0,3} \t|\t {1,3}", P1toere, P2toere);
                        Console.WriteLine("--------------------3 - 3'ere: \t {0,3} \t|\t {1,3}", P1treere, P2treere);
                        Console.WriteLine("--------------------4 - 4'ere: \t {0,3} \t|\t {1,3}", P1firere, P2firere);
                        Console.WriteLine("--------------------5 - 5'ere: \t {0,3} \t|\t {1,3}", P1femmere, P2femmere);
                        Console.WriteLine("--------------------6 - 6'ere: \t {0,3} \t|\t {1,3}", P1seksere, P2seksere);
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine("--------------------------Sum: \t {0,3} \t|\t {1,3}", P1sum = (P1ettere + P1toere + P1treere + P1firere + P1femmere + P1seksere), P2sum = (P2ettere + P2toere + P2treere + P2firere + P2femmere + P2seksere));
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine("Bonus v. 63 points, +50 point: \t {0,3} \t|\t {1,3}", bonus1 = ((P1sum >= 63) ? 50 : 0), bonus2 = ((P2sum >= 63) ? 50 : 0));


                        Console.WriteLine("-------------------A - et par: \t {0,3} \t|\t {1,3}", P1etPar, P2etPar);
                        Console.WriteLine("-------------------B - to par: \t {0,3} \t|\t {1,3}", P1toPar, P2toPar);
                        Console.WriteLine("------------------C - tre ens: \t {0,3} \t|\t {1,3}", P1treEns, P2treEns);
                        Console.WriteLine("-----------------D - fire ens: \t {0,3} \t|\t {1,3}", P1fireEns, P2fireEns);

                        Console.WriteLine("-----------E - lille straight: \t {0,3} \t|\t {1,3}", P1lilleStraight, P2lilleStraight);
                        Console.WriteLine("------------F - stor straight: \t {0,3} \t|\t {1,3}", P1storeStraight, P2storeStraight);

                        Console.WriteLine("----------------G - fuldt hus: \t {0,3} \t|\t {1,3}", P1fuldtHus, P2fuldtHus);
                        Console.WriteLine("-------------------H - CHANCE: \t {0,3} \t|\t {1,3}", P1chance, P2chance);
                        Console.WriteLine("--------------------I - YATZY: \t {0,3} \t|\t {1,3}", P1yatzy, P2yatzy);

                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine("------------------------Total: \t {0,3} \t|\t {1,3}", P1result = (P1sum + bonus1 + P1etPar + P1toPar + P1treEns + P1fireEns + P1lilleStraight + P1storeStraight + P1fuldtHus + P1chance + P1yatzy), P2result = (P2sum + P2etPar + P2toPar + P2treEns + P2fireEns + P2lilleStraight + P2storeStraight + P2fuldtHus + P2chance + P2yatzy));
                        Console.WriteLine("_______________________________________________________________");



                        // bools - betingelser for kombinationer sættes til falsk før hvert kast, så man KUN kan sætte point ind et sted på scoreboardet hvis betingelsen er opfyldt på det aktuelle kast
                        ettere = false;
                        toere = false;
                        treere = false;
                        firere = false;
                        femmere = false;
                        seksere = false;

                        etPar = false;
                        toPar = false;
                        treEns = false;
                        fireEns = false;
                        smallStraight = false;

                        storeStraight = false;
                        fuldtHus = false;
                        yatzy = false;

                        Console.WriteLine("Spiller 1 kaster sine terninger");

                        // Første spillers tur - kaster med 5 terninger
                        //terning1 = r.Next(1, 7);
                        //terning2 = r.Next(1, 7);
                        //terning3 = r.Next(1, 7);
                        //terning4 = r.Next(1, 7);
                        //terning5 = r.Next(1, 7); 
                        
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        terning1 = 2;
                        terning2 = 3;
                        terning3 = 4;
                        terning4 = 5;
                        terning5 = 6;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                        Console.WriteLine($"\n{p1Roll + 1}. Terningekast: {terning1}, {terning2}, {terning3}, {terning4}, {terning5}");
                        Console.WriteLine("\nKombinationer:");

                        //SumOfNumberOfEyes(int eyes, int t1, int t2, int t3, int t4, int t5)
                        sum1 = SumOfNumberOfEyes(1, terning1, terning2, terning3, terning4, terning5);
                        sum2 = SumOfNumberOfEyes(2, terning1, terning2, terning3, terning4, terning5);
                        sum3 = SumOfNumberOfEyes(3, terning1, terning2, terning3, terning4, terning5);
                        sum4 = SumOfNumberOfEyes(4, terning1, terning2, terning3, terning4, terning5);
                        sum5 = SumOfNumberOfEyes(5, terning1, terning2, terning3, terning4, terning5);
                        sum6 = SumOfNumberOfEyes(6, terning1, terning2, terning3, terning4, terning5);

                        //
                        // Regler kontrolleres (hvilke betingelser er opfyldt for hvilke kombinationer)
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

                        // Menu efter spillerens kast
                        Console.Write("\n\nVælg om du vil 1) Kaste igen 2) Skrive point på scoreboard: ");
                        diceChoice = Console.ReadLine();
                        Console.Write("\n\n"); // laver mellemrum mellem hvert kast

                        // Spillerens valg i menuen
                        switch (diceChoice)
                        {
                            case "1": // Hvis spilleren vælger at trykke 1
                                goto rollAgain; // Gå til switch label 'rollAgain'
                            rollAgain:
                                player1 = true;
                                break;
                            case "2": // Hvis spilleren vælger at skrive sin kombination på scoreboardet (vælger 2 i ovenstående menuen)
                                Console.Write("Tast bogstavet ind, som svarer til den kombination du vil have point på eller strege: ");
                                scoreboardChoice = Console.ReadLine();

                                switch (scoreboardChoice) // Her kontrolleres for hvad spilleren vælger - Dvs. hvilken position på scoreboardet pointene skal på
                                {
                                    case "1":
                                        player1 = false;
                                        if (ettere) // Kontrollere at spilleren faktisk har ettere i sit kast
                                            P1ettere = sum1;
                                        else        // Ellers, sæt ettere til 0 point - det samme for resten af kombinationerne nedenfor
                                            P1ettere = 0;
                                        break;
                                    case "2":
                                        player1 = false;
                                        if (toere)
                                            P1toere = (sum2 * 2);
                                        else
                                            P1toere = 0;
                                        break;
                                    case "3":
                                        player1 = false;
                                        if (treere)
                                            P1treere = (sum3 * 3);
                                        else
                                            P1treere = 0;
                                        break;
                                    case "4":
                                        player1 = false;
                                        if (firere)
                                            P1firere = (sum4 * 4);
                                        else
                                            P1firere = 0;
                                        break;
                                    case "5":
                                        player1 = false;
                                        if (femmere)
                                            P1femmere = (sum5 * 5);
                                        else
                                            P1femmere = 0;
                                        break;
                                    case "6":
                                        player1 = false;
                                        if (seksere)
                                            P1seksere = (sum6 * 6);
                                        else
                                            P1seksere = 0;
                                        break;
                                    case "A":
                                        player1 = false;
                                        if (etPar)
                                            if (terning1 == terning2)
                                                P1etPar = (terning1 + terning2);
                                            else if (terning1 == terning3)
                                                P1etPar = (terning1 + terning3);
                                            else if (terning1 == terning4)
                                                P1etPar = (terning1 + terning4);
                                            else if (terning1 == terning5)
                                                P1etPar = (terning1 + terning5);
                                        else
                                            P1etPar = 0;
                                        break;
                                    case "B":
                                        player1 = false;
                                        if (toPar)
                                            if ((terning1 == terning2) && (terning3 == terning4) ||
                                                (terning1 == terning3) && (terning2 == terning4) ||
                                                (terning1 == terning4) && (terning2 == terning3))
                                                P1toPar = (terning1 + terning2 + terning3 + terning4);
                                            else if ((terning1 == terning2) && (terning3 == terning5) ||
                                                    (terning1 == terning3) && (terning2 == terning5) ||
                                                    (terning1 == terning5) && (terning2 == terning3))
                                                    P1toPar = (terning1 + terning2 + terning3 + terning5);
                                            else if ((terning1 == terning2) && (terning4 == terning5) ||
                                                    (terning1 == terning4) && (terning2 == terning5) ||
                                                    (terning1 == terning5) && (terning2 == terning4))
                                                    P1toPar = (terning1 + terning2 + terning4 + terning5);
                                        else
                                            P1toPar = 0;
                                        break;
                                    case "C":
                                        player1 = false;
                                        if (treEns)
                                            if (sum1 >= 3)
                                                P1treEns = 3;
                                            else if (sum2 >= 3)
                                                P1treEns = 6;
                                            else if (sum3 >= 3)
                                                P1treEns = 9;
                                            else if (sum4 >= 3)
                                                P1treEns = 12;
                                            else if (sum5 >= 3)
                                                P1treEns = 15;
                                            else if (sum6 >= 3)
                                                P1treEns = 18;
                                            else
                                                P1treEns = 0;
                                        break;
                                    case "D":
                                        player1 = false;
                                        if (fireEns)
                                            if (sum1 >= 4)
                                                P1fireEns = 4;
                                            else if (sum2 >= 4)
                                                P1fireEns = 8;
                                            else if (sum3 >= 4)
                                                P1fireEns = 12;
                                            else if (sum4 >= 4)
                                                P1fireEns = 16;
                                            else if (sum5 >= 4)
                                                P1fireEns = 20;
                                            else if (sum6 >= 4)
                                                P1fireEns = 24;
                                            else
                                                P1fireEns = 0;
                                        break;
                                    case "E":
                                        player1 = false;
                                        if (smallStraight)
                                            P1lilleStraight = 15;
                                        else
                                            P1lilleStraight = 0;
                                        break;
                                    case "F":
                                        player1 = false;
                                        if (storeStraight)
                                            P1storeStraight = 20;
                                        else
                                            P1storeStraight = 0;
                                        break;
                                    case "G":
                                        player1 = false;
                                        if (fuldtHus)
                                            P1fuldtHus = terning1 + terning2 + terning3 + terning4 + terning5;
                                        else
                                            P1fuldtHus = 0;
                                        break;
                                    case "H":
                                        player1 = false;
                                        P1chance = terning1 + terning2 + terning3 + terning4 + terning5;
                                        break;
                                    case "I":
                                        player1 = false;
                                        if (yatzy)
                                            if ((sum1 == 5) || (sum2 == 5) || (sum3 == 5) || (sum4 == 5) || (sum5 == 5))
                                                P1yatzy = 50;
                                            else
                                                P1yatzy = 0;
                                        break;
                                    default:
                                        player1 = false;
                                        break;
                                }
                                break; // case 2 break

                            default: // denne default sikrer at spiller ikke bare trykker enter uden at vælge noget i menuen og dermed spille for evigt.
                                player1 = false;
                                Console.WriteLine("Du valgte ingenting. Du har mistet din tur - ooops!");
                                break;
                        }

                        //
                        // Sikring at turen går til anden spiller
                        //

                        if (player1 == false) // Hvis player1 er falsk bryder den ud af den ud af spilleres 3 kast ('for' loop)
                            break;

                        if (p1Roll == 2) // Kontrollere at spilleren ikke bruger flere kast end 3 ---- p1Roll 0, 1, 2 (3 kast) ellers sætter den player1 til falsk
                        {
                            player1 = false;
                            break;
                        }
                    }

                    Console.WriteLine("Tryk på en tast for at gå til næste runde");
                    Console.ReadKey();
                }

                else if (player1 == false) // Anden spillers tur, fordi 'player1' bool er false
                {
                    Console.WriteLine("\n\n\nNu er det spiller2's tur");
                    Console.WriteLine("\n\n\n");
                    Console.ReadKey();

                    //
                    // skal have alt det første spiller har i ovenstående 'for' loop
                    //

                    player1 = true; // I slutningen af player2's tur, sætter vi igen player1 til true (denne slettes når spiller1 kode kopieres ned)       
                }

                //
                // Vores Scoreboard
                //


                Console.WriteLine("Runde: " + roundsCounter);
                Console.WriteLine("SCOREBOARD:");
                Console.WriteLine("------------------------------ \t {0,3} \t|\t {1,3}", "P1", "P2");
                Console.WriteLine("--------------------1 - 1'ere: \t {0,3} \t|\t {1,3}", P1ettere, P2ettere);
                Console.WriteLine("--------------------2 - 2'ere: \t {0,3} \t|\t {1,3}", P1toere, P2toere);
                Console.WriteLine("--------------------3 - 3'ere: \t {0,3} \t|\t {1,3}", P1treere, P2treere);
                Console.WriteLine("--------------------4 - 4'ere: \t {0,3} \t|\t {1,3}", P1firere, P2firere);
                Console.WriteLine("--------------------5 - 5'ere: \t {0,3} \t|\t {1,3}", P1femmere, P2femmere);
                Console.WriteLine("--------------------6 - 6'ere: \t {0,3} \t|\t {1,3}", P1seksere, P2seksere);
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("--------------------------Sum: \t {0,3} \t|\t {1,3}", P1sum = (P1ettere + P1toere + P1treere + P1firere + P1femmere + P1seksere), P2sum = (P2ettere + P2toere + P2treere + P2firere + P2femmere + P2seksere));
                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("Bonus v. 63 points, +50 point: \t {0,3} \t|\t {1,3}", bonus1 = ((P1sum >= 63) ? 50 : 0), bonus2 = ((P2sum >= 63) ? 50 : 0));


                Console.WriteLine("-------------------A - et par: \t {0,3} \t|\t {1,3}", P1etPar, P2etPar);
                Console.WriteLine("-------------------B - to par: \t {0,3} \t|\t {1,3}", P1toPar, P2toPar);
                Console.WriteLine("------------------C - tre ens: \t {0,3} \t|\t {1,3}", P1treEns, P2treEns);
                Console.WriteLine("-----------------D - fire ens: \t {0,3} \t|\t {1,3}", P1fireEns, P2fireEns);

                Console.WriteLine("-----------E - lille straight: \t {0,3} \t|\t {1,3}", P1lilleStraight, P2lilleStraight);
                Console.WriteLine("------------F - stor straight: \t {0,3} \t|\t {1,3}", P1storeStraight, P2storeStraight);

                Console.WriteLine("----------------G - fuldt hus: \t {0,3} \t|\t {1,3}", P1fuldtHus, P2fuldtHus);
                Console.WriteLine("-------------------H - CHANCE: \t {0,3} \t|\t {1,3}", P1chance, P2chance);
                Console.WriteLine("--------------------I - YATZY: \t {0,3} \t|\t {1,3}", P1yatzy, P2yatzy);

                Console.WriteLine("_______________________________________________________________");
                Console.WriteLine("------------------------Total: \t {0,3} \t|\t {1,3}", P1result = (P1sum + bonus1 + P1etPar + P1toPar + P1treEns + P1fireEns + P1lilleStraight + P1storeStraight + P1fuldtHus + P1chance + P1yatzy), P2result = (P2sum + P2etPar + P2toPar + P2treEns + P2fireEns + P2lilleStraight + P2storeStraight + P2fuldtHus + P2chance + P2yatzy));
                Console.WriteLine("_______________________________________________________________");


                //Console.WriteLine("Tryk på en tast for at gå til næste runde");
                //Console.ReadKey();
                //Console.Clear();

                if (rounds % 2 != 0)
                    roundsCounter++;
            }


            //
            // Resultat! Hvem vandt??
            //


            if (P1result > P2result)
            {
                Console.WriteLine("Spiller 1 har vundet");
            }
            else if (P1result < P2result)
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










////
//// Første version MED gyldigKombi bool - slettet i den nye version
////

//// Hvis én eller flere af ovenstående bools blive sande efter spillerens kast, sættes bool gyldigKombi, til sand
//if (ettere || toere || treere || firere || femmere || seksere || etPar || toPar || treEns || fireEns || smallStraight || storeStraight || fuldtHus || yatzy)
//    gyldigKombi = true;

//// Menu efter spillerens kast
//Console.Write("\n\nVælg om du vil 1) Kaste igen 2) Skrive point på scoreboard: ");
//diceChoice = Console.ReadLine();

//// Spillerens valg i menuen
//switch (diceChoice)
//{
//    case "1": // Hvis spilleren vælger at trykke 1
//        break;
//    case "2": // Hvis spilleren vælger at skrive sin kombination på scoreboardet (vælger 2 i ovenstående menuen)
//        Console.Write("Tast bogstavet ind, som svarer til din kombination: ");
//        scoreboardChoice = Console.ReadLine();

//        if (gyldigKombi) // Hvis en eller flere af regel-bools blev sande (&&) spilleren valgte 2 i menuen
//        {
//            switch (scoreboardChoice) // Så vælger spilleren hvilken position på scoreboardet pointene skal på
//            {
//                case "A":
//                    if (ettere) // Kontrollere at spilleren faktisk har ettere i sit kast
//                        P1ettere = sum1;
//                    else        // Ellers, sæt ettere til 0 point - det samme for resten af kombinationerne nedenfor
//                        P1ettere = 0;
//                    break;
//                case "B":
//                    if (toere)
//                        P1toere = (sum2 * 2);
//                    else
//                        P1ettere = 0;
//                    break;
//                case "C":
//                    if (treere)
//                        P1treere = (sum3 * 3);
//                    else
//                        P1ettere = 0;
//                    break;
//                case "D":
//                    if (firere)
//                        P1firere = (sum4 * 4);
//                    else
//                        P1ettere = 0;
//                    break;
//                case "E":
//                    if (femmere)
//                        P1femmere = (sum5 * 5);
//                    else
//                        P1ettere = 0;
//                    break;
//                case "F":
//                    if (seksere)
//                        P1seksere = (sum6 * 6);
//                    else
//                        P1ettere = 0;
//                    break;
//                default:
//                    Console.WriteLine("Du trykkede forkert - Game Over");
//                    break;
//            }
//        }
//        player1 = false;
//        break;
//        //default:
//        //    Console.WriteLine("Du trykkede forkert - Game Over");
//        //    player1 = false;
//        //    break;
//}








////
//// Array og Math metode til at tælle terningerne i stedet for Thomas' metode!
//// 


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