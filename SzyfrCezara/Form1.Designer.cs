namespace SzyfrCezara
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtWejscie = new TextBox();
            label2 = new Label();
            txtKlucz = new TextBox();
            btnZaszyfruj = new Button();
            btnOdszyfruj = new Button();
            label3 = new Label();
            txtWynik = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(217, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 0;
            label1.Text = "Wpisz tekst";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtWejscie
            // 
            txtWejscie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtWejscie.Location = new Point(12, 42);
            txtWejscie.Name = "txtWejscie";
            txtWejscie.Size = new Size(517, 23);
            txtWejscie.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(160, 84);
            label2.Name = "label2";
            label2.Size = new Size(211, 21);
            label2.TabIndex = 2;
            label2.Text = "Wpisz klucz szyfrujacy (1-32)";
            // 
            // txtKlucz
            // 
            txtKlucz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtKlucz.Location = new Point(160, 123);
            txtKlucz.Name = "txtKlucz";
            txtKlucz.Size = new Size(211, 23);
            txtKlucz.TabIndex = 3;
            // 
            // btnZaszyfruj
            // 
            btnZaszyfruj.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnZaszyfruj.Location = new Point(12, 171);
            btnZaszyfruj.Name = "btnZaszyfruj";
            btnZaszyfruj.Size = new Size(235, 23);
            btnZaszyfruj.TabIndex = 4;
            btnZaszyfruj.Text = "Zaszyfruj";
            btnZaszyfruj.UseVisualStyleBackColor = true;
            btnZaszyfruj.Click += btnZaszyfruj_Click;
            // 
            // btnOdszyfruj
            // 
            btnOdszyfruj.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOdszyfruj.Location = new Point(296, 171);
            btnOdszyfruj.Name = "btnOdszyfruj";
            btnOdszyfruj.Size = new Size(233, 23);
            btnOdszyfruj.TabIndex = 5;
            btnOdszyfruj.Text = "Odszyfruj";
            btnOdszyfruj.UseVisualStyleBackColor = true;
            btnOdszyfruj.Click += btnOdszyfruj_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(175, 229);
            label3.Name = "label3";
            label3.Size = new Size(177, 21);
            label3.TabIndex = 6;
            label3.Text = "Ponizej pojawi sie wynik";
            // 
            // txtWynik
            // 
            txtWynik.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtWynik.Location = new Point(12, 274);
            txtWynik.Name = "txtWynik";
            txtWynik.ReadOnly = true;
            txtWynik.Size = new Size(517, 23);
            txtWynik.TabIndex = 7;
            txtWynik.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(541, 345);
            Controls.Add(txtWynik);
            Controls.Add(label3);
            Controls.Add(btnOdszyfruj);
            Controls.Add(btnZaszyfruj);
            Controls.Add(txtKlucz);
            Controls.Add(label2);
            Controls.Add(txtWejscie);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Szyfr Cezara";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWejscie;
        private Label label2;
        private TextBox txtKlucz;
        private Button btnZaszyfruj;
        private Button btnOdszyfruj;
        private Label label3;
        private TextBox txtWynik;
    }
}
