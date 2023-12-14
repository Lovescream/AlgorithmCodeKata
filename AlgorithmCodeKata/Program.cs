using System.Reflection;
namespace AlgorithmCodeKata;

public abstract class KataBase {
    public abstract void Example();
}

public static class Program {
    public static void Main() {
        Console.WriteLine("실행하고자 하는 문제의 Index를 적어주세요:");
        if (!int.TryParse(Console.ReadLine(), out int index)) return;
        Type type = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(KataBase)) && type.Name.Contains(index.ToString())).FirstOrDefault();
        if (type == null) {
            Console.WriteLine($"Number {index} not found.");
            return;
        }
        (Activator.CreateInstance(type) as KataBase)?.Example();
    }
}
