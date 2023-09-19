using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.commands
{
    internal class CommandButton : Button
    {
        public CommandButton()
        {
            this.Click += new EventHandler(this.commandButton_Click);
        }

        public ICommand FetchCommand { private get; set; }

        private void commandButton_Click(object sender, EventArgs e)
        {
            if (FetchCommand != null)
            {
                FetchCommand.Execute();
            }
        }
    }
}
