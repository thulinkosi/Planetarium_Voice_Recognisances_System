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
    public partial class UpdateDictionary : UserControl
    {
        PlanetariumDB_API api = new PlanetariumDB_API();
        private string keyword = string.Empty;
        public UpdateDictionary()
        {
            InitializeComponent();
        }

        private void cmbDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            PowerPoint.Presentation presentation;

            string dictionaryName = cmbDictionary.SelectedItem.ToString();
            string location = api.getDictionary(dictionaryName).Slide_URL;
            presentation = Globals.ThisAddIn.Application.Presentations.Open(location);
        }


        private void UpdateDictionary_Load_1(object sender, EventArgs e)
        {
            
            List<Dictionary> dic = api.getAllDictionaries();

            if (cmbDictionary.Items.Count != 0)
            {
                cmbDictionary.Items.Clear();
            }

            foreach (Dictionary d in dic)
            {
                cmbDictionary.Items.Add(d.Type);
            }
        }

        private void reload()
        {
            List<Dictionary> dic = api.getAllDictionaries();

            if (cmbDictionary.Items.Count != 0)
            {
                cmbDictionary.Items.Clear();
            }

            cmbDictionary.Items.Add("");

            foreach (Dictionary d in dic)
            {
                cmbDictionary.Items.Add(d.Type);
            }

            cmbDictionary.SelectedIndex = 0;
        }

        private void txtSlideNumber_TextChanged_1(object sender, EventArgs e)
        {
            if (cmbDictionary.SelectedItem != null)
            {
                txtKeyword.Text = api.getKeyword(cmbDictionary.SelectedItem.ToString(), Int32.Parse(txtSlideNumber.Tag.ToString()));
                keyword = txtKeyword.Text;
            }
        }

        private void cmdUpdateDictionary_Click(object sender, EventArgs e)
        {
            api.updateKeywordPhrase(keyword, txtKeyword.Text, cmbDictionary.SelectedItem.ToString());

            txtKeyword.Text = api.getKeyword(cmbDictionary.SelectedItem.ToString(), Int32.Parse(txtSlideNumber.Tag.ToString()));

            MessageBox.Show("Keyword Updated");
        }

        private void cmbDictionary_Click(object sender, EventArgs e)
        {
            reload();
            List<Dictionary> dic = api.getAllDictionaries();

            if (cmbDictionary.Items.Count != 0)
            {
                cmbDictionary.Items.Clear();
            }

            foreach (Dictionary d in dic)
            {
                cmbDictionary.Items.Add(d.Type);
            }
        }

        private void cmdFinish_Click(object sender, EventArgs e)
        {
            cmbDictionary.SelectedIndex = -1;
        }

        private void cmbDictionary_Click_1(object sender, EventArgs e)
        {
            List<Dictionary> dic = api.getAllDictionaries();

            cmbDictionary.Items.Clear();

            foreach (Dictionary d in dic)
            {
                cmbDictionary.Items.Add(d.Type);
            }
        }


    }
}
