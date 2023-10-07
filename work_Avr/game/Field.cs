namespace work_Avr.game
{
    public class Field
    {
        public const int _FIELD_WIDTH = 10;
        public const int _FIELD_HEIGTH = 10;
        public int[][] FieldData => _field;
        private int[][] _field;
        private object _fieldlockObject=new object();

        private static int[][] InitField()
        {
            int[][] result = new int[_FIELD_HEIGTH][];
            for (int rowCounter = 0; rowCounter < _FIELD_HEIGTH; rowCounter++)
            {
                result[rowCounter] = new int[_FIELD_WIDTH];
                Array.Fill(result[rowCounter], 0, 0, _FIELD_WIDTH);
            }
            return result;
        }

        public Field()
        {
            _field = InitField();
        }
        public void ChangeField()
        {
            lock (_fieldlockObject)
            {
                _field = InitField();
                var randomizer = new Random();
                var rndRow = randomizer.Next() % 10;
                var rndColumn = randomizer.Next() % 10;
                _field[rndRow][rndColumn] = 1;
            }
        }
    }
}
