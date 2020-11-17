namespace Geldautomaat_admin
{
    partial class Main
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
            this.DgvAccounts = new System.Windows.Forms.DataGridView();
            this.NumAccountNumber = new System.Windows.Forms.NumericUpDown();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.NumPassword = new System.Windows.Forms.NumericUpDown();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.ChbBlocked = new System.Windows.Forms.CheckBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.BtnClearFlieds = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSearchLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSearchAccountNumber = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAccountNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAccounts
            // 
            this.DgvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAccounts.Location = new System.Drawing.Point(303, 101);
            this.DgvAccounts.Name = "DgvAccounts";
            this.DgvAccounts.Size = new System.Drawing.Size(470, 337);
            this.DgvAccounts.TabIndex = 0;
            this.DgvAccounts.DoubleClick += new System.EventHandler(this.DgvAccounts_DoubleClick);
            // 
            // NumAccountNumber
            // 
            this.NumAccountNumber.Location = new System.Drawing.Point(12, 57);
            this.NumAccountNumber.Name = "NumAccountNumber";
            this.NumAccountNumber.Size = new System.Drawing.Size(273, 20);
            this.NumAccountNumber.TabIndex = 1;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(11, 180);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(272, 20);
            this.TxtFirstName.TabIndex = 2;
            // 
            // NumPassword
            // 
            this.NumPassword.Location = new System.Drawing.Point(11, 125);
            this.NumPassword.Name = "NumPassword";
            this.NumPassword.Size = new System.Drawing.Size(273, 20);
            this.NumPassword.TabIndex = 3;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(14, 237);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(272, 20);
            this.TxtLastName.TabIndex = 4;
            // 
            // ChbBlocked
            // 
            this.ChbBlocked.AutoSize = true;
            this.ChbBlocked.Location = new System.Drawing.Point(14, 291);
            this.ChbBlocked.Name = "ChbBlocked";
            this.ChbBlocked.Size = new System.Drawing.Size(79, 17);
            this.ChbBlocked.TabIndex = 5;
            this.ChbBlocked.Text = "geblokeerd";
            this.ChbBlocked.UseVisualStyleBackColor = true;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(11, 314);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(271, 23);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "Maak aan";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "rekeningnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "pincode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "voornaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "achternaam";
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.Location = new System.Drawing.Point(12, 349);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(271, 23);
            this.BtnDeleteUser.TabIndex = 11;
            this.BtnDeleteUser.Text = "Verwijder huidige gebruiker";
            this.BtnDeleteUser.UseVisualStyleBackColor = true;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // BtnClearFlieds
            // 
            this.BtnClearFlieds.Location = new System.Drawing.Point(11, 383);
            this.BtnClearFlieds.Name = "BtnClearFlieds";
            this.BtnClearFlieds.Size = new System.Drawing.Size(271, 23);
            this.BtnClearFlieds.TabIndex = 12;
            this.BtnClearFlieds.Text = "Leeg velden";
            this.BtnClearFlieds.UseVisualStyleBackColor = true;
            this.BtnClearFlieds.Click += new System.EventHandler(this.BtnClearFlieds_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "zoeken";
            // 
            // TxtSearchLastName
            // 
            this.TxtSearchLastName.Location = new System.Drawing.Point(303, 38);
            this.TxtSearchLastName.Name = "TxtSearchLastName";
            this.TxtSearchLastName.Size = new System.Drawing.Size(232, 20);
            this.TxtSearchLastName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "achternaam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(618, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "rekeningnummer";
            // 
            // TxtSearchAccountNumber
            // 
            this.TxtSearchAccountNumber.Location = new System.Drawing.Point(541, 38);
            this.TxtSearchAccountNumber.Name = "TxtSearchAccountNumber";
            this.TxtSearchAccountNumber.Size = new System.Drawing.Size(232, 20);
            this.TxtSearchAccountNumber.TabIndex = 16;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(303, 72);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(232, 23);
            this.BtnSearch.TabIndex = 18;
            this.BtnSearch.Text = "Zoeken";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(541, 72);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(232, 23);
            this.BtnBack.TabIndex = 19;
            this.BtnBack.Text = "Terug";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSearchAccountNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSearchLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnClearFlieds);
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.ChbBlocked);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.NumPassword);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.NumAccountNumber);
            this.Controls.Add(this.DgvAccounts);
            this.Name = "Main";
            this.Text = "Geldautomaat: admin";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAccountNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAccounts;
        private System.Windows.Forms.NumericUpDown NumAccountNumber;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.NumericUpDown NumPassword;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.CheckBox ChbBlocked;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.Button BtnClearFlieds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSearchLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSearchAccountNumber;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnBack;
    }
}

