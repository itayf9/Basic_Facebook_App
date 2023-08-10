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

        private const string k_DefaultLoginButtonText = "Login";

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

        private Session m_Session;
        private User m_LoggedInUser;

        public LoginForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;

            if (Session.IsSessionExist())
            {
                m_Session = Session.LoadFromFile();
            }

            setLoginFormComponents();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (m_Session != null && !checkBoxRememberMe.Checked)
            {
                Session.DeleteSession();
            }
            else if (m_Session != null)
            {
                m_Session.SaveToFile();
            }

            base.OnFormClosing(e);
        }

        private void setLoginFormComponents()
        {
            if (m_Session != null)
            {
                checkBoxRememberMe.Checked = m_Session.IsRememberMe;
                buttonLogin.Text = m_Session.IsRememberMe ? k_SessionLoginButtonText
                    : k_DefaultLoginButtonText;
            }
            else
            {
                checkBoxRememberMe.Checked = false;
                buttonLogin.Text = k_DefaultLoginButtonText;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_Session != null)
            {
                loginWithSession(m_Session);
            }
            else
            {
                loginWithoutSession();
            }
        }

        private void loginWithSession(Session session)
        {
            try
            {
                LoginResult loginResult = FacebookService.Connect(session.AccessToken);
                m_LoggedInUser = loginResult.LoggedInUser;

                handleAppearenceOfLoginAndMainDialogs();
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.GENERAL_ERROR_MESSAGE);
            }
        }

        private void loginWithoutSession()
        {
            try
            {
                LoginResult loginResult = FacebookService.Login(k_AppID, r_RequestedPermissions);

                if (!string.IsNullOrEmpty(loginResult.AccessToken))
                {
                    labelError.Visible = false;
                    m_LoggedInUser = loginResult.LoggedInUser;

                    m_Session = new Session
                    {
                        AccessToken = loginResult.AccessToken,
                        IsRememberMe = checkBoxRememberMe.Checked,
                    };
                    m_Session.SaveToFile();

                    handleAppearenceOfLoginAndMainDialogs();
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

        private void handleAppearenceOfLoginAndMainDialogs()
        {
            this.Hide();
            new FormMain(m_LoggedInUser).ShowDialog();
            if (!Session.IsSessionExist())
            {
                m_Session = null;
            }

            setLoginFormComponents();
            this.Show();
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (m_Session != null)
            {
                m_Session.IsRememberMe = checkBoxRememberMe.Checked;
            }
        }
    }
}
