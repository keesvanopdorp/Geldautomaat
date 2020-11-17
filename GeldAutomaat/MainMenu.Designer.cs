namespace GeldAutomaat
{
    partial class MainMenu
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
            this.LblShowBalance = new System.Windows.Forms.Label();
            this.LblShowFullName = new System.Windows.Forms.Label();
            this.BtnWithdrawCash = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnLatestTransactions = new System.Windows.Forms.Button();
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblShowBalance
            // 
            this.LblShowBalance.AutoSize = true;
            this.LblShowBalance.Location = new System.Drawing.Point(349, 111);
            this.LblShowBalance.Name = "LblShowBalance";
            this.LblShowBalance.Size = new System.Drawing.Size(35, 13);
            this.LblShowBalance.TabIndex = 0;
            this.LblShowBalance.Text = "label1";
            // 
            // LblShowFullName
            // 
            this.LblShowFullName.AutoSize = true;
            this.LblShowFullName.Location = new System.Drawing.Point(349, 47);
            this.LblShowFullName.Name = "LblShowFullName";
            this.LblShowFullName.Size = new System.Drawing.Size(35, 13);
            this.LblShowFullName.TabIndex = 1;
            this.LblShowFullName.Text = "label1";
            // 
            // BtnWithdrawCash
            // 
            this.BtnWithdrawCash.Location = new System.Drawing.Point(155, 169);
            this.BtnWithdrawCash.Name = "BtnWithdrawCash";
            this.BtnWithdrawCash.Size = new System.Drawing.Size(203, 88);
            this.BtnWithdrawCash.TabIndex = 2;
            this.BtnWithdrawCash.Text = "Geld opnemen";
            this.BtnWithdrawCash.UseVisualStyleBackColor = true;
            this.BtnWithdrawCash.Click += new System.EventHandler(this.BtnWithdrawCash_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(405, 288);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(203, 88);
            this.BtnLogout.TabIndex = 3;
            this.BtnLogout.Text = "Uitloggen";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnLatestTransactions
            // 
            this.BtnLatestTransactions.Location = new System.Drawing.Point(405, 169);
            this.BtnLatestTransactions.Name = "BtnLatestTransactions";
            this.BtnLatestTransactions.Size = new System.Drawing.Size(203, 88);
            this.BtnLatestTransactions.TabIndex = 5;
            this.BtnLatestTransactions.Text = "Laatste transacties";
            this.BtnLatestTransactions.UseVisualStyleBackColor = true;
            this.BtnLatestTransactions.Click += new System.EventHandler(this.BtnLatestTransactions_Click);
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.Location = new System.Drawing.Point(155, 288);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(203, 88);
            this.BtnDeposit.TabIndex = 4;
            this.BtnDeposit.Text = "Geld storten";
            this.BtnDeposit.UseVisualStyleBackColor = true;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLatestTransactions);
            this.Controls.Add(this.BtnDeposit);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnWithdrawCash);
            this.Controls.Add(this.LblShowFullName);
            this.Controls.Add(this.LblShowBalance);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblShowBalance;
        private System.Windows.Forms.Label LblShowFullName;
        private System.Windows.Forms.Button BtnWithdrawCash;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnLatestTransactions;
        private System.Windows.Forms.Button BtnDeposit;
    }
}