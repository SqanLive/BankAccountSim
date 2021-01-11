
namespace BankAccountSim
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.depositTextbox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawTextbox = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.creditTextbox = new System.Windows.Forms.TextBox();
            this.creditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(447, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Balance";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.balanceLabel.Location = new System.Drawing.Point(536, 181);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(86, 31);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "label2";
            // 
            // depositTextbox
            // 
            this.depositTextbox.Location = new System.Drawing.Point(35, 96);
            this.depositTextbox.Name = "depositTextbox";
            this.depositTextbox.Size = new System.Drawing.Size(100, 20);
            this.depositTextbox.TabIndex = 2;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(171, 96);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 20);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawTextbox
            // 
            this.withdrawTextbox.Location = new System.Drawing.Point(35, 193);
            this.withdrawTextbox.Name = "withdrawTextbox";
            this.withdrawTextbox.Size = new System.Drawing.Size(100, 20);
            this.withdrawTextbox.TabIndex = 4;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(171, 193);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 20);
            this.withdrawButton.TabIndex = 5;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.creditLabel.Location = new System.Drawing.Point(536, 306);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(86, 31);
            this.creditLabel.TabIndex = 6;
            this.creditLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(467, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Credit Balance";
            // 
            // creditTextbox
            // 
            this.creditTextbox.Location = new System.Drawing.Point(35, 279);
            this.creditTextbox.Name = "creditTextbox";
            this.creditTextbox.Size = new System.Drawing.Size(100, 20);
            this.creditTextbox.TabIndex = 8;
            // 
            // creditButton
            // 
            this.creditButton.Location = new System.Drawing.Point(171, 278);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(75, 20);
            this.creditButton.TabIndex = 9;
            this.creditButton.Text = "Take Credit";
            this.creditButton.UseVisualStyleBackColor = true;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.creditTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.withdrawTextbox);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.depositTextbox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox depositTextbox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox withdrawTextbox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox creditTextbox;
        private System.Windows.Forms.Button creditButton;
    }
}

