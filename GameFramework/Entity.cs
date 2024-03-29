﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    delegate void Event();

    class Entity
    {
        public Event OnStart;
        public Event OnUpdate;
        public Event OnDraw;

        public char Icon { get; set; } = ' ';

        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        private Scene _scene;
        public Scene TheScene
        {
            set
            {
                _scene = value;
            }
            get
            {
                return _scene;
            }
        }

        public Entity()
        {

        }

        public Entity(char icon)
        {
            Icon = icon;
        }

        public void Start()
        {
            OnStart?.Invoke();
        }

        public void Update()
        {
            OnUpdate?.Invoke();
        }

        public void Draw()
        {
            OnDraw?.Invoke();
        }
    }
}
