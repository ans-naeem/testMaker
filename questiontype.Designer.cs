
namespace testMaker
{
    partial class questiontype
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
            this.labelClass = new System.Windows.Forms.Label();
            this.labelclass2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(22, 29);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(99, 33);
            this.labelClass.TabIndex = 0;
            this.labelClass.Text = "label1";
            // 
            // labelclass2
            // 
            this.labelclass2.AutoSize = true;
            this.labelclass2.Location = new System.Drawing.Point(185, 48);
            this.labelclass2.Name = "labelclass2";
            this.labelclass2.Size = new System.Drawing.Size(35, 13);
            this.labelclass2.TabIndex = 1;
            this.labelclass2.Text = "label1";
            // 
            // questiontype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelclass2);
            this.Controls.Add(this.labelClass);
            this.Name = "questiontype";
            this.Text = "subjects";
            this.Load += new System.EventHandler(this.subjects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelclass2;
    }
}