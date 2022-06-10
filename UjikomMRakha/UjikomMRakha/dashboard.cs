using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UjikomMRakha
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            customizeDesing();

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,10),      //First Point of First Line
                        new ObservablePoint(4,7),       //2nd POint
                        new ObservablePoint(5,3),     //------
                        new ObservablePoint(7,6),
                        new ObservablePoint(10,8)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,2),      //First Point of 2nd Line
                        new ObservablePoint(2,5),       //2nd POint
                        new ObservablePoint(3,6),     //------
                        new ObservablePoint(6,8),
                        new ObservablePoint(10,5)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,4),      //First Point of 3rd Line
                        new ObservablePoint(5,5),       //2nd POint
                        new ObservablePoint(7,7),     //------
                        new ObservablePoint(9,10),
                        new ObservablePoint(10,9)
                    },
                    PointGeometrySize = 15
                }
            };
        }

        private void customizeDesing()
        {
            panelMasterSubmenu.Visible = false;
            panelFileSubmenu.Visible = false;
            panelLaporanSubmenu.Visible = false;
            panelTransaksiSubmenu.Visible = false;
            panelUtilitySubmenu.Visible = false;
            //..
        }
        private void hideSubMenu()
        {
            if (panelFileSubmenu.Visible==true)
                panelFileSubmenu.Visible = false;

            if (panelMasterSubmenu.Visible == true)
                panelMasterSubmenu.Visible = false;

            if (panelTransaksiSubmenu.Visible == true)
                panelTransaksiSubmenu.Visible = false;

            if (panelLaporanSubmenu.Visible == true)
                panelLaporanSubmenu.Visible = false;

            if (panelUtilitySubmenu.Visible == true)
                panelUtilitySubmenu.Visible = false;
            
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
            
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFileSubmenu);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //...

            hideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //...

            hideSubMenu();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            //...

            hideSubMenu();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMasterSubmenu);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            //...

            hideSubMenu();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //...

            hideSubMenu();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTransaksiSubmenu);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //...

            hideSubMenu();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLaporanSubmenu);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //...

            hideSubMenu();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //...

            hideSubMenu();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            //...

            hideSubMenu();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUtilitySubmenu);
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            //...

            hideSubMenu();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            //...

            hideSubMenu();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
