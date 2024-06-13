namespace TTFTileMapViewer
{
    public partial class MainForm : Form
    {
        private TileToolForm _tileToolbox;
        private TilePropertiesForm _tileProperties;
        private Size[] _spriteSizes = new Size[0];


        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog.FileName))
            {
                var form = new TileViewerForm(openFileDialog.FileName);
                form.Text = openFileDialog.FileName;
                form.MdiParent = this;
                form.Show();
                _tileToolbox.Tiles = form.Tiles;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _tileToolbox = new TileToolForm();
            _tileToolbox.MdiParent = this;
            _tileToolbox.Show();

            _tileProperties = new TilePropertiesForm();
            _tileProperties.MdiParent = this;
            _tileProperties.Show();

            _tileProperties.Tile = new Tile();

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(importFileDialog.FileName))
            {
                var fileContent = File.ReadAllBytes(importFileDialog.FileName);
                var lzwDecoder = new LZWDecoder();
                var decoded = lzwDecoder.Decode(fileContent);
                var form = new TileViewerForm(decoded);
                form.Text = importFileDialog.FileName;
                form.MdiParent = this;
                form.Show();
                _tileToolbox.Tiles = form.Tiles;
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {

        }

        private void loadSpritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(importFileDialog.FileName))
            {
                var fileContent = File.ReadAllBytes(importFileDialog.FileName);
                _spriteSizes = TileTool.GetSizes(fileContent).ToArray();
            }
        }

        private void loadSpritesSizesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(importFileDialog.FileName))
            {
                var fileContent = File.ReadAllBytes(importFileDialog.FileName);
                _spriteSizes = TileTool.GetSizes(fileContent).ToArray();
            }
        }

        private void importSpriteSizeDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void tilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StripMenuItemCheckedChanged(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var form = this.ActiveMdiChild as TileViewerForm;

            if (menuItem.Text == "Tiles")
            {
                form.ShowTiles = menuItem.Checked;
            }
            else if (menuItem.Text == "Bonusses")
            {
                form.ShowBonusses = menuItem.Checked;
            }
            else if (menuItem.Text == "Transportation Gates")
            {
                form.ShowGates = menuItem.Checked;
            }
            else if (menuItem.Text == "Transportation")
            {
                form.ShowTransportation = menuItem.Checked;
            }

            form.Refresh();
        }
    }
}