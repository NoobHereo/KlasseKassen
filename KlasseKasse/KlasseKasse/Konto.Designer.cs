namespace KlasseKasse
{
    partial class Konto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBox_NyRække = new System.Windows.Forms.GroupBox();
            this.btn_TilføjRække = new System.Windows.Forms.Button();
            this.btn_Tilføj = new System.Windows.Forms.Button();
            this.btn_Tilbage = new System.Windows.Forms.Button();
            this.btn_Tilbage2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Titel = new System.Windows.Forms.TextBox();
            this.textBox_Beskrivelse = new System.Windows.Forms.TextBox();
            this.textBox_Beløb = new System.Windows.Forms.TextBox();
            this.btn_Færdig = new System.Windows.Forms.Button();
            this.comboBox_PosEllerNeg = new System.Windows.Forms.ComboBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnTitel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBeskrivelse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBeløb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBruger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label_Saldo = new System.Windows.Forms.Label();
            this.grpBox_NyRække.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_NyRække
            // 
            this.grpBox_NyRække.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpBox_NyRække.Controls.Add(this.label_Saldo);
            this.grpBox_NyRække.Controls.Add(this.label4);
            this.grpBox_NyRække.Controls.Add(this.comboBox_PosEllerNeg);
            this.grpBox_NyRække.Controls.Add(this.textBox_Beløb);
            this.grpBox_NyRække.Controls.Add(this.textBox_Beskrivelse);
            this.grpBox_NyRække.Controls.Add(this.textBox_Titel);
            this.grpBox_NyRække.Controls.Add(this.label3);
            this.grpBox_NyRække.Controls.Add(this.label2);
            this.grpBox_NyRække.Controls.Add(this.label1);
            this.grpBox_NyRække.Controls.Add(this.btn_Tilbage);
            this.grpBox_NyRække.Controls.Add(this.btn_Tilføj);
            this.grpBox_NyRække.Location = new System.Drawing.Point(275, 241);
            this.grpBox_NyRække.Name = "grpBox_NyRække";
            this.grpBox_NyRække.Size = new System.Drawing.Size(279, 184);
            this.grpBox_NyRække.TabIndex = 1;
            this.grpBox_NyRække.TabStop = false;
            this.grpBox_NyRække.Text = "Ny Række";
            this.grpBox_NyRække.Visible = false;
            // 
            // btn_TilføjRække
            // 
            this.btn_TilføjRække.Location = new System.Drawing.Point(13, 252);
            this.btn_TilføjRække.Name = "btn_TilføjRække";
            this.btn_TilføjRække.Size = new System.Drawing.Size(95, 50);
            this.btn_TilføjRække.TabIndex = 2;
            this.btn_TilføjRække.Text = "Tilføj Række";
            this.btn_TilføjRække.UseVisualStyleBackColor = true;
            this.btn_TilføjRække.Click += new System.EventHandler(this.btn_TilføjRække_Click);
            // 
            // btn_Tilføj
            // 
            this.btn_Tilføj.Location = new System.Drawing.Point(191, 140);
            this.btn_Tilføj.Name = "btn_Tilføj";
            this.btn_Tilføj.Size = new System.Drawing.Size(82, 25);
            this.btn_Tilføj.TabIndex = 0;
            this.btn_Tilføj.Text = "Tilføj";
            this.btn_Tilføj.UseVisualStyleBackColor = true;
            this.btn_Tilføj.Click += new System.EventHandler(this.btn_Tilføj_Click);
            // 
            // btn_Tilbage
            // 
            this.btn_Tilbage.Location = new System.Drawing.Point(6, 140);
            this.btn_Tilbage.Name = "btn_Tilbage";
            this.btn_Tilbage.Size = new System.Drawing.Size(82, 25);
            this.btn_Tilbage.TabIndex = 1;
            this.btn_Tilbage.Text = "Tilbage";
            this.btn_Tilbage.UseVisualStyleBackColor = true;
            this.btn_Tilbage.Click += new System.EventHandler(this.btn_Tilbage_Click);
            // 
            // btn_Tilbage2
            // 
            this.btn_Tilbage2.Location = new System.Drawing.Point(13, 597);
            this.btn_Tilbage2.Name = "btn_Tilbage2";
            this.btn_Tilbage2.Size = new System.Drawing.Size(95, 44);
            this.btn_Tilbage2.TabIndex = 3;
            this.btn_Tilbage2.Text = "Tilbage";
            this.btn_Tilbage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beksrivelse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Beløb";
            // 
            // textBox_Titel
            // 
            this.textBox_Titel.Location = new System.Drawing.Point(49, 20);
            this.textBox_Titel.Name = "textBox_Titel";
            this.textBox_Titel.Size = new System.Drawing.Size(100, 20);
            this.textBox_Titel.TabIndex = 5;
            // 
            // textBox_Beskrivelse
            // 
            this.textBox_Beskrivelse.Location = new System.Drawing.Point(77, 55);
            this.textBox_Beskrivelse.Name = "textBox_Beskrivelse";
            this.textBox_Beskrivelse.Size = new System.Drawing.Size(100, 20);
            this.textBox_Beskrivelse.TabIndex = 6;
            // 
            // textBox_Beløb
            // 
            this.textBox_Beløb.Location = new System.Drawing.Point(49, 83);
            this.textBox_Beløb.Name = "textBox_Beløb";
            this.textBox_Beløb.Size = new System.Drawing.Size(100, 20);
            this.textBox_Beløb.TabIndex = 7;
            // 
            // btn_Færdig
            // 
            this.btn_Færdig.Location = new System.Drawing.Point(457, 597);
            this.btn_Færdig.Name = "btn_Færdig";
            this.btn_Færdig.Size = new System.Drawing.Size(103, 44);
            this.btn_Færdig.TabIndex = 4;
            this.btn_Færdig.Text = "Færdig";
            this.btn_Færdig.UseVisualStyleBackColor = true;
            // 
            // comboBox_PosEllerNeg
            // 
            this.comboBox_PosEllerNeg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PosEllerNeg.FormattingEnabled = true;
            this.comboBox_PosEllerNeg.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBox_PosEllerNeg.Location = new System.Drawing.Point(152, 83);
            this.comboBox_PosEllerNeg.Name = "comboBox_PosEllerNeg";
            this.comboBox_PosEllerNeg.Size = new System.Drawing.Size(64, 21);
            this.comboBox_PosEllerNeg.TabIndex = 8;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitel,
            this.columnBeskrivelse,
            this.columnBeløb,
            this.columnBruger,
            this.columnDato,
            this.columnSaldo});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(13, 13);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(541, 222);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnTitel
            // 
            this.columnTitel.Text = "Titel";
            // 
            // columnBeskrivelse
            // 
            this.columnBeskrivelse.Text = "Beskrivelse";
            this.columnBeskrivelse.Width = 180;
            // 
            // columnBeløb
            // 
            this.columnBeløb.Text = "Beløb";
            // 
            // columnBruger
            // 
            this.columnBruger.Text = "Bruger";
            // 
            // columnDato
            // 
            this.columnDato.Text = "Dato";
            this.columnDato.Width = 120;
            // 
            // columnSaldo
            // 
            this.columnSaldo.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saldo:";
            // 
            // label_Saldo
            // 
            this.label_Saldo.AutoSize = true;
            this.label_Saldo.Location = new System.Drawing.Point(49, 121);
            this.label_Saldo.Name = "label_Saldo";
            this.label_Saldo.Size = new System.Drawing.Size(0, 13);
            this.label_Saldo.TabIndex = 10;
            // 
            // Konto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 653);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btn_Færdig);
            this.Controls.Add(this.btn_Tilbage2);
            this.Controls.Add(this.btn_TilføjRække);
            this.Controls.Add(this.grpBox_NyRække);
            this.Name = "Konto";
            this.Text = "Klasse Kassen - Konto";
            this.grpBox_NyRække.ResumeLayout(false);
            this.grpBox_NyRække.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBox_NyRække;
        private System.Windows.Forms.Button btn_Tilbage;
        private System.Windows.Forms.Button btn_Tilføj;
        private System.Windows.Forms.Button btn_TilføjRække;
        private System.Windows.Forms.Button btn_Tilbage2;
        private System.Windows.Forms.TextBox textBox_Beløb;
        private System.Windows.Forms.TextBox textBox_Beskrivelse;
        private System.Windows.Forms.TextBox textBox_Titel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Færdig;
        private System.Windows.Forms.ComboBox comboBox_PosEllerNeg;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnTitel;
        private System.Windows.Forms.ColumnHeader columnBeskrivelse;
        private System.Windows.Forms.ColumnHeader columnBeløb;
        private System.Windows.Forms.ColumnHeader columnBruger;
        private System.Windows.Forms.ColumnHeader columnDato;
        private System.Windows.Forms.ColumnHeader columnSaldo;
        private System.Windows.Forms.Label label_Saldo;
        private System.Windows.Forms.Label label4;
    }
}