namespace ffff
{
    partial class ShowForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteButt = new MaterialSkin.Controls.MaterialFlatButton();
            this.SaveButt = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(766, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // DeleteButt
            // 
            this.DeleteButt.AutoSize = true;
            this.DeleteButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButt.Depth = 0;
            this.DeleteButt.Location = new System.Drawing.Point(335, 368);
            this.DeleteButt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteButt.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Primary = false;
            this.DeleteButt.Size = new System.Drawing.Size(73, 36);
            this.DeleteButt.TabIndex = 1;
            this.DeleteButt.Text = "DELETE";
            this.DeleteButt.UseVisualStyleBackColor = true;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // SaveButt
            // 
            this.SaveButt.AutoSize = true;
            this.SaveButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButt.Depth = 0;
            this.SaveButt.Location = new System.Drawing.Point(169, 368);
            this.SaveButt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButt.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButt.Name = "SaveButt";
            this.SaveButt.Primary = false;
            this.SaveButt.Size = new System.Drawing.Size(56, 36);
            this.SaveButt.TabIndex = 2;
            this.SaveButt.Text = "SAVE";
            this.SaveButt.UseVisualStyleBackColor = true;
            this.SaveButt.Click += new System.EventHandler(this.SaveButt_Click);
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 628);
            this.Controls.Add(this.SaveButt);
            this.Controls.Add(this.DeleteButt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowForm";
            this.Text = "Show";
            this.Load += new System.EventHandler(this.ShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton DeleteButt;
        private MaterialSkin.Controls.MaterialFlatButton SaveButt;
    }
}