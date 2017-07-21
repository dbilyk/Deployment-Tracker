using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deployment_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //makes sure only one of the two room grid creation methods are used.
        private void numRoomsTxt_Click(object sender, EventArgs e)
        {
            numColTxt.Clear();
            numRowsTxt.Clear();
        }

        private void numRowsTxt_Click(object sender, EventArgs e)
        {
            numRoomsTxt.Clear();
        }
        private void numColTxt_Click(object sender, EventArgs e)
        {
            numRoomsTxt.Clear();
        }

        private void createMapBtn_Click(object sender, EventArgs e)
        {
            RoomMap.ColumnStyles.Clear();
            RoomMap.RowStyles.Clear();
            RoomMap.Controls.Clear();

            //create table via total desired rooms
            if (numRoomsTxt.Text != "")
            {
                int RoomCount = Convert.ToInt16(numRoomsTxt.Text);
                int ColumnCt = 1;
                int RowCt = RoomCount;
                bool RowsNowPrime = false;
                while (ColumnCt < RowCt && !RowsNowPrime)
                {
                    for (int i = 2; i <= 9; i++)
                    {
                        if (RoomCount % i == 0 && RoomCount / i != 1)
                        {
                            RoomCount /= i;
                            ColumnCt *= i;
                            RowCt = RoomCount;
                            break;
                        }
                        if (i == 9 && RoomCount % i != 0)
                        {
                            RoomMap.ColumnCount = ColumnCt;
                            RoomMap.RowCount = RowCt;
                            RowsNowPrime = true;
                        }
                    }

                }

                for (int i = 0; i <= ColumnCt; i++)
                {
                    ColumnStyle newCol = new ColumnStyle(SizeType.Percent, 0.1f);
                    RoomMap.ColumnStyles.Add(newCol);


                }
                for (int i = 0; i <= RowCt; i++)
                {
                    RowStyle newRow = new RowStyle(SizeType.Percent, 0.1f);
                    RoomMap.RowStyles.Add(newRow);

                }
                RoomMap.ColumnCount = ColumnCt;
                RoomMap.RowCount = RowCt;


            }
            //create table via rows and columns
            if (numRoomsTxt.Text == "" && numColTxt.Text != "" && numRowsTxt.Text != "")
            {
                for (int i = 1; i <= Convert.ToInt16(numColTxt.Text); i++)
                {
                    ColumnStyle newCol = new ColumnStyle(SizeType.Percent, 0.1f);
                    RoomMap.ColumnStyles.Add(newCol);

                }

                for (int i = 1; i <= Convert.ToInt16(numRowsTxt.Text); i++)
                {
                    RowStyle newRow = new RowStyle(SizeType.Percent, 0.1f);
                    RoomMap.RowStyles.Add(newRow);

                }
                RoomMap.ColumnCount = Convert.ToInt16(numColTxt.Text);
                RoomMap.RowCount = Convert.ToInt16(numRowsTxt.Text);

            }


            for (int i = 0; i < RoomMap.ColumnCount; i++)
            {
                for (int j = 0; j < RoomMap.RowCount; j++)
                {
                    int[] currentID = new int[] { i, j };
                    RoomCell cell = new RoomCell(currentID);
                    cell.id = currentID;
                    RoomMap.Controls.Add(cell.cont, i, j);


                }
            }


        }
        public class RoomCell : Form
        {
            public int[] id = new int[2];
            public string name;
            public Label lbl = new Label();
            public TextBox inputName = new TextBox();
            public Panel cont = new Panel();

            public RoomCell(int[] cellID)
            {
                this.id = cellID;
                this.lbl.Text = cellID[0].ToString() + "," + cellID[1].ToString();
                lbl.AutoSize = true;

                this.cont.Dock = DockStyle.Fill;
                this.cont.Controls.Add(this.lbl);
                this.cont.Controls.Add(this.inputName);

                this.cont.Click += delegate
                {
                    this.cont.Focus();
                };




                this.inputName.Visible = false;
                this.lbl.Click += delegate
                {
                    
                    this.inputName.Visible = true;
                    this.inputName.Focus();
                    this.lbl.Visible = false;

                };

                this.inputName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);

                

                this.inputName.LostFocus += delegate
                {
                    this.inputName.Visible = false;
                    this.lbl.Text = this.inputName.Text;
                    this.lbl.Visible = true;
                };


               
                
            }

            public void OnKeyDownHandler(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.Parent.Focus();
                }
            }

            private void InitializeComponent()
            {
                this.SuspendLayout();
                // 
                // RoomCell
                // 
                this.ClientSize = new System.Drawing.Size(1365, 640);
                this.Name = "RoomCell";
                this.ResumeLayout(false);

            }



        }
    }
}
