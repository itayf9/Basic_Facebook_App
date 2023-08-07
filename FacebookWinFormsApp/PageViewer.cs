using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class PageViewer
    {
        private readonly Label r_LabelDescription;
        private readonly TextBox r_TextBoxDescription;

        public PageViewer()
        {
            r_LabelDescription = new Label();
            r_LabelDescription.AutoSize = true;
            r_LabelDescription.Location = new System.Drawing.Point(595, 178);
            r_LabelDescription.Name = "labelDescription";
            r_LabelDescription.Size = new System.Drawing.Size(127, 26);
            r_LabelDescription.TabIndex = 70;
            r_LabelDescription.Text = "Description:";

            r_TextBoxDescription = new TextBox();
            r_TextBoxDescription.Location = new System.Drawing.Point(600, 211);
            r_TextBoxDescription.Multiline = true;
            r_TextBoxDescription.Name = "textBoxDescription";
            r_TextBoxDescription.Size = new System.Drawing.Size(521, 135);
            r_TextBoxDescription.TabIndex = 71;
        }
    }
}
