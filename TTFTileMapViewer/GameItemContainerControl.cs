using System.Windows.Forms;

namespace TTFTileMapViewer
{
    public partial class GameItemContainerControl : UserControl
    {
        private int _rowItemsCount = 0;
        public IGameItem SelectedItem { get; }
        public IGameItem[] Items { get; set; }

        public GameItemContainerControl()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            var graphics = CreateGraphics();
            for (var index = 0; index < Items?.Length; index++)
            {
                graphics.DrawImage(Items[index].ImageData
                    , (index % _rowItemsCount) * 16, (index / _rowItemsCount) * 16);
            }
            graphics.Dispose();
            base.OnPaint(e);
        }

        private void GameItemContainerControl_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedIndex = (e.Y / 15) * 256 + e.X / 15;
            var x = e.X / 15;
            var y = e.Y / 15;
             
            //if ( )
            //{
            //    _selectedTiles.Add((int)selectedIndex);
            //}
            //else
            //{
            //    _selectedTiles.Remove((int)selectedIndex);
            //}
            Refresh();
        }

        private void GameItemContainerControl_SizeChanged(object sender, EventArgs e)
        {
            _rowItemsCount = Width / 15;
        }
    }
}
