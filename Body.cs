using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakegame
{
    internal class Body
    {
        private Sprite2D _sprite;
        Body next = null;
        public Body(Sprite2D sprite) { _sprite = sprite; }
        void AddToTail(Sprite2D sprite)
        {
            this.next = new Body(sprite);
        }
    }
}
