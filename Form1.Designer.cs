namespace DisabledComputerFixAndReport {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.runScanButton = new System.Windows.Forms.Button();
            this.addToListButton = new System.Windows.Forms.Button();
            this.propertyTextbox = new System.Windows.Forms.TextBox();
            this.propertiesToSearchRichTextbox = new System.Windows.Forms.RichTextBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.outputListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runScanButton
            // 
            this.runScanButton.Location = new System.Drawing.Point(12, 12);
            this.runScanButton.Name = "runScanButton";
            this.runScanButton.Size = new System.Drawing.Size(75, 23);
            this.runScanButton.TabIndex = 0;
            this.runScanButton.Text = "Run";
            this.runScanButton.UseVisualStyleBackColor = true;
            this.runScanButton.Click += new System.EventHandler(this.runScanButton_Click);
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(794, 11);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(106, 23);
            this.addToListButton.TabIndex = 2;
            this.addToListButton.Text = "Add";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // propertyTextbox
            // 
            this.propertyTextbox.Location = new System.Drawing.Point(565, 15);
            this.propertyTextbox.Name = "propertyTextbox";
            this.propertyTextbox.Size = new System.Drawing.Size(223, 20);
            this.propertyTextbox.TabIndex = 3;
            this.propertyTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.propertyTextbox_KeyDown);
            // 
            // propertiesToSearchRichTextbox
            // 
            this.propertiesToSearchRichTextbox.Enabled = false;
            this.propertiesToSearchRichTextbox.Location = new System.Drawing.Point(794, 41);
            this.propertiesToSearchRichTextbox.Name = "propertiesToSearchRichTextbox";
            this.propertiesToSearchRichTextbox.Size = new System.Drawing.Size(106, 209);
            this.propertiesToSearchRichTextbox.TabIndex = 4;
            this.propertiesToSearchRichTextbox.Text = "";
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(93, 12);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(106, 23);
            this.clearAllButton.TabIndex = 5;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // outputListView
            // 
            this.outputListView.HideSelection = false;
            this.outputListView.Location = new System.Drawing.Point(12, 41);
            this.outputListView.Name = "outputListView";
            this.outputListView.Size = new System.Drawing.Size(776, 209);
            this.outputListView.TabIndex = 6;
            this.outputListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Properties To Search:";
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(205, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 259);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputListView);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.propertiesToSearchRichTextbox);
            this.Controls.Add(this.propertyTextbox);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.runScanButton);
            this.Name = "Form1";
            this.Text = "Disabled AD Report and Fix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runScanButton;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.TextBox propertyTextbox;
        private System.Windows.Forms.RichTextBox propertiesToSearchRichTextbox;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.ListView outputListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button settingsButton;
    }
}

