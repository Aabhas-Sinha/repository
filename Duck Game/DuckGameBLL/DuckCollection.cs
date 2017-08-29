using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckGameShared;
using DuckGameBLL;
using System.Threading.Tasks;

namespace Duck_Game {
    public class DuckCollection {
        List<Duck> Collection;
        public DuckCollection() {
            Collection = new List<Duck>();
        }
        public void AddDuck(int Weight, int wingCount, int FlyType, int QuackType) {
            Collection.Add(new Duck(Weight, wingCount, FlyType, QuackType));    
        }
        public void RemoveDuck(int Index) {
            if(Collection.Count()>Index)
                Collection.RemoveAt(Index);
            else
                Console.WriteLine("Invalid Index!!");
        }
        public void RemoveAllDucks() {
            Collection.Clear();
        }
        public void InsertDuck(int Index, int Weight, int wingCount, int FlyType, int QuackType) {
            if(Collection.Count()>Index)
                Collection.Insert(Index, new Duck(Weight, wingCount, FlyType, QuackType));
            else
                Console.WriteLine("Invalid Index");
        }
        //Index Based Iterator for ducks
        public void IndexIterator() {
            for (int i = 0; i < Collection.Count; i++) {
                Console.WriteLine(" " + Collection[i].name);
            }
        }
        //Weight Based Iterator
        public void WeightIterator() {
            List<Duck> WeightedList = Collection.OrderBy(o => o.weight).ToList();
            for (int i = 0; i < WeightedList.Count; i++) {
                Console.WriteLine(" " + WeightedList[i].name);
            }
        }
        //Wing-Count Based Iterator
        public void WingsIterator() {
            List<Duck> wingCountList = Collection.OrderBy(o => o.WingCount).ToList();
            for (int i = 0; i < wingCountList.Count; i++) {
                Console.WriteLine(" " + wingCountList[i].name);
            }
        }
        public void ChangeFlyType(int pos, int choice) {
            if (Collection.Count > pos) {
                if (choice == 1)
                    Collection[pos].ChangeFlyType(new Fly.CannotFly());
                else if (choice == 2)
                    Collection[pos].ChangeFlyType(new Fly.Slow());
                else if (choice == 3)
                    Collection[pos].ChangeFlyType(new Fly.Fast());
            }
            else
                Console.WriteLine("Invalid Index");
        }
        public void ChangeQuackType(int pos, int choice) {
            if (Collection.Count() > pos) {
                if (choice == 1)
                    Collection[pos].ChangeQuackType(new Quack.Squeak());
                else if (choice == 2)
                    Collection[pos].ChangeQuackType(new Quack.Mild());
                else if (choice == 3)
                    Collection[pos].ChangeQuackType(new Quack.Loud());
            }
            else
                Console.WriteLine("Invalid Index");
        }
        public Object CloneDuck(int pos) {
            Object clone = Collection[pos].Clone();
            return clone;
        }
        public int CompareDuck(int pos1, int pos2) {
            int heavy = Collection[pos1].CompareTo(Collection[pos2]);
            return heavy;
        }
    }
}
