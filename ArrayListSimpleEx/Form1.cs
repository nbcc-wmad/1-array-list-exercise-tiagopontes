using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList msg = new ArrayList();

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            msg.Clear();

            msg.Add("I");
            msg.Add("Love");
            msg.Add("Programming");
            msg.Add("So");
            msg.Add("Much");

            foreach (object item in msg)
            {
                lblMessage.Text += item + " ";
            }

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            msg.Reverse();

            foreach (object item in msg)
            {
                lblMessage.Text += item + " ";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            msg.Insert(1, txtSecondPos.Text.Trim());

            foreach (object item in msg)
            {
                lblMessage.Text += item + " ";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            msg.RemoveAt(1);

            foreach (object item in msg)
            {
                lblMessage.Text += item + " ";
            }
        }
    }
}
