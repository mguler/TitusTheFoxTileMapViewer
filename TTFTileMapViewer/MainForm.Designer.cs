namespace TTFTileMapViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            importToolStripMenuItem = new ToolStripMenuItem();
            loadSpritesToolStripMenuItem = new ToolStripMenuItem();
            loadSpritesSizesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            showGridlinesToolStripMenuItem = new ToolStripMenuItem();
            graphicsToolStripMenuItem = new ToolStripMenuItem();
            tilesToolStripMenuItem = new ToolStripMenuItem();
            bonussesToolStripMenuItem = new ToolStripMenuItem();
            gatesToolStripMenuItem = new ToolStripMenuItem();
            transportationLinesToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            importFileDialog = new OpenFileDialog();
            openFileDialog1 = new OpenFileDialog();
            importSpriteSizeDialog = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, importToolStripMenuItem, loadSpritesToolStripMenuItem, loadSpritesSizesToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(190, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(190, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(190, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(190, 22);
            saveAsToolStripMenuItem.Text = "Save As..";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(187, 6);
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(190, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // loadSpritesToolStripMenuItem
            // 
            loadSpritesToolStripMenuItem.Name = "loadSpritesToolStripMenuItem";
            loadSpritesToolStripMenuItem.Size = new Size(190, 22);
            loadSpritesToolStripMenuItem.Text = "Import Sprites";
            loadSpritesToolStripMenuItem.Click += loadSpritesToolStripMenuItem_Click;
            // 
            // loadSpritesSizesToolStripMenuItem
            // 
            loadSpritesSizesToolStripMenuItem.Name = "loadSpritesSizesToolStripMenuItem";
            loadSpritesSizesToolStripMenuItem.Size = new Size(190, 22);
            loadSpritesSizesToolStripMenuItem.Text = "Import Sprite Size Info";
            loadSpritesSizesToolStripMenuItem.Click += loadSpritesSizesToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(190, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, showGridlinesToolStripMenuItem, graphicsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.Size = new Size(180, 22);
            zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(180, 22);
            zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // showGridlinesToolStripMenuItem
            // 
            showGridlinesToolStripMenuItem.CheckOnClick = true;
            showGridlinesToolStripMenuItem.Name = "showGridlinesToolStripMenuItem";
            showGridlinesToolStripMenuItem.Size = new Size(180, 22);
            showGridlinesToolStripMenuItem.Text = "Show Gridlines";
            // 
            // graphicsToolStripMenuItem
            // 
            graphicsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tilesToolStripMenuItem, bonussesToolStripMenuItem, gatesToolStripMenuItem, transportationLinesToolStripMenuItem });
            graphicsToolStripMenuItem.Name = "graphicsToolStripMenuItem";
            graphicsToolStripMenuItem.Size = new Size(180, 22);
            graphicsToolStripMenuItem.Text = "Sprite Visibility";
            // 
            // tilesToolStripMenuItem
            // 
            tilesToolStripMenuItem.Checked = true;
            tilesToolStripMenuItem.CheckOnClick = true;
            tilesToolStripMenuItem.CheckState = CheckState.Checked;
            tilesToolStripMenuItem.Name = "tilesToolStripMenuItem";
            tilesToolStripMenuItem.Size = new Size(182, 22);
            tilesToolStripMenuItem.Text = "Tiles";
            tilesToolStripMenuItem.CheckedChanged += StripMenuItemCheckedChanged;
            // 
            // bonussesToolStripMenuItem
            // 
            bonussesToolStripMenuItem.Checked = true;
            bonussesToolStripMenuItem.CheckOnClick = true;
            bonussesToolStripMenuItem.CheckState = CheckState.Checked;
            bonussesToolStripMenuItem.Name = "bonussesToolStripMenuItem";
            bonussesToolStripMenuItem.Size = new Size(182, 22);
            bonussesToolStripMenuItem.Text = "Bonusses";
            bonussesToolStripMenuItem.CheckedChanged += StripMenuItemCheckedChanged;
            // 
            // gatesToolStripMenuItem
            // 
            gatesToolStripMenuItem.Checked = true;
            gatesToolStripMenuItem.CheckOnClick = true;
            gatesToolStripMenuItem.CheckState = CheckState.Checked;
            gatesToolStripMenuItem.Name = "gatesToolStripMenuItem";
            gatesToolStripMenuItem.Size = new Size(182, 22);
            gatesToolStripMenuItem.Text = "Transportation Gates";
            gatesToolStripMenuItem.CheckedChanged += StripMenuItemCheckedChanged;
            // 
            // transportationLinesToolStripMenuItem
            // 
            transportationLinesToolStripMenuItem.Checked = true;
            transportationLinesToolStripMenuItem.CheckOnClick = true;
            transportationLinesToolStripMenuItem.CheckState = CheckState.Checked;
            transportationLinesToolStripMenuItem.Name = "transportationLinesToolStripMenuItem";
            transportationLinesToolStripMenuItem.Size = new Size(182, 22);
            transportationLinesToolStripMenuItem.Text = "Transportation";
            transportationLinesToolStripMenuItem.CheckedChanged += StripMenuItemCheckedChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Decompressed Level Files|*.LVL";
            // 
            // importFileDialog
            // 
            importFileDialog.Filter = "Compressed Level Files|*.SQZ";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Compressed Level Files|*.SQZ";
            // 
            // importSpriteSizeDialog
            // 
            importSpriteSizeDialog.Filter = "Sprite Size Files|*.SIZ";
            importSpriteSizeDialog.FileOk += importSpriteSizeDialog_FileOk;
            // 
            // openFileDialog2
            // 
            openFileDialog2.Filter = "Compressed Level Files|*.SQZ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Titus The Fox Tile Viewer";
            Load += MainForm_Load;
            Click += MainForm_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem showGridlinesToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private OpenFileDialog importFileDialog;
        private ToolStripMenuItem loadSpritesToolStripMenuItem;
        private ToolStripMenuItem loadSpritesSizesToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog importSpriteSizeDialog;
        private OpenFileDialog openFileDialog2;
        private ToolStripMenuItem graphicsToolStripMenuItem;
        private ToolStripMenuItem tilesToolStripMenuItem;
        private ToolStripMenuItem bonussesToolStripMenuItem;
        private ToolStripMenuItem gatesToolStripMenuItem;
        private ToolStripMenuItem transportationLinesToolStripMenuItem;
    }
}