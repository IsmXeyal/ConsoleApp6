namespace ConsoleApp6
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Enter string: "); var str = Console.ReadLine();

            MyClass cls = new(str);
            Func funcDell = new(cls.Space);	
            funcDell.functions(cls.Reverse);

            Run run = new();
            run.runFunc(funcDell, str); //cagiranda Space() ve Reverse() functionlari ise dusmelidir
        }
    }
}