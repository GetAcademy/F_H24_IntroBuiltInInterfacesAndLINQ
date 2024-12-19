namespace IntroBuiltInInterfacesAndLINQ
{
    internal class CharacterDrawing
    {
        private char[] _chars;
        private int _width;

        public CharacterDrawing(int width, int height)
        {
            _width = width;
            var size = width * height;
            _chars = Enumerable.Repeat(' ', size).ToArray();
        }

        public CharacterDrawing AddStar(int col, int row)
        {
            var index = row * _width + col;
            _chars[index] = '*';
            return this;
        }

        public CharacterDrawing AddT(int col, int row)
        {
            var index = row * _width + col;
            _chars[index] = 'T';
            return this;
        }

        public string Build()
        {
            return new string(_chars);
        }
    }
}
