using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    class Player : Entity
    {
        public Player() : this('@')
        {
           
        }

        public Player(char icon) : base(icon)
        {
            //OnUpdate += MoveRight;
            PlayerInput.AddKeyEvent(MoveRight, ConsoleKey.RightArrow);
            PlayerInput.AddKeyEvent(MoveLeft, ConsoleKey.LeftArrow);
            PlayerInput.AddKeyEvent(MoveUp, ConsoleKey.UpArrow);
            PlayerInput.AddKeyEvent(MoveDown, ConsoleKey.DownArrow);
        }

        //Moves 1 space to the right
        private void MoveRight()
        {
            if (X < TheScene.SizeX - 1)
            {
                X++;
            }
        }

        //Moves 1 space to the left
        private void MoveLeft()
        {
            if (X > 0)
            {
                X--;
            }
        }

        private void MoveUp()
        {
            if (Y > 0)
            {
                Y--;
            }
        }

        private void MoveDown()
        {
            if (Y < TheScene.SizeY -1)
            {
                Y++;
            }
        }
    }
}
