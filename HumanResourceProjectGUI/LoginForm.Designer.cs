namespace HumanResourceProjectGUI
{
    partial class LoginForm
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
            panel1 = new Panel();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.default_img;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(132, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 110);
            panel1.TabIndex = 0;
            // 
            // usernameTB
            // 
            usernameTB.BackColor = Color.FromArgb(244, 244, 244);
            usernameTB.BorderStyle = BorderStyle.FixedSingle;
            usernameTB.Location = new Point(167, 142);
            usernameTB.Name = "usernameTB";
            usernameTB.PlaceholderText = "Enter username...";
            usernameTB.Size = new Size(161, 27);
            usernameTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            passwordTB.BackColor = Color.FromArgb(244, 244, 244);
            passwordTB.BorderStyle = BorderStyle.FixedSingle;
            passwordTB.Location = new Point(167, 175);
            passwordTB.Name = "passwordTB";
            passwordTB.PasswordChar = '*';
            passwordTB.PlaceholderText = "Enter password...";
            passwordTB.Size = new Size(161, 27);
            passwordTB.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(167, 208);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(161, 29);
            loginButton.TabIndex = 2;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 244);
            ClientSize = new Size(494, 259);
            Controls.Add(loginButton);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Login";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Button loginButton;
    }
}