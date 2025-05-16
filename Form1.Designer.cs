namespace Lab4
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdateFile = new System.Windows.Forms.Button();
            this.buttonCommandFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnType,
            this.columnDate,
            this.ColumnSource,
            this.ColumnAmount,
            this.ColumnHours,
            this.ColumnPayer,
            this.ColumnPeriod});
            this.dataGridView1.Location = new System.Drawing.Point(36, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 170);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // columnType
            // 
            this.columnType.HeaderText = "Тип дохода";
            this.columnType.MinimumWidth = 6;
            this.columnType.Name = "columnType";
            this.columnType.Width = 125;
            // 
            // columnDate
            // 
            this.columnDate.HeaderText = "Дата";
            this.columnDate.MinimumWidth = 6;
            this.columnDate.Name = "columnDate";
            this.columnDate.Width = 125;
            // 
            // ColumnSource
            // 
            this.ColumnSource.HeaderText = "Источник";
            this.ColumnSource.MinimumWidth = 6;
            this.ColumnSource.Name = "ColumnSource";
            this.ColumnSource.Width = 125;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Сумма";
            this.ColumnAmount.MinimumWidth = 6;
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.Width = 125;
            // 
            // ColumnHours
            // 
            this.ColumnHours.HeaderText = "Часы";
            this.ColumnHours.MinimumWidth = 6;
            this.ColumnHours.Name = "ColumnHours";
            this.ColumnHours.Width = 125;
            // 
            // ColumnPayer
            // 
            this.ColumnPayer.HeaderText = "Плательщик";
            this.ColumnPayer.MinimumWidth = 6;
            this.ColumnPayer.Name = "ColumnPayer";
            this.ColumnPayer.Width = 125;
            // 
            // ColumnPeriod
            // 
            this.ColumnPeriod.HeaderText = "Период";
            this.ColumnPeriod.MinimumWidth = 6;
            this.ColumnPeriod.Name = "ColumnPeriod";
            this.ColumnPeriod.Width = 125;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(36, 202);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 63);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(188, 202);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(130, 63);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonUpdateFile
            // 
            this.buttonUpdateFile.Location = new System.Drawing.Point(324, 202);
            this.buttonUpdateFile.Name = "buttonUpdateFile";
            this.buttonUpdateFile.Size = new System.Drawing.Size(130, 63);
            this.buttonUpdateFile.TabIndex = 3;
            this.buttonUpdateFile.Text = "Обновить файл";
            this.buttonUpdateFile.UseVisualStyleBackColor = true;
            this.buttonUpdateFile.Click += new System.EventHandler(this.buttonUpdateFile_Click);
            // 
            // buttonCommandFile
            // 
            this.buttonCommandFile.Location = new System.Drawing.Point(834, 202);
            this.buttonCommandFile.Name = "buttonCommandFile";
            this.buttonCommandFile.Size = new System.Drawing.Size(130, 63);
            this.buttonCommandFile.TabIndex = 4;
            this.buttonCommandFile.Text = "Файл команд";
            this.buttonCommandFile.UseVisualStyleBackColor = true;
            this.buttonCommandFile.Click += new System.EventHandler(this.buttonCommandFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(581, 202);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(129, 63);
            this.buttonOpenFile.TabIndex = 5;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 289);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonCommandFile);
            this.Controls.Add(this.buttonUpdateFile);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Доходы";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPeriod;
        private System.Windows.Forms.Button buttonUpdateFile;
        private System.Windows.Forms.Button buttonCommandFile;
        private System.Windows.Forms.Button buttonOpenFile;
    }
}

