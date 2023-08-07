using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {
        private const string k_AppID = "832742648143866";
        private const string k_SessionLoginButtonText = "Continue With Facebook";

        private readonly string[] r_RequestedPermissions =
        {
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
        };

        private Session session;
        private User m_LoggedInUser;

        public LoginForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;

            if (Session.IsSessionExist())
            {
                checkBoxRememberMe.Checked = true;
                buttonLogin.Text = k_SessionLoginButtonText;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!checkBoxRememberMe.Checked)
            {
                Session.DeleteSession();
            }

            base.OnFormClosing(e);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Session.IsSessionExist())
            {
                session = Session.LoadFromFile();
                loginWithSession(session);
            }
            else
            {
                login();
            }
        }

        private void loginWithSession(Session session)
        {
            try
            {
                LoginResult loginResult = FacebookService.Connect(session.AccessToken);
                m_LoggedInUser = loginResult.LoggedInUser;
                Hide();
                new FormMain(m_LoggedInUser).ShowDialog();
                Show();
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.GENERAL_ERROR_MESSAGE);
            }
        }

        private void login()
        {
            try
            {
                LoginResult loginResult = FacebookService.Login(k_AppID, r_RequestedPermissions);

                if (!string.IsNullOrEmpty(loginResult.AccessToken))
                {
                    labelError.Visible = false;
                    m_LoggedInUser = loginResult.LoggedInUser;

                    if (checkBoxRememberMe.Checked)
                    {
                        session = new Session
                        {
                            AccessToken = loginResult.AccessToken,
                            IsRememberMeChecked = true,
                        };
                        session.SaveToFile();
                    }

                    this.Hide();
                    new FormMain(m_LoggedInUser).ShowDialog();
                    this.Show();
                }
                else if (loginResult.ErrorMessage.Equals(string.Empty))
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
            catch (Exception)
            {
                MessageBox.Show(Constants.GENERAL_ERROR_MESSAGE);
            }
        }
    }
}
