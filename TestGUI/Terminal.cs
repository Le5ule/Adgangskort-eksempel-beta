using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGUI
{
    public partial class Terminal : Form
    {
        Input autentisering = new Input();
        Sentral sentralUI = new Sentral();

        public Terminal()
        {
            InitializeComponent();
        }
        public void access(int inn)
        {
            autentisering.Kode().Add(inn);

            if (autentisering.Kode().Count == 4)
            {
                autentisering.Godkjenning(autentisering.Kombo());
                TB_KomboTerm.Text = autentisering.Kombo();
                //this.Hide();
                sentralUI.Show();
                autentisering.Kode().Clear();
            }
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            access(1);
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            access(2);
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            access(3);
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            access(4);
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            access(5);
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            access(6);
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            access(7);
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            access(8);
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            access(9);
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            access(0);
        }
    }
}
