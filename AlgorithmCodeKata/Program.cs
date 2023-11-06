namespace AlgorithmCodeKata {
    internal class Program {
        static void Main(string[] args) {
            _049_SelectTwoSum sadas = new _049_SelectTwoSum();
            int[] a = sadas.solution(new int[] { 2, 1, 3, 4, 1 });
            string s = "";
            for (int i = 0; i < a.Length; i++) {
                s += a[i].ToString();
            }
            Console.WriteLine(s);
        }
    }
}