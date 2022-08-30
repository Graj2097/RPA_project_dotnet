using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE
{

    public partial class FrmMain : Form
    {
        int splitDis = 0;
        DataTable dt = new DataTable();
        [System.Runtime.InteropServices.DllImport("shell32. dll")]
        private static extern long ShellExecute(Int32 hWnd, string lpOperation,
                                           string lpFile, string lpParameters,
                                               string lpDirectory, long nShowCmd);
        FrmPdfViewer frm = new FrmPdfViewer("");

        string path = string.Empty;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.ExecutablePath.Replace(@"bin\Debug\IDE.exe", @"");
            path = path.Replace(@"bin\Release\IDE.exe", @"");
            axAcroPDF1.LoadFile(path + @"App\blank.pdf");

            dgvData.DataSource = null;

            dt = new DataTable();

            dt.Columns.Add("DataID");
            dt.Columns.Add("Field");
            dt.Columns.Add("Section");
            dt.Columns.Add("Value");

            DataRow dr = dt.NewRow();
            dr["DataID"] = "k4"; dr["Field"] = "Street Number"; dr["Section"] = "Summary"; dr["Value"] = "";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["DataID"] = "k5"; dr["Field"] = "City"; dr["Section"] = "Subject Info"; dr["Value"] = "";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["DataID"] = "k6"; dr["Field"] = "State"; dr["Section"] = "Summary,Subject Info"; dr["Value"] = "";
            dt.Rows.Add(dr);
            
            dr = dt.NewRow();
            dr["DataID"] = "k7"; dr["Field"] = "Zip"; dr["Section"] = " Income Approach"; dr["Value"] = "";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["DataID"] = "k8"; dr["Field"] = "Country"; dr["Section"] = "Appendix"; dr["Value"] = "";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["DataID"] = "k9"; dr["Field"] = "Property Name"; dr["Section"] = "Summary, Certification, Reconciliation"; dr["Value"] = "";
            dt.Rows.Add(dr);

            dgvData.DataSource = dt;

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "PDF Files |*.pdf";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                axAcroPDF1.LoadFile(path);
            }

            axAcroPDF1.AllowDrop = true;

        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(new object(),null);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //axAcroPDF1.Dispose();
            string _path = Application.ExecutablePath.Replace(@"bin\Debug\IDE.exe", @"");
            _path = _path.Replace(@"bin\Release\IDE.exe", @"");
            axAcroPDF1.LoadFile(_path + @"App\blank.pdf");
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            closeToolStripMenuItem_Click(new object(), null);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            axAcroPDF1.Dispose();
        }

        private void openInNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm = new FrmPdfViewer(path);
            frm.Show();

            splitDis = splitContainer1.SplitterDistance;
            splitContainer1.SplitterDistance = 0;
            splitContainer1.Panel1.Hide();
        }

        private void singleWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Show();
            splitContainer1.SplitterDistance = splitDis;
            frm.Close();
        }

        private void toolStripButtonSingleScreen_Click(object sender, EventArgs e)
        {
            singleWindowToolStripMenuItem_Click(new object(), null);
        }

        private void toolStripMultiScreen_Click(object sender, EventArgs e)
        {
            openInNewWindowToolStripMenuItem_Click(new object(), null);
        }
    }
}
