using System.Windows.Forms;
using System;

namespace adpt_xcl_tool
{
    public partial class Form1 : Form
    {
        private OpenFileDialog fileDialog;
        private FolderBrowserDialog folderDialog;
        //private <excel> ExcelFileManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileDialog   = new OpenFileDialog();
            folderDialog = new FolderBrowserDialog();
        }

        private void OriginFile_Btn_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "Excel(2.0-2007)|*.xlsxc;*.xls;*.xlsx;*.xlsb";
            if (fileDialog.ShowDialog() == DialogResult.OK)
                 OriginFile_Path.Text = fileDialog.FileName;
            else OriginFile_Path.Text = string.Empty;
        }

        private void SaveTo_Btn_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
                 SaveTo_Path.Text = folderDialog.SelectedPath;
            else SaveTo_Path.Text = string.Empty;
        }

        private void Execute_btn_Click(object sender, EventArgs e)
        {
            //TODO: call correction method.
        }
    }
}
