namespace IntroBuiltInInterfacesAndLINQ
{
    internal class BuilderPatternDemo
    {
        public static void Run()
        {
            // Uten builder pattern
            var drawing = new CharacterDrawing(20, 20);
            drawing.AddStar(10, 11);
            drawing.AddStar(10, 12);
            drawing.AddT(5, 5);
            drawing.AddT(6, 5);
            var text = drawing.Build();
            Console.WriteLine(text);


            new CharacterDrawing(20, 20)
                .AddStar(10, 11)
                .AddStar(10, 12)
                .AddT(5, 5)
                .AddT(6, 5)
                .Build();

        }
    }
}
