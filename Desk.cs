using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Alexander
{
    public class Desk
    {
        // Constraints
        // Constants for width and depth constraints
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public const int MIN_DRAWERS = 0;
        public const int MAX_DRAWERS = 7;

        // Properties of Desk
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial Material { get; set; } 

        public Desk(int width, int depth, int numberOfDrawers, DesktopMaterial material)
        {
            Width = width;
            Depth = depth;
            NumberOfDrawers = numberOfDrawers;
            Material = material;
        }
    }

    public enum DesktopMaterial
    {
        None,
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
