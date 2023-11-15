namespace AlgorithmCodeKata {
    internal class Program {
        static void Main(string[] args) {
            _052_Coke coke = new _052_Coke();
            int total = coke.solution(2, 1, 20);
            Console.WriteLine(total);
        }
    }
}