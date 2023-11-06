namespace AlgorithmCodeKata {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            _044_MinRectangle a = new _044_MinRectangle();
            int[,] cards = new int[,] { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };
            a.solution(cards);
        }
    }
}