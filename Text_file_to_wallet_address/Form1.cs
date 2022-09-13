using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_file_to_wallet_address
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        string filePath = string.Empty;
        string[] list;
        bool isloaded=false;
        List<string> r = new List<string>();
        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_file = new OpenFileDialog();
            open_file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open_file.ShowDialog() == DialogResult.OK)
            {
                filePath = open_file.FileName;
                list = File.ReadAllLines(filePath);
                isloaded = true;

            }
        }

        private void export_wallets()
        {
            string wallet="";
            for(int i = 0; i < list.Length; i++)
            {
                try
                {
                    //MessageBox.Show(RemoveAllWhitespaces(list[i]));
                    //list[i] = RemoveAllWhitespaces(list[i]);
                    MessageBox.Show(list[i]);
                    wallet = list[i].Substring(list[i].IndexOf('0'), list[i].IndexOf(']'));
                    results.Text += wallet + "\n";
                }
                catch(Exception s)
                {
                    MessageBox.Show(s.Message+" "+i);
                }
            }
        }

        public static string RemoveAllWhitespaces(string source)
        {
            string r = "";
            char[] chararr = source.ToCharArray();
            for(int i = 0; i < chararr.Length; i++)
            {
                if (chararr[i] != ' ')
                {
                    r += chararr[i].ToString();
                }
            }
            //string r = chararr.ToString();
            return r;
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (isloaded==true)
            {
                export_wallets();
            }
            else
            {
                MessageBox.Show("Load the text file first !!", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
