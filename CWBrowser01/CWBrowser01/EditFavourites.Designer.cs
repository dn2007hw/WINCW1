
namespace CWBrowser01
{
    partial class editfavourites
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
            this.favdataGrid = new System.Windows.Forms.DataGridView();
            this.favsave = new System.Windows.Forms.Button();
            this.favcancel = new System.Windows.Forms.Button();
            this.favdelete = new System.Windows.Forms.Button();
            this.favsaveexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.favdataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // favdataGrid
            // 
            this.favdataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favdataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.favdataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.favdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.favdataGrid.Location = new System.Drawing.Point(1, 3);
            this.favdataGrid.Name = "favdataGrid";
            this.favdataGrid.Size = new System.Drawing.Size(580, 326);
            this.favdataGrid.StandardTab = true;
            this.favdataGrid.TabIndex = 0;
            // 
            // favsave
            // 
            this.favsave.Location = new System.Drawing.Point(387, 334);
            this.favsave.Name = "favsave";
            this.favsave.Size = new System.Drawing.Size(57, 23);
            this.favsave.TabIndex = 1;
            this.favsave.Text = "Save";
            this.favsave.UseVisualStyleBackColor = true;
            this.favsave.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // favcancel
            // 
            this.favcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.favcancel.Location = new System.Drawing.Point(525, 334);
            this.favcancel.Name = "favcancel";
            this.favcancel.Size = new System.Drawing.Size(53, 23);
            this.favcancel.TabIndex = 2;
            this.favcancel.Text = "Cancel";
            this.favcancel.UseVisualStyleBackColor = true;
            // 
            // favdelete
            // 
            this.favdelete.Location = new System.Drawing.Point(1, 334);
            this.favdelete.Name = "favdelete";
            this.favdelete.Size = new System.Drawing.Size(93, 23);
            this.favdelete.TabIndex = 3;
            this.favdelete.Text = "Delete Selected";
            this.favdelete.UseVisualStyleBackColor = true;
            this.favdelete.Click += new System.EventHandler(this.favdelete_Click);
            // 
            // favsaveexit
            // 
            this.favsaveexit.Location = new System.Drawing.Point(443, 333);
            this.favsaveexit.Name = "favsaveexit";
            this.favsaveexit.Size = new System.Drawing.Size(83, 24);
            this.favsaveexit.TabIndex = 4;
            this.favsaveexit.Text = "Save and Exit";
            this.favsaveexit.UseVisualStyleBackColor = true;
            this.favsaveexit.Click += new System.EventHandler(this.favsaveexit_Click);
            // 
            // editfavourites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.favcancel;
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.ControlBox = false;
            this.Controls.Add(this.favsaveexit);
            this.Controls.Add(this.favdelete);
            this.Controls.Add(this.favcancel);
            this.Controls.Add(this.favsave);
            this.Controls.Add(this.favdataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "editfavourites";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Favourites";
            ((System.ComponentModel.ISupportInitialize)(this.favdataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView favdataGrid;
        private System.Windows.Forms.Button favsave;
        private System.Windows.Forms.Button favcancel;
        private System.Windows.Forms.Button favdelete;
        private System.Windows.Forms.Button favsaveexit;
    }
}