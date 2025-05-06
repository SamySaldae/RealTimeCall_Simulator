namespace ticket_call_system
{
    partial class MESSAGE_TRANSMISSION_FORM
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anomaliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionLostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backendDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedWaitingTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseUnusedTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomingMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeEveryoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weWishYouAHappyHolidayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weWishYouAHappyWeekendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haveANiceEndOfTheDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wellBeClosingIn30MinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsWillBeGoneIn30MinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLastMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(76, 91);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(614, 276);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Write your message here";
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(341, 373);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(101, 54);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openToolStripMenuItem,
            this.resetLastMessageToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFileToolStripMenuItem.Text = "New text";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templateMessageToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // templateMessageToolStripMenuItem
            // 
            this.templateMessageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anomaliesToolStripMenuItem,
            this.welcomingMessagesToolStripMenuItem,
            this.closingMessageToolStripMenuItem});
            this.templateMessageToolStripMenuItem.Name = "templateMessageToolStripMenuItem";
            this.templateMessageToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.templateMessageToolStripMenuItem.Text = "Template vocal message";
            // 
            // anomaliesToolStripMenuItem
            // 
            this.anomaliesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionLostToolStripMenuItem,
            this.backendDownToolStripMenuItem,
            this.extendedWaitingTimeToolStripMenuItem,
            this.releaseUnusedTicketsToolStripMenuItem});
            this.anomaliesToolStripMenuItem.Name = "anomaliesToolStripMenuItem";
            this.anomaliesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.anomaliesToolStripMenuItem.Text = "Anomalies";
            // 
            // connexionLostToolStripMenuItem
            // 
            this.connexionLostToolStripMenuItem.Name = "connexionLostToolStripMenuItem";
            this.connexionLostToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.connexionLostToolStripMenuItem.Text = "Connexion Lost";
            // 
            // backendDownToolStripMenuItem
            // 
            this.backendDownToolStripMenuItem.Name = "backendDownToolStripMenuItem";
            this.backendDownToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.backendDownToolStripMenuItem.Text = "backend down";
            // 
            // extendedWaitingTimeToolStripMenuItem
            // 
            this.extendedWaitingTimeToolStripMenuItem.Name = "extendedWaitingTimeToolStripMenuItem";
            this.extendedWaitingTimeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.extendedWaitingTimeToolStripMenuItem.Text = "Extended waiting time";
            // 
            // releaseUnusedTicketsToolStripMenuItem
            // 
            this.releaseUnusedTicketsToolStripMenuItem.Name = "releaseUnusedTicketsToolStripMenuItem";
            this.releaseUnusedTicketsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.releaseUnusedTicketsToolStripMenuItem.Text = "Release unused tickets";
            // 
            // welcomingMessagesToolStripMenuItem
            // 
            this.welcomingMessagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeEveryoneToolStripMenuItem,
            this.weWishYouAHappyHolidayToolStripMenuItem,
            this.weWishYouAHappyWeekendToolStripMenuItem,
            this.haveANiceEndOfTheDayToolStripMenuItem});
            this.welcomingMessagesToolStripMenuItem.Name = "welcomingMessagesToolStripMenuItem";
            this.welcomingMessagesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.welcomingMessagesToolStripMenuItem.Text = "Welcoming messages";
            // 
            // welcomeEveryoneToolStripMenuItem
            // 
            this.welcomeEveryoneToolStripMenuItem.Name = "welcomeEveryoneToolStripMenuItem";
            this.welcomeEveryoneToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.welcomeEveryoneToolStripMenuItem.Text = "Welcome Everyone";
            // 
            // weWishYouAHappyHolidayToolStripMenuItem
            // 
            this.weWishYouAHappyHolidayToolStripMenuItem.Name = "weWishYouAHappyHolidayToolStripMenuItem";
            this.weWishYouAHappyHolidayToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.weWishYouAHappyHolidayToolStripMenuItem.Text = "We wish you a happy holiday";
            // 
            // weWishYouAHappyWeekendToolStripMenuItem
            // 
            this.weWishYouAHappyWeekendToolStripMenuItem.Name = "weWishYouAHappyWeekendToolStripMenuItem";
            this.weWishYouAHappyWeekendToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.weWishYouAHappyWeekendToolStripMenuItem.Text = "We wish you a happy weekend";
            // 
            // haveANiceEndOfTheDayToolStripMenuItem
            // 
            this.haveANiceEndOfTheDayToolStripMenuItem.Name = "haveANiceEndOfTheDayToolStripMenuItem";
            this.haveANiceEndOfTheDayToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.haveANiceEndOfTheDayToolStripMenuItem.Text = "Have a nice end of the day";
            // 
            // closingMessageToolStripMenuItem
            // 
            this.closingMessageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wToolStripMenuItem,
            this.wellBeClosingIn30MinutesToolStripMenuItem,
            this.ticketsWillBeGoneIn30MinutesToolStripMenuItem});
            this.closingMessageToolStripMenuItem.Name = "closingMessageToolStripMenuItem";
            this.closingMessageToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.closingMessageToolStripMenuItem.Text = "Closing message";
            // 
            // wToolStripMenuItem
            // 
            this.wToolStripMenuItem.Name = "wToolStripMenuItem";
            this.wToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.wToolStripMenuItem.Text = "We\'ll be closing in 1 hour";
            // 
            // wellBeClosingIn30MinutesToolStripMenuItem
            // 
            this.wellBeClosingIn30MinutesToolStripMenuItem.Name = "wellBeClosingIn30MinutesToolStripMenuItem";
            this.wellBeClosingIn30MinutesToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.wellBeClosingIn30MinutesToolStripMenuItem.Text = "We\'ll be closing in 30 minutes";
            // 
            // ticketsWillBeGoneIn30MinutesToolStripMenuItem
            // 
            this.ticketsWillBeGoneIn30MinutesToolStripMenuItem.Name = "ticketsWillBeGoneIn30MinutesToolStripMenuItem";
            this.ticketsWillBeGoneIn30MinutesToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.ticketsWillBeGoneIn30MinutesToolStripMenuItem.Text = "Tickets will be gone in 30 minutes";
            // 
            // resetLastMessageToolStripMenuItem
            // 
            this.resetLastMessageToolStripMenuItem.Name = "resetLastMessageToolStripMenuItem";
            this.resetLastMessageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetLastMessageToolStripMenuItem.Text = "Reset last message";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Save";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreInformationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // moreInformationToolStripMenuItem
            // 
            this.moreInformationToolStripMenuItem.Name = "moreInformationToolStripMenuItem";
            this.moreInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moreInformationToolStripMenuItem.Text = "More information";
            // 
            // MESSAGE_TRANSMISSION_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MESSAGE_TRANSMISSION_FORM";
            this.Text = "MESSAGE_TRANSMISSION_FORM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anomaliesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionLostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backendDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extendedWaitingTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomingMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomeEveryoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weWishYouAHappyHolidayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weWishYouAHappyWeekendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haveANiceEndOfTheDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseUnusedTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wellBeClosingIn30MinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsWillBeGoneIn30MinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLastMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreInformationToolStripMenuItem;
    }
}