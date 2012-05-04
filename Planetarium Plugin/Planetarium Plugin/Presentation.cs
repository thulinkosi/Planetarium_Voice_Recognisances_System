using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.Speech.Recognition;

namespace Planetarium_Plugin
{
    public partial class Presentation : UserControl
    {
        PlanetariumDB_API api = new PlanetariumDB_API();
        string dictionaryName;
        string location;
        string phrase;
        public bool enableNotification = false;
        public Presentation()
        {
            InitializeComponent();
        }

        private void Presentation_Load(object sender, EventArgs e)
        {
            List<Dictionary> dic = api.getAllDictionaries();

            if (cmdDictionary.Items.Count != 0)
            {
                cmdDictionary.Items.Clear();
            }

            foreach (Dictionary d in dic)
            {
                cmdDictionary.Items.Add(d.Type);
            }
        }

        private void cmdDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {

            location = api.getDictionary(cmdDictionary.SelectedItem.ToString()).Slide_URL;
            dictionaryName = cmdDictionary.SelectedItem.ToString();

        }

        private void smdStartPresentation_Click(object sender, EventArgs e)
        {
            try
            {
                SpeechRecognitionEngine sr = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-GB"));
                SpeechRecognition speech = new SpeechRecognition(sr, api.getAllStringKeywordsInDictionary(cmdDictionary.SelectedItem.ToString()), location, dictionaryName);
                speech.Start();
            }
            catch (NullReferenceException)
            {

            }
        }

        private void cmdDictionary_Click(object sender, EventArgs e)
        {
            List<Dictionary> dic = api.getAllDictionaries();

            if (cmdDictionary.Items.Count != 0)
            {
                cmdDictionary.Items.Clear();
            }

            foreach (Dictionary d in dic)
            {
                cmdDictionary.Items.Add(d.Type);
            }
        }

        private void rdbEnableNotifications_CheckedChanged(object sender, EventArgs e)
        {
           
            enableNotification = true;
        }

        private void rdbDisableNotifications_CheckedChanged(object sender, EventArgs e)
        {
            enableNotification = false;
        }
    }
}
