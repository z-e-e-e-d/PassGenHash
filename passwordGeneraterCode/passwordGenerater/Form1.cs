using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordGenerater
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lengthTxb.Text = "20";
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordTxb.Text);
        }

        public static string GeneratePassword(string input, string additionalKey, int length)
        {
            string combinedInput = input + additionalKey + "salt123"; // Slight change to alter output

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(combinedInput));
                string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                StringBuilder password = new StringBuilder();
                const string symbols = "!@#$%^&*()";
                bool hasUppercase = false;

                for (int i = 0; i < length; i++)
                {
                    char charToAdd;
                    switch (i % 4)
                    {
                        case 0:
                            charToAdd = char.ToUpper(hashString[i % hashString.Length]);
                            hasUppercase = true;
                            break;
                        case 1:
                            charToAdd = char.ToLower(hashString[i % hashString.Length]);
                            break;
                        case 2:
                            charToAdd = (char)('0' + (hashBytes[i % hashBytes.Length] % 10));
                            break;
                        default:
                            charToAdd = symbols[hashBytes[i % hashBytes.Length] % symbols.Length];
                            break;
                    }
                    password.Append(charToAdd);
                }

                if (!hasUppercase)
                {
                    return GeneratePassword(input, additionalKey, length);
                }

                return password.ToString();
            }
        }

        private void inputTxb_TextChanged(object sender, EventArgs e)
        {
            genPassword();
        }

        private void secondInputTxb_TextChanged(object sender, EventArgs e)
        {
            genPassword();
        }

        private void lengthTxb_TextChanged(object sender, EventArgs e)
        {
            genPassword();
        }

        private void genPassword()
        {
            if (string.IsNullOrWhiteSpace(lengthTxb.Text) || !int.TryParse(lengthTxb.Text, out int length) || length <= 0)
            {
                length = 20; // Default length
                lengthTxb.Text = length.ToString();
            }
            passwordTxb.Text = GeneratePassword(inputTxb.Text, secondInputTxb.Text, length);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hidePnlBtn_Click(object sender, EventArgs e)
        {
            if (hidePanel.Visible) hidePanel.Visible = false;
            else hidePanel.Visible = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
