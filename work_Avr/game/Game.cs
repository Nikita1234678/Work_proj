namespace work_Avr.game
{
    public class Game
    {
        public Field field => _field;
        public Snake Snake => _snake;
        public GameTimer Timer => _timer;

        private readonly Field _field;
        private readonly Snake _snake;
        private readonly GameTimer _timer;
        public Game()
        {
             _snake = new Snake();
             _field = new Field(_snake);
           
            _timer = new GameTimer(TimeSpan.FromSeconds(0.5f), _field.ChangeField, _snake.Move);
        }
    }
}
