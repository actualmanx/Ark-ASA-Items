using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System;

namespace Ark_ASA_Items
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveControl = inputBox1;

        }

        private void addToButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(inputBox1.Text))
            {
                ActiveControl = inputBox1; // Do something...
            }
            else
            {
                int v = blueprintBox1.Checked ? 1 : 0;
                string input = inputBox1.Text;
                string pattern = @"(\d+)\s+(\d+)\s+(\d+)$"; // Matches the last three numbers
                // Get the new numbers from the textboxes
                string replacement = $"{howManyBox1.Text} {qualityBox1.Text} {v}";
                string result = Regex.Replace(input, pattern, replacement);
                inputBox1.Text = result;
                logBox1.AppendText(inputBox1.Text);
                logBox1.AppendText(" | ");
                inputBox1.Clear();
                ActiveControl = inputBox1;
            }

        }


        private async void copyText_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(logBox1.Text))
            {
                Clipboard.SetText(logBox1.Text);
                logBox1.Clear();
                statusLabel1.Text = "Copied To Clipboard";
                await Task.Delay(3_000);
                statusLabel1.Text = "";
            }
            ActiveControl = inputBox1;

        }

        private void setTo100_Click(object sender, EventArgs e)
        {
            if (setTo100.Text == "100")
            {
                setTo100.Text = "1";
                howManyBox1.Text = "100";
            }
            else
            {
                setTo100.Text = "100";
                howManyBox1.Text = "1";
            }
            // howManyBox1.Text = "100";
            // setTo100.Text = "1";
            int v = blueprintBox1.Checked ? 1 : 0;
            string input = inputBox1.Text;
            string pattern = @"(\d+)\s+(\d+)\s+(\d+)$"; // Matches the last three numbers
            // Get the new numbers from the textboxes
            string replacement = $"{howManyBox1.Text} {qualityBox1.Text} {v}";
            string result = Regex.Replace(input, pattern, replacement);
            inputBox1.Text = result;
            ActiveControl = inputBox1;

        }

        private void QualityAscendent_Click(object sender, EventArgs e)
        {
            if (qualityBox1.Text == "100")
            {
                qualityBox1.Text = "1";
                QualityAscendent.Text = "100";
            }
            else
            {
                qualityBox1.Text = "100";
                QualityAscendent.Text = "1";
            }
            int v = blueprintBox1.Checked ? 1 : 0;
            string input = inputBox1.Text;
            string pattern = @"(\d+)\s+(\d+)\s+(\d+)$"; // Matches the last three numbers
            // Get the new numbers from the textboxes
            string replacement = $"{howManyBox1.Text} {qualityBox1.Text} {v}";
            string result = Regex.Replace(input, pattern, replacement);
            inputBox1.Text = result;
            ActiveControl = inputBox1;
        }


        private void blueprintBox1_CheckedChanged(object sender, EventArgs e)
        {
            int v = blueprintBox1.Checked ? 1 : 0;
            string input = inputBox1.Text;
            string pattern = @"(\d+)\s+(\d+)\s+(\d+)$"; // Matches the last three numbers
            // Get the new numbers from the textboxes
            string replacement = $"{howManyBox1.Text} {qualityBox1.Text} {v}";
            string result = Regex.Replace(input, pattern, replacement);
            inputBox1.Text = result;
            ActiveControl = inputBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                inputBox1.Text = clipboardText;
            }
            else
            {
                MessageBox.Show("The clipboard does not contain any text.");
            }
        }


        private async void MejoBerrys_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0");
            statusLabel1.Text = "Mejo Berry's Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }

        private async void CookedMeat_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0");
            statusLabel1.Text = "Cooked Meat Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }

        private async void Kibble_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0");
            statusLabel1.Text = "Kibble Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }

        private async void CookedPrimeFishMeat_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0");
            statusLabel1.Text = "Cooked Prime Fish Meat Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }

        private async void PriMeatJerky_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 1 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0");
            statusLabel1.Text = "Cooked Prime Meat Jerky Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }

        private async void ShockDarts_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI RefinedTranq 100 0 0 ");
            statusLabel1.Text = "100 Shock Darts Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }

        private async void BioToxin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0");
            statusLabel1.Text = "500 Bio Toxin Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }

        private async void Element_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0");
            statusLabel1.Text = "Element Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }

        private async void Tributes_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI ApexDrop_Allo 10 0 0 | cheat GFI ApexDrop_Basilo 10 0 0 | cheat GFI ApexDrop_Basilisk 10 0 0 | cheat GFI ApexDrop_Giga 10 0 0 | cheat GFI ApexDrop_Tuso 10 0 0 | cheat GFI ApexDrop_Rex 10 0 0 | cheat GFI ApexDrop_Yuty 10 0 0 | cheat GFI ApexDrop_Argentavis 10 0 0 | cheat GFI ApexDrop_Sarco 10 0 0 | cheat GFI ApexDrop_PoisonWyvern 10 0 0 | admincheat GFI ApexDrop_FireWyvern 10 1 0 | admincheat GFI ApexDrop_LightningWyvern 10 1 0 | admincheat GFI ApexDrop_Megalodon 10 1 0 | admincheat GFI ApexDrop_Sauro 10 1 0 | cheat GFI ApexDrop_Boa 10 0 0 | admincheat GFI ApexDrop_Megalania 10 0 0 | admincheat GFI ApexDrop_Spino 10 0 0 | admincheat GFI ApexDrop_Theriz 10 0 0 | admincheat GFI ApexDrop_Thylaco 10 0 0");
            statusLabel1.Text = "Tributes Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }

        private async void Artifacts_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI Extinction_DesertKaiju 1 0 0 | cheat GFI Extinction_ForestKaiju 1 0 0 | cheat GFI Artifact_12 1 0 0 | cheat GFI Artifact_05 1 0 0 | cheat GFI ArtifactSE_02 1 0 0 | cheat GFI Artifact_11 1 0 0 | cheat GFI ArtifactAB 1 0 0 | cheat GFI ArtifactSE_03 1 0 0 | cheat GFI Artifact_04 1 0 0 | cheat GFI Artifact_07 1 0 0 | cheat GFI ArtifactSE_01 1 0 0 | cheat GFI Artifact_01 1 0 0 | cheat GFI Artifact_08 1 0 0 | cheat GFI ArtifactAB_4 1 0 0 | cheat GFI Artifact_03 1 0 0 | cheat GFI Artifact_02 1 0 0 | cheat GFI ArtifactAB_2 1 0 0 | cheat GFI Artifact_06 1 0 0 | cheat GFI ArtifactAB_3 1 0 0 | cheat GFI Artifact_09 1 0 0 | cheat GFI Extinction_IceKaiju 1 0 0");
            statusLabel1.Text = "Artifacts Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }


        private async void TranqArrow_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI ArrowTranq 100 0 0");
            statusLabel1.Text = "100 Tranq Arrow's Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }

        private async void TranqDarts_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI TranqDart 100 0 0");
            statusLabel1.Text = "100 Tranq Dart's Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }
    }
}