using IntroBuiltInInterfacesAndLINQ.Extensions;

namespace IntroBuiltInInterfacesAndLINQ.Demos
{
    internal class ExtensionDemo : IDemo
    {
        public void Run()
        {
            var text = "Terje";
            var newText = text.Repeat(1000);
            //var newText = StringTools.Repeat(text, 1000);
            Console.WriteLine(newText);

            //var s = new string('T', 1000);
        }
    }
}
