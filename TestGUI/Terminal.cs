using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestGUI
{
    public partial class Terminal : Form
    {
        Input autentisering = new Input();
        Sentral sentralUI = new Sentral();

        static string ehm = "";

        public Terminal()
        {
            InitializeComponent();
        }
        private void Terminal_Load(object sender, EventArgs e)
        {
            if (TB_KortInput.Text.Length == 4 && Int32.TryParse(TB_KortInput.Text, out Input.pin))
            {
                Input.pin = Convert.ToInt32(TB_KortInput.Text);
                TB_KortInput.Visible = false;
                UgyldigLabel.Visible = false;
                TB_KortInput.Clear();
            }
            else
            {
                UgyldigLabel.Visible = true;
                //TB_KortInput.Clear();
            }
        }
        public void access(int inn)
        {
            autentisering.Kode().Add(inn);

            if (autentisering.Kode().Count == 4)
            {
                autentisering.godkjenning(autentisering.Kombo());
                TB_KomboTerm.Text = autentisering.Kombo();
                //this.Hide();
                sentralUI.ShowDialog();
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

        private void BTN_Kort_Click(object sender, EventArgs e)
        {
            TB_KortInput.Visible = true;
            TB_KortInput.Select();
        }


    }
}
