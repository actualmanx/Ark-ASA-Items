using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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


        private void copyText_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(logBox1.Text))
            {
                Clipboard.SetText(logBox1.Text);
                logBox1.Clear();
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
            Clipboard.SetText("cheat gfi ApexDrop_Allo 10 0 0 | cheat gfi ApexDrop_Basilo 10 0 0 | cheat gfi ApexDrop_Basilisk 10 0 0 | cheat gfi ApexDrop_Giga 10 0 0 | cheat gfi ApexDrop_Tuso 10 0 0 | cheat gfi ApexDrop_Rex 10 0 0 | cheat gfi ApexDrop_Yuty 10 0 0 | cheat gfi ApexDrop_Argentavis 10 0 0 | cheat gfi ApexDrop_Sarco 10 0 0 | cheat gfi ApexDrop_PoisonWyvern 10 0 0 | admincheat GFI ApexDrop_FireWyvern 10 1 0 | admincheat GFI ApexDrop_LightningWyvern 10 1 0 | admincheat GFI ApexDrop_Megalodon 10 1 0 | admincheat GFI ApexDrop_Sauro 10 1 0 | cheat GFI ApexDrop_Boa 10 0 0 | admincheat GFI ApexDrop_Megalania 10 0 0 | admincheat GFI ApexDrop_Spino 10 0 0 | admincheat GFI ApexDrop_Theriz 10 0 0 | admincheat GFI ApexDrop_Thylaco 10 0 0");
            statusLabel1.Text = "Tributes Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
        }

        private async void Artifacts_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat gfi Extinction_DesertKaiju 1 0 0 | cheat gfi Extinction_ForestKaiju 1 0 0 | cheat gfi Artifact_12 1 0 0 | cheat gfi Artifact_05 1 0 0 | cheat gfi ArtifactSE_02 1 0 0 | cheat gfi Artifact_11 1 0 0 | cheat gfi ArtifactAB 1 0 0 | cheat gfi ArtifactSE_03 1 0 0 | cheat gfi Artifact_04 1 0 0 | cheat gfi Artifact_07 1 0 0 | cheat gfi ArtifactSE_01 1 0 0 | cheat gfi Artifact_01 1 0 0 | cheat gfi Artifact_08 1 0 0 | cheat gfi ArtifactAB_4 1 0 0 | cheat gfi Artifact_03 1 0 0 | cheat gfi Artifact_02 1 0 0 | cheat gfi ArtifactAB_2 1 0 0 | cheat gfi Artifact_06 1 0 0 | cheat gfi ArtifactAB_3 1 0 0 | cheat gfi Artifact_09 1 0 0 | cheat gfi Extinction_IceKaiju 1 0 0");
            statusLabel1.Text = "Artifacts Copied";
            await Task.Delay(3_000);
            statusLabel1.Text = "";
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
    }
}