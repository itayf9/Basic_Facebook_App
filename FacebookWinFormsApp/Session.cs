using System.IO;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class Session
    {
        private const string k_SessionFileName = "Session.xml";
        private string m_LoggedInUserName;
        private string m_AccessToken;
        private bool m_IsRememberMe;

        public string LoggedInUserName { get; set; }

        public string AccessToken { get; set; }

        public bool IsRememberMe { get; set; }

        public static bool IsSessionExist()
        {
            return File.Exists(k_SessionFileName);
        }

        public static Session LoadFromFile()
        {
            Session session = null;
            using (Stream stream = new FileStream(k_SessionFileName, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Session));
                session = serializer.Deserialize(stream) as Session;
            }

            return session;
        }

        public void SaveToFile()
        {
            FileMode fileMode;
            if (File.Exists(k_SessionFileName))
            {
                fileMode = FileMode.Truncate;
            }
            else
            {
                fileMode = FileMode.CreateNew;
            }

            using (Stream stream = new FileStream(k_SessionFileName, fileMode))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        internal static void DeleteSession()
        {
            File.Delete(k_SessionFileName);
        }
    }
}