namespace IntroBuiltInInterfacesAndLINQ
{
    internal class NumberTools
    {
        public static bool IsBetween10And100(int number)
        {
            return number is > 10 and < 100;
        }
    }
}
