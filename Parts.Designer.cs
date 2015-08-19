namespace PartsInventory_15
{
    partial class Parts
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
            this.btnSearchParts = new System.Windows.Forms.Button();
            this.btnDisplayParts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.Location = new System.Drawing.Point(86, 67);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearchParts.Size = new System.Drawing.Size(110, 23);
            this.btnSearchParts.TabIndex = 0;
            this.btnSearchParts.Text = "Search Parts";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            this.btnSearchParts.Click += new System.EventHandler(this.btnSearchParts_Click);
            // 
            // btnDisplayParts
            // 
            this.btnDisplayParts.Location = new System.Drawing.Point(86, 131);
            this.btnDisplayParts.Name = "btnDisplayParts";
            this.btnDisplayParts.Size = new System.Drawing.Size(110, 23);
            this.btnDisplayParts.TabIndex = 1;
            this.btnDisplayParts.Text = "Display Parts";
            this.btnDisplayParts.UseVisualStyleBackColor = true;
            this.btnDisplayParts.Click += new System.EventHandler(this.btnDisplayParts_Click);
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDisplayParts);
            this.Controls.Add(this.btnSearchParts);
            this.Name = "Parts";
            this.Text = "Parts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchParts;
        private System.Windows.Forms.Button btnDisplayParts;
    }
}