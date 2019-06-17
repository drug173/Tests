namespace test_megaperfume2
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
            this.components = new System.ComponentModel.Container();
            this.distributors = new System.Windows.Forms.ComboBox();
            this.dISTRIBUTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet3 = new test_megaperfume2.testDataSet3();
            this.prices = new System.Windows.Forms.ComboBox();
            this.pRICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet2 = new test_megaperfume2.testDataSet2();
            this.criterion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idP12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.differenceMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.differenceMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.distributor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceList2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProduct2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICESTableAdapter = new test_megaperfume2.testDataSet2TableAdapters.PRICESTableAdapter();
            this.dISTRIBUTORSTableAdapter = new test_megaperfume2.testDataSet3TableAdapters.DISTRIBUTORSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dISTRIBUTORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRICESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // distributors
            // 
            this.distributors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distributors.DisplayMember = "ID";
            this.distributors.FormattingEnabled = true;
            this.distributors.Location = new System.Drawing.Point(3, 3);
            this.distributors.Name = "distributors";
            this.distributors.Size = new System.Drawing.Size(215, 21);
            this.distributors.TabIndex = 0;
            this.distributors.ValueMember = "ID";
            this.distributors.SelectedIndexChanged += new System.EventHandler(this.distributors_SelectedIndexChanged);
            // 
            // dISTRIBUTORSBindingSource
            // 
            this.dISTRIBUTORSBindingSource.DataMember = "DISTRIBUTORS";
            this.dISTRIBUTORSBindingSource.DataSource = this.testDataSet3;
            // 
            // testDataSet3
            // 
            this.testDataSet3.DataSetName = "testDataSet3";
            this.testDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prices
            // 
            this.prices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prices.DisplayMember = "ID";
            this.prices.FormattingEnabled = true;
            this.prices.Location = new System.Drawing.Point(224, 3);
            this.prices.Name = "prices";
            this.prices.Size = new System.Drawing.Size(215, 21);
            this.prices.TabIndex = 1;
            this.prices.ValueMember = "ID";
            this.prices.SelectedIndexChanged += new System.EventHandler(this.prices_SelectedIndexChanged);
            // 
            // pRICESBindingSource
            // 
            this.pRICESBindingSource.DataMember = "PRICES";
            this.pRICESBindingSource.DataSource = this.testDataSet2;
            // 
            // testDataSet2
            // 
            this.testDataSet2.DataSetName = "testDataSet2";
            this.testDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // criterion
            // 
            this.criterion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.criterion.FormattingEnabled = true;
            this.criterion.Items.AddRange(new object[] {
            "Выберите критерий",
            "Минимальная цена у других",
            "Минимальная цена здесь",
            "Все"});
            this.criterion.Location = new System.Drawing.Point(445, 3);
            this.criterion.Name = "criterion";
            this.criterion.Size = new System.Drawing.Size(215, 21);
            this.criterion.TabIndex = 2;
            this.criterion.SelectedIndexChanged += new System.EventHandler(this.criterion_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(666, 3);
            this.button1.MinimumSize = new System.Drawing.Size(110, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выполнить анализ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 0);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.distributors, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.prices, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.criterion, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 29);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.32802F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.67198F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 498);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idP12,
            this.nameProducts,
            this.price,
            this.minPrice,
            this.differenceMin,
            this.maxPrice,
            this.differenceMax,
            this.distributor,
            this.priceList,
            this.notes});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 492);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDown);
            // 
            // idP12
            // 
            this.idP12.HeaderText = "id";
            this.idP12.Name = "idP12";
            this.idP12.ReadOnly = true;
            this.idP12.Visible = false;
            // 
            // nameProducts
            // 
            this.nameProducts.HeaderText = "наименование товара";
            this.nameProducts.Name = "nameProducts";
            this.nameProducts.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // minPrice
            // 
            this.minPrice.HeaderText = "мин. цена";
            this.minPrice.Name = "minPrice";
            this.minPrice.ReadOnly = true;
            // 
            // differenceMin
            // 
            this.differenceMin.HeaderText = "разница";
            this.differenceMin.Name = "differenceMin";
            this.differenceMin.ReadOnly = true;
            // 
            // maxPrice
            // 
            this.maxPrice.HeaderText = "макс. цена";
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.ReadOnly = true;
            // 
            // differenceMax
            // 
            this.differenceMax.HeaderText = "разница";
            this.differenceMax.Name = "differenceMax";
            this.differenceMax.ReadOnly = true;
            // 
            // distributor
            // 
            this.distributor.DividerWidth = 1;
            this.distributor.HeaderText = "поставщик";
            this.distributor.Name = "distributor";
            this.distributor.ReadOnly = true;
            // 
            // priceList
            // 
            this.priceList.HeaderText = "прайс-лист";
            this.priceList.Name = "priceList";
            this.priceList.ReadOnly = true;
            // 
            // notes
            // 
            this.notes.HeaderText = "примечания";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distributor2,
            this.priceList2,
            this.nameProduct2,
            this.price2,
            this.difference});
            this.dataGridView2.Location = new System.Drawing.Point(479, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(396, 492);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // distributor2
            // 
            this.distributor2.HeaderText = "поставщик";
            this.distributor2.Name = "distributor2";
            this.distributor2.ReadOnly = true;
            // 
            // priceList2
            // 
            this.priceList2.HeaderText = "прайс-лист";
            this.priceList2.Name = "priceList2";
            this.priceList2.ReadOnly = true;
            // 
            // nameProduct2
            // 
            this.nameProduct2.HeaderText = "наименование товара";
            this.nameProduct2.Name = "nameProduct2";
            this.nameProduct2.ReadOnly = true;
            // 
            // price2
            // 
            this.price2.HeaderText = "цена";
            this.price2.Name = "price2";
            this.price2.ReadOnly = true;
            // 
            // difference
            // 
            this.difference.HeaderText = "разница";
            this.difference.Name = "difference";
            this.difference.ReadOnly = true;
            // 
            // pRICESTableAdapter
            // 
            this.pRICESTableAdapter.ClearBeforeFill = true;
            // 
            // dISTRIBUTORSTableAdapter
            // 
            this.dISTRIBUTORSTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.Text = "АНАЛИЗ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dISTRIBUTORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRICESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox distributors;
        private System.Windows.Forms.ComboBox prices;
        private System.Windows.Forms.ComboBox criterion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private testDataSet2 testDataSet2;
        private System.Windows.Forms.BindingSource pRICESBindingSource;
        private testDataSet2TableAdapters.PRICESTableAdapter pRICESTableAdapter;
        private testDataSet3 testDataSet3;
        private System.Windows.Forms.BindingSource dISTRIBUTORSBindingSource;
        private testDataSet3TableAdapters.DISTRIBUTORSTableAdapter dISTRIBUTORSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceList2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct2;
        private System.Windows.Forms.DataGridViewTextBoxColumn price2;
        private System.Windows.Forms.DataGridViewTextBoxColumn difference;
        private System.Windows.Forms.DataGridViewTextBoxColumn idP12;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn minPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn differenceMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn differenceMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributor;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
    }
}

