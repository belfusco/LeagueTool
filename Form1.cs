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

        private APIRequest req;
        
        //initialize working APIRequest and the form GUI
        public Form1() {
            InitializeComponent();
            req = new APIRequest();
        }

        //called when Summoner Info is clicked
        private void SummonerButton_Click(object sender, EventArgs e) {
            MessageBox.Show(req.ProcessSummCheck(), req.GetName());
            Console.WriteLine("SUMM BUTTON CLICK"); //made sure _Click works
        }

        //called when Ranked Info is clicked
        private void RankedButton_Click(object sender, EventArgs e) {
            req.ProcessRankedCheck();
        }

        private void MasteryButton_Click(object sender, EventArgs e) {
            req.ProcessMasteryCheck(1);
        }

        private void SummonerInput_TextChanged(object sender, EventArgs e) {
            req.UpdateName(summonerInput.Text);
        }
    }
}
