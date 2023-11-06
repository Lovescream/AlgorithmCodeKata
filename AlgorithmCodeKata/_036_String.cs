using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    internal class _036_String {
        public bool solution(string s) {
            if (s.Length != 4 && s.Length != 6) return false;
            if (long.TryParse(s, out long temp)) return true;
            return false;
        }
    }
}
