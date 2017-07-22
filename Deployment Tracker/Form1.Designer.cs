namespace Deployment_Tracker
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addZoneMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Inventory = new System.Windows.Forms.TabPage();
            this.RoomMap = new System.Windows.Forms.TableLayoutPanel();
            this.ZoneTabs = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.Inventory.SuspendLayout();
            this.ZoneTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1328, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemTypeToolStripMenuItem,
            this.addZoneMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // addItemTypeToolStripMenuItem
            // 
            this.addItemTypeToolStripMenuItem.Name = "addItemTypeToolStripMenuItem";
            this.addItemTypeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addItemTypeToolStripMenuItem.Text = "Add Item Type...";
            // 
            // addZoneMenuItem
            // 
            this.addZoneMenuItem.Name = "addZoneMenuItem";
            this.addZoneMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addZoneMenuItem.Text = "Add Zone...";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 899);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // Inventory
            // 
            this.Inventory.Controls.Add(this.RoomMap);
            this.Inventory.Location = new System.Drawing.Point(4, 22);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.Inventory.Size = new System.Drawing.Size(1022, 396);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "tabPage1";
            this.Inventory.UseVisualStyleBackColor = true;
            // 
            // RoomMap
            // 
            this.RoomMap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RoomMap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RoomMap.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.RoomMap.ColumnCount = 1;
            this.RoomMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RoomMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomMap.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.RoomMap.Location = new System.Drawing.Point(3, 3);
            this.RoomMap.Name = "RoomMap";
            this.RoomMap.RowCount = 1;
            this.RoomMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RoomMap.Size = new System.Drawing.Size(1016, 390);
            this.RoomMap.TabIndex = 0;
            // 
            // ZoneTabs
            // 
            this.ZoneTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoneTabs.Controls.Add(this.Inventory);
            this.ZoneTabs.Location = new System.Drawing.Point(298, 27);
            this.ZoneTabs.Name = "ZoneTabs";
            this.ZoneTabs.SelectedIndex = 0;
            this.ZoneTabs.Size = new System.Drawing.Size(1030, 422);
            this.ZoneTabs.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 923);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.ZoneTabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Inventory.ResumeLayout(false);
            this.ZoneTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addZoneMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage Inventory;
        private System.Windows.Forms.TableLayoutPanel RoomMap;
        private System.Windows.Forms.TabControl ZoneTabs;
    }



}

