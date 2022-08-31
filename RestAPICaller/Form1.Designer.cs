namespace RestAPICaller
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
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.buttonFireTile = new System.Windows.Forms.Button();
            this.textBoxTile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonAssignTiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSequence
            // 
            this.buttonSequence.Location = new System.Drawing.Point(12, 554);
            this.buttonSequence.Name = "buttonSequence";
            this.buttonSequence.Size = new System.Drawing.Size(178, 111);
            this.buttonSequence.TabIndex = 0;
            this.buttonSequence.Text = "Fire in Sequence";
            this.buttonSequence.UseVisualStyleBackColor = true;
            this.buttonSequence.Click += new System.EventHandler(this.buttonSequence_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(12, 437);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(178, 111);
            this.buttonRandom.TabIndex = 1;
            this.buttonRandom.Text = "Fire Randomly";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 897);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(178, 111);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reload";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(196, 12);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(719, 1163);
            this.webView21.Source = new System.Uri("http://localhost:5000/admin", System.UriKind.Absolute);
            this.webView21.TabIndex = 3;
            this.webView21.ZoomFactor = 1D;
            // 
            // buttonFireTile
            // 
            this.buttonFireTile.Location = new System.Drawing.Point(12, 86);
            this.buttonFireTile.Name = "buttonFireTile";
            this.buttonFireTile.Size = new System.Drawing.Size(178, 111);
            this.buttonFireTile.TabIndex = 4;
            this.buttonFireTile.Text = "Fire";
            this.buttonFireTile.UseVisualStyleBackColor = true;
            this.buttonFireTile.Click += new System.EventHandler(this.buttonFireTile_Click);
            // 
            // textBoxTile
            // 
            this.textBoxTile.Location = new System.Drawing.Point(12, 40);
            this.textBoxTile.MaxLength = 4;
            this.textBoxTile.Name = "textBoxTile";
            this.textBoxTile.PlaceholderText = "1-1400";
            this.textBoxTile.Size = new System.Drawing.Size(178, 31);
            this.textBoxTile.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tiles";
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(12, 320);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(178, 111);
            this.buttonAdmin.TabIndex = 7;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 203);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(178, 111);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonAssignTiles
            // 
            this.buttonAssignTiles.Location = new System.Drawing.Point(12, 671);
            this.buttonAssignTiles.Name = "buttonAssignTiles";
            this.buttonAssignTiles.Size = new System.Drawing.Size(178, 111);
            this.buttonAssignTiles.TabIndex = 9;
            this.buttonAssignTiles.Text = "Assign Tiles";
            this.buttonAssignTiles.UseVisualStyleBackColor = true;
            this.buttonAssignTiles.Click += new System.EventHandler(this.buttonAssignTiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 1187);
            this.Controls.Add(this.buttonAssignTiles);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTile);
            this.Controls.Add(this.buttonFireTile);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonSequence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NYP 30th Anniversarry";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSequence;
        private Button buttonRandom;
        private Button buttonReset;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button buttonFireTile;
        private TextBox textBoxTile;
        private Label label1;
        private Button buttonAdmin;
        private Button buttonLoad;
        private Button buttonAssignTiles;
    }
}