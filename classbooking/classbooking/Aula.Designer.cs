namespace classbooking
{
    partial class Aula
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Indietro = new System.Windows.Forms.Button();
            this.Avanti = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.CercaOrario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "9.00-10.00",
            "10.00-11.00",
            "11.00-12.00",
            "12.00-13.00",
            "14.00-15.00",
            "15.00-16.00",
            "16.00-17.00",
            "17.00-18.00"});
            this.checkedListBox1.Location = new System.Drawing.Point(25, 82);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(94, 124);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Indietro
            // 
            this.Indietro.Location = new System.Drawing.Point(115, 18);
            this.Indietro.Name = "Indietro";
            this.Indietro.Size = new System.Drawing.Size(75, 23);
            this.Indietro.TabIndex = 4;
            this.Indietro.Text = "Indietro";
            this.Indietro.UseVisualStyleBackColor = true;
            // 
            // Avanti
            // 
            this.Avanti.Location = new System.Drawing.Point(265, 18);
            this.Avanti.Name = "Avanti";
            this.Avanti.Size = new System.Drawing.Size(75, 23);
            this.Avanti.TabIndex = 5;
            this.Avanti.Text = "Avanti";
            this.Avanti.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(420, 17);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // CercaOrario
            // 
            this.CercaOrario.Location = new System.Drawing.Point(35, 227);
            this.CercaOrario.Name = "CercaOrario";
            this.CercaOrario.Size = new System.Drawing.Size(75, 23);
            this.CercaOrario.TabIndex = 7;
            this.CercaOrario.Text = "Cerca";
            this.CercaOrario.UseVisualStyleBackColor = true;
            this.CercaOrario.Click += new System.EventHandler(this.CercaOrario_Click);
            // 
            // Aula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.CercaOrario);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Avanti);
            this.Controls.Add(this.Indietro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Aula";
            this.Text = "Aula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Indietro;
        private System.Windows.Forms.Button Avanti;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button CercaOrario;
    }
}