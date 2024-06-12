using System.ComponentModel;

namespace TTFTileMapViewer
{
    public class Tile:IGameItem
    {
        public Bitmap ImageData { get; set; }
        public CeilingFlags Ceiling { get; set; }
        [Category("Patates")]
        public FloorFlags Floor { get; set; }
        [Category("Tile")]
        [DisplayName("Test Property")]
        [Description("This is the description that shows up")]
        public HorizontalFlags Wall { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public Tile() { }
    }
} 
