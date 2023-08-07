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
        private readonly string[] r_RequestedPermissions = {
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
            "user_videos",
            "groups_access_member_info"
        };
        private User m_LoggedInUser;

        public LoginForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
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
            LoginResult loginResult = FacebookService.Login(k_AppID, r_RequestedPermissions);

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                labelError.Visible = false;
                m_LoggedInUser = loginResult.LoggedInUser;
                this.Hide();
                new FormMain(m_LoggedInUser).ShowDialog();
                this.Show();
                m_LoggedInUser = null;
            }
            else if (loginResult.ErrorMessage.Equals(""))
            {
                labelError.Visible = true;
                labelError.Text = "Login Error !! Please Try Again.";
            }
            else 
            {
                labelError.Enabled = true;
                labelError.Text = loginResult.ErrorMessage;
            }
        }
    }
}
