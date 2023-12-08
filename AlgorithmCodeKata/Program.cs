namespace AlgorithmCodeKata {
    public class Program {
        static void Main(string[] args) {
            var a = new _063_NumberPartner();
            Console.WriteLine(a.solution("3403", "13203"));
        }

        public static void PrintArray(int[] array) {
            Console.WriteLine(string.Join(',', array));
        }
    }
}