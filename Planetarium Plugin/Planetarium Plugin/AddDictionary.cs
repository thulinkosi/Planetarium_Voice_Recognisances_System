﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace Planetarium_Plugin
{
    public partial class AddDictionary : UserControl
    {
        PlanetariumDB_API api = new PlanetariumDB_API();
        string dictionaryName = "";
        string location = "";

        public AddDictionary()
        {
            InitializeComponent();
        }

        private void cmdCreateDictionary_Click(object sender, EventArgs e)
        {

            dictionaryName = txtDictionary.Text;

            if (!api.dictionary_exists(dictionaryName))
            {
                if (dictionaryName != "")
                {
                    PowerPoint.Presentation pres = Globals.ThisAddIn.Application.ActivePresentation;
                    
                    string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    location = filePath + "\\Dictionaries\\" + dictionaryName;

                    pres.SaveAs(location, Microsoft.Office.Interop.PowerPoint.PpSaveAsFileType.ppSaveAsDefault, Microsoft.Office.Core.MsoTriState.msoTrue);
                    pres.Save();

                    api.addDictionary(dictionaryName, location + ".pptx");

                    MessageBox.Show("Dictionary added");
                    
                }
            }
            else 
            {
                MessageBox.Show("Already exists");
            }
        }

        private void cmdAddSlide_Click_1(object sender, EventArgs e)
        {
            if (txtPhrase.Text != "")
            {
                if (dictionaryName != "")
                {
                    if (!api.keyword_exists(dictionaryName, txtPhrase.Text))
                    {
                        api.addKeyword(dictionaryName, txtPhrase.Text, Int32.Parse(txtSlideNumber.Tag.ToString()));
                        MessageBox.Show("Slide added");
                    }
                    else
                    {
                        MessageBox.Show("Keyword already exists");
                    }
                }

            }
            else {
                MessageBox.Show("Please enter a keyword");
            }

        }

        private void txtDictionary_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDictionary_Load(object sender, EventArgs e)
        {

        }

        private void cmdFinish_Click(object sender, EventArgs e)
        {
            txtDictionary.Clear();
            txtPhrase.Clear();
        }

        private void txtSlideNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtDictionary.Text != null)
            {
                txtPhrase.Text = api.getKeyword(txtDictionary.Text, Int32.Parse(txtSlideNumber.Tag.ToString()));
            }
        }

        private void txtPhrase_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
