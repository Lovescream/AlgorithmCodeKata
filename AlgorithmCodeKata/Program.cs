namespace AlgorithmCodeKata {
    public class Program {
        static void Main(string[] args) {
            var a = new _064_SweatSuits();
            Console.WriteLine(a.solution(5, new int[] { 2, 4 }, new int[] { 5, 3 }));
            Console.WriteLine(a.solution(5, new int[] { 2, 4 }, new int[] { 3 }));
            Console.WriteLine(a.solution(3, new int[] { 3 }, new int[] { 1 }));
            Console.WriteLine(a.solution(5, new int[] { 1, 5 }, new int[] { 3 }));
        }

        public static void PrintArray(int[] array) {
            Console.WriteLine(string.Join(',', array));
        }
    }
}