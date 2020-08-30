using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LToolsGUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private string summonerName;
        private int numMasteryChampions;
        private void summonerButton_Click(object sender, EventArgs e) {

            
        }

        private void rankedButton_Click(object sender, EventArgs e)
        {

        }

        private void masteryButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.GetIndex());
           // numMasteryChampions = int.Parse(sender.ToString());
           // Console.WriteLine(numMasteryChampions);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(e.ToString());
           // Console.WriteLine(sender.ToString());
            summonerName = sender.ToString().Split(':')[1].Trim();
            Console.WriteLine(summonerName);
        }
    }
}
