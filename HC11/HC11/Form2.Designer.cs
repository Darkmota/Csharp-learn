namespace HC11
{
    partial class Form2
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
            this.textURL = new System.Windows.Forms.TextBox();
            this.startSpider = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtHtml = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(13, 13);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(610, 21);
            this.textURL.TabIndex = 0;
            // 
            // startSpider
            // 
            this.startSpider.Location = new System.Drawing.Point(629, 11);
            this.startSpider.Name = "startSpider";
            this.startSpider.Size = new System.Drawing.Size(159, 23);
            this.startSpider.TabIndex = 1;
            this.startSpider.Text = "start spider";
            this.startSpider.UseVisualStyleBackColor = true;
            this.startSpider.Click += new System.EventHandler(this.startSpider_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URL});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(444, 398);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtHtml
            // 
            this.txtHtml.Location = new System.Drawing.Point(463, 41);
            this.txtHtml.Multiline = true;
            this.txtHtml.Name = "txtHtml";
            this.txtHtml.Size = new System.Drawing.Size(325, 397);
            this.txtHtml.TabIndex = 3;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Width = 400;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHtml);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.startSpider);
            this.Controls.Add(this.textURL);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Button startSpider;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtHtml;
        private System.Windows.Forms.DataGridViewLinkColumn URL;
    }
}