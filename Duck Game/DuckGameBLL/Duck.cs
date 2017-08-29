using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckGameShared;
using DuckGameBLL;
using System.Threading.Tasks;

namespace Duck_Game {
    public class Duck : ICloneable, IComparable{
        public Fly.IChangeFly strategyFly;                                    //strategyFly implements changing fly type during run time using strategy design pattern
        public Quack.IChangeQuack strategyQuack;                                //strategyQuack implements changing quack type during run time using strategy design pattern
        public static int nameCounter = 0;
        public string name { get; private set; }
        public int weight { get; private set;}
        public int WingCount{ get; private set;}
        public Shared.FlyType fly;
        public Shared.QuackType quack;
        
        //Duck Constructor
        public Duck(int Weight, int wings, int FlyChoice, int QuackChoice) {
            name = "Duck" + nameCounter++;
            this.weight = Weight;
            this.WingCount = wings;
            if (FlyChoice == 1) {
                fly = Shared.FlyType.cannot_fly;
            } else if (FlyChoice == 2) {
                fly = Shared.FlyType.slow;
            } else if (FlyChoice == 3) {
                fly = Shared.FlyType.fast;
            }else
                Console.WriteLine("\nInvalid Choice!!");
            if (QuackChoice == 1) {
                quack = Shared.QuackType.squeak;
            } else if (QuackChoice == 2) {
                quack = Shared.QuackType.mild;
            } else if (QuackChoice == 3) {
                quack = Shared.QuackType.loud;
            } else
                Console.WriteLine("\nInvalid Choice");
        }
        //Copy Constructor
        public Duck(Duck copy) {
            this.weight = copy.weight;
            this.WingCount = copy.WingCount;
            this.fly = copy.fly;
            this.quack = copy.quack;
        }
        //Clone() method for ICloneable interface
        public Object Clone() {
            return new Duck(this);
        }
        //CompareTo() method for IComparable interface (comparing by weight)
        public int CompareTo(Object duck2) {
            Duck duck = (Duck)duck2;
            if (this.weight == duck.weight)
                return -1;
            else if (this.weight > duck.weight)
                return this.weight;
            else
                return duck.weight;
        }
        //Allows changing fly type during run time
        public void ChangeFlyType(Fly.IChangeFly strat){
            strategyFly = strat;
            fly = strategyFly.SetFlyType(this);
        }
        //Allows changing quack type during run time
        public void ChangeQuackType(Quack.IChangeQuack strat) {
            strategyQuack = strat;
            quack = strategyQuack.SetQuackType(this);
        }
    }
}

