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
            if (numRoomsTxt.Text != "")
            {
                int RoomCount = Convert.ToInt16(numRoomsTxt.Text);
                int ColumnCt = 1;
                int RowCt = RoomCount;

                while (ColumnCt < RowCt)
                {
                    for (int i = 2;i<=9;i++)
                    {
                        if (RoomCount % i == 0)
                        {
                            RoomCount /= i;
                            ColumnCt *= i;
                            RowCt = RoomCount;
                            break;
                        }
                    }
                    
                }

                for(int i = 1; i <= ColumnCt; i++)
                {
                    ColumnStyle newCol = new ColumnStyle(SizeType.Percent, 10f);
                    RoomMap.ColumnStyles.Add(newCol);
                }
                for (int i = 1; i <= RowCt; i++)
                {
                    RowStyle newRow = new RowStyle(SizeType.Percent, 10f);
                    RoomMap.RowStyles.Add(newRow);

                }
                
            }
            if(numRoomsTxt.Text == "" && numColTxt.Text != "" && numRowsTxt.Text != "")
            {
                for (int i = 1; i <= Convert.ToInt16(numColTxt.Text); i++)
                {
                    ColumnStyle newCol = new ColumnStyle(SizeType.Percent, 10f);
                    RoomMap.ColumnStyles.Add(newCol);
                }
                for (int i = 1; i <= Convert.ToInt16(numRowsTxt.Text); i++)
                {
                    RowStyle newRow = new RowStyle(SizeType.Percent,10f);
                    RoomMap.RowStyles.Add(newRow);
                    
                }

            }
        }

    }
}
