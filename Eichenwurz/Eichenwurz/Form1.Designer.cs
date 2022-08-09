namespace Eichenwurz
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
            this.SzenarienText = new System.Windows.Forms.TextBox();
            this.textBoxSzenario = new System.Windows.Forms.TextBox();
            this.CmdWeiter = new System.Windows.Forms.Button();
            this.Auswahl1 = new System.Windows.Forms.RadioButton();
            this.Auswahl2 = new System.Windows.Forms.RadioButton();
            this.Auswahl3 = new System.Windows.Forms.RadioButton();
            this.CmdEntscheidung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SzenarienText
            // 
            this.SzenarienText.Location = new System.Drawing.Point(26, 29);
            this.SzenarienText.Multiline = true;
            this.SzenarienText.Name = "SzenarienText";
            this.SzenarienText.Size = new System.Drawing.Size(750, 300);
            this.SzenarienText.TabIndex = 0;
            this.SzenarienText.Text = "Geschichte";
            // 
            // textBoxSzenario
            // 
            this.textBoxSzenario.Location = new System.Drawing.Point(40, 40);
            this.textBoxSzenario.Multiline = true;
            this.textBoxSzenario.Name = "textBoxSzenario";
            this.textBoxSzenario.ReadOnly = true;
            this.textBoxSzenario.Size = new System.Drawing.Size(750, 300);
            this.textBoxSzenario.TabIndex = 0;
            this.textBoxSzenario.Text = "Geschichte";
            this.textBoxSzenario.TextChanged += new System.EventHandler(this.textBoxSzenario_TextChanged);
            // 
            // CmdWeiter
            // 
            this.CmdWeiter.Location = new System.Drawing.Point(714, 393);
            this.CmdWeiter.Name = "CmdWeiter";
            this.CmdWeiter.Size = new System.Drawing.Size(75, 23);
            this.CmdWeiter.TabIndex = 1;
            this.CmdWeiter.Text = "Weiter";
            this.CmdWeiter.UseVisualStyleBackColor = true;
            this.CmdWeiter.Click += new System.EventHandler(this.CmdWeiter_Click);
            // 
            // Auswahl1
            // 
            this.Auswahl1.AutoSize = true;
            this.Auswahl1.Location = new System.Drawing.Point(152, 372);
            this.Auswahl1.Name = "Auswahl1";
            this.Auswahl1.Size = new System.Drawing.Size(76, 19);
            this.Auswahl1.TabIndex = 2;
            this.Auswahl1.TabStop = true;
            this.Auswahl1.Text = "Auswahl1";
            this.Auswahl1.UseVisualStyleBackColor = true;
            // 
            // Auswahl2
            // 
            this.Auswahl2.AutoSize = true;
            this.Auswahl2.Location = new System.Drawing.Point(328, 376);
            this.Auswahl2.Name = "Auswahl2";
            this.Auswahl2.Size = new System.Drawing.Size(76, 19);
            this.Auswahl2.TabIndex = 3;
            this.Auswahl2.TabStop = true;
            this.Auswahl2.Text = "Auswahl2";
            this.Auswahl2.UseVisualStyleBackColor = true;
            // 
            // Auswahl3
            // 
            this.Auswahl3.AutoSize = true;
            this.Auswahl3.Location = new System.Drawing.Point(492, 377);
            this.Auswahl3.Name = "Auswahl3";
            this.Auswahl3.Size = new System.Drawing.Size(76, 19);
            this.Auswahl3.TabIndex = 4;
            this.Auswahl3.TabStop = true;
            this.Auswahl3.Text = "Auswahl3";
            this.Auswahl3.UseVisualStyleBackColor = true;
            // 
            // CmdEntscheidung
            // 
            this.CmdEntscheidung.Location = new System.Drawing.Point(670, 437);
            this.CmdEntscheidung.Name = "CmdEntscheidung";
            this.CmdEntscheidung.Size = new System.Drawing.Size(150, 23);
            this.CmdEntscheidung.TabIndex = 5;
            this.CmdEntscheidung.Text = "Entscheidung wählen";
            this.CmdEntscheidung.UseVisualStyleBackColor = true;
            this.CmdEntscheidung.Click += new System.EventHandler(this.CmdEntscheidung_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(832, 472);
            this.Controls.Add(this.CmdEntscheidung);
            this.Controls.Add(this.Auswahl3);
            this.Controls.Add(this.Auswahl2);
            this.Controls.Add(this.Auswahl1);
            this.Controls.Add(this.CmdWeiter);
            this.Controls.Add(this.textBoxSzenario);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SzenarienText;
        private TextBox textBoxSzenario;
        private Button CmdWeiter;
        private RadioButton Auswahl1;
        private RadioButton Auswahl2;
        private RadioButton Auswahl3;
        private Button CmdEntscheidung;
    }
}