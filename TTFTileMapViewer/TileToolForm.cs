using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTFTileMapViewer
{
    public partial class TileToolForm : Form
    {
        public Bitmap[] _tiles = new Bitmap[0];
        public Bitmap[] Tiles
        {
            get => _tiles;
            set
            {
                _tiles = value;
                Redraw();
            }
        }
        public TileToolForm()
        {
            InitializeComponent();
            this.DoubleBuffered = this.ResizeRedraw = true;
        }

        private void Redraw()
        {
            var graphics = splitContainer2.Panel2.CreateGraphics();
            for (var index = 0; index < _tiles.Length; index++)
            {
                graphics.DrawImage(_tiles[index]
                    , (index % 16) * 16, (index / 16) * 15);
            }
            graphics.Dispose();
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Redraw();
            base.OnPaint(e);

        }
        private void TileToolForm_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
