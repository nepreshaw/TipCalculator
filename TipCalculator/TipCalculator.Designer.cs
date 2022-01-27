
namespace TipCalculator {
    partial class TipCalculator {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.txtTipRate = new System.Windows.Forms.TextBox();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.labelBill = new System.Windows.Forms.Label();
            this.labelTipRate = new System.Windows.Forms.Label();
            this.labelTipAmount = new System.Windows.Forms.Label();
            this.labelTotalBill = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(78, 280);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 34);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate Tip";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(254, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBill
            // 
            this.txtBill.AcceptsTab = true;
            this.txtBill.Location = new System.Drawing.Point(242, 22);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(150, 31);
            this.txtBill.TabIndex = 2;
            this.txtBill.TextChanged += new System.EventHandler(this.txtBill_TextChanged);
            // 
            // txtTipRate
            // 
            this.txtTipRate.AcceptsReturn = true;
            this.txtTipRate.AcceptsTab = true;
            this.txtTipRate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTipRate.Location = new System.Drawing.Point(242, 100);
            this.txtTipRate.Name = "txtTipRate";
            this.txtTipRate.PlaceholderText = "%";
            this.txtTipRate.Size = new System.Drawing.Size(150, 31);
            this.txtTipRate.TabIndex = 3;
            this.txtTipRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTipRate.TextChanged += new System.EventHandler(this.txtTipRate_TextChanged);
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Location = new System.Drawing.Point(242, 178);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.ReadOnly = true;
            this.txtTipAmount.Size = new System.Drawing.Size(150, 31);
            this.txtTipAmount.TabIndex = 4;
            // 
            // labelBill
            // 
            this.labelBill.AutoSize = true;
            this.labelBill.Location = new System.Drawing.Point(78, 25);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(34, 25);
            this.labelBill.TabIndex = 5;
            this.labelBill.Text = "Bill";
            this.labelBill.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTipRate
            // 
            this.labelTipRate.AutoSize = true;
            this.labelTipRate.Location = new System.Drawing.Point(78, 103);
            this.labelTipRate.Name = "labelTipRate";
            this.labelTipRate.Size = new System.Drawing.Size(115, 25);
            this.labelTipRate.TabIndex = 6;
            this.labelTipRate.Text = "Tip Rate in %";
            this.labelTipRate.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTipAmount
            // 
            this.labelTipAmount.AutoSize = true;
            this.labelTipAmount.Location = new System.Drawing.Point(78, 181);
            this.labelTipAmount.Name = "labelTipAmount";
            this.labelTipAmount.Size = new System.Drawing.Size(106, 25);
            this.labelTipAmount.TabIndex = 7;
            this.labelTipAmount.Text = "Tip Amount";
            // 
            // labelTotalBill
            // 
            this.labelTotalBill.AutoSize = true;
            this.labelTotalBill.Location = new System.Drawing.Point(78, 226);
            this.labelTotalBill.Name = "labelTotalBill";
            this.labelTotalBill.Size = new System.Drawing.Size(76, 25);
            this.labelTotalBill.TabIndex = 8;
            this.labelTotalBill.Text = "Total Bill";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(242, 223);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.Size = new System.Drawing.Size(150, 31);
            this.txtTotalBill.TabIndex = 9;
            // 
            // TipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 385);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.labelTotalBill);
            this.Controls.Add(this.labelTipAmount);
            this.Controls.Add(this.labelTipRate);
            this.Controls.Add(this.labelBill);
            this.Controls.Add(this.txtTipAmount);
            this.Controls.Add(this.txtTipRate);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "TipCalculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.TextBox txtTipRate;
        private System.Windows.Forms.TextBox txtTipAmount;
        private System.Windows.Forms.Label labelBill;
        private System.Windows.Forms.Label labelTipRate;
        private System.Windows.Forms.Label labelTipAmount;
        private System.Windows.Forms.Label labelTotalBill;
        private System.Windows.Forms.TextBox txtTotalBill;
    }
}

