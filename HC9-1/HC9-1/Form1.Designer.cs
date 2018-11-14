namespace HC9_1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateXMLButton = new System.Windows.Forms.Button();
            this.XMLBox = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateXMLButton
            // 
            this.CreateXMLButton.Location = new System.Drawing.Point(585, 12);
            this.CreateXMLButton.Name = "CreateXMLButton";
            this.CreateXMLButton.Size = new System.Drawing.Size(203, 30);
            this.CreateXMLButton.TabIndex = 0;
            this.CreateXMLButton.Text = "生成Xml文档于D:\\test.xml";
            this.CreateXMLButton.UseVisualStyleBackColor = true;
            this.CreateXMLButton.Click += new System.EventHandler(this.CreateXMLButton_Click);
            // 
            // XMLBox
            // 
            this.XMLBox.Font = new System.Drawing.Font("宋体", 20F);
            this.XMLBox.Location = new System.Drawing.Point(0, 0);
            this.XMLBox.Multiline = true;
            this.XMLBox.Name = "XMLBox";
            this.XMLBox.Size = new System.Drawing.Size(561, 450);
            this.XMLBox.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(651, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 21);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "水果名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "价格";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(651, 80);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(137, 21);
            this.txtPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "产地";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(651, 107);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(137, 21);
            this.txtFrom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "等级";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(651, 134);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(137, 21);
            this.txtLevel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "保质期";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(651, 161);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(137, 21);
            this.txtDate.TabIndex = 10;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(585, 188);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(203, 30);
            this.Insert.TabIndex = 12;
            this.Insert.Text = "插入新结点";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(585, 224);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(203, 30);
            this.Search.TabIndex = 13;
            this.Search.Text = "搜索并准备编辑";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.XMLBox);
            this.Controls.Add(this.CreateXMLButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateXMLButton;
        private System.Windows.Forms.TextBox XMLBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Search;
    }
}

