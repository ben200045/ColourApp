namespace ColourApp
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
            this.colourToJson = new System.Windows.Forms.Button();
            this.colours = new System.Windows.Forms.Button();
            this.jsonBox = new System.Windows.Forms.RichTextBox();
            this.colourBox = new System.Windows.Forms.ListView();
            this.Colour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RGB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // colourToJson
            // 
            this.colourToJson.Location = new System.Drawing.Point(12, 492);
            this.colourToJson.Name = "colourToJson";
            this.colourToJson.Size = new System.Drawing.Size(496, 23);
            this.colourToJson.TabIndex = 0;
            this.colourToJson.Text = "Write Colours File";
            this.colourToJson.UseVisualStyleBackColor = true;
            this.colourToJson.Click += new System.EventHandler(this.colourToJson_Click);
            // 
            // colours
            // 
            this.colours.Location = new System.Drawing.Point(557, 492);
            this.colours.Name = "colours";
            this.colours.Size = new System.Drawing.Size(319, 23);
            this.colours.TabIndex = 1;
            this.colours.Text = "Read Colours File";
            this.colours.UseVisualStyleBackColor = true;
            this.colours.Click += new System.EventHandler(this.colours_Click);
            // 
            // jsonBox
            // 
            this.jsonBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.jsonBox.Location = new System.Drawing.Point(12, 0);
            this.jsonBox.Name = "jsonBox";
            this.jsonBox.Size = new System.Drawing.Size(496, 486);
            this.jsonBox.TabIndex = 2;
            this.jsonBox.Text = "";
            // 
            // colourBox
            // 
            this.colourBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colourBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Colour,
            this.Hex,
            this.RGB});
            this.colourBox.Location = new System.Drawing.Point(557, 0);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(319, 486);
            this.colourBox.TabIndex = 3;
            this.colourBox.UseCompatibleStateImageBehavior = false;
            // 
            // Hex
            // 
            this.Hex.Text = "Hex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(888, 527);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.jsonBox);
            this.Controls.Add(this.colours);
            this.Controls.Add(this.colourToJson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button colourToJson;
        private System.Windows.Forms.Button colours;
        private System.Windows.Forms.RichTextBox jsonBox;
        private System.Windows.Forms.ListView colourBox;
        private System.Windows.Forms.ColumnHeader Colour;
        private System.Windows.Forms.ColumnHeader Hex;
        private System.Windows.Forms.ColumnHeader RGB;
    }
}

