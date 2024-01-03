namespace TTFTileMapViewer
{
    public partial class TileViewerForm : Form
    {
        public Bitmap[] Tiles { get => _tiles; }
        private byte[] _tileMap;
        private Bitmap[] _tiles;
        private long _levelSize;
        public TileViewerForm(string fileName)
        {
            InitializeComponent();
            this.DoubleBuffered = this.ResizeRedraw = true;
            var file = new FileStream(fileName, FileMode.Open);
            _levelSize = (file.Length - 35828) / 256;
            var p = 256 * _levelSize + 32768;
            _tileMap = new byte[_levelSize * 256];
            file.Read(_tileMap, 0, _tileMap.Length);
            var bitmaps = new byte[256 * 128];
            file.Position = (_levelSize * 256);
            file.Read(bitmaps, (int)0, bitmaps.Length);
            var t = this.AutoScrollMargin;
            _tiles = TileTool.GetTiles(bitmaps);
            file.Dispose();

            AutoScroll = true;
            SetAutoScrollMargin(256 * 16, (int)_levelSize * 16);
            panel1.Size = new Size(0, 0);
        }

        public TileViewerForm(Stream stream)
        {
            InitializeComponent();
            this.DoubleBuffered = this.ResizeRedraw = true;
            _levelSize = (stream.Length - 35828) / 256;
            var p = 256 * _levelSize + 32768;
            _tileMap = new byte[_levelSize * 256];
            stream.Read(_tileMap, 0, _tileMap.Length);
            var bitmaps = new byte[256 * 128];
            stream.Position = (_levelSize * 256);
            stream.Read(bitmaps, (int)0, bitmaps.Length);
            var t = this.AutoScrollMargin;
            _tiles = TileTool.GetTiles(bitmaps);
            stream.Dispose();

            AutoScroll = true;
            SetAutoScrollMargin(256 * 16, (int)_levelSize * 16);
            panel1.Size = new Size(0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
            for (var y = 0; y < _levelSize; y++)
            {
                for (var x = 0; x < 256; x++)
                {
                    var tile = _tiles[_tileMap[y * 256 + x]];
                    e.Graphics.DrawImage(tile, x * 15, y * 15);
                }
            }
        }
    }
}