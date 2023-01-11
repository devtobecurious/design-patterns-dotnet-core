using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuProjetFinal.State
{
    internal struct Texture
    {
        public static Texture IdleTexture = new Texture() { Name = "Idle" };
        public static Texture MovingTexture = new Texture() { Name = "Moving" };

        public string Name { get; set; }
    }
}
