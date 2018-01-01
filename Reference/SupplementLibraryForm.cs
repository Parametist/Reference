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
    public partial class SupplementLibraryForm : Form
    {

        string[] directories;
        string[] files;

        string fullDesc = "";

        public SupplementLibraryForm()
        {
            InitializeComponent();
            lStatus.Text = "Введите название\nВведите тег(и)\nВыберите библиотеку";
            lStatus.ForeColor = Color.Red;
            bNext.Enabled = false;
            tbPartialDesc.Enabled = false;
            tbFullDesc.Enabled = false;
            bSave.Enabled = false;
            bClear.Enabled = false;
            bChange.Enabled = false;
            directories = Directory.GetDirectories("Library");
            int i = 0;
            foreach (string s in directories)
            {
                directories[i] = s.Substring(8);
                i++;
            }
            foreach (string s in directories)
            {
                cbLibs.Items.Add(s);
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if ((tbName.Text == "") && (tbTags.Text == "") && (cbLibs.Text == ""))
            {
                lStatus.Text = "Введите название\nВведите тег(и)\nВыберите библиотеку";
                lStatus.ForeColor = Color.Red;
                bNext.Enabled = false;
                tbPartialDesc.Enabled = false;
                tbFullDesc.Enabled = false;
                bSave.Enabled = false;
            }
            else if ((tbName.Text != "") && (tbTags.Text == "") && (cbLibs.Text == ""))
            {
                lStatus.Text = "Введите тег(и)\nВыберите библиотеку";
                FalseAct();
            }
            else if ((tbName.Text == "") && (tbTags.Text != "") && (cbLibs.Text == ""))
            {
                lStatus.Text = "Введите название\nВыберите библиотеку";
                FalseAct();
            }
            else if ((tbName.Text == "") && (tbTags.Text == "") && (cbLibs.Text != ""))
            {
                lStatus.Text = "Введите название\nВведите тег(и)";
                FalseAct();
            }
            else if ((tbName.Text != "") && (tbTags.Text == "") && (cbLibs.Text != ""))
            {
                lStatus.Text = "Введите тег(и)";
                FalseAct();
            }
            else if ((tbName.Text != "") && (tbTags.Text != "") && (cbLibs.Text == ""))
            {
                lStatus.Text = "Выберите библиотеку";
                FalseAct();
            }
            else if ((tbName.Text == "") && (tbTags.Text != "") && (cbLibs.Text != ""))
            {
                lStatus.Text = "Выберите название";
                FalseAct();
            }
            else
            {
                lStatus.Text = "Можно продолжить";
                lStatus.ForeColor = Color.Green;
                bNext.Enabled = true;
            }
        }

        private void FalseAct()
        {
            lStatus.ForeColor = Color.Red;
            bNext.Enabled = false;
            tbPartialDesc.Enabled = false;
            tbFullDesc.Enabled = false;
            bSave.Enabled = false;
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            if (CheckLib() == true)
            {
                files = Directory.GetFiles("Library\\" + cbLibs.Text);
                if (CheckFiles() == false)
                {
                    tbPartialDesc.Enabled = true;
                    tbFullDesc.Enabled = true;
                    bClear.Enabled = true;
                    tbName.Enabled = false;
                    tbTags.Enabled = false;
                    cbLibs.Enabled = false;
                    bChange.Enabled = true;
                    if (tbPartialDesc.Text != "")
                        bSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Описание с данным именем уже существует!\nЗапишите другое имя.", "Ошибка имени", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Указанной библиотеки не существует.\nУкажите существующую библиотеку.", "Ошибка продолжения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckLib()
        {
            bool rez = false;
            foreach (string s in directories)
            {
                if (s == cbLibs.Text)
                    rez = true;
            }
            return rez;
        }

        private bool CheckFiles()
        {
            bool rez = false;
            int i = 0;
            
            foreach (string s in files)
            {
                files[i] = s.Substring(9 + cbLibs.Text.Length);
                i++;
            }
            foreach (string s in files)
            {
                if (tbName.Text + ".txt" == s)
                    rez = true;
            }
            return rez;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm form = new StartForm();
            form.ShowDialog();
            Close();
        }

        private void tbPartialDesc_TextChanged(object sender, EventArgs e)
        {
            if (tbPartialDesc.Text != "")
            {
                bSave.Enabled = true;
            }
            else
            {
                bSave.Enabled = false;
            }
        }

        private void tbFullDesc_TextChanged(object sender, EventArgs e)
        {
            fullDesc = tbFullDesc.Text;
        }

        private void tbFullDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fullDesc += '\n';
            }
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            tbPartialDesc.Enabled = false;
            tbFullDesc.Enabled = false;
            tbName.Enabled = true;
            tbTags.Enabled = true;
            cbLibs.Enabled = true;
            bSave.Enabled = false;
            bChange.Enabled = false;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            tbTags.Text = "";
            cbLibs.Text = "";
            tbPartialDesc.Text = "";
            tbFullDesc.Text = "";
            fullDesc = "";
            tbName.Enabled = true;
            tbTags.Enabled = true;
            cbLibs.Enabled = true;
            bChange.Enabled = false;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("Library\\" + cbLibs.Text + "\\" + tbName.Text + ".txt");
            writer.WriteLine("Name: " + tbName.Text);
            writer.WriteLine("Tags: " + tbTags.Text);
            writer.WriteLine("Partial description: " + tbPartialDesc.Text);
            writer.WriteLine("Full description:");
            writer.WriteLine(fullDesc);
            writer.Close();

        }
    }
}
