namespace Geometry
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
            this.cbGeometryShapes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.pnlParameters = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGeometryShapes
            // 
            this.cbGeometryShapes.DisplayMember = "Name";
            this.cbGeometryShapes.FormattingEnabled = true;
            this.cbGeometryShapes.Location = new System.Drawing.Point(35, 12);
            this.cbGeometryShapes.Name = "cbGeometryShapes";
            this.cbGeometryShapes.Size = new System.Drawing.Size(134, 24);
            this.cbGeometryShapes.TabIndex = 0;
            this.cbGeometryShapes.SelectedIndexChanged += new System.EventHandler(this.cbGeometryShapes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Result:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(591, 502);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(172, 22);
            this.tbResult.TabIndex = 2;
            // 
            // pnlParameters
            // 
            this.pnlParameters.Location = new System.Drawing.Point(12, 278);
            this.pnlParameters.Name = "pnlParameters";
            this.pnlParameters.Size = new System.Drawing.Size(333, 216);
            this.pnlParameters.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 217);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlParameters);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbGeometryShapes);
            this.Name = "Form1";
            this.Text = "Geometry";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGeometryShapes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Panel pnlParameters;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

