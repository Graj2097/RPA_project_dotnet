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
    public partial class MDIParentMain : Form
    {
        [System.Runtime.InteropServices.DllImport("shell32. dll")]
        private static extern long ShellExecute(Int32 hWnd, string lpOperation,
                                          string lpFile, string lpParameters,
                                              string lpDirectory, long nShowCmd);
        private int childFormNumber = 0;
        DataTable dt = new DataTable();
        FrmPdfViewer frm = new FrmPdfViewer();
        int splitDis = 0;
        string path = string.Empty;
        public MDIParentMain()
        {
            InitializeComponent();
        }
        private void MDIParentMain_Load(object sender, EventArgs e)
        {
            int s = splitContainer1.Width;
            splitContainer1.SplitterDistance = s/2;

            //string path = Application.ExecutablePath.Replace(@"bin\Debug\IDE.exe", @"");
            //path = path.Replace(@"bin\Release\IDE.exe", @"");
            //axAcroPDF1.LoadFile(path + @"App\blank.pdf");

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
        private void ShowNewForm(object sender, EventArgs e)
        {
            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            //childForm.Show();

            string path = Application.ExecutablePath.Replace(@"bin\Debug\IDE.exe", @"");
            path = path.Replace(@"bin\Release\IDE.exe", @"");
            axAcroPDF1.LoadFile(path + @"App\blank.pdf");
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                axAcroPDF1.LoadFile(path);
            }
            //temp
            //axAcroPDF1.setCurrentPage
            //temp
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            //if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = saveFileDialog.FileName;
            //}
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripOneScreen_Click(object sender, EventArgs e)
        {
            if (frm.IsOpen)
            {
                splitContainer1.Panel1.Show();
                splitContainer1.SplitterDistance = splitDis;
                frm.Close();
            }
            else
            {
                splitContainer1.Panel1.Show();
                //axAcroPDF1.LoadFile(path);

                int s = splitContainer1.Width;
                splitContainer1.SplitterDistance = s / 2;
            }
        }

        private void toolStripTwoScreen_Click(object sender, EventArgs e)
        {
            if (frm.IsOpen == false)
            {
                frm = new FrmPdfViewer(path);
                frm.Show();

                splitDis = splitContainer1.SplitterDistance;
                splitContainer1.SplitterDistance = 0;
                splitContainer1.Panel1.Hide();
            }
        }

        private void toolStripSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            //frmSettings.MdiParent = this;
            frmSettings.ShowDialog();
        }

        private void toolStripExport_Click(object sender, EventArgs e)
        {

        }
    }
}
