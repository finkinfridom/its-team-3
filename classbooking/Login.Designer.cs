namespace classbooking
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this._registrazione = new System.Windows.Forms.Button();
            this._exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._login = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.insertEmail = new System.Windows.Forms.TextBox();
            this.insertPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _registrazione
            // 
            this._registrazione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._registrazione.BackColor = System.Drawing.Color.Transparent;
            this._registrazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._registrazione.Location = new System.Drawing.Point(112, 253);
            this._registrazione.Name = "_registrazione";
            this._registrazione.Size = new System.Drawing.Size(100, 55);
            this._registrazione.TabIndex = 3;
            this._registrazione.Text = "REGISTRATI";
            this._registrazione.UseVisualStyleBackColor = false;
            this._registrazione.Click += new System.EventHandler(this._registrazione_Click);
            // 
            // _exit
            // 
            this._exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._exit.BackColor = System.Drawing.Color.Snow;
            this._exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exit.Location = new System.Drawing.Point(374, 253);
            this._exit.Name = "_exit";
            this._exit.Size = new System.Drawing.Size(100, 55);
            this._exit.TabIndex = 5;
            this._exit.Text = "EXIT";
            this._exit.UseVisualStyleBackColor = false;
            this._exit.Click += new System.EventHandler(this._exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(287, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Login";
            // 
            // _login
            // 
            this._login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._login.BackColor = System.Drawing.Color.Snow;
            this._login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._login.Location = new System.Drawing.Point(232, 253);
            this._login.Name = "_login";
            this._login.Size = new System.Drawing.Size(120, 55);
            this._login.TabIndex = 4;
            this._login.Text = "LOGIN";
            this._login.UseVisualStyleBackColor = false;
            this._login.Click += new System.EventHandler(this._login_Click);
            // 
            // Pass
            // 
            this.Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pass.AutoSize = true;
            this.Pass.BackColor = System.Drawing.Color.Transparent;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.Snow;
            this.Pass.Location = new System.Drawing.Point(108, 169);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(91, 20);
            this.Pass.TabIndex = 17;
            this.Pass.Text = "Password:";
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Snow;
            this.Email.Location = new System.Drawing.Point(108, 132);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(69, 20);
            this.Email.TabIndex = 16;
            this.Email.Text = "E-mail :";
            // 
            // insertEmail
            // 
            this.insertEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertEmail.Location = new System.Drawing.Point(232, 134);
            this.insertEmail.Name = "insertEmail";
            this.insertEmail.Size = new System.Drawing.Size(230, 20);
            this.insertEmail.TabIndex = 1;
            // 
            // insertPass
            // 
            this.insertPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertPass.Location = new System.Drawing.Point(232, 171);
            this.insertPass.Name = "insertPass";
            this.insertPass.Size = new System.Drawing.Size(230, 20);
            this.insertPass.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 355);
            this.Controls.Add(this.insertPass);
            this.Controls.Add(this.insertEmail);
            this.Controls.Add(this._registrazione);
            this.Controls.Add(this._exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._login);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _registrazione;
        private System.Windows.Forms.Button _exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _login;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox insertEmail;
        private System.Windows.Forms.TextBox insertPass;
    }
}

