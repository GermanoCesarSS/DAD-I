namespace LISTA_DE_EXERCÍCIOS_WINDOWS_FORM_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.imag_butterfly = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imag_butterfly)).BeginInit();
            this.SuspendLayout();
            // 
            // imag_butterfly
            // 
            this.imag_butterfly.BackColor = System.Drawing.Color.Transparent;
            this.imag_butterfly.Image = ((System.Drawing.Image)(resources.GetObject("imag_butterfly.Image")));
            this.imag_butterfly.Location = new System.Drawing.Point(349, 77);
            this.imag_butterfly.Name = "imag_butterfly";
            this.imag_butterfly.Size = new System.Drawing.Size(165, 138);
            this.imag_butterfly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imag_butterfly.TabIndex = 0;
            this.imag_butterfly.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imag_butterfly);
            this.Name = "Form3";
            this.Text = "Form3";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.imag_butterfly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imag_butterfly;
    }
}