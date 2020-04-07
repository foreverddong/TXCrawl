namespace TXCrawlWinformUI
{
    partial class QueryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.departingTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.arrivalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.departDatePicker = new System.Windows.Forms.DateTimePicker();
            this.economyButton = new System.Windows.Forms.RadioButton();
            this.businessButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departing Airport:";
            // 
            // departingTextbox
            // 
            this.departingTextbox.Location = new System.Drawing.Point(16, 32);
            this.departingTextbox.Name = "departingTextbox";
            this.departingTextbox.Size = new System.Drawing.Size(205, 25);
            this.departingTextbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arriving Airport:";
            // 
            // arrivalTextBox
            // 
            this.arrivalTextBox.Location = new System.Drawing.Point(16, 83);
            this.arrivalTextBox.Name = "arrivalTextBox";
            this.arrivalTextBox.Size = new System.Drawing.Size(205, 25);
            this.arrivalTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Departing Date:";
            // 
            // departDatePicker
            // 
            this.departDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.departDatePicker.Location = new System.Drawing.Point(16, 130);
            this.departDatePicker.Name = "departDatePicker";
            this.departDatePicker.Size = new System.Drawing.Size(200, 25);
            this.departDatePicker.TabIndex = 2;
            // 
            // economyButton
            // 
            this.economyButton.AutoSize = true;
            this.economyButton.Location = new System.Drawing.Point(6, 24);
            this.economyButton.Name = "economyButton";
            this.economyButton.Size = new System.Drawing.Size(84, 19);
            this.economyButton.TabIndex = 3;
            this.economyButton.TabStop = true;
            this.economyButton.Text = "Economy";
            this.economyButton.UseVisualStyleBackColor = true;
            // 
            // businessButton
            // 
            this.businessButton.AutoSize = true;
            this.businessButton.Location = new System.Drawing.Point(6, 49);
            this.businessButton.Name = "businessButton";
            this.businessButton.Size = new System.Drawing.Size(92, 19);
            this.businessButton.TabIndex = 3;
            this.businessButton.TabStop = true;
            this.businessButton.Text = "Business";
            this.businessButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.economyButton);
            this.groupBox1.Controls.Add(this.businessButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabin";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 252);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 42);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 316);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.departDatePicker);
            this.Controls.Add(this.arrivalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departingTextbox);
            this.Controls.Add(this.label1);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox departingTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arrivalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker departDatePicker;
        private System.Windows.Forms.RadioButton economyButton;
        private System.Windows.Forms.RadioButton businessButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
    }
}