namespace ClarionLiveDemo
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
            this.btnPressForMessage = new System.Windows.Forms.Button();
            this.btnSendText = new System.Windows.Forms.Button();
            this.txtToClarion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPressForMessage
            // 
            this.btnPressForMessage.Location = new System.Drawing.Point(24, 25);
            this.btnPressForMessage.Name = "btnPressForMessage";
            this.btnPressForMessage.Size = new System.Drawing.Size(133, 23);
            this.btnPressForMessage.TabIndex = 0;
            this.btnPressForMessage.Text = "Press for Message";
            this.btnPressForMessage.UseVisualStyleBackColor = true;
            this.btnPressForMessage.Click += new System.EventHandler(this.btnPressForMessage_Click);
            // 
            // btnSendText
            // 
            this.btnSendText.Location = new System.Drawing.Point(455, 69);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(75, 23);
            this.btnSendText.TabIndex = 1;
            this.btnSendText.Text = "Send Text";
            this.btnSendText.UseVisualStyleBackColor = true;
            this.btnSendText.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // txtToClarion
            // 
            this.txtToClarion.Location = new System.Drawing.Point(137, 71);
            this.txtToClarion.Name = "txtToClarion";
            this.txtToClarion.Size = new System.Drawing.Size(312, 20);
            this.txtToClarion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Send Text To Clarion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clarion Live Demo ActiveX Control";
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(27, 133);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(259, 212);
            this.lstNames.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToClarion);
            this.Controls.Add(this.btnSendText);
            this.Controls.Add(this.btnPressForMessage);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(580, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPressForMessage;
        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.TextBox txtToClarion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstNames;
    }
}

