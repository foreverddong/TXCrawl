namespace TXCrawlWinformUI
{
    partial class ViewTicketForm
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
            this.departLabel = new System.Windows.Forms.Label();
            this.arriveLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.departTimeLabel = new System.Windows.Forms.Label();
            this.arriveTimeLabel = new System.Windows.Forms.Label();
            this.departDateLabel = new System.Windows.Forms.Label();
            this.plusOneLabel = new System.Windows.Forms.Label();
            this.carrierNameLabel = new System.Windows.Forms.Label();
            this.flightNumLabel = new System.Windows.Forms.Label();
            this.ticketPriceLabel = new System.Windows.Forms.Label();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departLabel
            // 
            this.departLabel.AutoSize = true;
            this.departLabel.Font = new System.Drawing.Font("Source Sans Pro", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departLabel.Location = new System.Drawing.Point(12, 9);
            this.departLabel.Name = "departLabel";
            this.departLabel.Size = new System.Drawing.Size(110, 60);
            this.departLabel.TabIndex = 0;
            this.departLabel.Text = "DEP";
            // 
            // arriveLabel
            // 
            this.arriveLabel.AutoSize = true;
            this.arriveLabel.Font = new System.Drawing.Font("Source Sans Pro", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arriveLabel.Location = new System.Drawing.Point(327, 9);
            this.arriveLabel.Name = "arriveLabel";
            this.arriveLabel.Size = new System.Drawing.Size(97, 60);
            this.arriveLabel.TabIndex = 0;
            this.arriveLabel.Text = "ARI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "----->";
            // 
            // departTimeLabel
            // 
            this.departTimeLabel.AutoSize = true;
            this.departTimeLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.departTimeLabel.Location = new System.Drawing.Point(18, 80);
            this.departTimeLabel.Name = "departTimeLabel";
            this.departTimeLabel.Size = new System.Drawing.Size(86, 20);
            this.departTimeLabel.TabIndex = 1;
            this.departTimeLabel.Text = "TimeDep";
            // 
            // arriveTimeLabel
            // 
            this.arriveTimeLabel.AutoSize = true;
            this.arriveTimeLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.arriveTimeLabel.Location = new System.Drawing.Point(333, 80);
            this.arriveTimeLabel.Name = "arriveTimeLabel";
            this.arriveTimeLabel.Size = new System.Drawing.Size(86, 20);
            this.arriveTimeLabel.TabIndex = 1;
            this.arriveTimeLabel.Text = "TimeAri";
            // 
            // departDateLabel
            // 
            this.departDateLabel.AutoSize = true;
            this.departDateLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.departDateLabel.Location = new System.Drawing.Point(121, 80);
            this.departDateLabel.Name = "departDateLabel";
            this.departDateLabel.Size = new System.Drawing.Size(196, 20);
            this.departDateLabel.TabIndex = 1;
            this.departDateLabel.Text = "Date Of Departure";
            // 
            // plusOneLabel
            // 
            this.plusOneLabel.AutoSize = true;
            this.plusOneLabel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plusOneLabel.Location = new System.Drawing.Point(412, 67);
            this.plusOneLabel.Name = "plusOneLabel";
            this.plusOneLabel.Size = new System.Drawing.Size(25, 15);
            this.plusOneLabel.TabIndex = 2;
            this.plusOneLabel.Text = "+1";
            // 
            // carrierNameLabel
            // 
            this.carrierNameLabel.AutoSize = true;
            this.carrierNameLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.carrierNameLabel.Location = new System.Drawing.Point(18, 118);
            this.carrierNameLabel.Name = "carrierNameLabel";
            this.carrierNameLabel.Size = new System.Drawing.Size(141, 20);
            this.carrierNameLabel.TabIndex = 1;
            this.carrierNameLabel.Text = "Carrier Name";
            // 
            // flightNumLabel
            // 
            this.flightNumLabel.AutoSize = true;
            this.flightNumLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flightNumLabel.Location = new System.Drawing.Point(299, 118);
            this.flightNumLabel.Name = "flightNumLabel";
            this.flightNumLabel.Size = new System.Drawing.Size(108, 20);
            this.flightNumLabel.TabIndex = 1;
            this.flightNumLabel.Text = "FlightNum";
            // 
            // ticketPriceLabel
            // 
            this.ticketPriceLabel.AutoSize = true;
            this.ticketPriceLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ticketPriceLabel.Location = new System.Drawing.Point(149, 154);
            this.ticketPriceLabel.Name = "ticketPriceLabel";
            this.ticketPriceLabel.Size = new System.Drawing.Size(141, 20);
            this.ticketPriceLabel.TabIndex = 1;
            this.ticketPriceLabel.Text = "Ticket Price";
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(12, 189);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(407, 49);
            this.purchaseButton.TabIndex = 3;
            this.purchaseButton.Text = "Purchase On SkyScanner";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // ViewTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 250);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.plusOneLabel);
            this.Controls.Add(this.arriveTimeLabel);
            this.Controls.Add(this.departDateLabel);
            this.Controls.Add(this.flightNumLabel);
            this.Controls.Add(this.ticketPriceLabel);
            this.Controls.Add(this.carrierNameLabel);
            this.Controls.Add(this.departTimeLabel);
            this.Controls.Add(this.arriveLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departLabel);
            this.Name = "ViewTicketForm";
            this.Text = "ViewTicketForm";
            this.Load += new System.EventHandler(this.ViewTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label departLabel;
        private System.Windows.Forms.Label arriveLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label departTimeLabel;
        private System.Windows.Forms.Label arriveTimeLabel;
        private System.Windows.Forms.Label departDateLabel;
        private System.Windows.Forms.Label plusOneLabel;
        private System.Windows.Forms.Label carrierNameLabel;
        private System.Windows.Forms.Label flightNumLabel;
        private System.Windows.Forms.Label ticketPriceLabel;
        private System.Windows.Forms.Button purchaseButton;
    }
}