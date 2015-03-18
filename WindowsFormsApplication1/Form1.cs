using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnRed_Click(object sender, EventArgs e)
        {
            SetRedHeight(tbxRedHeight.Text);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            SetBlueHeight(tbxBlueHeight.Text);
        }

        private void btnDoAll_Click(object sender, EventArgs e)
        {
            SetRedHeight(tbxRedHeight.Text);
            SetBlueHeight(tbxBlueHeight.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSetting(tbxRedHeight.Text, tbxBlueHeight.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadSetting();
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            UseSetting(lbxSavedItems.SelectedItem.ToString());
        }

        private void SetRedHeight(string h)
        {
            int unicorn = int.Parse(h);
            int i = 0;
            
            while (i < unicorn)
            {
                pbxRed.Height = i;
                pbxRed.Refresh();
                i += 5;
                Thread.Sleep(20);
            }
                
        }

        private void SetBlueHeight(string h)
        {
            int unicorn = int.Parse(h);
            int i = 0;
            while (i < unicorn)
            {
                pbxBlue.Height = i;
                pbxBlue.Refresh();
                i += 5;
                Thread.Sleep(20);
            }
        }

        private void SaveSetting(string r, string b)
        {
            StreamWriter sw = new StreamWriter("Saved.txt", true);
            string linetowrite = r + ',' + b;
            sw.WriteLine(linetowrite);
            sw.Close();
        }

        private void LoadSetting()
        {
            lbxSavedItems.Items.Clear();
            StreamReader sr = new StreamReader("Saved.txt");
            while (!sr.EndOfStream)
            {
                string readline = sr.ReadLine();
                lbxSavedItems.Items.Add(readline);
            }
            sr.Close();
        }

        private void UseSetting(string dump)
        {
            string[] values = dump.Split(',');
            tbxRedHeight.Text = values[0];
            tbxBlueHeight.Text = values[1];

            SetRedHeight(tbxRedHeight.Text);
            SetBlueHeight(tbxBlueHeight.Text);
        }






    }
}
