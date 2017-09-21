namespace BarcodeGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.submitButton = new System.Windows.Forms.Button();
            this.barcodeRange1 = new System.Windows.Forms.ComboBox();
            this.barcodeRange2 = new System.Windows.Forms.ComboBox();
            this.lastRange1 = new System.Windows.Forms.Label();
            this.lastRange2 = new System.Windows.Forms.Label();
            this.rangeCount = new System.Windows.Forms.Label();
            this.lastSubmitDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(286, 270);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // barcodeRange1
            // 
            this.barcodeRange1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.barcodeRange1.FormattingEnabled = true;
            this.barcodeRange1.Items.AddRange(new object[] {
            "51000001849",
            "51000001850",
            "51000001851",
            "51000001852",
            "51000001853",
            "51000001854",
            "51000001855",
            "51000001856",
            "51000001857",
            "51000001858",
            "51000001859",
            "51000001860",
            "51000001861",
            "51000001862",
            "51000001863",
            "51000001864",
            "51000001865",
            "51000001866",
            "51000001867",
            "51000001868"});
            this.barcodeRange1.Location = new System.Drawing.Point(191, 105);
            this.barcodeRange1.Name = "barcodeRange1";
            this.barcodeRange1.Size = new System.Drawing.Size(121, 150);
            this.barcodeRange1.TabIndex = 4;
            this.barcodeRange1.SelectedIndexChanged += new System.EventHandler(this.barcodeRange1_SelectedIndexChanged);
            // 
            // barcodeRange2
            // 
            this.barcodeRange2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.barcodeRange2.FormattingEnabled = true;
            this.barcodeRange2.Items.AddRange(new object[] {
            "51000001849",
            "51000001850",
            "51000001851",
            "51000001852",
            "51000001853",
            "51000001854",
            "51000001855",
            "51000001856",
            "51000001857",
            "51000001858",
            "51000001859",
            "51000001860",
            "51000001861",
            "51000001862",
            "51000001863",
            "51000001864",
            "51000001865",
            "51000001866",
            "51000001867",
            "51000001868"});
            this.barcodeRange2.Location = new System.Drawing.Point(362, 105);
            this.barcodeRange2.Name = "barcodeRange2";
            this.barcodeRange2.Size = new System.Drawing.Size(121, 150);
            this.barcodeRange2.TabIndex = 5;
            this.barcodeRange2.SelectedIndexChanged += new System.EventHandler(this.barcodeRange2_SelectedIndexChanged);
            // 
            // lastRange1
            // 
            this.lastRange1.AutoSize = true;
            this.lastRange1.Location = new System.Drawing.Point(293, 388);
            this.lastRange1.Name = "lastRange1";
            this.lastRange1.Size = new System.Drawing.Size(73, 13);
            this.lastRange1.TabIndex = 7;
            this.lastRange1.Text = "51000001839";
            this.lastRange1.Click += new System.EventHandler(this.lastRange1_Click);
            // 
            // lastRange2
            // 
            this.lastRange2.AutoSize = true;
            this.lastRange2.Location = new System.Drawing.Point(394, 388);
            this.lastRange2.Name = "lastRange2";
            this.lastRange2.Size = new System.Drawing.Size(73, 13);
            this.lastRange2.TabIndex = 11;
            this.lastRange2.Text = "51000001848";
            this.lastRange2.Click += new System.EventHandler(this.lastRange2_Click);
            // 
            // rangeCount
            // 
            this.rangeCount.AutoSize = true;
            this.rangeCount.Location = new System.Drawing.Point(353, 79);
            this.rangeCount.Name = "rangeCount";
            this.rangeCount.Size = new System.Drawing.Size(13, 13);
            this.rangeCount.TabIndex = 10;
            this.rangeCount.Text = "0";
            this.rangeCount.Click += new System.EventHandler(this.rangeCount_Click);
            // 
            // lastSubmitDate
            // 
            this.lastSubmitDate.AutoSize = true;
            this.lastSubmitDate.Location = new System.Drawing.Point(293, 375);
            this.lastSubmitDate.Name = "lastSubmitDate";
            this.lastSubmitDate.Size = new System.Drawing.Size(110, 13);
            this.lastSubmitDate.TabIndex = 12;
            this.lastSubmitDate.Text = "13/09/2017 10:00:50";
            this.lastSubmitDate.Click += new System.EventHandler(this.lastSubmitDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Range of Barcodes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "barcodes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last range entered:\r\nRange:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "to";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(703, 443);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.barcodeRange1);
            this.Controls.Add(this.barcodeRange2);
            this.Controls.Add(this.lastRange1);
            this.Controls.Add(this.lastRange2);
            this.Controls.Add(this.rangeCount);
            this.Controls.Add(this.lastSubmitDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox barcodeRange1;
        private System.Windows.Forms.ComboBox barcodeRange2;
        private System.Windows.Forms.Label lastRange1;
        private System.Windows.Forms.Label lastRange2;
        private System.Windows.Forms.Label rangeCount;
        private System.Windows.Forms.Label lastSubmitDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

