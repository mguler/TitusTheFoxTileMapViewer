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
    public partial class MainForm : Form
    {
        private TileToolForm _tileToolbox;
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
    }
}
