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
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                var form = new TileViewerForm(openFileDialog1.FileName);
                form.Text = openFileDialog1.FileName;
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
    }
}
