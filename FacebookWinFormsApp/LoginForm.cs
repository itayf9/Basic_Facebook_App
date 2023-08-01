using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {

        private const string k_AppID = "832742648143866";
        private User m_LoggedInUser;

        public LoginForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoggedInUser == null)
            {
                login();
            }
        }

        private void login()
        {
            FacebookWrapper.LoginResult m_LoginResult = FacebookService.Login(
                k_AppID,
                /// requested permissions:
                "email",
                "public_profile"
                /// add any relevant permissions
                );

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.BackColor = Color.LightGreen;
                this.Hide();
                new FormMain(m_LoggedInUser).ShowDialog();
                this.Close();
            }
            else if (m_LoginResult.ErrorMessage.Equals(""))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "Login Error !! Please Try Again.";
            }
            else 
            {
                ErrorLabel.Enabled = true;
                ErrorLabel.Text = m_LoginResult.ErrorMessage;
            }
        }
    }
}
