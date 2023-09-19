using System.Windows.Forms;

namespace BasicFacebookFeatures.commands
{
    internal class CommandButton : Button
    {
        private ICommand m_Command;

        public ICommand Command
        {
            get { return m_Command; }
            set { m_Command = value; }
        }
    }
}
