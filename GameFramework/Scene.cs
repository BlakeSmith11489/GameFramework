using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    //This will be responsible for updating and drawing the game 
    class Scene
    {
        private List<Entity> _entities = new List<Entity>();
        private int _sizeX;
        private int _sizeY;
        //int counter = 0;

        public Scene()
        {
            _sizeX = 12;
            _sizeY = 3;
        }

        public Scene(int sizeX, int sizeY)
        {
            _sizeX = sizeX;
            _sizeY = sizeY;
        }

        public int SizeX
        {
            get
            {
                return _sizeX;
            }
        }
        public int SizeY
        {
            get
            {
                return _sizeY;
            }
        }

        public void Start()
        {
            foreach (Entity e in _entities)
            {
                e.Start();
            }
        }
        
        public void Update()
        {
            //counter++;
            foreach (Entity e in _entities)
            {
                e.Update();
            }
        }

        public void Draw()
        {
            Console.Clear();

            char[,] display = new char[_sizeX, _sizeY];

            foreach (Entity e in _entities)
            {
                e.Draw();
                //Position each Entity's icon in the display
                if (e.X >= 0 && e.X < _sizeX
                    && e.Y >= 0 && e.Y < _sizeY)
                {
                    display[e.X, e.Y] = e.Icon;
                }
            }

            //Console.Write(counter);

            for (int y = 0; y < _sizeY; y++)
            {
                for(int x = 0; x < _sizeX; x++)
                {
                    Console.Write(display[x, y]);
                }
                Console.WriteLine();
            }

        }

        //Adds an entity to the Scene
        public void AddEntity(Entity entity)
        {
            _entities.Add(entity);
            entity.TheScene = this;
        }

        //Remove an entity from the Scene
        public void RemoveEntity(Entity entity)
        {
            _entities.Remove(entity);
            entity.TheScene = null;
        }

        public void ClearEntities()
        {
            foreach (Entity e in _entities)
            {
                e.TheScene = null;
            }
            _entities.Clear();
        }
    }
}
