using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata {
    public class _054_2016 {
        public string solution(int a, int b) => new DateTime(2016, a, b).ToString("ddd").ToUpper();
    }
}
