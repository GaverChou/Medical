namespace Medical
{
    partial class Form3
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
            this.rtfRichTextBox1 = new CCWin.SkinControl.RtfRichTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // rtfRichTextBox1
            // 
            this.rtfRichTextBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.rtfRichTextBox1.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBox1.Location = new System.Drawing.Point(7, 19);
            this.rtfRichTextBox1.Name = "rtfRichTextBox1";
            this.rtfRichTextBox1.Size = new System.Drawing.Size(663, 453);
            this.rtfRichTextBox1.TabIndex = 0;
            this.rtfRichTextBox1.Text = "";
            this.rtfRichTextBox1.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.Location = new System.Drawing.Point(229, 490);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(146, 34);
            this.skinButton1.TabIndex = 1;
            this.skinButton1.Text = "skinButton1";
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BackgroundImage = global::Medical.Properties.Resources.add;
            this.skinButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinButton2.Image = global::Medical.Properties.Resources.add;
            this.skinButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skinButton2.ImageWidth = 120;
            this.skinButton2.Location = new System.Drawing.Point(364, 317);
            this.skinButton2.MouseBack = global::Medical.Properties.Resources.add;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Radius = 4;
            this.skinButton2.Size = new System.Drawing.Size(137, 142);
            this.skinButton2.TabIndex = 2;
            this.skinButton2.Text = "skinButton2";
            this.skinButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skinButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.skinButton2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 531);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.rtfRichTextBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBox1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
    }
}