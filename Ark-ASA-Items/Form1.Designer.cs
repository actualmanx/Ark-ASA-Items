namespace Ark_ASA_Items
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            logBox1 = new RichTextBox();
            inputBox1 = new TextBox();
            addToButton = new Button();
            copyText = new Button();
            setTo100 = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            MejoBerrys = new ToolStripMenuItem();
            CoookedMeat = new ToolStripMenuItem();
            Kibble = new ToolStripMenuItem();
            PriMeatJerky = new ToolStripMenuItem();
            CookedPrimeFishMeat = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            ShockDarts = new ToolStripMenuItem();
            BioToxin = new ToolStripMenuItem();
            tranqArrow = new ToolStripMenuItem();
            TranqDarts = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            Element = new ToolStripMenuItem();
            Tributes = new ToolStripMenuItem();
            Artifacts = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabel1 = new ToolStripStatusLabel();
            QualityAscendent = new Button();
            howManyBox1 = new TextBox();
            qualityBox1 = new TextBox();
            blueprintBox1 = new CheckBox();
            howMany = new Label();
            quality = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // logBox1
            // 
            logBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logBox1.Location = new Point(27, 104);
            logBox1.Name = "logBox1";
            logBox1.ReadOnly = true;
            logBox1.Size = new Size(418, 144);
            logBox1.TabIndex = 0;
            logBox1.Text = "";
            // 
            // inputBox1
            // 
            inputBox1.AcceptsTab = true;
            inputBox1.AllowDrop = true;
            inputBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            inputBox1.Cursor = Cursors.IBeam;
            inputBox1.Location = new Point(774, 69);
            inputBox1.Name = "inputBox1";
            inputBox1.Size = new Size(436, 31);
            inputBox1.TabIndex = 1;
            // 
            // addToButton
            // 
            addToButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addToButton.Location = new Point(1098, 248);
            addToButton.Name = "addToButton";
            addToButton.Size = new Size(112, 53);
            addToButton.TabIndex = 2;
            addToButton.Text = "Add";
            addToButton.UseVisualStyleBackColor = true;
            addToButton.Click += addToButton_Click;
            // 
            // copyText
            // 
            copyText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            copyText.Location = new Point(27, 254);
            copyText.Name = "copyText";
            copyText.Size = new Size(112, 53);
            copyText.TabIndex = 3;
            copyText.Text = "Copy";
            copyText.UseVisualStyleBackColor = true;
            copyText.Click += copyText_Click;
            // 
            // setTo100
            // 
            setTo100.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            setTo100.Location = new Point(1098, 131);
            setTo100.Name = "setTo100";
            setTo100.Size = new Size(112, 53);
            setTo100.TabIndex = 4;
            setTo100.Text = "100";
            setTo100.UseVisualStyleBackColor = true;
            setTo100.Click += setTo100_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 33);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { MejoBerrys, CoookedMeat, Kibble, PriMeatJerky, CookedPrimeFishMeat });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(144, 29);
            toolStripMenuItem1.Text = "Meat && Berry's";
            // 
            // MejoBerrys
            // 
            MejoBerrys.Image = (Image)resources.GetObject("MejoBerrys.Image");
            MejoBerrys.Name = "MejoBerrys";
            MejoBerrys.Size = new Size(307, 34);
            MejoBerrys.Text = "Mejoberry's";
            MejoBerrys.Click += MejoBerrys_Click;
            // 
            // CoookedMeat
            // 
            CoookedMeat.Image = (Image)resources.GetObject("CoookedMeat.Image");
            CoookedMeat.Name = "CoookedMeat";
            CoookedMeat.Size = new Size(307, 34);
            CoookedMeat.Text = "Cooked Meat";
            CoookedMeat.Click += CookedMeat_Click;
            // 
            // Kibble
            // 
            Kibble.Image = (Image)resources.GetObject("Kibble.Image");
            Kibble.Name = "Kibble";
            Kibble.Size = new Size(307, 34);
            Kibble.Text = "Kibble";
            Kibble.Click += Kibble_Click;
            // 
            // PriMeatJerky
            // 
            PriMeatJerky.Image = (Image)resources.GetObject("PriMeatJerky.Image");
            PriMeatJerky.Name = "PriMeatJerky";
            PriMeatJerky.Size = new Size(307, 34);
            PriMeatJerky.Text = "Prime Meat Jerky";
            PriMeatJerky.Click += PriMeatJerky_Click;
            // 
            // CookedPrimeFishMeat
            // 
            CookedPrimeFishMeat.Image = (Image)resources.GetObject("CookedPrimeFishMeat.Image");
            CookedPrimeFishMeat.Name = "CookedPrimeFishMeat";
            CookedPrimeFishMeat.Size = new Size(307, 34);
            CookedPrimeFishMeat.Text = "Cooked Prime Fish Meat";
            CookedPrimeFishMeat.Click += CookedPrimeFishMeat_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { ShockDarts, BioToxin, tranqArrow, TranqDarts });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(85, 29);
            toolStripMenuItem2.Text = "Taming";
            // 
            // ShockDarts
            // 
            ShockDarts.Image = (Image)resources.GetObject("ShockDarts.Image");
            ShockDarts.Name = "ShockDarts";
            ShockDarts.Size = new Size(213, 34);
            ShockDarts.Text = "Shock Dart's";
            ShockDarts.Click += ShockDarts_Click;
            // 
            // BioToxin
            // 
            BioToxin.Image = (Image)resources.GetObject("BioToxin.Image");
            BioToxin.Name = "BioToxin";
            BioToxin.Size = new Size(213, 34);
            BioToxin.Text = "Bio Toxin";
            BioToxin.Click += BioToxin_Click;
            // 
            // tranqArrow
            // 
            tranqArrow.Image = (Image)resources.GetObject("tranqArrow.Image");
            tranqArrow.Name = "tranqArrow";
            tranqArrow.Size = new Size(213, 34);
            tranqArrow.Text = "Tranq Arrow";
            tranqArrow.Click += TranqArrow_Click;
            // 
            // TranqDarts
            // 
            TranqDarts.Image = (Image)resources.GetObject("TranqDarts.Image");
            TranqDarts.Name = "TranqDarts";
            TranqDarts.Size = new Size(213, 34);
            TranqDarts.Text = "Tranq Dart's";
            TranqDarts.Click += TranqDarts_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { Element, Tributes, Artifacts });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(122, 29);
            toolStripMenuItem3.Text = "Boss Fight's";
            // 
            // Element
            // 
            Element.Image = (Image)resources.GetObject("Element.Image");
            Element.Name = "Element";
            Element.Size = new Size(179, 34);
            Element.Text = "Element";
            Element.Click += Element_Click;
            // 
            // Tributes
            // 
            Tributes.Image = (Image)resources.GetObject("Tributes.Image");
            Tributes.Name = "Tributes";
            Tributes.Size = new Size(179, 34);
            Tributes.Text = "Tributes";
            Tributes.Click += Tributes_Click;
            // 
            // Artifacts
            // 
            Artifacts.Image = (Image)resources.GetObject("Artifacts.Image");
            Artifacts.Name = "Artifacts";
            Artifacts.Size = new Size(179, 34);
            Artifacts.Text = "Artifacts";
            Artifacts.Click += Artifacts_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel1 });
            statusStrip1.Location = new Point(0, 649);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1262, 32);
            statusStrip1.TabIndex = 16;
            // 
            // statusLabel1
            // 
            statusLabel1.Name = "statusLabel1";
            statusLabel1.Size = new Size(370, 25);
            statusLabel1.Text = "Welcome to Ark SA Copy And Paste Spawner";
            // 
            // QualityAscendent
            // 
            QualityAscendent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QualityAscendent.Location = new Point(1098, 189);
            QualityAscendent.Name = "QualityAscendent";
            QualityAscendent.Size = new Size(112, 53);
            QualityAscendent.TabIndex = 17;
            QualityAscendent.Text = "100";
            QualityAscendent.UseVisualStyleBackColor = true;
            QualityAscendent.Click += QualityAscendent_Click;
            // 
            // howManyBox1
            // 
            howManyBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            howManyBox1.Location = new Point(932, 142);
            howManyBox1.Name = "howManyBox1";
            howManyBox1.Size = new Size(150, 31);
            howManyBox1.TabIndex = 19;
            howManyBox1.Text = "1";
            // 
            // qualityBox1
            // 
            qualityBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            qualityBox1.Location = new Point(932, 200);
            qualityBox1.Name = "qualityBox1";
            qualityBox1.Size = new Size(150, 31);
            qualityBox1.TabIndex = 20;
            qualityBox1.Text = "1";
            // 
            // blueprintBox1
            // 
            blueprintBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            blueprintBox1.AutoSize = true;
            blueprintBox1.Location = new Point(932, 261);
            blueprintBox1.Name = "blueprintBox1";
            blueprintBox1.Size = new Size(126, 29);
            blueprintBox1.TabIndex = 21;
            blueprintBox1.Text = "Is Blueprint";
            blueprintBox1.UseVisualStyleBackColor = true;
            blueprintBox1.CheckedChanged += blueprintBox1_CheckedChanged;
            // 
            // howMany
            // 
            howMany.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            howMany.AutoSize = true;
            howMany.Location = new Point(774, 145);
            howMany.Name = "howMany";
            howMany.Size = new Size(80, 25);
            howMany.TabIndex = 22;
            howMany.Text = "Quantity";
            // 
            // quality
            // 
            quality.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            quality.AutoSize = true;
            quality.Location = new Point(774, 203);
            quality.Name = "quality";
            quality.Size = new Size(140, 25);
            quality.TabIndex = 23;
            quality.Text = "Quality 1 to 100";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(1098, 514);
            button1.Name = "button1";
            button1.Size = new Size(112, 68);
            button1.TabIndex = 24;
            button1.Text = "Paste Or CTRL V";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AcceptButton = addToButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 681);
            Controls.Add(button1);
            Controls.Add(quality);
            Controls.Add(howMany);
            Controls.Add(blueprintBox1);
            Controls.Add(qualityBox1);
            Controls.Add(howManyBox1);
            Controls.Add(QualityAscendent);
            Controls.Add(statusStrip1);
            Controls.Add(setTo100);
            Controls.Add(copyText);
            Controls.Add(addToButton);
            Controls.Add(inputBox1);
            Controls.Add(logBox1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1284, 737);
            Name = "Form1";
            Text = "Ark SA Spawner";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox logBox1;
        private TextBox inputBox1;
        private Button addToButton;
        private Button copyText;
        private Button setTo100;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem MejoBerrys;
        private ToolStripMenuItem CoookedMeat;
        private ToolStripMenuItem Kibble;
        private ToolStripMenuItem PriMeatJerky;
        private ToolStripMenuItem CookedPrimeFishMeat;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem ShockDarts;
        private ToolStripMenuItem BioToxin;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem Element;
        private ToolStripMenuItem Tributes;
        private ToolStripMenuItem Artifacts;
        private Button QualityAscendent;
        private TextBox howManyBox1;
        private TextBox qualityBox1;
        private CheckBox blueprintBox1;
        private Label howMany;
        private Label quality;
        private ToolStripMenuItem tranqArrow;
        private Button button1;
        private ToolStripMenuItem TranqDarts;
    }
}