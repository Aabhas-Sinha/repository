using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckGameBLL {
    public class Validity {
        public static bool CheckValidity(string choice) {
            int x;
            if (int.TryParse(choice, out x)) {
                if (x <= 12 && x >= 1) {
                    return true;
                } else
                    return false;
            } else
                return false;
        }
    }
}
