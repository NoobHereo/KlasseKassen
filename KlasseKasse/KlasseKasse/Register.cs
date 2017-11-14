using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KlasseKasse.Database;

namespace KlasseKasse
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Tilbage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string navnInput = textBox_Navn.Text;
            string kodeInput = textBox_Kode.Text;
            string gentagKodeInput = textBox_GentagKode.Text;
            Database.Database db = new Database.Database();

            if (navnInput == "")
            {
                MessageBox.Show("Ugyldigt konto navn!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (kodeInput == "")
            {
                MessageBox.Show("Ugyldigt kodeord!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (kodeInput != gentagKodeInput)
            {
                MessageBox.Show("Dine kodeord, matcher ikke!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                db.RegisterKonto(navn: navnInput, kodeord: kodeInput);
            }
        }
    }
}
