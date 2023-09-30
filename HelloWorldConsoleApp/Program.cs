namespace HelloWorldConsoleApp
{
    class Hello
    {
        static void Main(string[] args)
        {
            MathDemo mathDemo = new MathDemo();
            Console.WriteLine(mathDemo.Add(2, 4));
        }
    }
}