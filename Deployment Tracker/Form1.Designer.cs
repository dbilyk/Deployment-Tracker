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
            this.addNewZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Inventory = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomMapSidePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numColTxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numRowsTxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numRoomsTxt = new System.Windows.Forms.MaskedTextBox();
            this.roomQtyLbl = new System.Windows.Forms.Label();
            this.createMapBtn = new System.Windows.Forms.Button();
            this.RoomMap = new System.Windows.Forms.TableLayoutPanel();
            this.ID_Assignments = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Inventory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.roomMapSidePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
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
            this.addNewZoneToolStripMenuItem});
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
            // addNewZoneToolStripMenuItem
            // 
            this.addNewZoneToolStripMenuItem.Name = "addNewZoneToolStripMenuItem";
            this.addNewZoneToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addNewZoneToolStripMenuItem.Text = "Add Zone...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Inventory);
            this.tabControl1.Controls.Add(this.ID_Assignments);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1480, 446);
            this.tabControl1.TabIndex = 1;
            // 
            // Inventory
            // 
            this.Inventory.Controls.Add(this.panel1);
            this.Inventory.Location = new System.Drawing.Point(4, 22);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.Inventory.Size = new System.Drawing.Size(1472, 420);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "tabPage1";
            this.Inventory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roomMapSidePanel);
            this.panel1.Controls.Add(this.RoomMap);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1472, 419);
            this.panel1.TabIndex = 1;
            // 
            // roomMapSidePanel
            // 
            this.roomMapSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roomMapSidePanel.Controls.Add(this.panel4);
            this.roomMapSidePanel.Controls.Add(this.panel3);
            this.roomMapSidePanel.Controls.Add(this.label1);
            this.roomMapSidePanel.Controls.Add(this.panel2);
            this.roomMapSidePanel.Controls.Add(this.createMapBtn);
            this.roomMapSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomMapSidePanel.Location = new System.Drawing.Point(0, 0);
            this.roomMapSidePanel.Name = "roomMapSidePanel";
            this.roomMapSidePanel.Size = new System.Drawing.Size(267, 419);
            this.roomMapSidePanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel4.Controls.Add(this.numColTxt);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 334);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(267, 36);
            this.panel4.TabIndex = 3;
            // 
            // numColTxt
            // 
            this.numColTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numColTxt.Location = new System.Drawing.Point(213, 8);
            this.numColTxt.Name = "numColTxt";
            this.numColTxt.PromptChar = '.';
            this.numColTxt.Size = new System.Drawing.Size(37, 20);
            this.numColTxt.TabIndex = 1;
            this.numColTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.numColTxt.Click += new System.EventHandler(this.numColTxt_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of Columns";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel3.Controls.Add(this.numRowsTxt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 300);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(267, 36);
            this.panel3.TabIndex = 2;
            // 
            // numRowsTxt
            // 
            this.numRowsTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numRowsTxt.Location = new System.Drawing.Point(213, 8);
            this.numRowsTxt.Name = "numRowsTxt";
            this.numRowsTxt.PromptChar = '.';
            this.numRowsTxt.Size = new System.Drawing.Size(37, 20);
            this.numRowsTxt.TabIndex = 1;
            this.numRowsTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.numRowsTxt.Click += new System.EventHandler(this.numRowsTxt_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Rows";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "-or-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.numRoomsTxt);
            this.panel2.Controls.Add(this.roomQtyLbl);
            this.panel2.Location = new System.Drawing.Point(0, 241);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(267, 36);
            this.panel2.TabIndex = 1;
            // 
            // numRoomsTxt
            // 
            this.numRoomsTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numRoomsTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.numRoomsTxt.Location = new System.Drawing.Point(213, 8);
            this.numRoomsTxt.Name = "numRoomsTxt";
            this.numRoomsTxt.PromptChar = '.';
            this.numRoomsTxt.Size = new System.Drawing.Size(37, 20);
            this.numRoomsTxt.TabIndex = 1;
            this.numRoomsTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.numRoomsTxt.Click += new System.EventHandler(this.numRoomsTxt_Click);
            // 
            // roomQtyLbl
            // 
            this.roomQtyLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomQtyLbl.AutoSize = true;
            this.roomQtyLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.roomQtyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomQtyLbl.Location = new System.Drawing.Point(5, 9);
            this.roomQtyLbl.Name = "roomQtyLbl";
            this.roomQtyLbl.Size = new System.Drawing.Size(122, 17);
            this.roomQtyLbl.TabIndex = 0;
            this.roomQtyLbl.Text = "Number of Rooms";
            this.roomQtyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createMapBtn
            // 
            this.createMapBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createMapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.createMapBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMapBtn.FlatAppearance.BorderSize = 0;
            this.createMapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMapBtn.Location = new System.Drawing.Point(0, 368);
            this.createMapBtn.Name = "createMapBtn";
            this.createMapBtn.Size = new System.Drawing.Size(0, 51);
            this.createMapBtn.TabIndex = 0;
            this.createMapBtn.Text = "Create Map";
            this.createMapBtn.UseVisualStyleBackColor = false;
            this.createMapBtn.Click += new System.EventHandler(this.createMapBtn_Click);
            // 
            // RoomMap
            // 
            this.RoomMap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RoomMap.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.RoomMap.ColumnCount = 1;
            this.RoomMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RoomMap.Dock = System.Windows.Forms.DockStyle.Right;
            this.RoomMap.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.RoomMap.Location = new System.Drawing.Point(267, 0);
            this.RoomMap.Name = "RoomMap";
            this.RoomMap.RowCount = 1;
            this.RoomMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RoomMap.Size = new System.Drawing.Size(1205, 419);
            this.RoomMap.TabIndex = 0;
            // 
            // ID_Assignments
            // 
            this.ID_Assignments.Location = new System.Drawing.Point(4, 22);
            this.ID_Assignments.Name = "ID_Assignments";
            this.ID_Assignments.Padding = new System.Windows.Forms.Padding(3);
            this.ID_Assignments.Size = new System.Drawing.Size(1472, 420);
            this.ID_Assignments.TabIndex = 1;
            this.ID_Assignments.Text = "tabPage2";
            this.ID_Assignments.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 709);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Inventory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.roomMapSidePanel.ResumeLayout(false);
            this.roomMapSidePanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewZoneToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Inventory;
        private System.Windows.Forms.TableLayoutPanel RoomMap;
        private System.Windows.Forms.TabPage ID_Assignments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel roomMapSidePanel;
        private System.Windows.Forms.Button createMapBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox numColTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox numRowsTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label roomQtyLbl;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MaskedTextBox numRoomsTxt;
    }
}

