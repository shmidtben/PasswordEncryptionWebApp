using Scrypt;
using SimpleCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

        protected bool passwordNotEnteredError()
        {
            if (TextBox1.Text.Length < 1)
            {
                Response.Write("Password cannot be empty. ");
                return true;              
            }
            return false;
        }

        protected void buttonSHA1_Click(object sender, EventArgs e)
        {
            if (passwordNotEnteredError())
            {
                return;
            }

            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] temp = sha.ComputeHash(Encoding.UTF8.GetBytes(TextBox1.Text));

            var sb = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
            {
                sb.Append(temp[i].ToString("x2"));
            }

            Response.Write($"Your SHA-1 encryption is {sb.ToString()}");
        }

        protected void buttonSHA256_Click(object sender, EventArgs e)
        {
            if (passwordNotEnteredError())
            {
                return;
            }

            SHA256 sha = new SHA256CryptoServiceProvider();
            byte[] temp = sha.ComputeHash(Encoding.UTF8.GetBytes(TextBox1.Text));

            var sb = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
            {
                sb.Append(temp[i].ToString("x2"));
            }

            Response.Write($"Your SHA-256 encryption is {sb.ToString()}");
        }

        protected void buttonMD5_Click(object sender, EventArgs e)
        {
            if (passwordNotEnteredError())
            {
                return;
            }

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] temp = md5.ComputeHash(Encoding.UTF8.GetBytes(TextBox1.Text));

            var sb = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
            {
                sb.Append(temp[i].ToString("x2"));
            }

            Response.Write($"Your MD-5 encryption is {sb.ToString()}");
        }

        protected void buttonPBKDF2_Click(object sender, EventArgs e)
        {
            if (passwordNotEnteredError())
            {
                return;
            }

            var pbkdf2Encryptor = new PBKDF2();
            string encryptedPass = pbkdf2Encryptor.Compute(TextBox1.Text);

            Response.Write($"Your PBKDF2 encryption is {encryptedPass}");
        }

        protected void buttonBCRYPT_Click(object sender, EventArgs e)
        {
            if (passwordNotEnteredError())
            {
                return;
            }

            Response.Write($"Your BCRYPT encryption is {BCrypt.Net.BCrypt.HashPassword(TextBox1.Text)}");
        }

        protected void buttonSCRYPT_Click(object sender, EventArgs e)
        {
            if (passwordNotEnteredError())
            {
                return;
            }

            ScryptEncoder encoder = new ScryptEncoder();
            Response.Write($"Your SCRYPT encryption is {encoder.Encode(TextBox1.Text)}");
        }
    }
}