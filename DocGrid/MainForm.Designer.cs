namespace DocGrid
{
    partial class MainForm
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
            this.addDocBtn = new System.Windows.Forms.Button();
            this.docGrigView = new System.Windows.Forms.DataGridView();
            this.numberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.docGrigView)).BeginInit();
            this.SuspendLayout();
            // 
            // addDocBtn
            // 
            this.addDocBtn.Location = new System.Drawing.Point(13, 13);
            this.addDocBtn.Name = "addDocBtn";
            this.addDocBtn.Size = new System.Drawing.Size(573, 23);
            this.addDocBtn.TabIndex = 0;
            this.addDocBtn.Text = "Добавить документ";
            this.addDocBtn.UseVisualStyleBackColor = true;
            this.addDocBtn.Click += new System.EventHandler(this.addDocBtn_Click);
            // 
            // docGrigView
            // 
            this.docGrigView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.docGrigView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docGrigView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberCol,
            this.dataCol,
            this.statusCol,
            this.signCol});
            this.docGrigView.Location = new System.Drawing.Point(13, 43);
            this.docGrigView.Name = "docGrigView";
            this.docGrigView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.docGrigView.Size = new System.Drawing.Size(573, 296);
            this.docGrigView.TabIndex = 1;
            this.docGrigView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.docGrigView_CellDoubleClick);
            // 
            // numberCol
            // 
            this.numberCol.DataPropertyName = "DocNumber";
            this.numberCol.HeaderText = "Номер";
            this.numberCol.Name = "numberCol";
            // 
            // dataCol
            // 
            this.dataCol.DataPropertyName = "DocDate";
            this.dataCol.HeaderText = "Дата";
            this.dataCol.Name = "dataCol";
            // 
            // statusCol
            // 
            this.statusCol.DataPropertyName = "DocStatus";
            this.statusCol.HeaderText = "Статус";
            this.statusCol.Name = "statusCol";
            // 
            // signCol
            // 
            this.signCol.DataPropertyName = "DocSign";
            this.signCol.HeaderText = "Подписан";
            this.signCol.Name = "signCol";
            this.signCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.signCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 351);
            this.Controls.Add(this.docGrigView);
            this.Controls.Add(this.addDocBtn);
            this.Name = "MainForm";
            this.Text = "Журнал докуменов";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docGrigView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDocBtn;
        private System.Windows.Forms.DataGridView docGrigView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn signCol;
    }
}

