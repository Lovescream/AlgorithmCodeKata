namespace AlgorithmCodeKata {
    public class Program {
        static void Main(string[] args) {
            _55_CardPack _55_CardPack = new _55_CardPack();
            Console.WriteLine(_55_CardPack.solution(
                new string[] { "i", "drink", "water" },
                new string[] { "want", "to" },
                new string[] { "i", "want", "to", "drink", "water" }
                ));
            Console.WriteLine(_55_CardPack.solution(
                            new string[] { "i", "water", "drink" },
                            new string[] { "want", "to" },
                            new string[] { "i", "want", "to", "drink", "water" }
                            ));

        }

        public static void PrintArray(int[] array) {
            Console.WriteLine(string.Join(',', array));
        }
    }
}