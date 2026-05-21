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


namespace TSVFileReaderProgram
{
    public partial class frmTSVFile : Form
    {
        public frmTSVFile()
        {
            InitializeComponent();
        }
        private void frmTSVFile_Load(object sender, EventArgs e)
        {
            lvwWord.Columns.Add("單字", 100);
            lvwWord.Columns.Add("音標", 100);
            lvwWord.Columns.Add("音檔路徑", 160);
            lvwWord.Columns.Add("解釋", 300);

            tsslMessage.Text = "請開啟檔案";
        }
        private void mnsWord_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TSV files (*.tsv)|*.tsv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.Title = "開啟檔案";
            ofd.InitialDirectory = Application.StartupPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);

                lvwWord.Items.Clear();
                lvwWord.BeginUpdate();

                foreach (string line in lines)
                {
                    string[] data = line.Split('\t');

                    if (data.Length >= 4)
                    {
                        ListViewItem item = new ListViewItem(data[0]);
                        item.SubItems.Add(data[1]);
                        item.SubItems.Add(data[2]);
                        item.SubItems.Add(data[3]);

                        lvwWord.Items.Add(item);
                    }
                }

                lvwWord.EndUpdate();
                tsslMessage.Text = $"已載入 {lvwWord.Items.Count} 筆資料";
            }
        }
        private void 檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
                                 

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {

        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "TSV資料檔讀取程式\n作者：你的名字\n版本：1.0",
                "關於",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void lvwWord_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ssrWord_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmTSVFile_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

     
    }
}
