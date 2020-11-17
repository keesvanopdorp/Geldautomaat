namespace GeldAutomaat
{
    partial class WidthdrawCash
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
            this.BtnWithdraw50 = new System.Windows.Forms.Button();
            this.BtnWithdraw10 = new System.Windows.Forms.Button();
            this.BtnWithdraw100 = new System.Windows.Forms.Button();
            this.BtnWithdraw20 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblShowBalance
            // 
            this.LblShowBalance.AutoSize = true;
            this.LblShowBalance.Location = new System.Drawing.Point(359, 108);
            this.LblShowBalance.Name = "LblShowBalance";
            this.LblShowBalance.Size = new System.Drawing.Size(35, 13);
            this.LblShowBalance.TabIndex = 1;
            this.LblShowBalance.Text = "label1";
            // 
            // BtnWithdraw50
            // 
            this.BtnWithdraw50.Location = new System.Drawing.Point(397, 162);
            this.BtnWithdraw50.Name = "BtnWithdraw50";
            this.BtnWithdraw50.Size = new System.Drawing.Size(203, 88);
            this.BtnWithdraw50.TabIndex = 9;
            this.BtnWithdraw50.Text = "€ 50,00";
            this.BtnWithdraw50.UseVisualStyleBackColor = true;
            this.BtnWithdraw50.Click += new System.EventHandler(this.BtnWithdraw50_Click);
            // 
            // BtnWithdraw10
            // 
            this.BtnWithdraw10.Location = new System.Drawing.Point(147, 281);
            this.BtnWithdraw10.Name = "BtnWithdraw10";
            this.BtnWithdraw10.Size = new System.Drawing.Size(203, 88);
            this.BtnWithdraw10.TabIndex = 8;
            this.BtnWithdraw10.Tag = "";
            this.BtnWithdraw10.Text = "€ 10,00";
            this.BtnWithdraw10.UseVisualStyleBackColor = true;
            this.BtnWithdraw10.Click += new System.EventHandler(this.BtnWithdraw10_Click);
            // 
            // BtnWithdraw100
            // 
            this.BtnWithdraw100.Location = new System.Drawing.Point(397, 281);
            this.BtnWithdraw100.Name = "BtnWithdraw100";
            this.BtnWithdraw100.Size = new System.Drawing.Size(203, 88);
            this.BtnWithdraw100.TabIndex = 7;
            this.BtnWithdraw100.Text = "€ 100,00";
            this.BtnWithdraw100.UseVisualStyleBackColor = true;
            this.BtnWithdraw100.Click += new System.EventHandler(this.BtnWithdraw100_Click);
            // 
            // BtnWithdraw20
            // 
            this.BtnWithdraw20.Location = new System.Drawing.Point(147, 162);
            this.BtnWithdraw20.Name = "BtnWithdraw20";
            this.BtnWithdraw20.Size = new System.Drawing.Size(203, 88);
            this.BtnWithdraw20.TabIndex = 6;
            this.BtnWithdraw20.Text = "€ 20,00";
            this.BtnWithdraw20.UseVisualStyleBackColor = true;
            this.BtnWithdraw20.Click += new System.EventHandler(this.BtnWithdraw20_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(179, 50);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Terug";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.AutoSize = true;
            this.LblErrorMessage.Location = new System.Drawing.Point(359, 409);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.LblErrorMessage.TabIndex = 11;
            // 
            // WidthdrawCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblErrorMessage);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnWithdraw50);
            this.Controls.Add(this.BtnWithdraw10);
            this.Controls.Add(this.BtnWithdraw100);
            this.Controls.Add(this.BtnWithdraw20);
            this.Controls.Add(this.LblShowBalance);
            this.Name = "WidthdrawCash";
            this.Text = "WidthdrawCash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblShowBalance;
        private System.Windows.Forms.Button BtnWithdraw50;
        private System.Windows.Forms.Button BtnWithdraw10;
        private System.Windows.Forms.Button BtnWithdraw100;
        private System.Windows.Forms.Button BtnWithdraw20;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblErrorMessage;
    }
}