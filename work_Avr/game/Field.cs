using System.Drawing;

namespace work_Avr.game
{
    public class Field
    {
        public const int _FIELD_WIDTH = 10;
        public const int _FIELD_HEIGTH = 10;
        public int[][] FieldData => _field;
        private int[][] _field;
        private readonly Snake _snake;

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
        private void AddSnakeDataToField()
        {
            Point snakeHead = _snake.SnakeHead;
            Point[] snakeBody = _snake.SnakeBody;
            
            _field[snakeHead.Y][snakeHead.X] = 3;
            foreach(var snakeBodyPoint in snakeBody)
            {
                _field[snakeBodyPoint.Y][snakeBodyPoint.X] = 2;
            }
        }
        public Field(Snake snake)
        {
            _snake = snake;
            _field = InitField();
            
        }
        public void ChangeField()
        {

            _field = InitField();
            AddSnakeDataToField();

            var randomizer = new Random();
            var rndRow = randomizer.Next() % 10;
            var rndColumn = randomizer.Next() % 10;

            _field[rndRow][rndColumn] = 1;

        }
    }
}
