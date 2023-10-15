using System.Data;

namespace work_Avr.game
{
    public class Statistics
    {
        private readonly Snake _snake;
        public TimeSpan GameTime { get;  private set; }
        public int GameScore { get; private set; }
        public int SnakeSize { get; private set; }
        private  DateTime GameStarted { get; set; }
        private DateTime TurnStarted { get; set; }  

        public Statistics(Snake snake)
        {
            _snake = snake;
            if (_snake.IsMoving){GameStarted = DateTime.Now;}
            else { GameStarted = DateTime.MinValue;}
            GameTime = TimeSpan.Zero;
            GameScore = 0;
            SnakeSize=_snake.SnakeSize;
            TurnStarted = GameStarted;
        }
        public void Tick() 
        {
            if(_snake.IsMoving && GameStarted==DateTime.MinValue)
            {
                GameStarted = DateTime.Now;
            }
            if(_snake.IsMoving) { GameTime = DateTime.Now - GameStarted; }
            if(_snake.SnakeSize != SnakeSize)
            {
                SnakeSize = _snake.SnakeSize;
                // base score 100
                // 100 for 10 turns i.e 10 sec
                // 1 for more than 20 sec

                var eatSecond = (int)(DateTime.Now - TurnStarted).TotalSeconds;
                if (eatSecond < 10) { GameScore += 100; }
                else if(eatSecond <= 20) { GameScore += 10*(20-eatSecond);}
                else { GameScore += 1; }
            }
        }
    }
}

