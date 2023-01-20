using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Dias.Resources
{
    internal class Desk
    {
        private int width, depth;
        public int numberOfDrawers;
        public DesktopMaterial surfaceMaterial;
        public int surfaceArea
        {
            get
            {
                return width * depth;
            }
        }

        public Desk(int width, int depth, int numberOfDrawers, DesktopMaterial surfaceMaterial) { 
            this.width = width;
            this.depth = depth;
            this.numberOfDrawers = numberOfDrawers; 
            this.surfaceMaterial = surfaceMaterial; 
        }

        public Desk(string str)
        {
            var deskStr = str.Split(',');
            this.width = int.Parse(deskStr[0]);
            this.depth = int.Parse(deskStr[1]);
            this.numberOfDrawers = int.Parse(deskStr[2]);
            this.surfaceMaterial = (DesktopMaterial)int.Parse(deskStr[3]);
        }
        public override string ToString()
        {
            return $"{width},{depth},{numberOfDrawers},{(int)surfaceMaterial}";
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
