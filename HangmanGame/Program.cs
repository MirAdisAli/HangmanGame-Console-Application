using System;

namespace HangemanGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("### WELCOME TO HANGMAN ###");
            string[] countrylistwords = new string[10];
            string[] footballplayerlistwords = new string[10];
            string[] flowerlistwords = new string[10];
            string[] fruitslistwords = new string[10];


            countrylistwords[0] = "brazil";
            countrylistwords[1] = "germany";
            countrylistwords[2] = "argentina";
            countrylistwords[3] = "belgium";
            countrylistwords[4] = "iran";
            countrylistwords[5] = "france";
            countrylistwords[6] = "spain";
            countrylistwords[7] = "portugal";
            countrylistwords[8] = "japan";
            countrylistwords[9] = "england";

            footballplayerlistwords[0] = "neymar";
            footballplayerlistwords[1] = "ronaldo";
            footballplayerlistwords[2] = "messi";
            footballplayerlistwords[3] = "beckham";
            footballplayerlistwords[4] = "pele";
            footballplayerlistwords[5] = "maradona";
            footballplayerlistwords[6] = "benzema";
            footballplayerlistwords[7] = "salah";
            footballplayerlistwords[8] = "zidane";
            footballplayerlistwords[9] = "muller";

            flowerlistwords[0] = "rose";
            flowerlistwords[1] = "waterLily";
            flowerlistwords[2] = "beliflower";
            flowerlistwords[3] = "sunflower";
            flowerlistwords[4] = "marigold";
            flowerlistwords[5] = "kamini";
            flowerlistwords[6] = "palash";
            flowerlistwords[7] = "sheuily";
            flowerlistwords[8] = "tuberose";
            flowerlistwords[9] = "krishnachura";

            fruitslistwords[0] = "apple";
            fruitslistwords[1] = "banana";
            fruitslistwords[2] = "mango";
            fruitslistwords[3] = "grape";
            fruitslistwords[4] = "dragonfruit";
            fruitslistwords[5] = "guava";
            fruitslistwords[6] = "cherry";
            fruitslistwords[7] = "lime";
            fruitslistwords[8] = "papaya";
            fruitslistwords[9] = "avocados";


            string mysteryWord;
            int xx;
            int x1;
            int d;
            char ch;
            char[] cn = new char[200];
            int ii = 0;
            int[] pn = new int[200];
            char playerGuess;
            char[] guess = new char[50];


            while (true)
            {

                Console.WriteLine("\n1.Country\n2.Football Player\n3.Flower\n4.Fruits\n5.Exit\n");

                xx = Convert.ToInt32(Console.ReadLine());

                Random randGen = new Random();
                var idx = randGen.Next(0, 9);


                if (xx == 5)
                {
                    Console.WriteLine("End");
                    break;
                }
                else if (xx == 1)
                {
                    mysteryWord = countrylistwords[idx];
                    d = mysteryWord.Length;

                    for (int p = 0; p < mysteryWord.Length; p++)
                    {
                        guess[p] = '_';
                    }
                    Console.WriteLine(guess);


                    x1 = mysteryWord.Length;
                    Console.WriteLine();
                    Console.WriteLine("Word Length: {0}", x1); d = mysteryWord.Length;
                    Console.WriteLine();
                    Console.WriteLine("Total life: {0}", d);
                    for (int i = 97; i <= 122; i++)
                    {
                        pn[i] = 0;
                    }

                    Console.Write("Please enter your guess: ");
                    while (ii != 200)
                    {
                        //Console.Clear();
                        //Console.Write("Enter: ");
                        playerGuess = Convert.ToChar(Console.ReadLine());
                        cn[ii] = playerGuess;
                        for (ch = 'a'; ch <= 'z'; ch++)
                        {

                            if (cn[ii] == ch)
                            {
                                pn[(int)ch]++;
                                if (pn[(int)ch] >= 5)
                                {

                                    Console.WriteLine("Your life is gone 5 time insert particular input");
                                    d--;
                                    Console.WriteLine("Your remain life is {0}", d);
                                    pn[(int)ch] = 0;

                                }


                            }
                        }

                        //Console.Clear();
                        for (int j = 0; j < mysteryWord.Length; j++)
                        {
                            if ((playerGuess == mysteryWord[j]) && (guess[j] != playerGuess))
                            {
                                guess[j] = playerGuess;
                                x1--;
                                //Console.WriteLine("Still {0} words have to match",x);
                            }
                        }
                        //Console.Clear();
                        Console.WriteLine(guess);
                        //Console.Clear();
                        if (x1 == 0)
                        {
                            Console.WriteLine("Congratulation Word Match");
                            break;
                        }
                        if (d == 0)
                        {
                            Console.WriteLine("your life is END");
                            Console.WriteLine(mysteryWord);
                            break;
                        }
                        ii++;
                    }
                }


                else if (xx == 2)
                {
                    mysteryWord = footballplayerlistwords[idx];
                    for (int p = 0; p < mysteryWord.Length; p++)
                    {
                        guess[p] = '_';
                    }
                    Console.WriteLine(guess);


                    x1 = mysteryWord.Length;
                    Console.WriteLine();
                    Console.WriteLine("Word Length: {0}", x1); d = mysteryWord.Length;
                    Console.WriteLine();
                    Console.WriteLine("Total life: {0}", d);
                    for (int i = 97; i <= 122; i++)
                    {
                        pn[i] = 0;
                    }
                    Console.Write("Please enter your guess: ");
                    while (ii != 200)
                    {
                        playerGuess = Convert.ToChar(Console.ReadLine());
                        cn[ii] = playerGuess;
                        for (ch = 'a'; ch <= 'z'; ch++)
                        {

                            if (cn[ii] == ch)
                            {

                                pn[(int)ch]++;

                                if (pn[(int)ch] >= 5)
                                {

                                    Console.WriteLine("Your life is gone 5 time insert particular input");
                                    d--;
                                    Console.WriteLine("Your remain life is {0}", d);
                                    pn[(int)ch] = 0;
                                }


                            }
                        }

                        // Console.Clear();
                        for (int j = 0; j < mysteryWord.Length; j++)
                        {
                            if ((playerGuess == mysteryWord[j]) && (guess[j] != playerGuess))
                            {
                                guess[j] = playerGuess;
                                x1--;
                            }
                        }
                        Console.WriteLine(guess);
                        if (x1 == 0)
                        {
                            Console.WriteLine("Congratulation Word Match");
                            break;
                        }
                        if (d == 0)
                        {
                            Console.WriteLine("your life is END");
                            Console.WriteLine(mysteryWord);
                            break;
                        }
                        ii++;

                    }
                }


                else if (xx == 3)
                {
                    mysteryWord = flowerlistwords[idx];


                    for (int p = 0; p < mysteryWord.Length; p++)
                    {
                        guess[p] = '_';
                    }
                    Console.WriteLine(guess);


                    x1 = mysteryWord.Length;
                    Console.WriteLine();
                    Console.WriteLine("Word Length: {0}", x1); d = mysteryWord.Length;
                    Console.WriteLine();
                    Console.WriteLine("Total life: {0}", d);
                    for (int i = 97; i <= 122; i++)
                    {
                        pn[i] = 0;
                    }
                    //int x=20;
                    Console.Write("Please enter your guess: ");
                    while (ii != 200)
                    {
                        playerGuess = Convert.ToChar(Console.ReadLine());
                        cn[ii] = playerGuess;
                        for (ch = 'a'; ch <= 'z'; ch++)
                        {

                            if (cn[ii] == ch)
                            {

                                pn[(int)ch]++;

                                if (pn[(int)ch] >= 5)
                                {

                                    Console.WriteLine("Your life is gone 5 time insert particular input");
                                    d--;
                                    Console.WriteLine("Your remain life is {0}", d);
                                    pn[(int)ch] = 0;

                                }


                            }
                        }

                        // Console.Clear();
                        for (int j = 0; j < mysteryWord.Length; j++)
                        {
                            if ((playerGuess == mysteryWord[j]) && (guess[j] != playerGuess))
                            {
                                guess[j] = playerGuess;
                                x1--;
                            }
                        }
                        Console.WriteLine(guess);
                        if (x1 == 0)
                        {
                            Console.WriteLine("Congratulation Word Match");
                            break;
                        }
                        if (d == 0)
                        {
                            Console.WriteLine("your life is END");
                            Console.WriteLine(mysteryWord);
                            break;
                        }
                        ii++;

                    }
                }


                else if (xx == 4)
                {
                    mysteryWord = fruitslistwords[idx];


                    for (int p = 0; p < mysteryWord.Length; p++)
                    {
                        guess[p] = '_';
                    }
                    Console.WriteLine(guess);


                    x1 = mysteryWord.Length;
                    Console.WriteLine();
                    Console.WriteLine("Word Length: {0}", x1); d = mysteryWord.Length;
                    Console.WriteLine();
                    Console.WriteLine("Total life: {0}", d);
                    for (int i = 97; i <= 122; i++)
                    {
                        pn[i] = 0;
                    }

                    Console.Write("Please enter your guess: ");
                    while (ii != 200)
                    {
                        playerGuess = Convert.ToChar(Console.ReadLine());
                        cn[ii] = playerGuess;
                        for (ch = 'a'; ch <= 'z'; ch++)
                        {

                            if (cn[ii] == ch)
                            {

                                pn[(int)ch]++;
                                if (pn[(int)ch] >= 5)
                                {

                                    Console.WriteLine("Your life is gone 5 time insert particular input");
                                    d--;
                                    Console.WriteLine("Your remain life is {0}", d);
                                    pn[(int)ch] = 0;
                                }


                            }
                        }

                        // Console.Clear();
                        for (int j = 0; j < mysteryWord.Length; j++)
                        {
                            if ((playerGuess == mysteryWord[j]) && (guess[j] != playerGuess))
                            {
                                guess[j] = playerGuess;
                                x1--;
                            }
                        }
                        Console.WriteLine(guess);
                        if (x1 == 0)
                        {
                            Console.WriteLine("Congratulation Word Match");
                            break;
                        }
                        if (d == 0)
                        {
                            Console.WriteLine("your life is END");
                            Console.WriteLine(mysteryWord);
                            break;
                        }
                        ii++;
                    }

                }


                else
                {
                    Console.WriteLine("Error");
                }

            }
        }
    }

}
