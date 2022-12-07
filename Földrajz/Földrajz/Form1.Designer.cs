
namespace Földrajz
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
            this.Begin = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Begin
            // 
            this.Begin.BackColor = System.Drawing.Color.SaddleBrown;
            this.Begin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Begin.Location = new System.Drawing.Point(300, 279);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(181, 69);
            this.Begin.TabIndex = 0;
            this.Begin.Text = "Press To Begin";
            this.Begin.UseVisualStyleBackColor = false;
            this.Begin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Exit.Location = new System.Drawing.Point(699, 388);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(89, 50);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Begin);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.Button Exit;
    }
}

