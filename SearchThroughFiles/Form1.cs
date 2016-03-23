using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using Code7248.word_reader;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace SearchThroughFiles
{
    public partial class Form1 : Form
    {
        List<string> CVdirs;
        DirectoryInfo dir;
        string[] searchWords;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Search Through Files";
            this.AcceptButton = searchBtn;
            CVdirs = new List<string>();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            resultListBox.Items.Clear();
            CVdirs.Clear();

            if (searWordsTxtBox.Text == "")
            {
                NoSearchWordForm newForm = new NoSearchWordForm();
                newForm.Show();
                return;
            }
            if (directoryTxtBox.Text == "")
            {
                NoDirectoryForm newForm = new NoDirectoryForm();
                newForm.Show();
                return;
            }

            resultListBox.Items.Add("Letar...");

            int endofDir = directoryTxtBox.Text.Length;
            if (directoryTxtBox.Text[endofDir - 1] != '\\' && directoryTxtBox.Text[endofDir - 1] != '/')
            {
                directoryTxtBox.Text += '\\';
            }

            string searchToLower = searWordsTxtBox.Text.ToLower();

            searchWords = searchToLower.Split(' ');

            SearchAllFilesAndDirectories(directoryTxtBox.Text);

            resultListBox.Items.RemoveAt(0);

            if (CVdirs.Count == 0) { }
                resultListBox.Items.Add("Hittade inga träffar.");

            Cursor.Current = Cursors.Default;
        }

        private bool StringContains(string p_sText, string[] p_sWords)
        {
            char[] delimiters = { ' ', ',', '.', '-', '_', ':', ';', '/', '?', '\\', '=', '!', '"', '#', '@', '%', '&', '(', ')', '[', ']', '{', '}', '<', '>', '*', '|' };
            
            string[] text = p_sText.Split(delimiters);


            foreach (string searchWord in p_sWords)
            {
                bool wordfound = false;

                foreach(string word in text)
                {
                    if(word == searchWord)
                    {
                        wordfound = true;
                        break;
                    }
                }
                if (!wordfound)
                    return false;
            }
            return true;
        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                resultDirectoryTxtBox.Text = CVdirs[resultListBox.SelectedIndex];
            }
            catch
            {
                Console.WriteLine("Not a file.");
            }
        }

        private void SearchAllFilesAndDirectories(string p_sPath)
        {
            string[] subfolders = Directory.GetDirectories(p_sPath);
            for (int i = 0; i < subfolders.Length; i++)
            {
                subfolders[i] += '\\';
                SearchAllFilesAndDirectories(subfolders[i]);
            }

            //search files docs
            SearchForDocFiles(p_sPath);
            //search files pdfs
            SearchForPDFFiles(p_sPath);
        }

        private void SearchForDocFiles(string p_sPath)
        {
            FileInfo[] Files;
            try
            {
                dir = new DirectoryInfo(@p_sPath);
                Files = dir.GetFiles("*.doc");
            }
            catch
            {
                InvalidDirectory dirForm = new InvalidDirectory();
                dirForm.Show();
                return;
            }

            foreach (FileInfo file in Files)
            {
                string fileName = dir.ToString() + file.ToString();
                try
                {
                    TextExtractor extractor = new TextExtractor(fileName);
                    string text = extractor.ExtractText();
                    string textToLower = text.ToLower();

                    if (StringContains(textToLower, searchWords))
                    {
                        resultListBox.Items.Add(file.ToString());
                        CVdirs.Add(fileName);
                    }
                }
                catch
                {
                    Console.WriteLine("could not open file: " + fileName);
                }
            }
        }

        private void SearchForPDFFiles(string p_sPath)
        {
            FileInfo[] Files;

            try
            {
                dir = new DirectoryInfo(@p_sPath);
                Files = dir.GetFiles("*.pdf");
            }
            catch
            {
                InvalidDirectory dirForm = new InvalidDirectory();
                dirForm.Show();
                return;
            }
            

            foreach (FileInfo file in Files)
            {
                string fileName = dir.ToString() + file.ToString();
                try
                {
                    PdfReader reader = new PdfReader(fileName);
                    StringBuilder text = new StringBuilder();
                    for (int page = 1; page <= reader.NumberOfPages; page++)
                    {
                        text.Append(PdfTextExtractor.GetTextFromPage(reader, page));
                    }
                    string textToLower = text.ToString().ToLower();

                    if (StringContains(textToLower, searchWords))
                    {
                        resultListBox.Items.Add(file.ToString());
                        CVdirs.Add(fileName);
                    }
                }

                catch
                {
                    Console.WriteLine("could not open file: " + fileName);
                }
            }
        }
    }
}
