namespace classbooking
{
    partial class Registrazione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrazione));
            this.esci = new System.Windows.Forms.Button();
            this.invia = new System.Windows.Forms.Button();
            this.insertCognome = new System.Windows.Forms.TextBox();
            this.insertEmail = new System.Windows.Forms.TextBox();
            this.insertPassword = new System.Windows.Forms.TextBox();
            this.insertNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // esci
            // 
            this.esci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.esci.BackColor = System.Drawing.Color.Snow;
            this.esci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esci.Location = new System.Drawing.Point(335, 219);
            this.esci.Name = "esci";
            this.esci.Size = new System.Drawing.Size(115, 42);
            this.esci.TabIndex = 6;
            this.esci.Text = "EXIT";
            this.esci.UseVisualStyleBackColor = false;
            this.esci.Click += new System.EventHandler(this.esci_Click);
            // 
            // invia
            // 
            this.invia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invia.BackColor = System.Drawing.Color.Snow;
            this.invia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invia.Location = new System.Drawing.Point(196, 219);
            this.invia.Name = "invia";
            this.invia.Size = new System.Drawing.Size(115, 42);
            this.invia.TabIndex = 5;
            this.invia.Text = "REGISTRATI";
            this.invia.UseVisualStyleBackColor = false;
            this.invia.Click += new System.EventHandler(this.invia_Click);
            // 
            // insertCognome
            // 
            this.insertCognome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertCognome.Location = new System.Drawing.Point(196, 98);
            this.insertCognome.Name = "insertCognome";
            this.insertCognome.Size = new System.Drawing.Size(254, 20);
            this.insertCognome.TabIndex = 2;
            // 
            // insertEmail
            // 
            this.insertEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertEmail.Location = new System.Drawing.Point(196, 129);
            this.insertEmail.Name = "insertEmail";
            this.insertEmail.Size = new System.Drawing.Size(254, 20);
            this.insertEmail.TabIndex = 3;
            // 
            // insertPassword
            // 
            this.insertPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertPassword.Location = new System.Drawing.Point(196, 165);
            this.insertPassword.Name = "insertPassword";
            this.insertPassword.Size = new System.Drawing.Size(254, 20);
            this.insertPassword.TabIndex = 4;
            this.insertPassword.TextChanged += new System.EventHandler(this.insertPassword_TextChanged);
            // 
            // insertNome
            // 
            this.insertNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertNome.Location = new System.Drawing.Point(196, 66);
            this.insertNome.Name = "insertNome";
            this.insertNome.Size = new System.Drawing.Size(254, 20);
            this.insertNome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(81, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(81, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-mail :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(81, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cognome :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(81, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registrazione";
            // 
            // Registrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 327);
            this.Controls.Add(this.esci);
            this.Controls.Add(this.invia);
            this.Controls.Add(this.insertCognome);
            this.Controls.Add(this.insertEmail);
            this.Controls.Add(this.insertPassword);
            this.Controls.Add(this.insertNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registrazione";
            this.Text = "Registrazione";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Registrazione_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button esci;
        private System.Windows.Forms.Button invia;
        private System.Windows.Forms.TextBox insertCognome;
        private System.Windows.Forms.TextBox insertEmail;
        private System.Windows.Forms.TextBox insertPassword;
        private System.Windows.Forms.TextBox insertNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}