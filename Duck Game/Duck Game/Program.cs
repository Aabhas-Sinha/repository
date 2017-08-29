using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckGameBLL;

namespace Duck_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int flychoice, quackchoice, weight, wings, pos;
            string choice;
            DuckCollection ducks = new DuckCollection();
            do {
                Console.Clear();
                Console.WriteLine("1.Add New Duck\n2.Insert New Duck\n3.Remove Duck\n4.Weight-Based Duck List\n5.Indexed Duck List\n6.Wings-Based Duck List\n7.Change Fly Type of a Duck\n8.Change Quack Type of a Duck\n9.Remove All Ducks\n10.Clone a Duck\n11.Compare two ducks by weight\n12.Exit");
                choice = Console.ReadLine();
                if (!Validity.CheckValidity(choice)) {
                    Console.WriteLine("\nEnter a valid choice!!");
                    continue;
                }
                if (Convert.ToInt32(choice) == 12) {
                    break;
                }
                switch (Convert.ToInt32(choice)) {
                    case 1: Console.Clear();
                        Console.WriteLine("\nEnter Weight : ");
                        weight = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter Number of Wings : ");
                        wings = int.Parse(Console.ReadLine());
                        Console.WriteLine("Pick Fly Type : \n1.Cannot Fly\n2.Slow\n3.Fast");
                        flychoice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Pick Quack Type : \n1.Squeak\n2.Mild\n3.Loud");
                        quackchoice = int.Parse(Console.ReadLine());
                        ducks.AddDuck(weight, wings, flychoice, quackchoice);
                        Console.ReadKey();
                        break;
                    case 2: Console.Clear();
                        Console.WriteLine("\nEnter position to insert at : ");
                        pos = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter Weight : ");
                        weight = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter Number of Wings : ");
                        wings = int.Parse(Console.ReadLine());
                        Console.WriteLine("Pick Fly Type : \n1.Cannot Fly\n2.Slow\n3.Fast");
                        flychoice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Pick Quack Type : \n1.Squeak\n2.Mild\n3.Loud");
                        quackchoice = int.Parse(Console.ReadLine());
                        ducks.InsertDuck(pos-1, weight, wings, flychoice, quackchoice);
                        Console.ReadKey();
                        break;
                    case 3: Console.Clear();
                        Console.WriteLine("\nEnter Position of duck : ");
                        pos = int.Parse(Console.ReadLine());
                        ducks.RemoveDuck(pos-1);
                        Console.ReadKey();
                        break;
                    case 4: Console.Clear();
                        ducks.WeightIterator();
                        Console.ReadKey();
                        break;
                    case 5: Console.Clear();
                        ducks.IndexIterator();
                        Console.ReadKey();
                        break;
                    case 6: Console.Clear();
                        ducks.WingsIterator();
                        Console.ReadKey();
                        break;
                    case 7: Console.Clear();
                        Console.WriteLine("\nEnter Position of duck : ");
                        pos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Pick Fly Type : \n1.Cannot Fly\n2.Slow\n3.Fast");
                        flychoice = int.Parse(Console.ReadLine());
                        ducks.ChangeFlyType(pos-1, flychoice);
                        Console.ReadKey();
                        break;
                    case 8: Console.Clear();
                        Console.WriteLine("\nEnter Position of duck : ");
                        pos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Pick Quack Type : \n1.Squeak\n2.Mild\n3.Loud");
                        quackchoice = int.Parse(Console.ReadLine());
                        ducks.ChangeQuackType(pos-1, quackchoice);
                        Console.ReadKey();
                        break;
                    case 9: Console.Clear();
                        ducks.RemoveAllDucks();
                        Console.ReadKey();
                        break;
                    case 10: Console.Clear();
                        Console.WriteLine("\nEnter Position of duck : ");
                        pos = int.Parse(Console.ReadLine());
                        Duck cloned = (Duck)ducks.CloneDuck(pos-1);
                        Console.ReadKey();
                        break;

                    case 11: Console.Clear();
                        Console.WriteLine("\nEnter Position of 2 ducks : ");
                        int pos1 = int.Parse(Console.ReadLine());
                        int pos2 = int.Parse(Console.ReadLine());
                        int heavier = ducks.CompareDuck(pos1-1, pos2-1);
                        if(heavier == -1)
                            Console.WriteLine("\nBoth weigh the same");
                        else
                            Console.WriteLine("\n" + heavier);
                        Console.ReadKey();
                        break;
                }
            } while (true);
        }
    }
}
