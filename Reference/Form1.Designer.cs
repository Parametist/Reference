namespace Reference
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.tlpActSelection = new System.Windows.Forms.TableLayoutPanel();
            this.bSearch = new System.Windows.Forms.Button();
            this.bCreateLibrary = new System.Windows.Forms.Button();
            this.bSupplementLibrary = new System.Windows.Forms.Button();
            this.bAddSeparateInfo = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.tlpActSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpActSelection
            // 
            this.tlpActSelection.ColumnCount = 3;
            this.tlpActSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpActSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpActSelection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpActSelection.Controls.Add(this.bSearch, 1, 1);
            this.tlpActSelection.Controls.Add(this.bCreateLibrary, 1, 2);
            this.tlpActSelection.Controls.Add(this.bSupplementLibrary, 1, 3);
            this.tlpActSelection.Controls.Add(this.bAddSeparateInfo, 1, 4);
            this.tlpActSelection.Controls.Add(this.bExit, 1, 5);
            this.tlpActSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpActSelection.Location = new System.Drawing.Point(0, 0);
            this.tlpActSelection.Name = "tlpActSelection";
            this.tlpActSelection.RowCount = 7;
            this.tlpActSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpActSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpActSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpActSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpActSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpActSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpActSelection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpActSelection.Size = new System.Drawing.Size(344, 351);
            this.tlpActSelection.TabIndex = 0;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.Yellow;
            this.bSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSearch.Location = new System.Drawing.Point(100, 53);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(144, 44);
            this.bSearch.TabIndex = 0;
            this.bSearch.Text = "Поиск...";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bCreateLibrary
            // 
            this.bCreateLibrary.BackColor = System.Drawing.Color.Lime;
            this.bCreateLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCreateLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCreateLibrary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreateLibrary.Location = new System.Drawing.Point(100, 103);
            this.bCreateLibrary.Name = "bCreateLibrary";
            this.bCreateLibrary.Size = new System.Drawing.Size(144, 44);
            this.bCreateLibrary.TabIndex = 1;
            this.bCreateLibrary.Text = "Создать библиотеку\r\nили удалить";
            this.bCreateLibrary.UseVisualStyleBackColor = false;
            this.bCreateLibrary.Click += new System.EventHandler(this.bCreateLibrary_Click);
            // 
            // bSupplementLibrary
            // 
            this.bSupplementLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bSupplementLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSupplementLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSupplementLibrary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSupplementLibrary.Location = new System.Drawing.Point(100, 153);
            this.bSupplementLibrary.Name = "bSupplementLibrary";
            this.bSupplementLibrary.Size = new System.Drawing.Size(144, 44);
            this.bSupplementLibrary.TabIndex = 2;
            this.bSupplementLibrary.Text = "Редактировать библиотеку";
            this.bSupplementLibrary.UseVisualStyleBackColor = false;
            this.bSupplementLibrary.Click += new System.EventHandler(this.bSupplementLibrary_Click);
            // 
            // bAddSeparateInfo
            // 
            this.bAddSeparateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bAddSeparateInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddSeparateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddSeparateInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddSeparateInfo.Location = new System.Drawing.Point(100, 203);
            this.bAddSeparateInfo.Name = "bAddSeparateInfo";
            this.bAddSeparateInfo.Size = new System.Drawing.Size(144, 44);
            this.bAddSeparateInfo.TabIndex = 3;
            this.bAddSeparateInfo.Text = "Добавить отдельную информацию";
            this.bAddSeparateInfo.UseVisualStyleBackColor = false;
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Red;
            this.bExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.Location = new System.Drawing.Point(100, 253);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(144, 44);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 351);
            this.Controls.Add(this.tlpActSelection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 390);
            this.MinimumSize = new System.Drawing.Size(360, 390);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в справочник";
            this.tlpActSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpActSelection;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bCreateLibrary;
        private System.Windows.Forms.Button bSupplementLibrary;
        private System.Windows.Forms.Button bAddSeparateInfo;
        private System.Windows.Forms.Button bExit;
    }
}

