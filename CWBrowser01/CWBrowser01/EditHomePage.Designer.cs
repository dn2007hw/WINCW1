
namespace CWBrowser01
{
    partial class EditHomePage
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
            this.homepagename = new System.Windows.Forms.TextBox();
            this.homepageurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homesave = new System.Windows.Forms.Button();
            this.homecancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homepagename
            // 
            this.homepagename.Enabled = false;
            this.homepagename.Location = new System.Drawing.Point(46, 12);
            this.homepagename.Name = "homepagename";
            this.homepagename.Size = new System.Drawing.Size(390, 20);
            this.homepagename.TabIndex = 0;
            // 
            // homepageurl
            // 
            this.homepageurl.Location = new System.Drawing.Point(46, 38);
            this.homepageurl.Name = "homepageurl";
            this.homepageurl.Size = new System.Drawing.Size(390, 20);
            this.homepageurl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL";
            // 
            // homesave
            // 
            this.homesave.Location = new System.Drawing.Point(286, 64);
            this.homesave.Name = "homesave";
            this.homesave.Size = new System.Drawing.Size(75, 23);
            this.homesave.TabIndex = 4;
            this.homesave.Text = "Save";
            this.homesave.UseVisualStyleBackColor = true;
            this.homesave.Click += new System.EventHandler(this.homesave_Click);
            // 
            // homecancel
            // 
            this.homecancel.Location = new System.Drawing.Point(361, 64);
            this.homecancel.Name = "homecancel";
            this.homecancel.Size = new System.Drawing.Size(75, 23);
            this.homecancel.TabIndex = 5;
            this.homecancel.Text = "Cancel";
            this.homecancel.UseVisualStyleBackColor = true;
            this.homecancel.Click += new System.EventHandler(this.homecancel_Click);
            // 
            // EditHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 93);
            this.Controls.Add(this.homecancel);
            this.Controls.Add(this.homesave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homepageurl);
            this.Controls.Add(this.homepagename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditHomePage";
            this.Text = "Update Home Page";
            this.Load += new System.EventHandler(this.EditHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox homepagename;
        private System.Windows.Forms.TextBox homepageurl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button homesave;
        private System.Windows.Forms.Button homecancel;
    }
}