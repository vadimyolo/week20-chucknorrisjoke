namespace ChuckForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getJokeBin = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getJokeBin
            // 
            this.getJokeBin.Location = new System.Drawing.Point(321, 51);
            this.getJokeBin.Name = "getJokeBin";
            this.getJokeBin.Size = new System.Drawing.Size(113, 42);
            this.getJokeBin.TabIndex = 0;
            this.getJokeBin.Text = "Get Joke";
            this.getJokeBin.UseVisualStyleBackColor = true;
            this.getJokeBin.Click += new System.EventHandler(this.getJokeBin_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(200, 110);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(244, 309);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "Get a joke, stupid.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.getJokeBin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getJokeBin;
        private System.Windows.Forms.RichTextBox textBox;
    }
}

