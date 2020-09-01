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
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addToListButton = new System.Windows.Forms.Button();
            this.propertyTextbox = new System.Windows.Forms.TextBox();
            this.propertiesToSearchRichTextbox = new System.Windows.Forms.RichTextBox();
            this.clearAllButton = new System.Windows.Forms.Button();
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
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(12, 41);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(776, 397);
            this.outputRichTextBox.TabIndex = 1;
            this.outputRichTextBox.Text = "";
            this.outputRichTextBox.WordWrap = false;
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(94, 12);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(75, 23);
            this.addToListButton.TabIndex = 2;
            this.addToListButton.Text = "Add";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // propertyTextbox
            // 
            this.propertyTextbox.Location = new System.Drawing.Point(175, 14);
            this.propertyTextbox.Name = "propertyTextbox";
            this.propertyTextbox.Size = new System.Drawing.Size(223, 20);
            this.propertyTextbox.TabIndex = 3;
            // 
            // propertiesToSearchRichTextbox
            // 
            this.propertiesToSearchRichTextbox.Enabled = false;
            this.propertiesToSearchRichTextbox.Location = new System.Drawing.Point(794, 41);
            this.propertiesToSearchRichTextbox.Name = "propertiesToSearchRichTextbox";
            this.propertiesToSearchRichTextbox.Size = new System.Drawing.Size(212, 96);
            this.propertiesToSearchRichTextbox.TabIndex = 4;
            this.propertiesToSearchRichTextbox.Text = "";
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(1076, 11);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 5;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 450);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.propertiesToSearchRichTextbox);
            this.Controls.Add(this.propertyTextbox);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.runScanButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runScanButton;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.TextBox propertyTextbox;
        private System.Windows.Forms.RichTextBox propertiesToSearchRichTextbox;
        private System.Windows.Forms.Button clearAllButton;
    }
}

