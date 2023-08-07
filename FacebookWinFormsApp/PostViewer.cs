using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class PostViewer
    {
        private readonly Label r_LabelCaption;
        private readonly TextBox r_TextBoxCaption;
        private readonly PictureBox r_PictureBoxPost;

        public PostViewer()
        {
            r_LabelCaption = new Label();
            r_LabelCaption.AutoSize = true;
            r_LabelCaption.Location = new System.Drawing.Point(596, 178);
            r_LabelCaption.Name = "labelCaption";
            r_LabelCaption.Size = new System.Drawing.Size(93, 26);
            r_LabelCaption.TabIndex = 70;
            r_LabelCaption.Text = "Caption:";

            r_TextBoxCaption = new TextBox();
            r_TextBoxCaption.Location = new System.Drawing.Point(601, 208);
            r_TextBoxCaption.Multiline = true;
            r_TextBoxCaption.Name = "textBoxCaption";
            r_TextBoxCaption.Size = new System.Drawing.Size(520, 88);
            r_TextBoxCaption.TabIndex = 71;

            r_PictureBoxPost = new PictureBox();
            r_PictureBoxPost.Location = new System.Drawing.Point(601, 304);
            r_PictureBoxPost.Name = "pictureBoxPost";
            r_PictureBoxPost.Size = new System.Drawing.Size(520, 243);
            r_PictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            r_PictureBoxPost.TabIndex = 72;
            r_PictureBoxPost.TabStop = false;
        }
    }
}
