namespace ticket_call_system
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.WMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.pbCounter = new System.Windows.Forms.PictureBox();
            this.pcSubTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSubTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP1
            // 
            this.WMP1.Enabled = true;
            this.WMP1.Location = new System.Drawing.Point(29, 33);
            this.WMP1.Name = "WMP1";
            this.WMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP1.OcxState")));
            this.WMP1.Size = new System.Drawing.Size(671, 295);
            this.WMP1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Counter/Guichet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(730, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ticket Number ";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbNumber.Font = new System.Drawing.Font("Ebrima", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbNumber.Location = new System.Drawing.Point(739, 215);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(140, 81);
            this.lbNumber.TabIndex = 5;
            this.lbNumber.Text = "200";
            // 
            // pbCounter
            // 
            this.pbCounter.Location = new System.Drawing.Point(730, 74);
            this.pbCounter.Name = "pbCounter";
            this.pbCounter.Size = new System.Drawing.Size(142, 77);
            this.pbCounter.TabIndex = 2;
            this.pbCounter.TabStop = false;
            // 
            // pcSubTitle
            // 
            this.pcSubTitle.Location = new System.Drawing.Point(29, 283);
            this.pcSubTitle.Name = "pcSubTitle";
            this.pcSubTitle.Size = new System.Drawing.Size(670, 44);
            this.pcSubTitle.TabIndex = 1;
            this.pcSubTitle.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 392);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCounter);
            this.Controls.Add(this.pcSubTitle);
            this.Controls.Add(this.WMP1);
            this.Name = "Form1";
            this.Text = "Principale screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSubTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer WMP1;
        private System.Windows.Forms.PictureBox pcSubTitle;
        private System.Windows.Forms.PictureBox pbCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNumber;
    }
}

