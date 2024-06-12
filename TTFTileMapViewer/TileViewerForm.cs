
namespace TTFTileMapViewer
{
    public partial class TileViewerForm : Form
    {
        public Tile[] Tiles { get => __tiles; }
        private byte[] _tileMap;
        private Bitmap[] _tiles;
        private Tile[] __tiles;
        private long _levelSize;
        private List<int> _selectedTiles = new List<int>();

        public bool ShowTiles { get => _showTiles; set { _showTiles = value; Refresh(); } }
        private bool _showTiles;

        public bool ShowBonusses { get => _showBonusses; set { _showBonusses = value; Refresh(); } }
        private bool _showBonusses;

        public bool ShowGates { get => _showGates; set { _showGates = value; Refresh(); } }
        private bool _showGates;

        public bool ShowTransportation { get => _showTransportation; set { _showTransportation = value; Refresh(); } }
        private bool _showTransportation;

        public Bonus[] Bonusses { get; private set; }
        public GameObject[] GameObjects { get; private set; }
        public Gate[] Gates { get; private set; }

        public TileViewerForm( )
        {
            var fileName = "";
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
            _tiles = TileTool.GetTileBitmaps(bitmaps);
            __tiles = _tiles.Select(t => new Tile
            {
                ImageData = t
            }).ToArray();

            file.Dispose();

            AutoScroll = true;
            SetAutoScrollMargin(256 * 16, (int)_levelSize * 16);
            panel1.Size = new Size(0, 0);
        }

        public TileViewerForm(string fileName ,bool tileVisibility = true, bool bonusVisibility =  true,bool gateVisibility = true,bool showTransportation = true)
        {
            InitializeComponent();

            _showTiles = tileVisibility;
            _showBonusses = bonusVisibility;
            _showGates = gateVisibility;
            _showTransportation = showTransportation;

            this.DoubleBuffered = this.ResizeRedraw = true;
            var file = new FileStream(fileName, FileMode.Open);
            _levelSize = (file.Length - 35828) / 256;
            var p = 256 * _levelSize + 32768;
            _tileMap = new byte[_levelSize * 256];
            file.Read(_tileMap, 0, _tileMap.Length);

            var tileData = new byte[256 * 128 + 3 * 256];
            file.Position = (_levelSize * 256);
            file.Read(tileData, (int)0, tileData.Length);

            var t = this.AutoScrollMargin;

            var tiles = TileTool.GetTiles(tileData);

            __tiles = tiles.ToArray();

            var bonusData = new byte[400];
            file.Position = p + 2314;
            file.Read(bonusData, 0, bonusData.Length);
            Bonusses = TileTool.GetBonusses(bonusData);

            var gameObjectData = new byte[40 * 6];
            file.Position = p + 768;
            file.Read(gameObjectData, 0, gameObjectData.Length);
            GameObjects = TileTool.GetGameObjects(gameObjectData);

            var gateData = new byte[20 * 7];
            file.Position = p + 2716;
            file.Read(gateData, 0, gateData.Length);
            Gates = TileTool.GetGates(gateData);

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
            _tiles = TileTool.GetTileBitmaps(bitmaps);
            __tiles = _tiles.Select(t => new Tile { ImageData = t }).ToArray();
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

            if (_showTiles)
            {
                for (var y = 0; y < _levelSize; y++)
                {
                    for (var x = 0; x < 256; x++)
                    {
                        var tile = __tiles[_tileMap[y * 256 + x]];
                        e.Graphics.DrawImage(tile.ImageData, x * 15, y * 15);
                    }
                }
            }

            if (_showBonusses)
            {

                for (var index = 0; index < Bonusses.Length; index++)
                {
                    e.Graphics.DrawImage(__tiles[Bonusses[index].SpriteNumber].ImageData, Bonusses[index].X * 15, Bonusses[index].Y * 15);
                }
            }

            if (_showGates)
            {

                for (var index = 0; index < Gates.Length; index++)
                {
                    var rect = new RectangleF(Gates[index].EntranceX * 15 - 8, Gates[index].EntranceY * 15 - 8, 16, 16);

                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Blue)), rect);
                    e.Graphics.DrawString(@$"{index} EN", Font, new SolidBrush(Color.White), rect);

                    rect = new RectangleF(Gates[index].ExitX * 15 - 8, Gates[index].ExitY * 15 - 8, 16, 16);
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Red)), rect);
                    e.Graphics.DrawString(@$"{index} EN", Font, new SolidBrush(Color.White), rect);
                }
            }

            if (_showTransportation)
            {

                for (var index = 0; index < Gates.Length; index++)
                {
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.White)), Gates[index].EntranceX*15, Gates[index].EntranceY*15, Gates[index].ExitX * 15, Gates[index].ExitY * 15);

                }
            }

            //for (var index = 0; index < GameObjects.Length; index++)
            //{
            //    e.Graphics.DrawImage(__tiles[GameObjects[index].SpriteNumber].ImageData, GameObjects[index].X * 15, GameObjects[index].Y * 15);
            //}

            for (var index = 0; index < _selectedTiles.Count; index++)
            {
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Yellow)), (_selectedTiles[index] % 256) * 15, (_selectedTiles[index] / 256)*15, 15, 15);
            }
        }

        private void TileViewerForm_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedIndex = (e.Y / 15) * 256 + e.X / 15;
            var x =  e.X / 15;
            var y = e.Y / 15;

            if (!_selectedTiles.Contains((int)selectedIndex))
            {
                _selectedTiles.Add((int)selectedIndex);
            }
            else 
            {
                _selectedTiles.Remove((int)selectedIndex);
            }
            Refresh();
        }
    }
}