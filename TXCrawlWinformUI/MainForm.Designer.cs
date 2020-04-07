namespace TXCrawlWinformUI
{
    partial class MainForm
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
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.queryBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.foundTicketBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newQueryButton = new System.Windows.Forms.Button();
            this.removeQueryButton = new System.Windows.Forms.Button();
            this.removeTicketButton = new System.Windows.Forms.Button();
            this.logClearButton = new System.Windows.Forms.Button();
            this.execOnceButton = new System.Windows.Forms.Button();
            this.execRepeatButton = new System.Windows.Forms.Button();
            this.intervalPicker = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.querySaveButton = new System.Windows.Forms.Button();
            this.queryLoadButton = new System.Windows.Forms.Button();
            this.ticketSaveButton = new System.Windows.Forms.Button();
            this.ticketLoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intervalPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Console";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(16, 41);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(716, 518);
            this.logTextBox.TabIndex = 1;
            // 
            // queryBox
            // 
            this.queryBox.FormattingEnabled = true;
            this.queryBox.ItemHeight = 15;
            this.queryBox.Location = new System.Drawing.Point(738, 41);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(237, 514);
            this.queryBox.TabIndex = 2;
            this.queryBox.DoubleClick += new System.EventHandler(this.queryBox_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Query";
            // 
            // foundTicketBox
            // 
            this.foundTicketBox.FormattingEnabled = true;
            this.foundTicketBox.ItemHeight = 15;
            this.foundTicketBox.Location = new System.Drawing.Point(981, 41);
            this.foundTicketBox.Name = "foundTicketBox";
            this.foundTicketBox.Size = new System.Drawing.Size(493, 514);
            this.foundTicketBox.TabIndex = 2;
            this.foundTicketBox.DoubleClick += new System.EventHandler(this.foundTicketBox_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(978, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Found Ticket";
            // 
            // newQueryButton
            // 
            this.newQueryButton.Location = new System.Drawing.Point(738, 561);
            this.newQueryButton.Name = "newQueryButton";
            this.newQueryButton.Size = new System.Drawing.Size(44, 41);
            this.newQueryButton.TabIndex = 3;
            this.newQueryButton.Text = "+";
            this.newQueryButton.UseVisualStyleBackColor = true;
            this.newQueryButton.Click += new System.EventHandler(this.newQueryButton_Click);
            // 
            // removeQueryButton
            // 
            this.removeQueryButton.Location = new System.Drawing.Point(931, 561);
            this.removeQueryButton.Name = "removeQueryButton";
            this.removeQueryButton.Size = new System.Drawing.Size(44, 41);
            this.removeQueryButton.TabIndex = 3;
            this.removeQueryButton.Text = "-";
            this.removeQueryButton.UseVisualStyleBackColor = true;
            this.removeQueryButton.Click += new System.EventHandler(this.removeQueryButton_Click);
            // 
            // removeTicketButton
            // 
            this.removeTicketButton.Location = new System.Drawing.Point(1430, 562);
            this.removeTicketButton.Name = "removeTicketButton";
            this.removeTicketButton.Size = new System.Drawing.Size(44, 41);
            this.removeTicketButton.TabIndex = 3;
            this.removeTicketButton.Text = "-";
            this.removeTicketButton.UseVisualStyleBackColor = true;
            // 
            // logClearButton
            // 
            this.logClearButton.Location = new System.Drawing.Point(16, 566);
            this.logClearButton.Name = "logClearButton";
            this.logClearButton.Size = new System.Drawing.Size(133, 37);
            this.logClearButton.TabIndex = 4;
            this.logClearButton.Text = "Clear Log";
            this.logClearButton.UseVisualStyleBackColor = true;
            this.logClearButton.Click += new System.EventHandler(this.logClearButton_Click);
            // 
            // execOnceButton
            // 
            this.execOnceButton.Location = new System.Drawing.Point(16, 627);
            this.execOnceButton.Name = "execOnceButton";
            this.execOnceButton.Size = new System.Drawing.Size(133, 45);
            this.execOnceButton.TabIndex = 5;
            this.execOnceButton.Text = "Execute Once";
            this.execOnceButton.UseVisualStyleBackColor = true;
            this.execOnceButton.Click += new System.EventHandler(this.execOnceButton_Click);
            // 
            // execRepeatButton
            // 
            this.execRepeatButton.Location = new System.Drawing.Point(171, 627);
            this.execRepeatButton.Name = "execRepeatButton";
            this.execRepeatButton.Size = new System.Drawing.Size(136, 45);
            this.execRepeatButton.TabIndex = 6;
            this.execRepeatButton.Text = "Execute Repeat";
            this.execRepeatButton.UseVisualStyleBackColor = true;
            // 
            // intervalPicker
            // 
            this.intervalPicker.Location = new System.Drawing.Point(322, 647);
            this.intervalPicker.Name = "intervalPicker";
            this.intervalPicker.Size = new System.Drawing.Size(72, 25);
            this.intervalPicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Repeat Interval (minutes)";
            // 
            // stopButton
            // 
            this.stopButton.ForeColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(535, 626);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(136, 45);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // querySaveButton
            // 
            this.querySaveButton.ForeColor = System.Drawing.Color.Black;
            this.querySaveButton.Location = new System.Drawing.Point(738, 608);
            this.querySaveButton.Name = "querySaveButton";
            this.querySaveButton.Size = new System.Drawing.Size(99, 45);
            this.querySaveButton.TabIndex = 6;
            this.querySaveButton.Text = "Save Queries";
            this.querySaveButton.UseVisualStyleBackColor = true;
            // 
            // queryLoadButton
            // 
            this.queryLoadButton.ForeColor = System.Drawing.Color.Black;
            this.queryLoadButton.Location = new System.Drawing.Point(876, 608);
            this.queryLoadButton.Name = "queryLoadButton";
            this.queryLoadButton.Size = new System.Drawing.Size(99, 45);
            this.queryLoadButton.TabIndex = 6;
            this.queryLoadButton.Text = "Load Queries";
            this.queryLoadButton.UseVisualStyleBackColor = true;
            // 
            // ticketSaveButton
            // 
            this.ticketSaveButton.ForeColor = System.Drawing.Color.Black;
            this.ticketSaveButton.Location = new System.Drawing.Point(1220, 562);
            this.ticketSaveButton.Name = "ticketSaveButton";
            this.ticketSaveButton.Size = new System.Drawing.Size(99, 45);
            this.ticketSaveButton.TabIndex = 6;
            this.ticketSaveButton.Text = "Save Tickets";
            this.ticketSaveButton.UseVisualStyleBackColor = true;
            // 
            // ticketLoadButton
            // 
            this.ticketLoadButton.ForeColor = System.Drawing.Color.Black;
            this.ticketLoadButton.Location = new System.Drawing.Point(1325, 562);
            this.ticketLoadButton.Name = "ticketLoadButton";
            this.ticketLoadButton.Size = new System.Drawing.Size(99, 45);
            this.ticketLoadButton.TabIndex = 6;
            this.ticketLoadButton.Text = "Load Tickets";
            this.ticketLoadButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 684);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intervalPicker);
            this.Controls.Add(this.ticketSaveButton);
            this.Controls.Add(this.ticketLoadButton);
            this.Controls.Add(this.queryLoadButton);
            this.Controls.Add(this.querySaveButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.execRepeatButton);
            this.Controls.Add(this.execOnceButton);
            this.Controls.Add(this.logClearButton);
            this.Controls.Add(this.removeTicketButton);
            this.Controls.Add(this.removeQueryButton);
            this.Controls.Add(this.newQueryButton);
            this.Controls.Add(this.foundTicketBox);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intervalPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.ListBox queryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox foundTicketBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newQueryButton;
        private System.Windows.Forms.Button removeQueryButton;
        private System.Windows.Forms.Button removeTicketButton;
        private System.Windows.Forms.Button logClearButton;
        private System.Windows.Forms.Button execOnceButton;
        private System.Windows.Forms.Button execRepeatButton;
        private System.Windows.Forms.NumericUpDown intervalPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button querySaveButton;
        private System.Windows.Forms.Button queryLoadButton;
        private System.Windows.Forms.Button ticketSaveButton;
        private System.Windows.Forms.Button ticketLoadButton;
    }
}

