namespace Snake
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
            this.gameMainControl1 = new Snake.GameMainControl();
            this.SuspendLayout();
            // 
            // gameMainControl1
            // 
            this.gameMainControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameMainControl1.Location = new System.Drawing.Point(0, 0);
            this.gameMainControl1.Margin = new System.Windows.Forms.Padding(1);
            this.gameMainControl1.Name = "gameMainControl1";
            this.gameMainControl1.Size = new System.Drawing.Size(365, 289);
            this.gameMainControl1.TabIndex = 0;
            this.gameMainControl1.Text = "gameMainControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 289);
            this.Controls.Add(this.gameMainControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GameMainControl gameMainControl1;
    }
}

