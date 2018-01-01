namespace Reference
{
    partial class CreateLibraryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLibraryForm));
            this.tlpCrtLibrary = new System.Windows.Forms.TableLayoutPanel();
            this.flpCreateNameLibrary = new System.Windows.Forms.FlowLayoutPanel();
            this.lNameLib = new System.Windows.Forms.Label();
            this.tbNameLib = new System.Windows.Forms.TextBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.flpManagementCrtLib = new System.Windows.Forms.FlowLayoutPanel();
            this.bBack = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.tlpCrtLibrary.SuspendLayout();
            this.flpCreateNameLibrary.SuspendLayout();
            this.flpManagementCrtLib.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCrtLibrary
            // 
            this.tlpCrtLibrary.ColumnCount = 1;
            this.tlpCrtLibrary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCrtLibrary.Controls.Add(this.flpCreateNameLibrary, 0, 0);
            this.tlpCrtLibrary.Controls.Add(this.flpManagementCrtLib, 0, 1);
            this.tlpCrtLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCrtLibrary.Location = new System.Drawing.Point(0, 0);
            this.tlpCrtLibrary.Name = "tlpCrtLibrary";
            this.tlpCrtLibrary.RowCount = 2;
            this.tlpCrtLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCrtLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCrtLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCrtLibrary.Size = new System.Drawing.Size(463, 66);
            this.tlpCrtLibrary.TabIndex = 0;
            // 
            // flpCreateNameLibrary
            // 
            this.flpCreateNameLibrary.Controls.Add(this.lNameLib);
            this.flpCreateNameLibrary.Controls.Add(this.tbNameLib);
            this.flpCreateNameLibrary.Controls.Add(this.lStatus);
            this.flpCreateNameLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCreateNameLibrary.Location = new System.Drawing.Point(3, 3);
            this.flpCreateNameLibrary.Name = "flpCreateNameLibrary";
            this.flpCreateNameLibrary.Size = new System.Drawing.Size(457, 27);
            this.flpCreateNameLibrary.TabIndex = 0;
            this.flpCreateNameLibrary.WrapContents = false;
            // 
            // lNameLib
            // 
            this.lNameLib.AutoSize = true;
            this.lNameLib.Dock = System.Windows.Forms.DockStyle.Left;
            this.lNameLib.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNameLib.Location = new System.Drawing.Point(3, 0);
            this.lNameLib.Name = "lNameLib";
            this.lNameLib.Size = new System.Drawing.Size(142, 26);
            this.lNameLib.TabIndex = 0;
            this.lNameLib.Text = "Название библиотеки:";
            this.lNameLib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNameLib
            // 
            this.tbNameLib.Location = new System.Drawing.Point(151, 3);
            this.tbNameLib.Name = "tbNameLib";
            this.tbNameLib.Size = new System.Drawing.Size(188, 20);
            this.tbNameLib.TabIndex = 1;
            this.tbNameLib.TextChanged += new System.EventHandler(this.tbNameLib_TextChanged);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStatus.ForeColor = System.Drawing.Color.Orange;
            this.lStatus.Location = new System.Drawing.Point(345, 0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(103, 26);
            this.lStatus.TabIndex = 2;
            this.lStatus.Text = "Введите название";
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpManagementCrtLib
            // 
            this.flpManagementCrtLib.Controls.Add(this.bBack);
            this.flpManagementCrtLib.Controls.Add(this.bCreate);
            this.flpManagementCrtLib.Controls.Add(this.bEdit);
            this.flpManagementCrtLib.Controls.Add(this.bDelete);
            this.flpManagementCrtLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpManagementCrtLib.Location = new System.Drawing.Point(3, 36);
            this.flpManagementCrtLib.Name = "flpManagementCrtLib";
            this.flpManagementCrtLib.Size = new System.Drawing.Size(457, 27);
            this.flpManagementCrtLib.TabIndex = 1;
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.Blue;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(3, 3);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(108, 23);
            this.bBack.TabIndex = 0;
            this.bBack.Text = "Отмена";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bCreate
            // 
            this.bCreate.BackColor = System.Drawing.Color.Lime;
            this.bCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreate.Location = new System.Drawing.Point(117, 3);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(108, 23);
            this.bCreate.TabIndex = 1;
            this.bCreate.Text = "Создать";
            this.bCreate.UseVisualStyleBackColor = false;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEdit.Location = new System.Drawing.Point(231, 3);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(108, 23);
            this.bEdit.TabIndex = 2;
            this.bEdit.Text = "Редактировать";
            this.bEdit.UseVisualStyleBackColor = false;
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Red;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.Location = new System.Drawing.Point(345, 3);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(108, 23);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Удалить...";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // CreateLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 66);
            this.Controls.Add(this.tlpCrtLibrary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(479, 105);
            this.MinimumSize = new System.Drawing.Size(479, 105);
            this.Name = "CreateLibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание библиотеки";
            this.tlpCrtLibrary.ResumeLayout(false);
            this.flpCreateNameLibrary.ResumeLayout(false);
            this.flpCreateNameLibrary.PerformLayout();
            this.flpManagementCrtLib.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCrtLibrary;
        private System.Windows.Forms.FlowLayoutPanel flpCreateNameLibrary;
        private System.Windows.Forms.FlowLayoutPanel flpManagementCrtLib;
        private System.Windows.Forms.Label lNameLib;
        private System.Windows.Forms.TextBox tbNameLib;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label lStatus;
    }
}