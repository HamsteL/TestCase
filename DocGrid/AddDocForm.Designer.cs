namespace DocGrid
{
    partial class AddDocForm
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
            this.numDocText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descText = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numDocText
            // 
            this.numDocText.Location = new System.Drawing.Point(117, 12);
            this.numDocText.Name = "numDocText";
            this.numDocText.Size = new System.Drawing.Size(244, 20);
            this.numDocText.TabIndex = 0;
            this.numDocText.TextChanged += new System.EventHandler(this.numDocText_TextChanged);
            this.numDocText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDocText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер документа: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Статус: ";
            // 
            // statusList
            // 
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            "Новый",
            "В работе",
            "Закрыт"});
            this.statusList.Location = new System.Drawing.Point(117, 41);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(244, 21);
            this.statusList.TabIndex = 4;
            this.statusList.TextChanged += new System.EventHandler(this.statusList_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Описание: ";
            // 
            // descText
            // 
            this.descText.Location = new System.Drawing.Point(117, 72);
            this.descText.Multiline = true;
            this.descText.Name = "descText";
            this.descText.Size = new System.Drawing.Size(244, 177);
            this.descText.TabIndex = 5;
            this.descText.TextChanged += new System.EventHandler(this.descText_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(15, 255);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(346, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Добавить документ";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 290);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descText);
            this.Controls.Add(this.statusList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDocText);
            this.Name = "AddDocForm";
            this.Text = "Добавление документа";
            this.Load += new System.EventHandler(this.AddDocForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numDocText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descText;
        private System.Windows.Forms.Button addBtn;
    }
}