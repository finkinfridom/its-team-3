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
            this.esci.BackColor = System.Drawing.Color.Red;
            this.esci.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esci.Location = new System.Drawing.Point(274, 219);
            this.esci.Name = "esci";
            this.esci.Size = new System.Drawing.Size(115, 42);
            this.esci.TabIndex = 22;
            this.esci.Text = "EXIT";
            this.esci.UseVisualStyleBackColor = false;
            this.esci.Click += new System.EventHandler(this.esci_Click);
            // 
            // invia
            // 
            this.invia.BackColor = System.Drawing.Color.Yellow;
            this.invia.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invia.Location = new System.Drawing.Point(153, 219);
            this.invia.Name = "invia";
            this.invia.Size = new System.Drawing.Size(115, 42);
            this.invia.TabIndex = 21;
            this.invia.Text = "REGISTRA";
            this.invia.UseVisualStyleBackColor = false;
            this.invia.Click += new System.EventHandler(this.invia_Click);
            // 
            // insertCognome
            // 
            this.insertCognome.Location = new System.Drawing.Point(196, 98);
            this.insertCognome.Name = "insertCognome";
            this.insertCognome.Size = new System.Drawing.Size(254, 20);
            this.insertCognome.TabIndex = 20;
            // 
            // insertEmail
            // 
            this.insertEmail.Location = new System.Drawing.Point(196, 129);
            this.insertEmail.Name = "insertEmail";
            this.insertEmail.Size = new System.Drawing.Size(254, 20);
            this.insertEmail.TabIndex = 19;
            // 
            // insertPassword
            // 
            this.insertPassword.Location = new System.Drawing.Point(196, 165);
            this.insertPassword.Name = "insertPassword";
            this.insertPassword.Size = new System.Drawing.Size(254, 20);
            this.insertPassword.TabIndex = 18;
            // 
            // insertNome
            // 
            this.insertNome.Location = new System.Drawing.Point(196, 66);
            this.insertNome.Name = "insertNome";
            this.insertNome.Size = new System.Drawing.Size(254, 20);
            this.insertNome.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(81, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(81, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(81, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cognome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(81, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(191, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registrazione";
            // 
            // Registrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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