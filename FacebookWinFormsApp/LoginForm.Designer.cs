namespace BasicFacebookFeatures
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelLoggedInUserNameValue = new System.Windows.Forms.Label();
            this.labelLoggedInUserNameTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.Location = new System.Drawing.Point(56, 97);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(426, 112);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Firebrick;
            this.labelError.Location = new System.Drawing.Point(51, 266);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(44, 20);
            this.labelError.TabIndex = 1;
            this.labelError.Text = "Error";
            this.labelError.Visible = false;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sessionBindingSource, "IsRememberMe", true));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(56, 217);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(140, 24);
            this.checkBoxRememberMe.TabIndex = 5;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataSource = typeof(BasicFacebookFeatures.sessions.Session);
            // 
            // labelLoggedInUserNameValue
            // 
            this.labelLoggedInUserNameValue.AutoSize = true;
            this.labelLoggedInUserNameValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sessionBindingSource, "LoggedInUserName", true));
            this.labelLoggedInUserNameValue.Location = new System.Drawing.Point(227, 72);
            this.labelLoggedInUserNameValue.Name = "labelLoggedInUserNameValue";
            this.labelLoggedInUserNameValue.Size = new System.Drawing.Size(84, 20);
            this.labelLoggedInUserNameValue.TabIndex = 7;
            this.labelLoggedInUserNameValue.Text = "user name";
            // 
            // labelLoggedInUserNameTitle
            // 
            this.labelLoggedInUserNameTitle.AutoSize = true;
            this.labelLoggedInUserNameTitle.Location = new System.Drawing.Point(55, 71);
            this.labelLoggedInUserNameTitle.Name = "labelLoggedInUserNameTitle";
            this.labelLoggedInUserNameTitle.Size = new System.Drawing.Size(162, 20);
            this.labelLoggedInUserNameTitle.TabIndex = 8;
            this.labelLoggedInUserNameTitle.Text = "Logged in user name:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 397);
            this.Controls.Add(this.labelLoggedInUserNameTitle);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.labelLoggedInUserNameValue);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Label labelLoggedInUserNameValue;
        private System.Windows.Forms.Label labelLoggedInUserNameTitle;
    }
}