﻿namespace RestAPICaller
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
            this.buttonSequence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSequence
            // 
            this.buttonSequence.Location = new System.Drawing.Point(593, 32);
            this.buttonSequence.Name = "buttonSequence";
            this.buttonSequence.Size = new System.Drawing.Size(178, 111);
            this.buttonSequence.TabIndex = 0;
            this.buttonSequence.Text = "Fire in Sequence";
            this.buttonSequence.UseVisualStyleBackColor = true;
            this.buttonSequence.Click += new System.EventHandler(this.buttonSequence_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSequence);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonSequence;
    }
}