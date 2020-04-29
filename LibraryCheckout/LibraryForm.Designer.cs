namespace LibraryCheckout
{
    partial class LibraryForm
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
            this.returnBox = new System.Windows.Forms.ListBox();
            this.outBttn = new System.Windows.Forms.Button();
            this.mysteryBox = new System.Windows.Forms.ListBox();
            this.returnBttn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.checkoutLabel = new System.Windows.Forms.Label();
            this.returnLabel = new System.Windows.Forms.Label();
            this.fantasyBox = new System.Windows.Forms.ListBox();
            this.scifiBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mysteryDetail = new System.Windows.Forms.Button();
            this.fantasyDetail = new System.Windows.Forms.Button();
            this.scifiDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnBox
            // 
            this.returnBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.returnBox.FormattingEnabled = true;
            this.returnBox.Location = new System.Drawing.Point(391, 41);
            this.returnBox.Name = "returnBox";
            this.returnBox.Size = new System.Drawing.Size(110, 134);
            this.returnBox.TabIndex = 0;
            // 
            // outBttn
            // 
            this.outBttn.Location = new System.Drawing.Point(139, 201);
            this.outBttn.Name = "outBttn";
            this.outBttn.Size = new System.Drawing.Size(78, 42);
            this.outBttn.TabIndex = 1;
            this.outBttn.Text = "Check Out";
            this.outBttn.UseVisualStyleBackColor = true;
            this.outBttn.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // mysteryBox
            // 
            this.mysteryBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mysteryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mysteryBox.FormattingEnabled = true;
            this.mysteryBox.Location = new System.Drawing.Point(8, 57);
            this.mysteryBox.Name = "mysteryBox";
            this.mysteryBox.Size = new System.Drawing.Size(105, 95);
            this.mysteryBox.TabIndex = 2;
            // 
            // returnBttn
            // 
            this.returnBttn.Location = new System.Drawing.Point(406, 201);
            this.returnBttn.Name = "returnBttn";
            this.returnBttn.Size = new System.Drawing.Size(72, 42);
            this.returnBttn.TabIndex = 3;
            this.returnBttn.Text = "Return a Book";
            this.returnBttn.UseVisualStyleBackColor = true;
            this.returnBttn.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 248);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 4;
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutLabel.Location = new System.Drawing.Point(146, 9);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(72, 20);
            this.checkoutLabel.TabIndex = 6;
            this.checkoutLabel.Text = "Shelves";
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.Location = new System.Drawing.Point(414, 9);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(64, 20);
            this.returnLabel.TabIndex = 7;
            this.returnLabel.Text = "Return";
            this.returnLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fantasyBox
            // 
            this.fantasyBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.fantasyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fantasyBox.FormattingEnabled = true;
            this.fantasyBox.Location = new System.Drawing.Point(128, 57);
            this.fantasyBox.Name = "fantasyBox";
            this.fantasyBox.Size = new System.Drawing.Size(105, 95);
            this.fantasyBox.TabIndex = 8;
            // 
            // scifiBox
            // 
            this.scifiBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.scifiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scifiBox.FormattingEnabled = true;
            this.scifiBox.Location = new System.Drawing.Point(248, 57);
            this.scifiBox.Name = "scifiBox";
            this.scifiBox.Size = new System.Drawing.Size(105, 95);
            this.scifiBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mystery";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fantasy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sci-fi";
            // 
            // mysteryDetail
            // 
            this.mysteryDetail.Location = new System.Drawing.Point(36, 163);
            this.mysteryDetail.Name = "mysteryDetail";
            this.mysteryDetail.Size = new System.Drawing.Size(52, 23);
            this.mysteryDetail.TabIndex = 13;
            this.mysteryDetail.Text = "Detail";
            this.mysteryDetail.UseVisualStyleBackColor = true;
            this.mysteryDetail.Click += new System.EventHandler(this.DetailButton_Click);
            // 
            // fantasyDetail
            // 
            this.fantasyDetail.Location = new System.Drawing.Point(153, 163);
            this.fantasyDetail.Name = "fantasyDetail";
            this.fantasyDetail.Size = new System.Drawing.Size(52, 23);
            this.fantasyDetail.TabIndex = 14;
            this.fantasyDetail.Text = "Detail";
            this.fantasyDetail.UseVisualStyleBackColor = true;
            this.fantasyDetail.Click += new System.EventHandler(this.DetailButton2_Click);
            // 
            // scifiDetail
            // 
            this.scifiDetail.Location = new System.Drawing.Point(273, 163);
            this.scifiDetail.Name = "scifiDetail";
            this.scifiDetail.Size = new System.Drawing.Size(52, 23);
            this.scifiDetail.TabIndex = 15;
            this.scifiDetail.Text = "Detail";
            this.scifiDetail.UseVisualStyleBackColor = true;
            this.scifiDetail.Click += new System.EventHandler(this.DetailButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(563, 270);
            this.Controls.Add(this.scifiDetail);
            this.Controls.Add(this.fantasyDetail);
            this.Controls.Add(this.mysteryDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scifiBox);
            this.Controls.Add(this.fantasyBox);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.checkoutLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.returnBttn);
            this.Controls.Add(this.mysteryBox);
            this.Controls.Add(this.outBttn);
            this.Controls.Add(this.returnBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Library Checkout Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox returnBox;
        private System.Windows.Forms.Button outBttn;
        private System.Windows.Forms.ListBox mysteryBox;
        private System.Windows.Forms.Button returnBttn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label checkoutLabel;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.ListBox fantasyBox;
        private System.Windows.Forms.ListBox scifiBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mysteryDetail;
        private System.Windows.Forms.Button fantasyDetail;
        private System.Windows.Forms.Button scifiDetail;
    }
}

