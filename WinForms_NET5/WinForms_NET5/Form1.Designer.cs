
namespace WinForms_NET5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnnotateDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnnotateDoc
            // 
            this.btnAnnotateDoc.Location = new System.Drawing.Point(128, 94);
            this.btnAnnotateDoc.Name = "btnAnnotateDoc";
            this.btnAnnotateDoc.Size = new System.Drawing.Size(82, 57);
            this.btnAnnotateDoc.TabIndex = 0;
            this.btnAnnotateDoc.Text = "Annotate PDF Doc";
            this.btnAnnotateDoc.UseVisualStyleBackColor = true;
            this.btnAnnotateDoc.Click += new System.EventHandler(this.btnAnnotateDoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 249);
            this.Controls.Add(this.btnAnnotateDoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnotateDoc;
    }
}

