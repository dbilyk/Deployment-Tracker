namespace Deployment_Tracker
{
    partial class AddRoomPopup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roomMapSidePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numRoomsTxt = new System.Windows.Forms.MaskedTextBox();
            this.roomQtyLbl = new System.Windows.Forms.Label();
            this.OR = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numColTxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numRowsTxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createMapBtn = new System.Windows.Forms.Button();
            this.roomMapSidePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomMapSidePanel
            // 
            this.roomMapSidePanel.BackColor = System.Drawing.Color.White;
            this.roomMapSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomMapSidePanel.Controls.Add(this.panel2);
            this.roomMapSidePanel.Controls.Add(this.OR);
            this.roomMapSidePanel.Controls.Add(this.panel4);
            this.roomMapSidePanel.Controls.Add(this.panel3);
            this.roomMapSidePanel.Controls.Add(this.createMapBtn);
            this.roomMapSidePanel.Location = new System.Drawing.Point(0, 0);
            this.roomMapSidePanel.Name = "roomMapSidePanel";
            this.roomMapSidePanel.Size = new System.Drawing.Size(211, 180);
            this.roomMapSidePanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.numRoomsTxt);
            this.panel2.Controls.Add(this.roomQtyLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(209, 37);
            this.panel2.TabIndex = 1;
            // 
            // numRoomsTxt
            // 
            this.numRoomsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numRoomsTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numRoomsTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.numRoomsTxt.Location = new System.Drawing.Point(158, 9);
            this.numRoomsTxt.Name = "numRoomsTxt";
            this.numRoomsTxt.PromptChar = '.';
            this.numRoomsTxt.Size = new System.Drawing.Size(45, 20);
            this.numRoomsTxt.TabIndex = 1;
            this.numRoomsTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // roomQtyLbl
            // 
            this.roomQtyLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.roomQtyLbl.AutoSize = true;
            this.roomQtyLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.roomQtyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomQtyLbl.Location = new System.Drawing.Point(5, 9);
            this.roomQtyLbl.Name = "roomQtyLbl";
            this.roomQtyLbl.Size = new System.Drawing.Size(122, 17);
            this.roomQtyLbl.TabIndex = 0;
            this.roomQtyLbl.Text = "Number of Rooms";
            this.roomQtyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OR
            // 
            this.OR.AutoSize = true;
            this.OR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OR.Location = new System.Drawing.Point(0, 39);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(31, 17);
            this.OR.TabIndex = 2;
            this.OR.Text = "-or-";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel4.Controls.Add(this.numColTxt);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(209, 35);
            this.panel4.TabIndex = 3;
            // 
            // numColTxt
            // 
            this.numColTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numColTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numColTxt.Location = new System.Drawing.Point(158, 8);
            this.numColTxt.Name = "numColTxt";
            this.numColTxt.PromptChar = '.';
            this.numColTxt.Size = new System.Drawing.Size(45, 20);
            this.numColTxt.TabIndex = 1;
            this.numColTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(209, 36);
            this.panel3.TabIndex = 2;
            // 
            // numRowsTxt
            // 
            this.numRowsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numRowsTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numRowsTxt.Location = new System.Drawing.Point(158, 8);
            this.numRowsTxt.Name = "numRowsTxt";
            this.numRowsTxt.PromptChar = '.';
            this.numRowsTxt.Size = new System.Drawing.Size(45, 20);
            this.numRowsTxt.TabIndex = 1;
            this.numRowsTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Rows";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createMapBtn
            // 
            this.createMapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(109)))));
            this.createMapBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createMapBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMapBtn.FlatAppearance.BorderSize = 0;
            this.createMapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMapBtn.Location = new System.Drawing.Point(0, 127);
            this.createMapBtn.Name = "createMapBtn";
            this.createMapBtn.Size = new System.Drawing.Size(209, 51);
            this.createMapBtn.TabIndex = 0;
            this.createMapBtn.Text = "Create New Zone";
            this.createMapBtn.UseVisualStyleBackColor = false;
            // 
            // AddRoomPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roomMapSidePanel);
            this.Name = "AddRoomPopup";
            this.Size = new System.Drawing.Size(211, 178);
            this.roomMapSidePanel.ResumeLayout(false);
            this.roomMapSidePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel roomMapSidePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox numRoomsTxt;
        private System.Windows.Forms.Label roomQtyLbl;
        private System.Windows.Forms.Label OR;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox numColTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox numRowsTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createMapBtn;
    }
}
