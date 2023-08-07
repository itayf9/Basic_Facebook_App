using System;
using System.IO;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class Session
    {
        private const string k_SessionFileName = "Session.xml";
        private string m_AccessToken;
        private bool m_IsRememberMeChecked;

        public string AccessToken { get; set; }

        public bool IsRememberMeChecked { get; set; }

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
            Stream stream = null;
            if (File.Exists(k_SessionFileName))
            {
                stream = new FileStream(k_SessionFileName, FileMode.Truncate);
            }
            else
            {
                stream = new FileStream(k_SessionFileName, FileMode.CreateNew);
            }

            using (stream)
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        internal void DeleteSession()
        {
            File.Delete(k_SessionFileName);
        }
    }
}