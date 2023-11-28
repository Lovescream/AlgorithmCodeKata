namespace AlgorithmCodeKata {
    public class Program {
        static void Main(string[] args) {
            //_056_Fruiterer fruiterer = new _056_Fruiterer();
            //Console.WriteLine(fruiterer.solution(3, 4, new int[] { 1, 2, 3, 1, 2, 3, 1 }));
            //Console.WriteLine(fruiterer.solution(4, 3, new int[] { 4, 1, 2, 2, 4, 4, 4, 4, 1, 2, 4, 2 }));
            //_057_MockTest test = new _057_MockTest();
            //PrintArray(test.solution(new int[] { 1, 2, 3, 4, 5 }));
            //PrintArray(test.solution(new int[] { 1, 3, 2, 4, 2 }));
            _058_GetPrime prime = new _058_GetPrime();
            Console.WriteLine(prime.solution(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(prime.solution(new int[] { 1, 2, 7, 6, 4 }));
        }

        public static void PrintArray(int[] array) {
            Console.WriteLine(string.Join(',', array));
        }
    }
}