using Engine.Models;

namespace Engine.ViewModels
{
    internal class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Scott";
            CurrentPlayer.Gold = 1000000;


        }

    }
}
