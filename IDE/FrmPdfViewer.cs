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
    public partial class FrmPdfViewer : Form
    {
        string path = string.Empty;
        private bool isOpen = false;
        public bool IsOpen
        {
            get
            {
                return isOpen;
            }
            set
            {
                isOpen = value;
            }   
        }
        public FrmPdfViewer()
        {
            InitializeComponent();
            IsOpen = false;
        }
        public FrmPdfViewer(string _path)
        {
            InitializeComponent();
            IsOpen = true;
            path = _path;
        }

        private void FrmPdfViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOpen = false;
            //axAcroPDF1.Dispose();
        }

        private void FrmPdfViewer_Load(object sender, EventArgs e)
        {
            //axAcroPDF1.LoadFile(path);
        }
    }
}
