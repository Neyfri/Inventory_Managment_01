namespace Inventory_managment_system
{
    partial class OrderModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderModelForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoadC = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UDQty = new System.Windows.Forms.NumericUpDown();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchProd = new System.Windows.Forms.TextBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.dgvloadP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadC)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloadP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 100);
            this.panel1.TabIndex = 15;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1247, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(36, 34);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 12;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Module";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOid);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtCtName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCtid);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSearchCust);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvLoadC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 547);
            this.panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(92, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Customer Name";
            // 
            // txtCtName
            // 
            this.txtCtName.Location = new System.Drawing.Point(236, 491);
            this.txtCtName.Name = "txtCtName";
            this.txtCtName.Size = new System.Drawing.Size(173, 27);
            this.txtCtName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(126, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customer ID";
            // 
            // txtCtid
            // 
            this.txtCtid.Location = new System.Drawing.Point(236, 427);
            this.txtCtid.Name = "txtCtid";
            this.txtCtid.Size = new System.Drawing.Size(173, 27);
            this.txtCtid.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(126, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "SEARCH BOX";
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.Location = new System.Drawing.Point(236, 359);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(173, 27);
            this.txtSearchCust.TabIndex = 10;
            this.txtSearchCust.TextChanged += new System.EventHandler(this.txtSearchCust_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "CUSTOMER";
            // 
            // dgvLoadC
            // 
            this.dgvLoadC.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(83)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoadC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoadC.ColumnHeadersHeight = 30;
            this.dgvLoadC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLoadC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column7,
            this.Column2});
            this.dgvLoadC.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLoadC.EnableHeadersVisualStyles = false;
            this.dgvLoadC.Location = new System.Drawing.Point(0, 0);
            this.dgvLoadC.Name = "dgvLoadC";
            this.dgvLoadC.RowHeadersVisible = false;
            this.dgvLoadC.Size = new System.Drawing.Size(412, 354);
            this.dgvLoadC.TabIndex = 8;
            this.dgvLoadC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoadC_CellClick);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "No";
            this.Column3.Name = "Column3";
            this.Column3.Width = 56;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Customer ID";
            this.Column7.Name = "Column7";
            this.Column7.Width = 126;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UDQty);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.dtOrder);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtPName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtSearchProd);
            this.panel3.Controls.Add(this.txtPid);
            this.panel3.Controls.Add(this.dgvloadP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(418, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 547);
            this.panel3.TabIndex = 17;
            // 
            // UDQty
            // 
            this.UDQty.Location = new System.Drawing.Point(680, 464);
            this.UDQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UDQty.Name = "UDQty";
            this.UDQty.Size = new System.Drawing.Size(173, 27);
            this.UDQty.TabIndex = 31;
            this.UDQty.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(203)))), ((int)(((byte)(84)))));
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(283, 466);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(129, 39);
            this.btnInsert.TabIndex = 30;
            this.btnInsert.Text = "Order Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(106)))), ((int)(((byte)(48)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(466, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 39);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(627, 519);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(627, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Qty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(627, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(680, 418);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(173, 27);
            this.txtPrice.TabIndex = 24;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(680, 515);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(173, 27);
            this.txtTotal.TabIndex = 23;
            // 
            // dtOrder
            // 
            this.dtOrder.CustomFormat = "dd/MM/yyyy";
            this.dtOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOrder.Location = new System.Drawing.Point(22, 517);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(200, 27);
            this.dtOrder.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(18, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Order Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(18, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(229, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "SEARCH BOX";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(22, 466);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(173, 27);
            this.txtPName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(115, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "PRODUCT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(18, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Product ID";
            // 
            // txtSearchProd
            // 
            this.txtSearchProd.Location = new System.Drawing.Point(341, 363);
            this.txtSearchProd.Name = "txtSearchProd";
            this.txtSearchProd.Size = new System.Drawing.Size(374, 27);
            this.txtSearchProd.TabIndex = 12;
            this.txtSearchProd.TextChanged += new System.EventHandler(this.txtSearchProd_TextChanged);
            // 
            // txtPid
            // 
            this.txtPid.Location = new System.Drawing.Point(22, 410);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(173, 27);
            this.txtPid.TabIndex = 16;
            // 
            // dgvloadP
            // 
            this.dgvloadP.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(83)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvloadP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvloadP.ColumnHeadersHeight = 30;
            this.dgvloadP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvloadP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column1});
            this.dgvloadP.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvloadP.EnableHeadersVisualStyles = false;
            this.dgvloadP.Location = new System.Drawing.Point(0, 0);
            this.dgvloadP.Name = "dgvloadP";
            this.dgvloadP.RowHeadersVisible = false;
            this.dgvloadP.Size = new System.Drawing.Size(865, 354);
            this.dgvloadP.TabIndex = 8;
            this.dgvloadP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloadP_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 56;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 112;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "Price";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 72;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Category";
            this.Column1.Name = "Column1";
            this.Column1.Width = 106;
            // 
            // lblOid
            // 
            this.lblOid.AutoSize = true;
            this.lblOid.Location = new System.Drawing.Point(13, 444);
            this.lblOid.Name = "lblOid";
            this.lblOid.Size = new System.Drawing.Size(67, 19);
            this.lblOid.TabIndex = 16;
            this.lblOid.Text = "label14";
            this.lblOid.Visible = false;
            // 
            // OrderModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 647);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderModelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderModelForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadC)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloadP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoadC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchProd;
        private System.Windows.Forms.DataGridView dgvloadP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Label lblOid;
        public System.Windows.Forms.TextBox txtCtName;
        public System.Windows.Forms.TextBox txtCtid;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.DateTimePicker dtOrder;
        public System.Windows.Forms.TextBox txtPName;
        public System.Windows.Forms.TextBox txtPid;
        public System.Windows.Forms.NumericUpDown UDQty;
    }
}