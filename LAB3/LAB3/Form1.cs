using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(DeleteWords);
            t.Start();
        }

        private void DeleteWords()
        {
            string input = textBox1.Text;
            string[] words = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            foreach (string word in words)
            {
                if (!word.StartsWith("a") && !word.StartsWith("m"))
                {
                    result.Add(word);
                }
            }

            string outputText = string.Join(" ", result);
            ShowMessage(outputText);
        }

        private void ShowMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { ShowMessage(message); });
                return;
            }

            MessageBox.Show(message);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

