using System.Windows.Forms;

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
            if (inputBox1.Text.Contains("1 1 0") || (inputBox1.Text.Contains("100 1 0")))
            {
                logBox1.AppendText(inputBox1.Text);
                logBox1.AppendText(" | ");
                inputBox1.Clear();
                ActiveControl = inputBox1;
            }
            else
            {
                inputBox1.Clear();
                ActiveControl = inputBox1;
            }
            /*if (inputBox1.Text == "")
            {
                ActiveControl = inputBox1;
            }
            else
            {
                logBox1.AppendText(" | ");
                inputBox1.Clear();
                ActiveControl = inputBox1;
            }*/
        }


        private void copyText_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(logBox1.Text);
            logBox1.Clear();
            ActiveControl = inputBox1;
        }

        private void setTo100_Click(object sender, EventArgs e)
        {
            string source = inputBox1.Text;
            // Remove a substring from the middle of the string.
            string toRemove = "1 1 0";
            string result = string.Empty;
            int i = source.IndexOf(toRemove);
            if (i >= 0)
            {
                result = source.Remove(i, toRemove.Length);
                inputBox1.Text = (result);
                inputBox1.AppendText("100 1 0");
                logBox1.AppendText(inputBox1.Text);
                logBox1.AppendText(" | ");
                inputBox1.Clear();
                ActiveControl = inputBox1;

            }
            else
            {
                inputBox1.Clear();
                ActiveControl = inputBox1;
            }




        }

        private void primeMeatJerky_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 1 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0|cheat GFI CookedPrimeMeat_Jerky 30 0 0");
        }


        private void cookPfishmeat_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0 | cheat GFI CookedPrimeMeat_Fish 30 0 0");
        }



        private void kibble1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0");
        }

        private void element1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0 | cheat GFI Element 100 0 0");
        }

        private void bioToxin1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0");
        }

        private void shockDarts1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI RefinedTranq 100 0 0 ");
        }

        private void artifacts1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat gfi Extinction_DesertKaiju 1 0 0 | cheat gfi Extinction_ForestKaiju 1 0 0 | cheat gfi Artifact_12 1 0 0 | cheat gfi Artifact_05 1 0 0 | cheat gfi ArtifactSE_02 1 0 0 | cheat gfi Artifact_11 1 0 0 | cheat gfi ArtifactAB 1 0 0 | cheat gfi ArtifactSE_03 1 0 0 | cheat gfi Artifact_04 1 0 0 | cheat gfi Artifact_07 1 0 0 | cheat gfi ArtifactSE_01 1 0 0 | cheat gfi Artifact_01 1 0 0 | cheat gfi Artifact_08 1 0 0 | cheat gfi ArtifactAB_4 1 0 0 | cheat gfi Artifact_03 1 0 0 | cheat gfi Artifact_02 1 0 0 | cheat gfi ArtifactAB_2 1 0 0 | cheat gfi Artifact_06 1 0 0 | cheat gfi ArtifactAB_3 1 0 0 | cheat gfi Artifact_09 1 0 0 | cheat gfi Extinction_IceKaiju 1 0 0");
        }

        private void tributes1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat gfi ApexDrop_Allo 10 0 0 | cheat gfi ApexDrop_Basilo 10 0 0 | cheat gfi ApexDrop_Basilisk 10 0 0 | cheat gfi ApexDrop_Giga 10 0 0 | cheat gfi ApexDrop_Tuso 10 0 0 | cheat gfi ApexDrop_Rex 10 0 0 | cheat gfi ApexDrop_Yuty 10 0 0 | cheat gfi ApexDrop_Argentavis 10 0 0 | cheat gfi ApexDrop_Sarco 10 0 0 | cheat gfi ApexDrop_PoisonWyvern 10 0 0 | admincheat GFI ApexDrop_FireWyvern 10 1 0 | admincheat GFI ApexDrop_LightningWyvern 10 1 0 | admincheat GFI ApexDrop_Megalodon 10 1 0 | admincheat GFI ApexDrop_Sauro 10 1 0 | cheat GFI ApexDrop_Boa 10 0 0 | admincheat GFI ApexDrop_Megalania 10 0 0 | admincheat GFI ApexDrop_Spino 10 0 0 | admincheat GFI ApexDrop_Theriz 10 0 0 | admincheat GFI ApexDrop_Thylaco 10 0 0");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0 | cheat GFI cooked 30 0 0");
        }
    }
}