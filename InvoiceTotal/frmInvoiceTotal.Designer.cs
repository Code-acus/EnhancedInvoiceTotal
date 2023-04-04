namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            lblSubtotal = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.TextBox();
            lblDiscountPercent = new System.Windows.Forms.Label();
            txtDiscountPercent = new System.Windows.Forms.TextBox();
            lblDsicountAmount = new System.Windows.Forms.Label();
            txtDiscountAmount = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            txtTotal = new System.Windows.Forms.TextBox();
            btnCalculate = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lblEnterSubtotal = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            btnClear = new System.Windows.Forms.Button();
            lblNumberOfInvoices = new System.Windows.Forms.Label();
            lblTotalOfInvoices = new System.Windows.Forms.Label();
            lblInvoiceAverage = new System.Windows.Forms.Label();
            txtNumberOfInv = new System.Windows.Forms.TextBox();
            txtTotalOfInv = new System.Windows.Forms.TextBox();
            txtInvoiceAvg = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new System.Drawing.Point(21, 60);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new System.Drawing.Size(54, 15);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "&Subtotal:";
            lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new System.Drawing.Point(131, 60);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new System.Drawing.Size(100, 23);
            txtSubtotal.TabIndex = 2;
            // 
            // lblDiscountPercent
            // 
            lblDiscountPercent.AutoSize = true;
            lblDiscountPercent.Location = new System.Drawing.Point(21, 92);
            lblDiscountPercent.Name = "lblDiscountPercent";
            lblDiscountPercent.Size = new System.Drawing.Size(100, 15);
            lblDiscountPercent.TabIndex = 2;
            lblDiscountPercent.Text = "Discount Percent:";
            lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.Location = new System.Drawing.Point(131, 89);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.ReadOnly = true;
            txtDiscountPercent.Size = new System.Drawing.Size(100, 23);
            txtDiscountPercent.TabIndex = 3;
            txtDiscountPercent.TabStop = false;
            // 
            // lblDsicountAmount
            // 
            lblDsicountAmount.AutoSize = true;
            lblDsicountAmount.Location = new System.Drawing.Point(21, 121);
            lblDsicountAmount.Name = "lblDsicountAmount";
            lblDsicountAmount.Size = new System.Drawing.Size(104, 15);
            lblDsicountAmount.TabIndex = 4;
            lblDsicountAmount.Text = "Discount Amount:";
            lblDsicountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new System.Drawing.Point(131, 118);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new System.Drawing.Size(100, 23);
            txtDiscountAmount.TabIndex = 4;
            txtDiscountAmount.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(21, 150);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(35, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(131, 147);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new System.Drawing.Size(100, 23);
            txtTotal.TabIndex = 5;
            txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(364, 246);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(529, 246);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblEnterSubtotal
            // 
            lblEnterSubtotal.AutoSize = true;
            lblEnterSubtotal.Location = new System.Drawing.Point(21, 30);
            lblEnterSubtotal.Name = "lblEnterSubtotal";
            lblEnterSubtotal.Size = new System.Drawing.Size(84, 15);
            lblEnterSubtotal.TabIndex = 8;
            lblEnterSubtotal.Text = "Enter &Subtotal:";
            lblEnterSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(131, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(448, 246);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfInvoices
            // 
            lblNumberOfInvoices.AutoSize = true;
            lblNumberOfInvoices.Location = new System.Drawing.Point(364, 97);
            lblNumberOfInvoices.Name = "lblNumberOfInvoices";
            lblNumberOfInvoices.Size = new System.Drawing.Size(114, 15);
            lblNumberOfInvoices.TabIndex = 9;
            lblNumberOfInvoices.Text = "Number of Invoices:";
            lblNumberOfInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalOfInvoices
            // 
            lblTotalOfInvoices.AutoSize = true;
            lblTotalOfInvoices.Location = new System.Drawing.Point(364, 126);
            lblTotalOfInvoices.Name = "lblTotalOfInvoices";
            lblTotalOfInvoices.Size = new System.Drawing.Size(95, 15);
            lblTotalOfInvoices.TabIndex = 10;
            lblTotalOfInvoices.Text = "Total of Invoices:";
            lblTotalOfInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoiceAverage
            // 
            lblInvoiceAverage.AutoSize = true;
            lblInvoiceAverage.Location = new System.Drawing.Point(364, 155);
            lblInvoiceAverage.Name = "lblInvoiceAverage";
            lblInvoiceAverage.Size = new System.Drawing.Size(94, 15);
            lblInvoiceAverage.TabIndex = 11;
            lblInvoiceAverage.Text = "Invoice Average:";
            lblInvoiceAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfInv
            // 
            txtNumberOfInv.Location = new System.Drawing.Point(504, 97);
            txtNumberOfInv.Name = "txtNumberOfInv";
            txtNumberOfInv.ReadOnly = true;
            txtNumberOfInv.Size = new System.Drawing.Size(100, 23);
            txtNumberOfInv.TabIndex = 12;
            txtNumberOfInv.TabStop = false;
            txtNumberOfInv.TextChanged += txtNumberOfInv_TextChanged;
            // 
            // txtTotalOfInv
            // 
            txtTotalOfInv.Location = new System.Drawing.Point(504, 123);
            txtTotalOfInv.Name = "txtTotalOfInv";
            txtTotalOfInv.ReadOnly = true;
            txtTotalOfInv.Size = new System.Drawing.Size(100, 23);
            txtTotalOfInv.TabIndex = 13;
            txtTotalOfInv.TabStop = false;
            // 
            // txtInvoiceAvg
            // 
            txtInvoiceAvg.Location = new System.Drawing.Point(504, 150);
            txtInvoiceAvg.Name = "txtInvoiceAvg";
            txtInvoiceAvg.ReadOnly = true;
            txtInvoiceAvg.Size = new System.Drawing.Size(100, 23);
            txtInvoiceAvg.TabIndex = 14;
            txtInvoiceAvg.TabStop = false;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(642, 293);
            Controls.Add(txtInvoiceAvg);
            Controls.Add(txtTotalOfInv);
            Controls.Add(txtNumberOfInv);
            Controls.Add(lblInvoiceAverage);
            Controls.Add(lblTotalOfInvoices);
            Controls.Add(lblNumberOfInvoices);
            Controls.Add(btnClear);
            Controls.Add(textBox1);
            Controls.Add(lblEnterSubtotal);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(lblDsicountAmount);
            Controls.Add(txtDiscountPercent);
            Controls.Add(lblDiscountPercent);
            Controls.Add(txtSubtotal);
            Controls.Add(lblSubtotal);
            Name = "frmInvoiceTotal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            Load += frmInvoiceTotal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.Label lblDsicountAmount;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEnterSubtotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNumberOfInvoices;
        private System.Windows.Forms.Label lblTotalOfInvoices;
        private System.Windows.Forms.Label lblInvoiceAverage;
        private System.Windows.Forms.TextBox txtNumberOfInv;
        private System.Windows.Forms.TextBox txtTotalOfInv;
        private System.Windows.Forms.TextBox txtInvoiceAvg;
    }
}

