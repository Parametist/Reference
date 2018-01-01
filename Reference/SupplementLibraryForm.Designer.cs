namespace Reference
{
    partial class SupplementLibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplementLibraryForm));
            this.tlpSupLib = new System.Windows.Forms.TableLayoutPanel();
            this.flpEditFile = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLibs = new System.Windows.Forms.ComboBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.bNext = new System.Windows.Forms.Button();
            this.flpManagement = new System.Windows.Forms.FlowLayoutPanel();
            this.bSave = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tlpEdit = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPartialDesc = new System.Windows.Forms.TextBox();
            this.tbFullDesc = new System.Windows.Forms.TextBox();
            this.bChange = new System.Windows.Forms.Button();
            this.tlpSupLib.SuspendLayout();
            this.flpEditFile.SuspendLayout();
            this.flpManagement.SuspendLayout();
            this.tlpEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSupLib
            // 
            this.tlpSupLib.ColumnCount = 2;
            this.tlpSupLib.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpSupLib.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSupLib.Controls.Add(this.flpEditFile, 0, 0);
            this.tlpSupLib.Controls.Add(this.flpManagement, 1, 1);
            this.tlpSupLib.Controls.Add(this.tlpEdit, 1, 0);
            this.tlpSupLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSupLib.Location = new System.Drawing.Point(0, 0);
            this.tlpSupLib.Name = "tlpSupLib";
            this.tlpSupLib.RowCount = 2;
            this.tlpSupLib.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSupLib.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpSupLib.Size = new System.Drawing.Size(704, 411);
            this.tlpSupLib.TabIndex = 0;
            // 
            // flpEditFile
            // 
            this.flpEditFile.Controls.Add(this.label1);
            this.flpEditFile.Controls.Add(this.tbName);
            this.flpEditFile.Controls.Add(this.label2);
            this.flpEditFile.Controls.Add(this.tbTags);
            this.flpEditFile.Controls.Add(this.label3);
            this.flpEditFile.Controls.Add(this.cbLibs);
            this.flpEditFile.Controls.Add(this.lStatus);
            this.flpEditFile.Controls.Add(this.bNext);
            this.flpEditFile.Controls.Add(this.bChange);
            this.flpEditFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEditFile.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEditFile.Location = new System.Drawing.Point(3, 18);
            this.flpEditFile.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
            this.flpEditFile.Name = "flpEditFile";
            this.flpEditFile.Size = new System.Drawing.Size(194, 356);
            this.flpEditFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(3, 18);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(190, 23);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Теги (через запятую):";
            // 
            // tbTags
            // 
            this.tbTags.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTags.Location = new System.Drawing.Point(3, 62);
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(190, 23);
            this.tbTags.TabIndex = 3;
            this.tbTags.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Библиотека:";
            // 
            // cbLibs
            // 
            this.cbLibs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLibs.FormattingEnabled = true;
            this.cbLibs.Location = new System.Drawing.Point(3, 106);
            this.cbLibs.Name = "cbLibs";
            this.cbLibs.Size = new System.Drawing.Size(190, 23);
            this.cbLibs.TabIndex = 5;
            this.cbLibs.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStatus.ForeColor = System.Drawing.Color.Orange;
            this.lStatus.Location = new System.Drawing.Point(3, 152);
            this.lStatus.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 15);
            this.lStatus.TabIndex = 6;
            // 
            // bNext
            // 
            this.bNext.BackColor = System.Drawing.Color.Lime;
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNext.Location = new System.Drawing.Point(3, 187);
            this.bNext.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(190, 30);
            this.bNext.TabIndex = 7;
            this.bNext.Text = "Продолжить..";
            this.bNext.UseVisualStyleBackColor = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // flpManagement
            // 
            this.flpManagement.Controls.Add(this.bSave);
            this.flpManagement.Controls.Add(this.bClear);
            this.flpManagement.Controls.Add(this.bCancel);
            this.flpManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpManagement.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpManagement.Location = new System.Drawing.Point(203, 380);
            this.flpManagement.Name = "flpManagement";
            this.flpManagement.Size = new System.Drawing.Size(498, 28);
            this.flpManagement.TabIndex = 1;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.Lime;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSave.Location = new System.Drawing.Point(411, 3);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(84, 23);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClear.Location = new System.Drawing.Point(321, 3);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(84, 23);
            this.bClear.TabIndex = 1;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(231, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(84, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tlpEdit
            // 
            this.tlpEdit.ColumnCount = 1;
            this.tlpEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEdit.Controls.Add(this.label4, 0, 0);
            this.tlpEdit.Controls.Add(this.label5, 0, 2);
            this.tlpEdit.Controls.Add(this.tbPartialDesc, 0, 1);
            this.tlpEdit.Controls.Add(this.tbFullDesc, 0, 3);
            this.tlpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEdit.Location = new System.Drawing.Point(203, 3);
            this.tlpEdit.Name = "tlpEdit";
            this.tlpEdit.RowCount = 4;
            this.tlpEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpEdit.Size = new System.Drawing.Size(498, 371);
            this.tlpEdit.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(492, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Краткое описание (без табуляции):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(492, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Полное описание (без табуляции):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPartialDesc
            // 
            this.tbPartialDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPartialDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPartialDesc.Location = new System.Drawing.Point(3, 33);
            this.tbPartialDesc.Multiline = true;
            this.tbPartialDesc.Name = "tbPartialDesc";
            this.tbPartialDesc.Size = new System.Drawing.Size(492, 87);
            this.tbPartialDesc.TabIndex = 2;
            this.tbPartialDesc.TextChanged += new System.EventHandler(this.tbPartialDesc_TextChanged);
            // 
            // tbFullDesc
            // 
            this.tbFullDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFullDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFullDesc.Location = new System.Drawing.Point(3, 156);
            this.tbFullDesc.Multiline = true;
            this.tbFullDesc.Name = "tbFullDesc";
            this.tbFullDesc.Size = new System.Drawing.Size(492, 212);
            this.tbFullDesc.TabIndex = 3;
            this.tbFullDesc.TextChanged += new System.EventHandler(this.tbFullDesc_TextChanged);
            this.tbFullDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFullDesc_KeyDown);
            // 
            // bChange
            // 
            this.bChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bChange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bChange.Location = new System.Drawing.Point(3, 223);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(190, 30);
            this.bChange.TabIndex = 8;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = false;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // SupplementLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.tlpSupLib);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 450);
            this.Name = "SupplementLibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование библиотеки";
            this.tlpSupLib.ResumeLayout(false);
            this.flpEditFile.ResumeLayout(false);
            this.flpEditFile.PerformLayout();
            this.flpManagement.ResumeLayout(false);
            this.tlpEdit.ResumeLayout(false);
            this.tlpEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSupLib;
        private System.Windows.Forms.FlowLayoutPanel flpEditFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLibs;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.FlowLayoutPanel flpManagement;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TableLayoutPanel tlpEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPartialDesc;
        private System.Windows.Forms.TextBox tbFullDesc;
        private System.Windows.Forms.Button bChange;
    }
}