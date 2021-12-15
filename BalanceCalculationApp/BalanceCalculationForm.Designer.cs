namespace BalanceCalculationApp
{
    partial class BalanceCalculationForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.textBoxAmountReceived = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.labelBalanceDisplay = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelDenominationsDisplay = new System.Windows.Forms.Label();
            this.labelDenominations = new System.Windows.Forms.Label();
            this.errorProviderProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAmountReceived = new System.Windows.Forms.ErrorProvider(this.components);
            this.Reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmountReceived)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(290, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the product price(£) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(290, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter amount received(£):";
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(527, 71);
            this.textBoxProduct.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(132, 22);
            this.textBoxProduct.TabIndex = 2;
            // 
            // textBoxAmountReceived
            // 
            this.textBoxAmountReceived.Location = new System.Drawing.Point(527, 118);
            this.textBoxAmountReceived.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmountReceived.Name = "textBoxAmountReceived";
            this.textBoxAmountReceived.Size = new System.Drawing.Size(132, 22);
            this.textBoxAmountReceived.TabIndex = 3;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculate.Location = new System.Drawing.Point(387, 182);
            this.calculate.Margin = new System.Windows.Forms.Padding(4);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(100, 28);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // labelBalanceDisplay
            // 
            this.labelBalanceDisplay.AutoSize = true;
            this.labelBalanceDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceDisplay.ForeColor = System.Drawing.SystemColors.Info;
            this.labelBalanceDisplay.Location = new System.Drawing.Point(300, 283);
            this.labelBalanceDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalanceDisplay.Name = "labelBalanceDisplay";
            this.labelBalanceDisplay.Size = new System.Drawing.Size(137, 17);
            this.labelBalanceDisplay.TabIndex = 5;
            this.labelBalanceDisplay.Text = "Balance Amount(£) :";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(527, 283);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(0, 29);
            this.labelBalance.TabIndex = 6;
            // 
            // labelDenominationsDisplay
            // 
            this.labelDenominationsDisplay.AutoSize = true;
            this.labelDenominationsDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenominationsDisplay.ForeColor = System.Drawing.SystemColors.Info;
            this.labelDenominationsDisplay.Location = new System.Drawing.Point(304, 342);
            this.labelDenominationsDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDenominationsDisplay.Name = "labelDenominationsDisplay";
            this.labelDenominationsDisplay.Size = new System.Drawing.Size(110, 17);
            this.labelDenominationsDisplay.TabIndex = 7;
            this.labelDenominationsDisplay.Text = "Denominations :";
            // 
            // labelDenominations
            // 
            this.labelDenominations.AutoSize = true;
            this.labelDenominations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenominations.Location = new System.Drawing.Point(523, 342);
            this.labelDenominations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDenominations.Name = "labelDenominations";
            this.labelDenominations.Size = new System.Drawing.Size(0, 20);
            this.labelDenominations.TabIndex = 8;
            // 
            // errorProviderProduct
            // 
            this.errorProviderProduct.ContainerControl = this;
            // 
            // errorProviderAmountReceived
            // 
            this.errorProviderAmountReceived.ContainerControl = this;
            // 
            // Reset
            // 
            this.Reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reset.Location = new System.Drawing.Point(531, 182);
            this.Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 28);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(357, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "BALANCE CALCULATOR";
            // 
            // BalanceCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.labelDenominations);
            this.Controls.Add(this.labelDenominationsDisplay);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelBalanceDisplay);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.textBoxAmountReceived);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BalanceCalculationForm";
            this.Text = "BalanceCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmountReceived)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.TextBox textBoxAmountReceived;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label labelBalanceDisplay;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelDenominationsDisplay;
        private System.Windows.Forms.Label labelDenominations;
        private System.Windows.Forms.ErrorProvider errorProviderProduct;
        private System.Windows.Forms.ErrorProvider errorProviderAmountReceived;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label5;
    }
}

