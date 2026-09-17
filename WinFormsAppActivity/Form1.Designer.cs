namespace WinFormsAppActivity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCustomerEmail = new TextBox();
            label1 = new Label();
            dgvItems = new DataGridView();
            label2 = new Label();
            cmbDiscountType = new ComboBox();
            label3 = new Label();
            btnCalculate = new Button();
            btnSaveOrder = new Button();
            btnEmailInvoice = new Button();
            btnPrint = new Button();
            label4 = new Label();
            lblTotal = new Label();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(179, 44);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(293, 23);
            txtCustomerEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 52);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Customer Email:";
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Qty });
            dgvItems.Location = new Point(179, 82);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(343, 150);
            dgvItems.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 82);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Items:";
            // 
            // cmbDiscountType
            // 
            cmbDiscountType.FormattingEnabled = true;
            cmbDiscountType.Items.AddRange(new object[] { "None", "Student", "Senior", "BlackFriday" });
            cmbDiscountType.Location = new Point(179, 238);
            cmbDiscountType.Name = "cmbDiscountType";
            cmbDiscountType.Size = new Size(117, 23);
            cmbDiscountType.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 241);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 5;
            label3.Text = "Discount Type:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(179, 294);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(260, 294);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(75, 23);
            btnSaveOrder.TabIndex = 7;
            btnSaveOrder.Text = "Save order";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnEmailInvoice
            // 
            btnEmailInvoice.Location = new Point(341, 294);
            btnEmailInvoice.Name = "btnEmailInvoice";
            btnEmailInvoice.Size = new Size(75, 23);
            btnEmailInvoice.TabIndex = 8;
            btnEmailInvoice.Text = "Email Invoice";
            btnEmailInvoice.UseVisualStyleBackColor = true;
            btnEmailInvoice.Click += btnEmailInvoice_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(422, 294);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 246);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(383, 241);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(18, 20);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "0";
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.Name = "Qty";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(btnPrint);
            Controls.Add(btnEmailInvoice);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnCalculate);
            Controls.Add(label3);
            Controls.Add(cmbDiscountType);
            Controls.Add(label2);
            Controls.Add(dgvItems);
            Controls.Add(label1);
            Controls.Add(txtCustomerEmail);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerEmail;
        private Label label1;
        private DataGridView dgvItems;
        private Label label2;
        private ComboBox cmbDiscountType;
        private Label label3;
        private Button btnCalculate;
        private Button btnSaveOrder;
        private Button btnEmailInvoice;
        private Button btnPrint;
        private Label label4;
        private Label lblTotal;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qty;
    }
}
