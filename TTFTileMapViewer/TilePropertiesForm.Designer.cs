﻿namespace TTFTileMapViewer
{
    partial class TilePropertiesForm
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
            propertyGrid1 = new PropertyGrid();
            SuspendLayout();
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.Location = new Point(0, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(313, 450);
            propertyGrid1.TabIndex = 0;
            // 
            // TilePropertiesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 450);
            Controls.Add(propertyGrid1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TilePropertiesForm";
            Text = "Tiles & Properties";
            Load += TileToolForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private PropertyGrid propertyGrid1;
    }
}