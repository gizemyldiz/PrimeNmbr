namespace AsalSayıÖdev
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
            this.button1AsalSayi = new System.Windows.Forms.Button();
            this.listBoxAsal = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1AsalSayi
            // 
            this.button1AsalSayi.Location = new System.Drawing.Point(504, 22);
            this.button1AsalSayi.Name = "button1AsalSayi";
            this.button1AsalSayi.Size = new System.Drawing.Size(97, 80);
            this.button1AsalSayi.TabIndex = 0;
            this.button1AsalSayi.Text = "Asal Sayılar";
            this.button1AsalSayi.UseVisualStyleBackColor = true;
            this.button1AsalSayi.Click += new System.EventHandler(this.button1AsalSayi_Click);
            // 
            // listBoxAsal
            // 
            this.listBoxAsal.FormattingEnabled = true;
            this.listBoxAsal.Location = new System.Drawing.Point(12, 22);
            this.listBoxAsal.Name = "listBoxAsal";
            this.listBoxAsal.Size = new System.Drawing.Size(469, 381);
            this.listBoxAsal.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxAsal);
            this.Controls.Add(this.button1AsalSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1AsalSayi;
        private System.Windows.Forms.ListBox listBoxAsal;
    }
}

