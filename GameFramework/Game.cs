using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    class Game
    {
        //Wheither or not the Game should finish running and exit
        public static bool GameOver = false;

        private Scene _currentScene;

        public Game()
        {
            _currentScene = new Scene();
        }

        public void Run()
        {
            Player player = new Player();
            player.X = 4;
            player.Y = 0;

            Entity enemy = new Entity('#');
            enemy.X = 7;
            enemy.Y = 2;

            _currentScene.AddEntity(player);
            _currentScene.AddEntity(enemy);

            _currentScene.Start();

            //loops until the game is over
            while(!GameOver)
            {
                _currentScene.Update();
                _currentScene.Draw();
                PlayerInput.ReadKey();
            }
        }

        public Scene CurrentScene
        {
            get
            {
                return _currentScene;
            }
        }
    }
}
