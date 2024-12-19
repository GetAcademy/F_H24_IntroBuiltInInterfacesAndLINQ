using System.Text;

namespace IntroBuiltInInterfacesAndLINQ.Extensions
{
    internal static class StringExtensions
    {
        public static string Repeat(this string text, int count)
        {
            var result = new StringBuilder();
            for (var i = 0; i < count; i++)
            {
                result.Append(text);
            }
            return result.ToString();


            //new StringBuilder()
            //    .Append("sdfk")
            //    .Append("sdfk")
            //    .Append("sdfk")
            //    .Append("sdfk")
            //    .Append("sdfk")
            //    .ToString();
            //    ;
        }
    }
}
