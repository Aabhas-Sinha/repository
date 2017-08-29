using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckGameShared;
using System.Threading.Tasks;
using Duck_Game;

namespace DuckGameBLL {
    public class Fly {
        //Fly type Interface with classes for each type (strategy design pattern)
        public interface IChangeFly {
            Shared.FlyType SetFlyType(Duck duck);
        }
        public class CannotFly : IChangeFly {
            public Shared.FlyType SetFlyType(Duck duck) {
                return Shared.FlyType.cannot_fly;
            }
        }
        public class Slow : IChangeFly {
            public Shared.FlyType SetFlyType(Duck duck) {
                return Shared.FlyType.slow;
            }
        }
        public class Fast : IChangeFly {
            public Shared.FlyType SetFlyType(Duck duck) {
                return Shared.FlyType.fast;
            }
        }
    }
}
