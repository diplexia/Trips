namespace ffff
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
            this.UserBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CityLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AddButt = new MaterialSkin.Controls.MaterialFlatButton();
            this.ShowButt = new MaterialSkin.Controls.MaterialFlatButton();
            this.CancelButt = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(171, 104);
            this.UserBox.Multiline = true;
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(252, 37);
            this.UserBox.TabIndex = 0;
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(171, 177);
            this.CityBox.Multiline = true;
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(252, 37);
            this.CityBox.TabIndex = 1;
            this.CityBox.TextChanged += new System.EventHandler(this.CityBox_TextChanged);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(171, 256);
            this.PriceBox.Multiline = true;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(252, 37);
            this.PriceBox.TabIndex = 2;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Depth = 0;
            this.UserLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.UserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserLabel.Location = new System.Drawing.Point(29, 117);
            this.UserLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(99, 24);
            this.UserLabel.TabIndex = 3;
            this.UserLabel.Text = "UserName";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Depth = 0;
            this.CityLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.CityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CityLabel.Location = new System.Drawing.Point(29, 190);
            this.CityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(42, 24);
            this.CityLabel.TabIndex = 4;
            this.CityLabel.Text = "City";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Depth = 0;
            this.PriceLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PriceLabel.Location = new System.Drawing.Point(29, 269);
            this.PriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(53, 24);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Price";
            // 
            // AddButt
            // 
            this.AddButt.AutoSize = true;
            this.AddButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButt.Depth = 0;
            this.AddButt.Location = new System.Drawing.Point(84, 388);
            this.AddButt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddButt.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButt.Name = "AddButt";
            this.AddButt.Primary = false;
            this.AddButt.Size = new System.Drawing.Size(93, 36);
            this.AddButt.TabIndex = 6;
            this.AddButt.Text = "ADD User";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.UseWaitCursor = true;
            this.AddButt.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // ShowButt
            // 
            this.ShowButt.AutoSize = true;
            this.ShowButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowButt.Depth = 0;
            this.ShowButt.Location = new System.Drawing.Point(233, 388);
            this.ShowButt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowButt.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowButt.Name = "ShowButt";
            this.ShowButt.Primary = false;
            this.ShowButt.Size = new System.Drawing.Size(119, 36);
            this.ShowButt.TabIndex = 8;
            this.ShowButt.Text = "SHOW USERS";
            this.ShowButt.UseVisualStyleBackColor = true;
            this.ShowButt.Click += new System.EventHandler(this.ShowButt_Click);
            // 
            // CancelButt
            // 
            this.CancelButt.AutoSize = true;
            this.CancelButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButt.Depth = 0;
            this.CancelButt.Location = new System.Drawing.Point(409, 388);
            this.CancelButt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelButt.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Primary = false;
            this.CancelButt.Size = new System.Drawing.Size(78, 36);
            this.CancelButt.TabIndex = 9;
            this.CancelButt.Text = "CANCEL";
            this.CancelButt.UseVisualStyleBackColor = true;
            this.CancelButt.Click += new System.EventHandler(this.CancelButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 612);
            this.Controls.Add(this.CancelButt);
            this.Controls.Add(this.ShowButt);
            this.Controls.Add(this.AddButt);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.UserBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel UserLabel;
        private MaterialSkin.Controls.MaterialLabel CityLabel;
        private MaterialSkin.Controls.MaterialLabel PriceLabel;
        private MaterialSkin.Controls.MaterialFlatButton AddButt;
        protected internal System.Windows.Forms.TextBox UserBox;
        protected internal System.Windows.Forms.TextBox CityBox;
        protected internal System.Windows.Forms.TextBox PriceBox;
        public MaterialSkin.Controls.MaterialFlatButton ShowButt;
        private MaterialSkin.Controls.MaterialFlatButton CancelButt;
    }
}

