namespace Planetarium_Plugin
{
    partial class MainMenu : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainMenu()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.PlanetariumPlugin = this.Factory.CreateRibbonTab();
            this.Presentation = this.Factory.CreateRibbonGroup();
            this.cmdStart = this.Factory.CreateRibbonButton();
            this.Dictionaries = this.Factory.CreateRibbonGroup();
            this.cmdAddDictionary = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.cmdUpdateDictionary = this.Factory.CreateRibbonButton();
            this.cmdDeleteDictionary = this.Factory.CreateRibbonButton();
            this.cmdAboutUs = this.Factory.CreateRibbonButton();
            this.cmdHelp = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.PlanetariumPlugin.SuspendLayout();
            this.Presentation.SuspendLayout();
            this.Dictionaries.SuspendLayout();
            this.group2.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // PlanetariumPlugin
            // 
            this.PlanetariumPlugin.Groups.Add(this.Presentation);
            this.PlanetariumPlugin.Groups.Add(this.Dictionaries);
            this.PlanetariumPlugin.Groups.Add(this.group2);
            this.PlanetariumPlugin.Label = "Planetarium Plugin";
            this.PlanetariumPlugin.Name = "PlanetariumPlugin";
            // 
            // Presentation
            // 
            this.Presentation.Items.Add(this.cmdStart);
            this.Presentation.Label = "Presentation";
            this.Presentation.Name = "Presentation";
            // 
            // cmdStart
            // 
            this.cmdStart.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.cmdStart.Image = global::Planetarium_Plugin.Properties.Resources._1335947130_gallery;
            this.cmdStart.Label = "Start";
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.ShowImage = true;
            this.cmdStart.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cmdStart_Click);
            // 
            // Dictionaries
            // 
            this.Dictionaries.Items.Add(this.cmdAddDictionary);
            this.Dictionaries.Items.Add(this.cmdUpdateDictionary);
            this.Dictionaries.Items.Add(this.cmdDeleteDictionary);
            this.Dictionaries.Label = "Dictionaries";
            this.Dictionaries.Name = "Dictionaries";
            // 
            // cmdAddDictionary
            // 
            this.cmdAddDictionary.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.cmdAddDictionary.Image = global::Planetarium_Plugin.Properties.Resources._1335947111_theme_editor;
            this.cmdAddDictionary.Label = "Add";
            this.cmdAddDictionary.Name = "cmdAddDictionary";
            this.cmdAddDictionary.ShowImage = true;
            this.cmdAddDictionary.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cmdAddDictionary_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.cmdAboutUs);
            this.group2.Items.Add(this.cmdHelp);
            this.group2.Label = "Other";
            this.group2.Name = "group2";
            // 
            // cmdUpdateDictionary
            // 
            this.cmdUpdateDictionary.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.cmdUpdateDictionary.Image = global::Planetarium_Plugin.Properties.Resources._1335950538_folder_updates;
            this.cmdUpdateDictionary.Label = "Update";
            this.cmdUpdateDictionary.Name = "cmdUpdateDictionary";
            this.cmdUpdateDictionary.ShowImage = true;
            this.cmdUpdateDictionary.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cmdUpdateDictionary_Click);
            // 
            // cmdDeleteDictionary
            // 
            this.cmdDeleteDictionary.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.cmdDeleteDictionary.Image = global::Planetarium_Plugin.Properties.Resources._1335950901_mac_trashcan_full_new;
            this.cmdDeleteDictionary.Label = "Delete";
            this.cmdDeleteDictionary.Name = "cmdDeleteDictionary";
            this.cmdDeleteDictionary.ShowImage = true;
            this.cmdDeleteDictionary.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cmdDeleteDictionary_Click);
            // 
            // cmdAboutUs
            // 
            this.cmdAboutUs.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.cmdAboutUs.Image = global::Planetarium_Plugin.Properties.Resources._1335950591_Information;
            this.cmdAboutUs.Label = "About Us";
            this.cmdAboutUs.Name = "cmdAboutUs";
            this.cmdAboutUs.ShowImage = true;
            // 
            // cmdHelp
            // 
            this.cmdHelp.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.cmdHelp.Image = global::Planetarium_Plugin.Properties.Resources._1335950564_Help_and_Support;
            this.cmdHelp.Label = "Help";
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.ShowImage = true;
            this.cmdHelp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cmdHelp_Click);
            // 
            // MainMenu
            // 
            this.Name = "MainMenu";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.PlanetariumPlugin);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MainMenu_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.PlanetariumPlugin.ResumeLayout(false);
            this.PlanetariumPlugin.PerformLayout();
            this.Presentation.ResumeLayout(false);
            this.Presentation.PerformLayout();
            this.Dictionaries.ResumeLayout(false);
            this.Dictionaries.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        private Microsoft.Office.Tools.Ribbon.RibbonTab PlanetariumPlugin;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Presentation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cmdStart;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Dictionaries;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cmdAddDictionary;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cmdUpdateDictionary;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cmdDeleteDictionary;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cmdAboutUs;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton cmdHelp;
    }

    partial class ThisRibbonCollection
    {
        internal MainMenu MainMenu
        {
            get { return this.GetRibbon<MainMenu>(); }
        }
    }
}
