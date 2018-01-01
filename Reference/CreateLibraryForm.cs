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

namespace Reference
{
    public partial class CreateLibraryForm : Form
    {

        public CreateLibraryForm()
        {
            InitializeComponent();
            lStatus.Text = "Введите название";
            lStatus.ForeColor = Color.Orange;
            bCreate.Enabled = false;
            bEdit.Enabled = false;
            bDelete.Enabled = false;
            if (!Directory.Exists("Library"))
            {
                Directory.CreateDirectory("Library");
                MessageBox.Show("Основной папки с библиотеками не нашлось,\nпо этому была создана новая.", "Отсутствие папки!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm transForm = new StartForm();
            transForm.ShowDialog();
            Close();
        }

        private void tbNameLib_TextChanged(object sender, EventArgs e)
        {
            CheckLib();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            tbNameLib.Enabled = false;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить\n\"" + tbNameLib.Text + "\"?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Directory.Delete(@"Library\" + tbNameLib.Text);
                tbNameLib.Text = "";
            }
            tbNameLib.Enabled = true;
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"Library\" + tbNameLib.Text);
            CheckLib();
        }

        private void CheckLib()
        {
            if (tbNameLib.Text == "")
            {
                lStatus.Text = "Введите название";
                lStatus.ForeColor = Color.Orange;
                bCreate.Enabled = false;
                bEdit.Enabled = false;
                bDelete.Enabled = false;
            }
            else if (Directory.Exists(@"Library\" + tbNameLib.Text))
            {
                lStatus.Text = "Уже существует";
                lStatus.ForeColor = Color.Red;
                bCreate.Enabled = false;
                bEdit.Enabled = true;
                bDelete.Enabled = true;
            }
            else
            {
                lStatus.Text = "Можно создать";
                lStatus.ForeColor = Color.Green;
                bCreate.Enabled = true;
                bEdit.Enabled = false;
                bDelete.Enabled = false;
            }
        }
    }
}
