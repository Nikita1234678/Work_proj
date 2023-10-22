
using Humanizer;

namespace work_Avr.Models.Api
{
    public class GetStatusDataModel
    {
        public int SnakeSize { get; }
        public int SnakeScore { get; }
        public TimeSpan GameTime { get; }
        public int SnakeDead { get; }
        public bool IsSnakeDead { get; }
        public bool IsSnakeMove { get; }
        public GetStatusDataModel(game.Game model)
        {
            GameTime = new TimeSpan(model.Statistic.GameTime.Hours, model.Statistic.GameTime.Minutes,
                       model.Statistic.GameTime.Seconds);
            SnakeScore = model.Statistic.GameScore;
            SnakeSize = model.Statistic.SnakeSize - 4;
            IsSnakeDead = !model.Statistic.IsDead;
            IsSnakeMove = model.Snake.IsMoving;
            
        }
    }
}
