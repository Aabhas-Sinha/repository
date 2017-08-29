using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckGameShared;
using System.Threading.Tasks;
using Duck_Game;
 
namespace DuckGameBLL {
    public class Quack {
        //Quack Type Interface with classes for each type (strategy design pattern)
        public interface IChangeQuack {
            Shared.QuackType SetQuackType(Duck duck);
        }
        public class Squeak : IChangeQuack {
            public Shared.QuackType SetQuackType(Duck duck) {
                return Shared.QuackType.squeak;
            }
        }
        public class Loud : IChangeQuack {
            public Shared.QuackType SetQuackType(Duck duck) {
                return Shared.QuackType.loud;
            }
        }
        public class Mild : IChangeQuack {
            public Shared.QuackType SetQuackType(Duck duck) {
                return Shared.QuackType.mild;
            }
        }
    }
}
