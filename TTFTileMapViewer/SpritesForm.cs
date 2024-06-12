namespace TTFTileMapViewer
{
    public partial class SpritesForm : Form
    {

        public Sprite[] _sprites = new Sprite[0];
        public Sprite[] Tiles
        {
            get => _sprites;
            set
            {
                gameItemContainerControl1.Items = value;
                Redraw();
            }
        }
        public SpritesForm()
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
