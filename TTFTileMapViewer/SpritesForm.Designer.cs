namespace TTFTileMapViewer
{
    partial class SpritesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileToolForm));
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            gameItemContainerControl1 = new GameItemContainerControl();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            gameItemContainerControl2 = new GameItemContainerControl();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(gameItemContainerControl2);
            splitContainer1.Size = new Size(313, 450);
            splitContainer1.SplitterDistance = 185;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(gameItemContainerControl1);
            splitContainer2.Panel2.Controls.Add(toolStrip1);
            splitContainer2.Size = new Size(313, 185);
            splitContainer2.SplitterDistance = 94;
            splitContainer2.TabIndex = 0;
            // 
            // gameItemContainerControl1
            // 
            gameItemContainerControl1.Dock = DockStyle.Fill;
            gameItemContainerControl1.Items = null;
            gameItemContainerControl1.Location = new Point(0, 0);
            gameItemContainerControl1.Name = "gameItemContainerControl1";
            gameItemContainerControl1.Size = new Size(313, 62);
            gameItemContainerControl1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 62);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(313, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // gameItemContainerControl2
            // 
            gameItemContainerControl2.Dock = DockStyle.Fill;
            gameItemContainerControl2.Items = null;
            gameItemContainerControl2.Location = new Point(0, 0);
            gameItemContainerControl2.Name = "gameItemContainerControl2";
            gameItemContainerControl2.Size = new Size(313, 261);
            gameItemContainerControl2.TabIndex = 2;
            // 
            // TileToolForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 450);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "TileToolForm";
            Text = "Tiles & Game Objects";
            Load += TileToolForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private GameItemContainerControl gameItemContainerControl1;
        private GameItemContainerControl gameItemContainerControl2;
    }
}