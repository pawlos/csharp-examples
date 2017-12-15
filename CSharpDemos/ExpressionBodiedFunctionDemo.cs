namespace CSharpDemos
{
    class ExpressionBodiedFunctionDemo
    {
        public static void Show()
        {

        }

        public string Name { get; set; }

        ExpressionBodiedFunctionDemo(string name) => Name = name;

        ~ExpressionBodiedFunctionDemo() => Name = null;
    }
}
