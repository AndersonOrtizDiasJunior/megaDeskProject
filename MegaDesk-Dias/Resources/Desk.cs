using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Dias.Resources
{
    internal class Desk
    {
        private float width, depth;
        public int numberOfDrawers;
        public DesktopMaterial surfaceMaterial;
        public float surfaceArea
        {
            get
            {
                return width * depth;
            }
        }

        public Desk(float width, float depth, int numberOfDrawers, DesktopMaterial surfaceMaterial) { 
            this.width = width;
            this.depth = depth;
            this.numberOfDrawers = numberOfDrawers; 
            this.surfaceMaterial = surfaceMaterial; 
        }
    }

    enum DesktopMaterial
    {
        oak,
        laminate,
        pine,
        rosewood,
        veneer
    }
}
