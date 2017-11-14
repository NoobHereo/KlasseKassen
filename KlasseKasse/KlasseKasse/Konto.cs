using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasseKasse
{
    public partial class Konto : Form
    {

        public Konto()
        {
            InitializeComponent();
        }

        private void btn_TilføjRække_Click(object sender, EventArgs e)
        {
            grpBox_NyRække.Visible = true;
        }

        private void btn_Tilbage_Click(object sender, EventArgs e)
        {
            grpBox_NyRække.Visible = false;
        }

        private void btn_Tilføj_Click(object sender, EventArgs e)
        {


            string beløbsType = comboBox_PosEllerNeg.Text;
            int beløb;
            var eksisterendeRække = new ListViewItem();

        

            #region Tjekker om brugeren har skrevet et navn og beløb, og valgt om beløbet skal være positvit eller negativt
            if (textBox_Titel.Text == "")
            {
                MessageBox.Show("Du skal skrive en gyldig titel til din række!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_Beløb.Text == "" || comboBox_PosEllerNeg.Text == "")
            {
                MessageBox.Show("Du skal skrive et gyldigt beløb til din række!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            else
            {
                
                beløb = int.Parse(textBox_Beløb.Text);




                #region Tjekker om beløbet der skal ligges til saldoen, skal trække fra eller ligge til.                  

                switch (beløbsType)
                {
                    case "+":
                  
                        break;

                    case "-":

                        break;
                }
                        
               

                #endregion

                string[] række =
                    {
                    textBox_Titel.Text,
                    textBox_Beskrivelse.Text,
                    textBox_Beløb.Text,
                    "user",
                    DateTime.Now.ToString(),
                    label_Saldo.Text
                    };

                var rækkeVisIndhold = new ListViewItem(række);
                listView.Items.Add(rækkeVisIndhold);
            }
        }
        private void CalculateSaldo()
        {
            decimal saldo = 0;
            foreach (ListViewItem item in listView.Items)
            {
                item.UseItemStyleForSubItems = false;
                saldo += decimal.Parse(item.SubItems[2].Text);
                item.Text = saldo.ToString();
            }
        }
    }
}
