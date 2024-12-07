namespace SlayTea
{
    partial class frmRecord
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
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpDateSearch = new System.Windows.Forms.DateTimePicker();
            this.cbbTea = new System.Windows.Forms.ComboBox();
            this.cbbTopping = new System.Windows.Forms.ComboBox();
            this.cbbIce = new System.Windows.Forms.ComboBox();
            this.cbbSugar = new System.Windows.Forms.ComboBox();
            this.cbbDiscount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbSoldBy = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderGridView
            // 
            this.orderGridView.AllowUserToAddRows = false;
            this.orderGridView.AllowUserToDeleteRows = false;
            this.orderGridView.AllowUserToOrderColumns = true;
            this.orderGridView.AllowUserToResizeColumns = false;
            this.orderGridView.AllowUserToResizeRows = false;
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.orderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.orderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(39, 90);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.ReadOnly = true;
            this.orderGridView.Size = new System.Drawing.Size(905, 469);
            this.orderGridView.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(124, 608);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnSearch.Location = new System.Drawing.Point(682, 637);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(195, 45);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDateSearch
            // 
            this.dtpDateSearch.Location = new System.Drawing.Point(464, 653);
            this.dtpDateSearch.Name = "dtpDateSearch";
            this.dtpDateSearch.Size = new System.Drawing.Size(171, 20);
            this.dtpDateSearch.TabIndex = 7;
            // 
            // cbbTea
            // 
            this.cbbTea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTea.FormattingEnabled = true;
            this.cbbTea.Items.AddRange(new object[] {
            "",
            "-",
            "Milk Tea",
            "Thai Tea",
            "Matcha Green Tea",
            "Peach Tea",
            "Passion Fruit Tea",
            "Lemon Tea"});
            this.cbbTea.Location = new System.Drawing.Point(289, 607);
            this.cbbTea.Name = "cbbTea";
            this.cbbTea.Size = new System.Drawing.Size(151, 21);
            this.cbbTea.TabIndex = 8;
            // 
            // cbbTopping
            // 
            this.cbbTopping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTopping.FormattingEnabled = true;
            this.cbbTopping.Items.AddRange(new object[] {
            "",
            "-",
            "Bubble",
            "Pudding",
            "Pop Pearl",
            "Coconut Jelly",
            "Cream Cheese"});
            this.cbbTopping.Location = new System.Drawing.Point(454, 607);
            this.cbbTopping.Name = "cbbTopping";
            this.cbbTopping.Size = new System.Drawing.Size(151, 21);
            this.cbbTopping.TabIndex = 9;
            // 
            // cbbIce
            // 
            this.cbbIce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIce.FormattingEnabled = true;
            this.cbbIce.Items.AddRange(new object[] {
            "",
            "-",
            "Haft Ice",
            "Full Ice"});
            this.cbbIce.Location = new System.Drawing.Point(620, 607);
            this.cbbIce.Name = "cbbIce";
            this.cbbIce.Size = new System.Drawing.Size(124, 21);
            this.cbbIce.TabIndex = 10;
            // 
            // cbbSugar
            // 
            this.cbbSugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSugar.FormattingEnabled = true;
            this.cbbSugar.Items.AddRange(new object[] {
            "",
            "-",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.cbbSugar.Location = new System.Drawing.Point(754, 608);
            this.cbbSugar.Name = "cbbSugar";
            this.cbbSugar.Size = new System.Drawing.Size(123, 21);
            this.cbbSugar.TabIndex = 11;
            // 
            // cbbDiscount
            // 
            this.cbbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiscount.FormattingEnabled = true;
            this.cbbDiscount.Items.AddRange(new object[] {
            "",
            "-",
            "10%",
            "30%",
            "50%",
            "100%"});
            this.cbbDiscount.Location = new System.Drawing.Point(125, 653);
            this.cbbDiscount.Name = "cbbDiscount";
            this.cbbDiscount.Size = new System.Drawing.Size(125, 21);
            this.cbbDiscount.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tea :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Topping :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 592);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ice Level :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(751, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sugar Level :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 638);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Discount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 638);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Date :";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSum.Location = new System.Drawing.Point(820, 562);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(74, 20);
            this.lblSum.TabIndex = 23;
            this.lblSum.Text = "Total : 0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 637);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Sold By :";
            // 
            // cbbSoldBy
            // 
            this.cbbSoldBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoldBy.FormattingEnabled = true;
            this.cbbSoldBy.Items.AddRange(new object[] {
            ""});
            this.cbbSoldBy.Location = new System.Drawing.Point(264, 653);
            this.cbbSoldBy.Name = "cbbSoldBy";
            this.cbbSoldBy.Size = new System.Drawing.Size(184, 21);
            this.cbbSoldBy.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SlayTea.Properties.Resources.Record_Order;
            this.pictureBox1.Location = new System.Drawing.Point(203, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 82);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(994, 709);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbSoldBy);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbDiscount);
            this.Controls.Add(this.cbbSugar);
            this.Controls.Add(this.cbbIce);
            this.Controls.Add(this.cbbTopping);
            this.Controls.Add(this.cbbTea);
            this.Controls.Add(this.dtpDateSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.orderGridView);
            this.Name = "frmRecord";
            this.Text = "Order Record";
            this.Load += new System.EventHandler(this.frmRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDateSearch;
        private System.Windows.Forms.ComboBox cbbTea;
        private System.Windows.Forms.ComboBox cbbTopping;
        private System.Windows.Forms.ComboBox cbbIce;
        private System.Windows.Forms.ComboBox cbbSugar;
        private System.Windows.Forms.ComboBox cbbDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbSoldBy;
    }
}