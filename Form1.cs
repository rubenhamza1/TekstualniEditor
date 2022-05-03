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

namespace TekstualniEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
            SaveFileDialog filesave1 = new SaveFileDialog();
            DialogResult result = filesave1.ShowDialog();
            
            filesave1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            filesave1.Title = "Save a text file";
            filesave1.ShowDialog();
            string path1 = Path.GetFileName(filesave1.FileName);

            if (filesave1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)filesave1.OpenFile();

                if (result == DialogResult.OK)
                {
                    File.WriteAllText(path1, filesave1.FileName);

                }

            }
            
           
        }
    }
}
