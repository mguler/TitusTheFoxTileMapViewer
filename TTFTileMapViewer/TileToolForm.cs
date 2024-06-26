﻿namespace TTFTileMapViewer
{
    public partial class TileToolForm : Form
    {
        public Tile[] _tiles = new Tile[0];
        public Tile[] Tiles
        {
            get => _tiles;
            set
            {
                gameItemContainerControl1.Items = value;
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

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Redraw();
        }
        private void TileToolForm_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
