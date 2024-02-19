namespace Interfacey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Console.WriteLine("-----");
            Console.WriteLine("");

            someClass1 ex1 = new someClass1();
            someClass2 ex2 = new someClass2();

            Console.WriteLine("to jest przykład bez dodatkowej klasy statycznej - w/g mnie prostszy: ");
            Console.WriteLine("");
            ex1.someMessage();
            ex2.someMessage();
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            Console.WriteLine("a to jest przykład z dodatkową klasą statyczną - w/g mnie więcej kodu");
            Console.WriteLine("");
            someStaticClass.someMessage(ex1);
            someStaticClass.someMessage(ex2);
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            Console.WriteLine("Ale efekt taki sam. To jaki jest cel stosowania tej konstrukcji poza tym, że sobie pokodowałem :-)");
            Console.WriteLine("");

        }
    }
}
