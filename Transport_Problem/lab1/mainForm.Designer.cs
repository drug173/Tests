namespace lab1
{
    partial class mainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle99 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle100 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle101 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle102 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle103 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle105 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle104 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gridSupport = new System.Windows.Forms.DataGridView();
            this.gridFinal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOptimum = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rbNW = new System.Windows.Forms.RadioButton();
            this.btnSolve = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridB = new System.Windows.Forms.DataGridView();
            this.MatrB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridC = new System.Windows.Forms.DataGridView();
            this.gridA = new System.Windows.Forms.DataGridView();
            this.MatrA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbMinElem = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFinal)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Решение";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.93581F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.06419F));
            this.tableLayoutPanel2.Controls.Add(this.gridSupport, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gridFinal, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblOptimum, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(779, 458);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // gridSupport
            // 
            this.gridSupport.AllowUserToAddRows = false;
            this.gridSupport.AllowUserToDeleteRows = false;
            this.gridSupport.AllowUserToResizeColumns = false;
            this.gridSupport.AllowUserToResizeRows = false;
            this.gridSupport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle99.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle99.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle99.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle99.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle99.Format = "N2";
            dataGridViewCellStyle99.NullValue = "null";
            dataGridViewCellStyle99.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle99.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle99.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSupport.DefaultCellStyle = dataGridViewCellStyle99;
            this.gridSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSupport.Location = new System.Drawing.Point(3, 35);
            this.gridSupport.MultiSelect = false;
            this.gridSupport.Name = "gridSupport";
            this.gridSupport.ReadOnly = true;
            this.gridSupport.RowHeadersWidth = 50;
            this.gridSupport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridSupport.Size = new System.Drawing.Size(382, 306);
            this.gridSupport.TabIndex = 1;
            // 
            // gridFinal
            // 
            this.gridFinal.AllowUserToAddRows = false;
            this.gridFinal.AllowUserToDeleteRows = false;
            this.gridFinal.AllowUserToResizeColumns = false;
            this.gridFinal.AllowUserToResizeRows = false;
            this.gridFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle100.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle100.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle100.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle100.Format = "N2";
            dataGridViewCellStyle100.NullValue = "null";
            dataGridViewCellStyle100.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle100.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle100.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFinal.DefaultCellStyle = dataGridViewCellStyle100;
            this.gridFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFinal.Location = new System.Drawing.Point(391, 35);
            this.gridFinal.MultiSelect = false;
            this.gridFinal.Name = "gridFinal";
            this.gridFinal.ReadOnly = true;
            this.gridFinal.RowHeadersWidth = 50;
            this.gridFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridFinal.Size = new System.Drawing.Size(385, 306);
            this.gridFinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Опорный план";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(391, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Оптимальное решение";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOptimum
            // 
            this.lblOptimum.AutoSize = true;
            this.lblOptimum.Location = new System.Drawing.Point(391, 344);
            this.lblOptimum.Name = "lblOptimum";
            this.lblOptimum.Size = new System.Drawing.Size(0, 13);
            this.lblOptimum.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 347);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(382, 108);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.rbNW, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbMinElem, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnSolve, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(376, 102);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // rbNW
            // 
            this.rbNW.AutoSize = true;
            this.rbNW.Checked = true;
            this.rbNW.Location = new System.Drawing.Point(3, 3);
            this.rbNW.Name = "rbNW";
            this.rbNW.Size = new System.Drawing.Size(177, 17);
            this.rbNW.TabIndex = 0;
            this.rbNW.TabStop = true;
            this.rbNW.Text = "Метод северо-западного угла";
            this.rbNW.UseVisualStyleBackColor = true;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(3, 71);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 21);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "Решить";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Условия задачи";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridC, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridA, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudB, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 458);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gridB
            // 
            this.gridB.AllowUserToAddRows = false;
            this.gridB.AllowUserToDeleteRows = false;
            this.gridB.AllowUserToResizeColumns = false;
            this.gridB.AllowUserToResizeRows = false;
            this.gridB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatrB});
            this.gridB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridB.Location = new System.Drawing.Point(132, 67);
            this.gridB.Name = "gridB";
            this.gridB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridB.Size = new System.Drawing.Size(145, 388);
            this.gridB.TabIndex = 16;
            // 
            // MatrB
            // 
            this.MatrB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle101.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle101.Format = "N0";
            dataGridViewCellStyle101.NullValue = "0";
            this.MatrB.DefaultCellStyle = dataGridViewCellStyle101;
            this.MatrB.HeaderText = "Потребители";
            this.MatrB.Name = "MatrB";
            this.MatrB.Width = 98;
            // 
            // gridC
            // 
            this.gridC.AllowUserToAddRows = false;
            this.gridC.AllowUserToDeleteRows = false;
            this.gridC.AllowUserToResizeColumns = false;
            this.gridC.AllowUserToResizeRows = false;
            this.gridC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle102.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle102.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle102.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle102.Format = "N2";
            dataGridViewCellStyle102.NullValue = "null";
            dataGridViewCellStyle102.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle102.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle102.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridC.DefaultCellStyle = dataGridViewCellStyle102;
            this.gridC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridC.Location = new System.Drawing.Point(283, 67);
            this.gridC.Name = "gridC";
            this.gridC.RowHeadersWidth = 50;
            this.gridC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle103.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle103.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle103.Format = "N2";
            dataGridViewCellStyle103.NullValue = "null";
            this.gridC.RowsDefaultCellStyle = dataGridViewCellStyle103;
            this.gridC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridC.Size = new System.Drawing.Size(493, 388);
            this.gridC.TabIndex = 14;
            // 
            // gridA
            // 
            this.gridA.AllowUserToAddRows = false;
            this.gridA.AllowUserToDeleteRows = false;
            this.gridA.AllowUserToResizeColumns = false;
            this.gridA.AllowUserToResizeRows = false;
            this.gridA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatrA});
            this.gridA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridA.Location = new System.Drawing.Point(3, 67);
            this.gridA.MultiSelect = false;
            this.gridA.Name = "gridA";
            dataGridViewCellStyle105.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle105.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle105.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle105.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle105.NullValue = null;
            dataGridViewCellStyle105.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle105.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle105.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridA.RowHeadersDefaultCellStyle = dataGridViewCellStyle105;
            this.gridA.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridA.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridA.RowTemplate.DefaultCellStyle.Format = "N2";
            this.gridA.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.gridA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridA.Size = new System.Drawing.Size(123, 388);
            this.gridA.TabIndex = 4;
            // 
            // MatrA
            // 
            this.MatrA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle104.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle104.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle104.Format = "N0";
            dataGridViewCellStyle104.NullValue = "0";
            this.MatrA.DefaultCellStyle = dataGridViewCellStyle104;
            this.MatrA.FillWeight = 50F;
            this.MatrA.HeaderText = "Поставщики";
            this.MatrA.Name = "MatrA";
            this.MatrA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MatrA.Width = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество поставщиков";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(132, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество потребителей";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(283, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(493, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Стоимость перевозки";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudA
            // 
            this.nudA.Location = new System.Drawing.Point(3, 35);
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(120, 20);
            this.nudA.TabIndex = 12;
            this.nudA.ValueChanged += new System.EventHandler(this.nudA_ValueChanged);
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(132, 35);
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(120, 20);
            this.nudB.TabIndex = 13;
            this.nudB.ValueChanged += new System.EventHandler(this.nudB_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(94, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 490);
            this.tabControl1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // rbMinElem
            // 
            this.rbMinElem.AutoSize = true;
            this.rbMinElem.Location = new System.Drawing.Point(3, 37);
            this.rbMinElem.Name = "rbMinElem";
            this.rbMinElem.Size = new System.Drawing.Size(187, 17);
            this.rbMinElem.TabIndex = 1;
            this.rbMinElem.Text = "Метод минимального элемента";
            this.rbMinElem.UseVisualStyleBackColor = true;
            this.rbMinElem.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(785, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "О программе";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(3, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(282, 89);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "    Программа для нахождения оптимального плана перевозок \r\nтовара от поставщиков" +
    " потребителям, при минимальной стоимости перевозок.\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выполнил ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(114, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Лейман М.А.";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(793, 514);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Транспортная задача";
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFinal)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView gridSupport;
        private System.Windows.Forms.DataGridView gridFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOptimum;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gridA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton rbNW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.DataGridView gridB;
        private System.Windows.Forms.DataGridView gridC;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatrB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatrA;
        private System.Windows.Forms.RadioButton rbMinElem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}

