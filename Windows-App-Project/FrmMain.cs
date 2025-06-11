using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_App_Project {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            this.notifyIcon1.ShowBalloonTip(15);

            this.ShowLoginForm();
        }

        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e) {
            if (menuExpand) {
                sidebarMenu.Width -= 10;
                if (sidebarMenu.Width <= 0) {
                    menuExpand = false;
                    menuTransition.Stop();
                }
            } else {
                sidebarMenu.Width += 10;
                if (sidebarMenu.Width >= 245) {
                    menuExpand = true;
                    menuTransition.Stop();
                }
            }
        }

        private void pcbMenu_Click(object sender, EventArgs e) {
            menuTransition.Start();
        }

        private void ShowLoginForm() {
            try {
                FrmLogin loginForm = new FrmLogin();
                loginForm.ShowDialog();

                loginForm.Dispose();
            } catch (Exception ex) {
                throw ex;
            }
        }

    }
}
