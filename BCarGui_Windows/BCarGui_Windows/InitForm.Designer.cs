namespace BCarGui_Windows
{
    partial class BCarGui
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
            this.coms_box = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coms_box
            // 
            this.coms_box.FormattingEnabled = true;
            this.coms_box.Location = new System.Drawing.Point(71, 70);
            this.coms_box.Name = "coms_box";
            this.coms_box.Size = new System.Drawing.Size(121, 21);
            this.coms_box.TabIndex = 0;
            this.coms_box.SelectedIndexChanged += new System.EventHandler(this.coms_box_SelectedIndexChanged);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(95, 113);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 1;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select COM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BCarGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.coms_box);
            this.Name = "BCarGui";
            this.Text = "InitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox coms_box;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label1;
    }
}