namespace House_Price
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Total_House_Price = new System.Windows.Forms.Label();
            this.Down_Payment = new System.Windows.Forms.Label();
            this.Annual_Interest_Rate = new System.Windows.Forms.Label();
            this.Loan_Term = new System.Windows.Forms.Label();
            this.Grace_Period = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Total_House_Price
            // 
            this.Total_House_Price.AutoSize = true;
            this.Total_House_Price.Location = new System.Drawing.Point(91, 99);
            this.Total_House_Price.Name = "Total_House_Price";
            this.Total_House_Price.Size = new System.Drawing.Size(106, 24);
            this.Total_House_Price.TabIndex = 0;
            this.Total_House_Price.Text = "房屋總價";
            // 
            // Down_Payment
            // 
            this.Down_Payment.AutoSize = true;
            this.Down_Payment.Location = new System.Drawing.Point(91, 153);
            this.Down_Payment.Name = "Down_Payment";
            this.Down_Payment.Size = new System.Drawing.Size(130, 24);
            this.Down_Payment.TabIndex = 1;
            this.Down_Payment.Text = "自備款比例";
            // 
            // Annual_Interest_Rate
            // 
            this.Annual_Interest_Rate.AutoSize = true;
            this.Annual_Interest_Rate.Location = new System.Drawing.Point(91, 213);
            this.Annual_Interest_Rate.Name = "Annual_Interest_Rate";
            this.Annual_Interest_Rate.Size = new System.Drawing.Size(106, 24);
            this.Annual_Interest_Rate.TabIndex = 2;
            this.Annual_Interest_Rate.Text = "貸款利率";
            // 
            // Loan_Term
            // 
            this.Loan_Term.AutoSize = true;
            this.Loan_Term.Location = new System.Drawing.Point(91, 270);
            this.Loan_Term.Name = "Loan_Term";
            this.Loan_Term.Size = new System.Drawing.Size(106, 24);
            this.Loan_Term.TabIndex = 3;
            this.Loan_Term.Text = "貸款年限";
            // 
            // Grace_Period
            // 
            this.Grace_Period.AutoSize = true;
            this.Grace_Period.Location = new System.Drawing.Point(91, 319);
            this.Grace_Period.Name = "Grace_Period";
            this.Grace_Period.Size = new System.Drawing.Size(82, 24);
            this.Grace_Period.TabIndex = 4;
            this.Grace_Period.Text = "寬限期";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 650);
            this.Controls.Add(this.Grace_Period);
            this.Controls.Add(this.Loan_Term);
            this.Controls.Add(this.Annual_Interest_Rate);
            this.Controls.Add(this.Down_Payment);
            this.Controls.Add(this.Total_House_Price);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Total_House_Price;
        private System.Windows.Forms.Label Down_Payment;
        private System.Windows.Forms.Label Annual_Interest_Rate;
        private System.Windows.Forms.Label Loan_Term;
        private System.Windows.Forms.Label Grace_Period;
    }
}

