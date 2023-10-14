using System.Drawing;

namespace work_Avr.game
{
    public class Snake
    {
        public const int BORN_SNAKE_SIZE = 4;
        public Point[] SnakeBody => _snakeBody.Where(x=>x != SnakeHead).ToArray();
        public Point SnakeHead => _snakeBody.Last();
        public Point Speed { get;  set; } = Point.Empty;
        private readonly Queue<Point> _snakeBody;


        public Snake() 
        {          
            Random randomizer = new Random();
            int snakeHead_X = randomizer.Next(Field._FIELD_WIDTH );
            int snakeHead_Y = randomizer.Next(Field._FIELD_HEIGTH);
            
            _snakeBody = new Queue<Point>();
            for(int counter =0;  counter < BORN_SNAKE_SIZE; counter++)
            {
                _snakeBody.Enqueue( new Point(snakeHead_X, snakeHead_Y) );
            }
        }
        public void Move()
        {
            Point head = SnakeHead;
            Point nextHead = new Point(head.X + Speed.X, head.Y + Speed.Y);
                            
            _snakeBody.Enqueue(nextHead);
            _snakeBody.Dequeue();
        }
    }
}
