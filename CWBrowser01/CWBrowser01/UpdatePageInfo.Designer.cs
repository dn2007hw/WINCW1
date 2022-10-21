
namespace CWBrowser01
{
    partial class updatepageinfo
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
            this.pageinfook = new System.Windows.Forms.Button();
            this.pageinfocancel = new System.Windows.Forms.Button();
            this.pageinfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pageinfook
            // 
            this.pageinfook.Location = new System.Drawing.Point(331, 26);
            this.pageinfook.Name = "pageinfook";
            this.pageinfook.Size = new System.Drawing.Size(75, 23);
            this.pageinfook.TabIndex = 1;
            this.pageinfook.Text = "Ok";
            this.pageinfook.UseVisualStyleBackColor = true;
            this.pageinfook.Click += new System.EventHandler(this.updatehomeok_Click);
            // 
            // pageinfocancel
            // 
            this.pageinfocancel.Location = new System.Drawing.Point(405, 27);
            this.pageinfocancel.Name = "pageinfocancel";
            this.pageinfocancel.Size = new System.Drawing.Size(75, 22);
            this.pageinfocancel.TabIndex = 2;
            this.pageinfocancel.Text = "Cancel";
            this.pageinfocancel.UseVisualStyleBackColor = true;
            this.pageinfocancel.Click += new System.EventHandler(this.updatehomecancel_Click);
            // 
            // pageinfo
            // 
            this.pageinfo.Location = new System.Drawing.Point(4, 4);
            this.pageinfo.Name = "pageinfo";
            this.pageinfo.Size = new System.Drawing.Size(476, 20);
            this.pageinfo.TabIndex = 0;
            this.pageinfo.TextChanged += new System.EventHandler(this.pagecontent_TextChanged);
            this.pageinfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pagecontent_KeyPress);
            // 
            // updatepageinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 53);
            this.ControlBox = false;
            this.Controls.Add(this.pageinfo);
            this.Controls.Add(this.pageinfocancel);
            this.Controls.Add(this.pageinfook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "updatepageinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pageinfook;
        private System.Windows.Forms.Button pageinfocancel;
        private System.Windows.Forms.TextBox pageinfo;
    }
}