namespace AlgorithmCodeKata {
    internal class Program {
        static void Main(string[] args) {
            _050_NearestEquals sadas = new _050_NearestEquals();
            int[] a = sadas.solution("banana");
            string s = "";
            for (int i = 0; i < a.Length; i++) {
                s += a[i].ToString();
            }
            Console.WriteLine(s);
        }
    }
}