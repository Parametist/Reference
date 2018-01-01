using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reference
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCreateLibrary_Click(object sender, EventArgs e)
        {
            Hide();
            CreateLibraryForm CrtLib = new CreateLibraryForm();
            CrtLib.ShowDialog();
            Close();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {

        }

        private void bSupplementLibrary_Click(object sender, EventArgs e)
        {
            Hide();
            SupplementLibraryForm form = new SupplementLibraryForm();
            form.ShowDialog();
            Close();
        }
    }
}
