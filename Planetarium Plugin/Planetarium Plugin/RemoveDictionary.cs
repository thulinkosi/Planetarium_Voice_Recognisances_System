﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Planetarium_Plugin
{
    public partial class RemoveDictionary : UserControl
    {
        PlanetariumDB_API api = new PlanetariumDB_API();
        private string dictionary = string.Empty;

        public RemoveDictionary()
        {
            InitializeComponent();
        }

        private void cmdRemoveDictionary_Click(object sender, EventArgs e)
        {
            PlanetariumDB_API api = new PlanetariumDB_API();

            if (cmbDictionary.SelectedIndex != -1)
            {
                api.removeDictionary(cmbDictionary.SelectedItem.ToString());
            }

            reload();
            MessageBox.Show("Dictionary deleted");
       }

        private void RemoveDictionary_Load(object sender, EventArgs e)
        {
            reload();
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

        private void cmbDictionary_Click(object sender, EventArgs e)
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
