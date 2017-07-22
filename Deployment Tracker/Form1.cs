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
            Components.MainApp = this;
            addZoneMenuItem.Click += new System.EventHandler(this.OnAddZone);
        }
        
        private void OnAddZone(object sender, EventArgs e)
        {
            ZoneCreatorPopup ZonePopup = new ZoneCreatorPopup();
            ZonePopup.ShowDialog();
        }

        

        }


    public partial class ZoneCreatorPopup : Form
    {
        public Form1 MainApp = Components.MainApp;
        public AddRoomPopup PopupContent = new AddRoomPopup();
        public MaskedTextBox numRoomsTxt;
        public MaskedTextBox numRowsTxt;
        public MaskedTextBox numColTxt;
        public Button createMapBtn;
        public TableLayoutPanel RoomMap;

        public ZoneCreatorPopup()
        {
            this.Controls.Add(PopupContent);
            PopupContent.Dock = DockStyle.Fill;
            //map all original zone creation Controls to identical variable names since its now a template and doesnt exist until runtime.
            numRoomsTxt = (MaskedTextBox)PopupContent.Controls.Find("numRoomsTxt", true)[0];
            numRowsTxt = (MaskedTextBox)PopupContent.Controls.Find("numRowsTxt", true)[0];
            numColTxt = (MaskedTextBox)PopupContent.Controls.Find("numColTxt", true)[0];
            createMapBtn = (Button)PopupContent.Controls.Find("CreateMapBtn", true)[0];
            RoomMap = (TableLayoutPanel)MainApp.Controls.Find("RoomMap", true)[0];

            //add events for all clicks to hook up to the original handlers.
            numRoomsTxt.Click += new System.EventHandler(this.numRoomsTxt_Click);
            numRowsTxt.Click += new System.EventHandler(this.numRowsTxt_Click);
            numColTxt.Click += new System.EventHandler(this.numColTxt_Click);
            createMapBtn.Click += new System.EventHandler(this.createMapBtn_Click);


            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // oneCreatorPopup
            // 
            this.ClientSize = new System.Drawing.Size(250, 200);
            this.Name = "ZoneCreatorPopup";
            this.ResumeLayout(true);
           
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
            Debug.WriteLine("HERE");

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
        
    }

    public static class Components
    {
        public static Form1 MainApp;
        

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
                this.lbl.AutoSize = false;
                this.lbl.TextAlign = ContentAlignment.TopCenter;
                this.inputName.Dock = DockStyle.Top;
                
                this.inputName.TextAlign = HorizontalAlignment.Center;

                this.cont.Dock = DockStyle.Fill;
                this.cont.Controls.Add(this.lbl);
                this.cont.Controls.Add(this.inputName);
                this.inputName.Visible = false;

                this.lbl.Dock = DockStyle.Top;
                

                this.cont.Click += delegate
                {
                    this.cont.Focus();
                };

                this.lbl.Click += delegate
                {
                    
                    this.inputName.Visible = true;
                    this.inputName.Focus();
                    this.lbl.Visible = false;

                };                
                this.inputName.LostFocus += delegate
                {
                    this.inputName.Visible = false;
                    if(this.inputName.Text == "")
                    {
                        this.lbl.Text = "---";
                    }
                    else
                    {
                        this.lbl.Text = this.inputName.Text;

                    }
                    this.lbl.Visible = true;
                };
                this.inputName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);




            }

            public void OnKeyDownHandler(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TextBox sendr = (TextBox)sender;
                    sendr.Parent.Focus();
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

