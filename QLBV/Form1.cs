using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelBenhnhanSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelBenhnhanSubmenu.Visible == true)
                panelBenhnhanSubmenu.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlLeftTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnNurse_Click(object sender, EventArgs e)
        {

        }

        private void btnPatient_Click_1(object sender, EventArgs e)
        {
        }

        private void btnBenhnhan_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBenhnhanSubmenu);
            pnlSide.Height = btnBenhnhan.Height;
            pnlSide.Top = btnBenhnhan.Top;
        }

        private void btnHethong_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnHethong.Height;
            pnlSide.Top = btnHethong.Top;
        }

        private void lblHethong_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnNhanvien.Height;
            pnlSide.Top = btnNhanvien.Top;
        }

        private void btnHethong_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnKoBHYT_Click(object sender, EventArgs e)
        {

        }
    }
}
