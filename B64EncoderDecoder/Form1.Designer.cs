namespace B64EncoderDecoder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputForm = new System.Windows.Forms.RichTextBox();
            this.outputForm = new System.Windows.Forms.RichTextBox();
            this.enCoderButton = new System.Windows.Forms.Button();
            this.deCoderButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputForm
            // 
            this.inputForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputForm.Location = new System.Drawing.Point(18, 18);
            this.inputForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputForm.Name = "inputForm";
            this.inputForm.Size = new System.Drawing.Size(558, 472);
            this.inputForm.TabIndex = 0;
            this.inputForm.Text = "";
            this.inputForm.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // outputForm
            // 
            this.outputForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputForm.Location = new System.Drawing.Point(585, 18);
            this.outputForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputForm.Name = "outputForm";
            this.outputForm.Size = new System.Drawing.Size(597, 472);
            this.outputForm.TabIndex = 1;
            this.outputForm.Text = "";
            this.outputForm.TextChanged += new System.EventHandler(this.outputForm_TextChanged);
            // 
            // enCoderButton
            // 
            this.enCoderButton.Location = new System.Drawing.Point(249, 557);
            this.enCoderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enCoderButton.Name = "enCoderButton";
            this.enCoderButton.Size = new System.Drawing.Size(159, 68);
            this.enCoderButton.TabIndex = 2;
            this.enCoderButton.Text = "ENCODE";
            this.enCoderButton.UseVisualStyleBackColor = true;
            this.enCoderButton.Click += new System.EventHandler(this.enCoderButton_Click);
            // 
            // deCoderButton
            // 
            this.deCoderButton.Location = new System.Drawing.Point(417, 557);
            this.deCoderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deCoderButton.Name = "deCoderButton";
            this.deCoderButton.Size = new System.Drawing.Size(159, 68);
            this.deCoderButton.TabIndex = 3;
            this.deCoderButton.Text = "DECODE";
            this.deCoderButton.UseVisualStyleBackColor = true;
            this.deCoderButton.Click += new System.EventHandler(this.deCoderButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(585, 557);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(159, 68);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(753, 557);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(159, 68);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.deCoderButton);
            this.Controls.Add(this.enCoderButton);
            this.Controls.Add(this.outputForm);
            this.Controls.Add(this.inputForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64 Encoder & Decoder - Kamran Saifullah";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputForm;
        private System.Windows.Forms.RichTextBox outputForm;
        private System.Windows.Forms.Button enCoderButton;
        private System.Windows.Forms.Button deCoderButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

