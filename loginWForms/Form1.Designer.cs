namespace loginWForms
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.maskedTextBoxUsuario = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.buttonClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelLogin.Location = new System.Drawing.Point(168, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(146, 65);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUser.Location = new System.Drawing.Point(20, 100);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(81, 25);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Usuário:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSenha.Location = new System.Drawing.Point(20, 132);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(68, 25);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha:";
            // 
            // maskedTextBoxUsuario
            // 
            this.maskedTextBoxUsuario.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxUsuario.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBoxUsuario.Location = new System.Drawing.Point(123, 105);
            this.maskedTextBoxUsuario.MaximumSize = new System.Drawing.Size(362, 23);
            this.maskedTextBoxUsuario.MinimumSize = new System.Drawing.Size(362, 23);
            this.maskedTextBoxUsuario.Name = "maskedTextBoxUsuario";
            this.maskedTextBoxUsuario.Size = new System.Drawing.Size(362, 23);
            this.maskedTextBoxUsuario.TabIndex = 3;
            // 
            // maskedTextBoxSenha
            // 
            this.maskedTextBoxSenha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxSenha.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBoxSenha.Location = new System.Drawing.Point(123, 134);
            this.maskedTextBoxSenha.MaximumSize = new System.Drawing.Size(362, 23);
            this.maskedTextBoxSenha.MinimumSize = new System.Drawing.Size(362, 23);
            this.maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            this.maskedTextBoxSenha.PasswordChar = '*';
            this.maskedTextBoxSenha.Size = new System.Drawing.Size(362, 23);
            this.maskedTextBoxSenha.TabIndex = 4;
            // 
            // buttonClick
            // 
            this.buttonClick.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClick.ForeColor = System.Drawing.Color.Black;
            this.buttonClick.Location = new System.Drawing.Point(168, 163);
            this.buttonClick.MaximumSize = new System.Drawing.Size(269, 51);
            this.buttonClick.MinimumSize = new System.Drawing.Size(269, 51);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(269, 51);
            this.buttonClick.TabIndex = 5;
            this.buttonClick.Text = "Login";
            this.buttonClick.UseVisualStyleBackColor = false;
            this.buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(518, 256);
            this.Controls.Add(this.buttonClick);
            this.Controls.Add(this.maskedTextBoxSenha);
            this.Controls.Add(this.maskedTextBoxUsuario);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelLogin);
            this.MinimumSize = new System.Drawing.Size(534, 295);
            this.Name = "Form1";
            this.Text = "a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLogin;
        private Label labelUser;
        private Label labelSenha;
        private MaskedTextBox maskedTextBoxUsuario;
        private MaskedTextBox maskedTextBoxSenha;
        private Button buttonClick;
    }
}