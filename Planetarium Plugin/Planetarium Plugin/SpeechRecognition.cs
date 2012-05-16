using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Recognition;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;


namespace Planetarium_Plugin
{
    class SpeechRecognition
    {
        PlanetariumDB_API api = new PlanetariumDB_API();
        private SpeechRecognitionEngine Sr;
        private List<string> keywords;
        private string dictionaryName;
        private string location;
        private Microsoft.Office.Interop.PowerPoint.Presentation pres;


        public SpeechRecognition(SpeechRecognitionEngine sr, List<string> words, string location, string dictionaryName)
        {
            this.location = location;
            this.dictionaryName = dictionaryName;
            Sr = sr;
            Sr.SetInputToDefaultAudioDevice();
            keywords = words;
            Grammar g = BuildGrammar();
            Sr.LoadGrammar(g);
        }

        public Grammar BuildGrammar()
        {
            GrammarBuilder gB = new GrammarBuilder(); gB.Culture = new System.Globalization.CultureInfo("en-GB");
            gB.Append(getGrammar());
            Grammar g = new Grammar(gB);
            return g;
        }

        void sr_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence >= 0.75)
            {
                string temp = e.Result.Text.ToLower();
                    ShowSlides(temp);
   
            }
        }



        public Choices getGrammar()
        {
            Choices grammar = new Choices();
            int a = keywords.Count();
            string[] temp = new string[a];
            for (int i = 0; i < a; i++)
            {
                temp[i] = keywords[i];
            }
            grammar.Add(temp);
            return grammar;
        }

        public void Start()
        {
            Sr.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sr_SpeechRecognized);
            Sr.RecognizeAsync(RecognizeMode.Multiple);
            pres = Globals.ThisAddIn.Application.Presentations.Open(location, Office.MsoTriState.msoFalse, Office.MsoTriState.msoFalse, Office.MsoTriState.msoTrue);
            pres = Globals.ThisAddIn.Application.ActivePresentation;
            pres.SlideShowSettings.Run();
        }

        public void ShowSlides(string phrase)
        {
            int id = api.getKeyword(dictionaryName, phrase).Slide_Num;
            int index = 0;

            if (pres != null)
            {
                try
                {
                    foreach (PowerPoint.Slide slide in pres.Slides)
                    {
                       
                        if (id != 0)
                        {
                            if (id == slide.SlideID)
                            {
                                index = slide.SlideIndex;
                                if (index != 0)
                                {

                                    pres.SlideShowWindow.View.GotoSlide(index);
                                }
                            }
                        }
                    }
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {


                }
            }
        }


        public void Pause()
        {
            Sr.RecognizeAsyncStop();
        }

        public void Stop()
        {
            Sr.RecognizeAsyncStop();
            Sr.UnloadAllGrammars();
        }
    }
}
