namespace KlasseKasse
{
    partial class Register
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
            this.btn_Tilbage = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Navn = new System.Windows.Forms.TextBox();
            this.textBox_Kode = new System.Windows.Forms.TextBox();
            this.textBox_GentagKode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Tilbage
            // 
            this.btn_Tilbage.Location = new System.Drawing.Point(12, 146);
            this.btn_Tilbage.Name = "btn_Tilbage";
            this.btn_Tilbage.Size = new System.Drawing.Size(90, 50);
            this.btn_Tilbage.TabIndex = 0;
            this.btn_Tilbage.Text = "Tilbage";
            this.btn_Tilbage.UseVisualStyleBackColor = true;
            this.btn_Tilbage.Click += new System.EventHandler(this.btn_Tilbage_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(182, 146);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(90, 50);
            this.btn_Register.TabIndex = 1;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Navn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gentag kode";
            // 
            // textBox_Navn
            // 
            this.textBox_Navn.Location = new System.Drawing.Point(53, 26);
            this.textBox_Navn.Name = "textBox_Navn";
            this.textBox_Navn.Size = new System.Drawing.Size(100, 20);
            this.textBox_Navn.TabIndex = 5;
            // 
            // textBox_Kode
            // 
            this.textBox_Kode.Location = new System.Drawing.Point(53, 59);
            this.textBox_Kode.Name = "textBox_Kode";
            this.textBox_Kode.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kode.TabIndex = 6;
            this.textBox_Kode.UseSystemPasswordChar = true;
            // 
            // textBox_GentagKode
            // 
            this.textBox_GentagKode.Location = new System.Drawing.Point(88, 93);
            this.textBox_GentagKode.Name = "textBox_GentagKode";
            this.textBox_GentagKode.Size = new System.Drawing.Size(100, 20);
            this.textBox_GentagKode.TabIndex = 7;
            this.textBox_GentagKode.UseSystemPasswordChar = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.textBox_GentagKode);
            this.Controls.Add(this.textBox_Kode);
            this.Controls.Add(this.textBox_Navn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Tilbage);
            this.Name = "Register";
            this.Text = "Klassen Kassen - Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Tilbage;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Navn;
        private System.Windows.Forms.TextBox textBox_Kode;
        private System.Windows.Forms.TextBox textBox_GentagKode;
    }
}