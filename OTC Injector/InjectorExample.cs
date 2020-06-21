using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace OTC_Injector
{
    public partial class InjectorExample : MetroFramework.Forms.MetroForm
    {

        string cheatdev = "0xb00b1e5#0089";
        string designdev = "THEGHOSTSOLDIER#3863";
        string discord = "https://discord.gg/adWT9N";
        string website = "website url";
        public InjectorExample()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();            
            foreach(Process process in processes)
            {
                comboBox1.Items.Add(process.ProcessName);
            }
        }

        string f = "";
        private void button3_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                f = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(f);
                    size = text.Length;
                    metroTextBox2.Text = f;
                    metroTextBox2.Text = Path.GetFileName(Path.GetDirectoryName(f));
                }

                catch (IOException)
                {

                }
            }
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            metroTextBox2.Text = f;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox3.Text = "onetap got selected";
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            metroTextBox3.Text = "Fatality got selected";
            checkBox1.Checked = false;
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            /*
            if (checkBox1.Checked == true)
            {
                metroTextBox3.Text = "onetap got selected";
            }

            else if (checkBox2.Checked == true)
            {
                metroTextBox3.Text = "Fatality got selected";
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "notepad")
            {
                metroTextBox1.Text = "You did inject onetap crack | fatality crack | own selected cheat to csgo";
            }

            else if (comboBox1.Text == "")
            {
                metroTextBox1.Text = "please select a process to inject";
            }

            else
            {
                metroTextBox1.Text = "You didn't select a dll or process";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cheatdev, "Information");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(designdev, "Information");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(discord, "Information");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(website, "Information");
        }
    }
}
