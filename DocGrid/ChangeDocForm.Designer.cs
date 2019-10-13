namespace DocGrid
{
    partial class ChangeDocForm
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
            this.signBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.ComboBox();
            this.descText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signBtn
            // 
            this.signBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signBtn.AutoSize = true;
            this.signBtn.Location = new System.Drawing.Point(12, 327);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(421, 31);
            this.signBtn.TabIndex = 0;
            this.signBtn.Text = "Подписать";
            this.signBtn.UseVisualStyleBackColor = true;
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер: ";
            // 
            // numText
            // 
            this.numText.BackColor = System.Drawing.SystemColors.Control;
            this.numText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numText.Location = new System.Drawing.Point(78, 13);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(108, 13);
            this.numText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Статус: ";
            // 
            // statusText
            // 
            this.statusText.FormattingEnabled = true;
            this.statusText.Items.AddRange(new object[] {
            "Новый",
            "В работе",
            "Закрыт"});
            this.statusText.Location = new System.Drawing.Point(78, 46);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(354, 21);
            this.statusText.TabIndex = 4;
            this.statusText.TextChanged += new System.EventHandler(this.statusText_TextChanged);
            // 
            // descText
            // 
            this.descText.BackColor = System.Drawing.SystemColors.Window;
            this.descText.Location = new System.Drawing.Point(78, 87);
            this.descText.Multiline = true;
            this.descText.Name = "descText";
            this.descText.ReadOnly = true;
            this.descText.Size = new System.Drawing.Size(354, 234);
            this.descText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Описание: ";
            // 
            // dataText
            // 
            this.dataText.BackColor = System.Drawing.SystemColors.Control;
            this.dataText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataText.Location = new System.Drawing.Point(274, 13);
            this.dataText.Name = "dataText";
            this.dataText.Size = new System.Drawing.Size(108, 13);
            this.dataText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата: ";
            // 
            // ChangeDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(445, 370);
            this.Controls.Add(this.dataText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeDocForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Изменение документа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeDocForm_FormClosing);
            this.Load += new System.EventHandler(this.ChangeDocForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusText;
        private System.Windows.Forms.TextBox descText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dataText;
        private System.Windows.Forms.Label label4;
    }
}