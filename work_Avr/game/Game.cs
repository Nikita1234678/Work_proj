namespace work_Avr.game
{
    public class Game
    {
        public Field field => _field;
        public Snake Snake => new Snake();
        private readonly Field _field = new Field();


    }
}
