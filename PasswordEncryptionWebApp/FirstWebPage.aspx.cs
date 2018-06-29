using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PasswordEncryptionWebApp
{
    public partial class FirstWebPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void passwordNotEnteredError()
        {
            if (TextBox1.Text.Length < 1)
            {
                Response.Write("Password cannot be empty");
            }
            return;
        }

        protected void buttonSHA1_Click(object sender, EventArgs e)
        {
            passwordNotEnteredError();
        }

        protected void buttonSHA2_Click(object sender, EventArgs e)
        {
            passwordNotEnteredError();
        }

        protected void buttonMD5_Click(object sender, EventArgs e)
        {
            passwordNotEnteredError();
        }

        protected void buttonPBKDF2_Click(object sender, EventArgs e)
        {
            passwordNotEnteredError();
        }

        protected void buttonBCRYPT_Click(object sender, EventArgs e)
        {
            passwordNotEnteredError();
        }

        protected void buttonSCRYPT_Click(object sender, EventArgs e)
        {
            passwordNotEnteredError();
        }
    }
}