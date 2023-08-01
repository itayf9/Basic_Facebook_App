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
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                this.Hide();
                new FormMain(m_LoggedInUser).ShowDialog();
                this.Show();
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
