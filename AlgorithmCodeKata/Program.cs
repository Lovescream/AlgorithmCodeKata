namespace AlgorithmCodeKata {
    public class Program {
        static void Main(string[] args) {
            _053_HallOfFrame a = new();
            a.solution(3, new int[] {10, 100, 20, 150, 1, 100, 200});
        }
        
        public static void PrintArray(int[] array) {
            Console.WriteLine(string.Join(',', array));
        }
    }
}