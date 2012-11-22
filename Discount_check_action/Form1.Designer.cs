namespace Discount_check_action
{
    partial class Discount_check_action
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discount_check_action));
            this.button_search = new System.Windows.Forms.Button();
            this.button_fix = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_group = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_group_text = new System.Windows.Forms.Label();
            this.button_group_prev = new System.Windows.Forms.Button();
            this.button_group_next = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.акцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.табачныеИзделияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сахарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упаковкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контейнерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фруктыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.желтыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИзСписковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(6, 5);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(123, 31);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_fix
            // 
            this.button_fix.Enabled = false;
            this.button_fix.Location = new System.Drawing.Point(140, 5);
            this.button_fix.Name = "button_fix";
            this.button_fix.Size = new System.Drawing.Size(123, 31);
            this.button_fix.TabIndex = 0;
            this.button_fix.TabStop = false;
            this.button_fix.Text = "Исправить";
            this.button_fix.UseVisualStyleBackColor = true;
            this.button_fix.Click += new System.EventHandler(this.button_fix_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(257, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.button_fix);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 77);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(6, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(272, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "BARCODE";
            this.Column1.MaxInputLength = 13;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 84;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "PRICE";
            this.Column2.MaxInputLength = 12;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "MINPRICE";
            this.Column3.MaxInputLength = 10;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "STATUS";
            this.Column4.MaxInputLength = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // label_group
            // 
            this.label_group.AutoSize = true;
            this.label_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_group.Location = new System.Drawing.Point(104, 9);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(58, 16);
            this.label_group.TabIndex = 4;
            this.label_group.Text = "Группа:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label_group_text);
            this.panel2.Controls.Add(this.button_group_prev);
            this.panel2.Controls.Add(this.button_group_next);
            this.panel2.Controls.Add(this.label_group);
            this.panel2.Location = new System.Drawing.Point(6, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 64);
            this.panel2.TabIndex = 5;
            // 
            // label_group_text
            // 
            this.label_group_text.AutoSize = true;
            this.label_group_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_group_text.ForeColor = System.Drawing.Color.Lime;
            this.label_group_text.Location = new System.Drawing.Point(54, 33);
            this.label_group_text.Name = "label_group_text";
            this.label_group_text.Size = new System.Drawing.Size(0, 20);
            this.label_group_text.TabIndex = 7;
            // 
            // button_group_prev
            // 
            this.button_group_prev.Location = new System.Drawing.Point(3, 3);
            this.button_group_prev.Name = "button_group_prev";
            this.button_group_prev.Size = new System.Drawing.Size(36, 50);
            this.button_group_prev.TabIndex = 6;
            this.button_group_prev.Text = "<<";
            this.button_group_prev.UseVisualStyleBackColor = true;
            this.button_group_prev.Click += new System.EventHandler(this.button_group_prev_Click);
            // 
            // button_group_next
            // 
            this.button_group_next.Location = new System.Drawing.Point(227, 3);
            this.button_group_next.Name = "button_group_next";
            this.button_group_next.Size = new System.Drawing.Size(36, 50);
            this.button_group_next.TabIndex = 5;
            this.button_group_next.Text = ">>";
            this.button_group_next.UseVisualStyleBackColor = true;
            this.button_group_next.Click += new System.EventHandler(this.button_group_next_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.выделитьToolStripMenuItem,
            this.удалитьИзСписковToolStripMenuItem,
            this.копироватьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 114);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.акцияToolStripMenuItem,
            this.табачныеИзделияToolStripMenuItem,
            this.сахарToolStripMenuItem,
            this.упаковкаToolStripMenuItem,
            this.контейнерToolStripMenuItem,
            this.фруктыToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem3.Text = "Добавить в список";
            // 
            // акцияToolStripMenuItem
            // 
            this.акцияToolStripMenuItem.Name = "акцияToolStripMenuItem";
            this.акцияToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.акцияToolStripMenuItem.Text = "Акция";
            this.акцияToolStripMenuItem.Click += new System.EventHandler(this.акцияToolStripMenuItem_Click);
            // 
            // табачныеИзделияToolStripMenuItem
            // 
            this.табачныеИзделияToolStripMenuItem.Name = "табачныеИзделияToolStripMenuItem";
            this.табачныеИзделияToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.табачныеИзделияToolStripMenuItem.Text = "Табачные изделия";
            this.табачныеИзделияToolStripMenuItem.Click += new System.EventHandler(this.табачныеИзделияToolStripMenuItem_Click);
            // 
            // сахарToolStripMenuItem
            // 
            this.сахарToolStripMenuItem.Name = "сахарToolStripMenuItem";
            this.сахарToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.сахарToolStripMenuItem.Text = "Сахар";
            this.сахарToolStripMenuItem.Click += new System.EventHandler(this.сахарToolStripMenuItem_Click);
            // 
            // упаковкаToolStripMenuItem
            // 
            this.упаковкаToolStripMenuItem.Name = "упаковкаToolStripMenuItem";
            this.упаковкаToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.упаковкаToolStripMenuItem.Text = "Упаковка";
            this.упаковкаToolStripMenuItem.Click += new System.EventHandler(this.упаковкаToolStripMenuItem_Click);
            // 
            // контейнерToolStripMenuItem
            // 
            this.контейнерToolStripMenuItem.Name = "контейнерToolStripMenuItem";
            this.контейнерToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.контейнерToolStripMenuItem.Text = "Контейнер";
            this.контейнерToolStripMenuItem.Click += new System.EventHandler(this.контейнерToolStripMenuItem_Click);
            // 
            // фруктыToolStripMenuItem
            // 
            this.фруктыToolStripMenuItem.Name = "фруктыToolStripMenuItem";
            this.фруктыToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.фруктыToolStripMenuItem.Text = "Фрукты";
            this.фруктыToolStripMenuItem.Click += new System.EventHandler(this.фруктыToolStripMenuItem_Click);
            // 
            // выделитьToolStripMenuItem
            // 
            this.выделитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.желтыйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.белыйToolStripMenuItem});
            this.выделитьToolStripMenuItem.Name = "выделитьToolStripMenuItem";
            this.выделитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.выделитьToolStripMenuItem.Text = "Выделить";
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.красныйToolStripMenuItem_Click);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // желтыйToolStripMenuItem
            // 
            this.желтыйToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.желтыйToolStripMenuItem.Name = "желтыйToolStripMenuItem";
            this.желтыйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.желтыйToolStripMenuItem.Text = "Желтый";
            this.желтыйToolStripMenuItem.Click += new System.EventHandler(this.желтыйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // белыйToolStripMenuItem
            // 
            this.белыйToolStripMenuItem.Name = "белыйToolStripMenuItem";
            this.белыйToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.белыйToolStripMenuItem.Text = "Белый";
            this.белыйToolStripMenuItem.Click += new System.EventHandler(this.белыйToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // удалитьИзСписковToolStripMenuItem
            // 
            this.удалитьИзСписковToolStripMenuItem.Name = "удалитьИзСписковToolStripMenuItem";
            this.удалитьИзСписковToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.удалитьИзСписковToolStripMenuItem.Text = "Удалить из списков";
            this.удалитьИзСписковToolStripMenuItem.Click += new System.EventHandler(this.удалитьИзСписковToolStripMenuItem_Click);
            // 
            // Discount_check_action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(283, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Discount_check_action";
            this.Text = "Discount-Check";
            this.Shown += new System.EventHandler(this.Discount_check_action_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_fix;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_group;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_group_text;
        private System.Windows.Forms.Button button_group_prev;
        private System.Windows.Forms.Button button_group_next;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem акцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem табачныеИзделияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сахарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упаковкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контейнерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фруктыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem белыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem желтыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзСписковToolStripMenuItem;
    }
}

