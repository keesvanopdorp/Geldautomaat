namespace GeldAutomaat
{
    partial class DepositCash
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.NumDepositCash = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDepositCash = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumDepositCash)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 50);
            this.BtnBack.TabIndex = 11;
            this.BtnBack.Text = "Terug";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // NumDepositCash
            // 
            this.NumDepositCash.DecimalPlaces = 2;
            this.NumDepositCash.Location = new System.Drawing.Point(272, 170);
            this.NumDepositCash.Name = "NumDepositCash";
            this.NumDepositCash.Size = new System.Drawing.Size(218, 20);
            this.NumDepositCash.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(294, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Geld Storten";
            // 
            // BtnDepositCash
            // 
            this.BtnDepositCash.Location = new System.Drawing.Point(272, 224);
            this.BtnDepositCash.Name = "BtnDepositCash";
            this.BtnDepositCash.Size = new System.Drawing.Size(218, 44);
            this.BtnDepositCash.TabIndex = 14;
            this.BtnDepositCash.Text = "Stort Geld";
            this.BtnDepositCash.UseVisualStyleBackColor = true;
            this.BtnDepositCash.Click += new System.EventHandler(this.BtnDepositCash_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bedrag:";
            // 
            // DepositCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDepositCash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumDepositCash);
            this.Controls.Add(this.BtnBack);
            this.Name = "DepositCash";
            this.Text = "DepositCash";
            ((System.ComponentModel.ISupportInitialize)(this.NumDepositCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.NumericUpDown NumDepositCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDepositCash;
        private System.Windows.Forms.Label label2;
    }
}