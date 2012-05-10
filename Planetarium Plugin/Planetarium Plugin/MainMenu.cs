using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Tools = Microsoft.Office.Tools;
using Office = Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace Planetarium_Plugin
{
    public partial class MainMenu
    {
        PlanetariumDB_API api = new PlanetariumDB_API();
        Tools.CustomTaskPane presentation;
        Tools.CustomTaskPane addDictionary;
        Tools.CustomTaskPane removeDictionary;
        Tools.CustomTaskPane updateDictionary;

        Presentation presentations = new Presentation();
        AddDictionary addDictionaries = new AddDictionary();
        RemoveDictionary removeDictionaries = new RemoveDictionary();
        UpdateDictionary updateDictionaries = new UpdateDictionary();

        private void MainMenu_Load(object sender, RibbonUIEventArgs e)
        {
            presentation = Globals.ThisAddIn.CustomTaskPanes.Add(presentations, "Presentation");
            addDictionary = Globals.ThisAddIn.CustomTaskPanes.Add(addDictionaries, "Add Dictionaries");
            removeDictionary = Globals.ThisAddIn.CustomTaskPanes.Add(removeDictionaries, "Remove Dictionaries");
            updateDictionary = Globals.ThisAddIn.CustomTaskPanes.Add(updateDictionaries, "Update Dictionaries");

            //Slide change event handler
            try
            {
                Globals.ThisAddIn.Application.SlideSelectionChanged += Application_SlideSelectionChanged;
            }
            catch (AccessViolationException ex)
            {
                
                
            }
           
        }

        //slide change function
        void Application_SlideSelectionChanged(PowerPoint.SlideRange SldRange) 
        {
            try
           {
                if (SldRange != null )
                {
                    addDictionaries.showSlideNumber(SldRange.SlideID.ToString(), SldRange.SlideNumber.ToString());
                    updateDictionaries.showSlideNumber(SldRange.SlideID.ToString(), SldRange.SlideNumber.ToString());
                }
           }
            catch (AccessViolationException avEx)
            {

           }
           catch (Exception ex) 
           {

            }
        }

        private void cmdStart_Click(object sender, RibbonControlEventArgs e)
        {
            addDictionary.Visible = false;
            removeDictionary.Visible = false;
            updateDictionary.Visible = false;
            presentation.Visible = true;
        }

        private void cmdAddDictionary_Click(object sender, RibbonControlEventArgs e)
        {
            removeDictionary.Visible = false;
            updateDictionary.Visible = false;
            presentation.Visible = false;
            addDictionary.Visible = true;
        }

        private void cmdUpdateDictionary_Click(object sender, RibbonControlEventArgs e)
        {
            removeDictionary.Visible = false;
            presentation.Visible = false;
            addDictionary.Visible = false;
            updateDictionary.Visible = true;
        }

        private void cmdDeleteDictionary_Click(object sender, RibbonControlEventArgs e)
        {
            presentation.Visible = false;
            addDictionary.Visible = false;
            updateDictionary.Visible = false;
            removeDictionary.Visible = true;
        }

        private void cmdHelp_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("\\myPVRS.chm");
        }
        
    }
}
