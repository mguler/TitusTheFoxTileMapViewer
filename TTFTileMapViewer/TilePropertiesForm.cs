
namespace TTFTileMapViewer
{
    public partial class TilePropertiesForm : Form
    {
        public object Tile { get => propertyGrid1.SelectedObject;  set => this.propertyGrid1.SelectedObject = value; } 

        public TilePropertiesForm()
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

        }
        private void TileToolForm_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
