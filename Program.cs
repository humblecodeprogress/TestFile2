﻿

//namespace HM14
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //            14.HM - Bowl
//            //We have 3L and 5L of water and bowls of size 1,2,4,6,8 L.Our program has to decide in which bowls we can put this water.


//            Console.WriteLine("Do you have 3L or 5L water");

//            int size = int.Parse(Console.ReadLine());

//            if (size)
//            {
//                Console.WriteLine("Bowl 1+2");
//                Console.WriteLine("Bowl 4");
//                Console.WriteLine("Bowl 6");
//                Console.WriteLine("Bowl 8");
//            }
//            else
//            {
//                Console.WriteLine("Bowl 4+6");
//                Console.WriteLine("Bowl 6");
//                Console.WriteLine("Bowl 8");
//            }
//        }
//    }
//}
//namespace HM14
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //            14.HM - Bowl
//            //We have 3L and 5L of water and bowls of size 1,2,4,6,8 L.Our program has to decide in which bowls we can put this water.


//            int x;
//            Console.WriteLine("How many L of water do you have? 3 OR 5 or both (8) : ");
//            x = Convert.ToInt32(Console.ReadLine());
//            if (x == 3)
//            {
//                Console.WriteLine("You can put water in a bowl 1+2");
//                Console.WriteLine("You can put water in a bowl 4");
//                Console.WriteLine("You can put water in a bowl 6");
//                Console.WriteLine("You can put water in a bowl 8");
//            }
//            else if (x == 5)
//            {
//                Console.WriteLine("You can put water in a bowl 6 ");
//                Console.WriteLine("You can put water in a bowl 8 ");
//            } else if (x == 8)
//            {
//                Console.WriteLine("You can put water in a bowl 8");
//            }
//            else
//            {
//                Console.WriteLine("We don't have appropriate bowl");
//            }
//        }
//    }
//}

//justes versija
//namespace TechProjects
//{
//    class HM14
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter the capacity of your bowl in L. The options are the following:");
//            Console.WriteLine("1, 2, 4, 6, 8");

//            int size = int.Parse(Console.ReadLine());
//            bool canFit3L = false;
//            bool canFit5L = false;
//            bool canFitBoth = false;

//            switch (size)
//            {
//                case 1:
//                case 2:
//                    break;
//                case 4:
//                    canFit3L = true;
//                    break;
//                case 6:
//                    canFit3L = true;
//                    canFit5L = true;
//                    break;
//                case 8:
//                    canFit3L = true;
//                    canFit5L = true;
//                    canFitBoth = true;
//                    break;
//                default:
//                    Console.WriteLine("You did not enter a correct capacity!");
//                    return;
//            }
//            Console.WriteLine($"Your bowl can fit 3L of water: {canFit3L}");
//            Console.WriteLine($"Your bowl can fit 5L of water: {canFit5L}");
//            Console.WriteLine($"Your bowl can fit both, 3L and 5L, of water: {canFitBoth}");
//        }
//    }
//}

//brigitas versija
//namespace HM14
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//            int a = 3;
//            int b = 5;
//            Console.WriteLine("We have bowls of size 1,2,4,6,8 L");
//            int[] Bowls = { 1, 2, 4, 6, 8 };
//            for (int i = 0; i < Bowls.Length; i++)
//            {
//                if (a < Bowls[i])
//                {
//                    string text = $"3 L can be placed in {Bowls[i]}";
//                    Console.WriteLine(text);
//                }
//                if (b < Bowls[i])
//                {
//                    string text = $"5 L can be placed in {Bowls[i]}";
//                    Console.WriteLine(text); ;
//                }
//            }
//        }
//    }
//}

//vitautes versija
//namespace _14HM_Bowl
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Please enter, if you have 3L or 5L of water: ");
//            string word = Console.ReadLine();
//            if (word.Contains("3L") == true)
//            {
//                Console.WriteLine("Bowl 1 + 2 or bowl 4 or bowl 6 or bowl 8");
//            }
//            else if (word.Contains("5L") == true)
//            {
//                Console.WriteLine("Bowl 1 + 2 + 4 or bowl 2 + 4 or bowl 4 + 6 or bowl 6 or bowl 8");
//            }
//            else
//            {
//                Console.WriteLine("Too much water");
//            }
//        }
//    }
//}

//zahras versija
//namespace HM14_waterBuckets
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int water = 3 + 5; // water = 8
//            string waterAmount = water.ToString();
//            string[] bucket = { "1", "2", "4", "6", "8" };
//            var check = Array.Exists(bucket, x => x == waterAmount);
//            if (check)
//            {
//                Console.WriteLine("Use bucket " + water + " L " + "or buckets " + (water - 2) + " L and " + (water - 6) + " L");  // hope to solve the + part one day with proper code
//            }
//            else
//            {
//                Console.WriteLine("Not enough buckets to fill with all water");

//            }


//        }

//    }
//}

//Nataljas versija
//static void Main(string[] args)
//{
//    int x;
//    Console.WriteLine("How many L of water do you have?: ");
//    x = Convert.ToInt32(Console.ReadLine());
//    if (x == 3)
//    {
//        Console.WriteLine("You can put water in a bowl 4L, 6L, 8L ");
//    }
//    else if (x == 5)
//    {
//        Console.WriteLine("You can put water in a bowl 6L, 8L ");       
//    }
//    else
//    {
//        Console.WriteLine("We don't have appropriate bowl");
//    }
//}
