namespace SlayTea
{
    partial class frmMain
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbTea = new System.Windows.Forms.GroupBox();
            this.btnLemonTea = new System.Windows.Forms.Button();
            this.btnPFTea = new System.Windows.Forms.Button();
            this.btnPeachTea = new System.Windows.Forms.Button();
            this.btnMGTea = new System.Windows.Forms.Button();
            this.btnThaiTea = new System.Windows.Forms.Button();
            this.btnMilkTea = new System.Windows.Forms.Button();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.btnCreamCheese = new System.Windows.Forms.Button();
            this.btnCoconutJelly = new System.Windows.Forms.Button();
            this.btnPopPearl = new System.Windows.Forms.Button();
            this.btnPudding = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnNoTopping = new System.Windows.Forms.Button();
            this.gbIce = new System.Windows.Forms.GroupBox();
            this.btnFullIce = new System.Windows.Forms.Button();
            this.btnHaftIce = new System.Windows.Forms.Button();
            this.btnNoIce = new System.Windows.Forms.Button();
            this.gbSugar = new System.Windows.Forms.GroupBox();
            this.btn100Sugar = new System.Windows.Forms.Button();
            this.btn75Sugar = new System.Windows.Forms.Button();
            this.btn50Sugar = new System.Windows.Forms.Button();
            this.btn25Sugar = new System.Windows.Forms.Button();
            this.btnNoSugar = new System.Windows.Forms.Button();
            this.gbDiscount = new System.Windows.Forms.GroupBox();
            this.btn100Discount = new System.Windows.Forms.Button();
            this.btn50Discount = new System.Windows.Forms.Button();
            this.btn30Discount = new System.Windows.Forms.Button();
            this.btn10Discount = new System.Windows.Forms.Button();
            this.btnNoDiscount = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnSugar = new System.Windows.Forms.Button();
            this.btnIce = new System.Windows.Forms.Button();
            this.btnTopping = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.gbTea.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbIce.SuspendLayout();
            this.gbSugar.SuspendLayout();
            this.gbDiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderGridView
            // 
            this.orderGridView.AllowUserToAddRows = false;
            this.orderGridView.AllowUserToDeleteRows = false;
            this.orderGridView.AllowUserToResizeColumns = false;
            this.orderGridView.AllowUserToResizeRows = false;
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.orderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.orderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(21, 12);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.ReadOnly = true;
            this.orderGridView.Size = new System.Drawing.Size(614, 205);
            this.orderGridView.TabIndex = 2;
            this.orderGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGridView_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(314, 602);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 51);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancel.Location = new System.Drawing.Point(508, 601);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 51);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnConfirm.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnConfirm.Location = new System.Drawing.Point(658, 601);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 51);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // gbTea
            // 
            this.gbTea.BackColor = System.Drawing.Color.Transparent;
            this.gbTea.Controls.Add(this.btnLemonTea);
            this.gbTea.Controls.Add(this.btnPFTea);
            this.gbTea.Controls.Add(this.btnPeachTea);
            this.gbTea.Controls.Add(this.btnMGTea);
            this.gbTea.Controls.Add(this.btnThaiTea);
            this.gbTea.Controls.Add(this.btnMilkTea);
            this.gbTea.Location = new System.Drawing.Point(29, 229);
            this.gbTea.Name = "gbTea";
            this.gbTea.Size = new System.Drawing.Size(631, 333);
            this.gbTea.TabIndex = 19;
            this.gbTea.TabStop = false;
            this.gbTea.Text = "Tea";
            this.gbTea.Visible = false;
            // 
            // btnLemonTea
            // 
            this.btnLemonTea.BackgroundImage = global::SlayTea.Properties.Resources._6;
            this.btnLemonTea.Location = new System.Drawing.Point(446, 189);
            this.btnLemonTea.Name = "btnLemonTea";
            this.btnLemonTea.Size = new System.Drawing.Size(170, 118);
            this.btnLemonTea.TabIndex = 18;
            this.btnLemonTea.UseVisualStyleBackColor = true;
            this.btnLemonTea.Click += new System.EventHandler(this.btnLemonTea_Click);
            // 
            // btnPFTea
            // 
            this.btnPFTea.BackgroundImage = global::SlayTea.Properties.Resources._5;
            this.btnPFTea.Location = new System.Drawing.Point(229, 189);
            this.btnPFTea.Name = "btnPFTea";
            this.btnPFTea.Size = new System.Drawing.Size(170, 118);
            this.btnPFTea.TabIndex = 17;
            this.btnPFTea.UseVisualStyleBackColor = true;
            this.btnPFTea.Click += new System.EventHandler(this.btnPFTea_Click);
            // 
            // btnPeachTea
            // 
            this.btnPeachTea.BackgroundImage = global::SlayTea.Properties.Resources._4;
            this.btnPeachTea.Location = new System.Drawing.Point(15, 189);
            this.btnPeachTea.Name = "btnPeachTea";
            this.btnPeachTea.Size = new System.Drawing.Size(170, 118);
            this.btnPeachTea.TabIndex = 16;
            this.btnPeachTea.UseVisualStyleBackColor = true;
            this.btnPeachTea.Click += new System.EventHandler(this.btnPeachTea_Click);
            // 
            // btnMGTea
            // 
            this.btnMGTea.BackgroundImage = global::SlayTea.Properties.Resources._3;
            this.btnMGTea.Location = new System.Drawing.Point(446, 15);
            this.btnMGTea.Name = "btnMGTea";
            this.btnMGTea.Size = new System.Drawing.Size(170, 118);
            this.btnMGTea.TabIndex = 15;
            this.btnMGTea.UseVisualStyleBackColor = true;
            this.btnMGTea.Click += new System.EventHandler(this.btnMGTea_Click);
            // 
            // btnThaiTea
            // 
            this.btnThaiTea.BackgroundImage = global::SlayTea.Properties.Resources._2;
            this.btnThaiTea.Location = new System.Drawing.Point(229, 15);
            this.btnThaiTea.Name = "btnThaiTea";
            this.btnThaiTea.Size = new System.Drawing.Size(170, 118);
            this.btnThaiTea.TabIndex = 14;
            this.btnThaiTea.UseVisualStyleBackColor = true;
            this.btnThaiTea.Click += new System.EventHandler(this.btnThaiTea_Click);
            // 
            // btnMilkTea
            // 
            this.btnMilkTea.BackgroundImage = global::SlayTea.Properties.Resources._1;
            this.btnMilkTea.Location = new System.Drawing.Point(15, 15);
            this.btnMilkTea.Name = "btnMilkTea";
            this.btnMilkTea.Size = new System.Drawing.Size(170, 118);
            this.btnMilkTea.TabIndex = 13;
            this.btnMilkTea.UseVisualStyleBackColor = true;
            this.btnMilkTea.Click += new System.EventHandler(this.btnMilkTea_Click);
            // 
            // gbTopping
            // 
            this.gbTopping.BackColor = System.Drawing.Color.Transparent;
            this.gbTopping.Controls.Add(this.btnCreamCheese);
            this.gbTopping.Controls.Add(this.btnCoconutJelly);
            this.gbTopping.Controls.Add(this.btnPopPearl);
            this.gbTopping.Controls.Add(this.btnPudding);
            this.gbTopping.Controls.Add(this.btnBubble);
            this.gbTopping.Controls.Add(this.btnNoTopping);
            this.gbTopping.Location = new System.Drawing.Point(21, 244);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(631, 332);
            this.gbTopping.TabIndex = 20;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Topping";
            this.gbTopping.Visible = false;
            // 
            // btnCreamCheese
            // 
            this.btnCreamCheese.BackgroundImage = global::SlayTea.Properties.Resources._12;
            this.btnCreamCheese.Location = new System.Drawing.Point(445, 193);
            this.btnCreamCheese.Name = "btnCreamCheese";
            this.btnCreamCheese.Size = new System.Drawing.Size(170, 118);
            this.btnCreamCheese.TabIndex = 18;
            this.btnCreamCheese.UseVisualStyleBackColor = true;
            this.btnCreamCheese.Click += new System.EventHandler(this.btnCreamCheese_Click);
            // 
            // btnCoconutJelly
            // 
            this.btnCoconutJelly.BackgroundImage = global::SlayTea.Properties.Resources._11;
            this.btnCoconutJelly.Location = new System.Drawing.Point(228, 193);
            this.btnCoconutJelly.Name = "btnCoconutJelly";
            this.btnCoconutJelly.Size = new System.Drawing.Size(170, 118);
            this.btnCoconutJelly.TabIndex = 17;
            this.btnCoconutJelly.UseVisualStyleBackColor = true;
            this.btnCoconutJelly.Click += new System.EventHandler(this.btnCoconutJelly_Click);
            // 
            // btnPopPearl
            // 
            this.btnPopPearl.BackgroundImage = global::SlayTea.Properties.Resources._10;
            this.btnPopPearl.Location = new System.Drawing.Point(14, 193);
            this.btnPopPearl.Name = "btnPopPearl";
            this.btnPopPearl.Size = new System.Drawing.Size(170, 118);
            this.btnPopPearl.TabIndex = 16;
            this.btnPopPearl.UseVisualStyleBackColor = true;
            this.btnPopPearl.Click += new System.EventHandler(this.btnPopPearl_Click);
            // 
            // btnPudding
            // 
            this.btnPudding.BackgroundImage = global::SlayTea.Properties.Resources._9;
            this.btnPudding.Location = new System.Drawing.Point(445, 19);
            this.btnPudding.Name = "btnPudding";
            this.btnPudding.Size = new System.Drawing.Size(170, 118);
            this.btnPudding.TabIndex = 15;
            this.btnPudding.UseVisualStyleBackColor = true;
            this.btnPudding.Click += new System.EventHandler(this.btnPudding_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.BackgroundImage = global::SlayTea.Properties.Resources._8;
            this.btnBubble.Location = new System.Drawing.Point(228, 19);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(170, 118);
            this.btnBubble.TabIndex = 14;
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnNoTopping
            // 
            this.btnNoTopping.BackgroundImage = global::SlayTea.Properties.Resources._7;
            this.btnNoTopping.Location = new System.Drawing.Point(14, 19);
            this.btnNoTopping.Name = "btnNoTopping";
            this.btnNoTopping.Size = new System.Drawing.Size(170, 118);
            this.btnNoTopping.TabIndex = 13;
            this.btnNoTopping.UseVisualStyleBackColor = true;
            this.btnNoTopping.Click += new System.EventHandler(this.btnNoTopping_Click);
            // 
            // gbIce
            // 
            this.gbIce.BackColor = System.Drawing.Color.Transparent;
            this.gbIce.Controls.Add(this.btnFullIce);
            this.gbIce.Controls.Add(this.btnHaftIce);
            this.gbIce.Controls.Add(this.btnNoIce);
            this.gbIce.Location = new System.Drawing.Point(13, 255);
            this.gbIce.Name = "gbIce";
            this.gbIce.Size = new System.Drawing.Size(633, 157);
            this.gbIce.TabIndex = 21;
            this.gbIce.TabStop = false;
            this.gbIce.Text = "Ice Level";
            this.gbIce.Visible = false;
            // 
            // btnFullIce
            // 
            this.btnFullIce.BackgroundImage = global::SlayTea.Properties.Resources._15;
            this.btnFullIce.Location = new System.Drawing.Point(445, 14);
            this.btnFullIce.Name = "btnFullIce";
            this.btnFullIce.Size = new System.Drawing.Size(170, 118);
            this.btnFullIce.TabIndex = 18;
            this.btnFullIce.UseVisualStyleBackColor = true;
            this.btnFullIce.Click += new System.EventHandler(this.btnFullIce_Click);
            // 
            // btnHaftIce
            // 
            this.btnHaftIce.BackgroundImage = global::SlayTea.Properties.Resources._142;
            this.btnHaftIce.Location = new System.Drawing.Point(228, 14);
            this.btnHaftIce.Name = "btnHaftIce";
            this.btnHaftIce.Size = new System.Drawing.Size(170, 118);
            this.btnHaftIce.TabIndex = 17;
            this.btnHaftIce.UseVisualStyleBackColor = true;
            this.btnHaftIce.Click += new System.EventHandler(this.btnHaftIce_Click);
            // 
            // btnNoIce
            // 
            this.btnNoIce.BackgroundImage = global::SlayTea.Properties.Resources._13;
            this.btnNoIce.Location = new System.Drawing.Point(14, 14);
            this.btnNoIce.Name = "btnNoIce";
            this.btnNoIce.Size = new System.Drawing.Size(170, 118);
            this.btnNoIce.TabIndex = 16;
            this.btnNoIce.UseVisualStyleBackColor = true;
            this.btnNoIce.Click += new System.EventHandler(this.btnNoIce_Click);
            // 
            // gbSugar
            // 
            this.gbSugar.BackColor = System.Drawing.Color.Transparent;
            this.gbSugar.Controls.Add(this.btn100Sugar);
            this.gbSugar.Controls.Add(this.btn75Sugar);
            this.gbSugar.Controls.Add(this.btn50Sugar);
            this.gbSugar.Controls.Add(this.btn25Sugar);
            this.gbSugar.Controls.Add(this.btnNoSugar);
            this.gbSugar.Location = new System.Drawing.Point(17, 244);
            this.gbSugar.Name = "gbSugar";
            this.gbSugar.Size = new System.Drawing.Size(638, 332);
            this.gbSugar.TabIndex = 25;
            this.gbSugar.TabStop = false;
            this.gbSugar.Text = "Sugar Level";
            this.gbSugar.Visible = false;
            // 
            // btn100Sugar
            // 
            this.btn100Sugar.BackgroundImage = global::SlayTea.Properties.Resources._20;
            this.btn100Sugar.Location = new System.Drawing.Point(339, 192);
            this.btn100Sugar.Name = "btn100Sugar";
            this.btn100Sugar.Size = new System.Drawing.Size(170, 118);
            this.btn100Sugar.TabIndex = 23;
            this.btn100Sugar.UseVisualStyleBackColor = true;
            this.btn100Sugar.Click += new System.EventHandler(this.btn100Sugar_Click);
            // 
            // btn75Sugar
            // 
            this.btn75Sugar.BackgroundImage = global::SlayTea.Properties.Resources._19;
            this.btn75Sugar.Location = new System.Drawing.Point(125, 192);
            this.btn75Sugar.Name = "btn75Sugar";
            this.btn75Sugar.Size = new System.Drawing.Size(170, 118);
            this.btn75Sugar.TabIndex = 22;
            this.btn75Sugar.UseVisualStyleBackColor = true;
            this.btn75Sugar.Click += new System.EventHandler(this.btn75Sugar_Click);
            // 
            // btn50Sugar
            // 
            this.btn50Sugar.BackgroundImage = global::SlayTea.Properties.Resources._18;
            this.btn50Sugar.Location = new System.Drawing.Point(448, 18);
            this.btn50Sugar.Name = "btn50Sugar";
            this.btn50Sugar.Size = new System.Drawing.Size(170, 118);
            this.btn50Sugar.TabIndex = 21;
            this.btn50Sugar.UseVisualStyleBackColor = true;
            this.btn50Sugar.Click += new System.EventHandler(this.btn50Sugar_Click);
            // 
            // btn25Sugar
            // 
            this.btn25Sugar.BackgroundImage = global::SlayTea.Properties.Resources._17;
            this.btn25Sugar.Location = new System.Drawing.Point(231, 18);
            this.btn25Sugar.Name = "btn25Sugar";
            this.btn25Sugar.Size = new System.Drawing.Size(170, 118);
            this.btn25Sugar.TabIndex = 20;
            this.btn25Sugar.UseVisualStyleBackColor = true;
            this.btn25Sugar.Click += new System.EventHandler(this.btn25Sugar_Click);
            // 
            // btnNoSugar
            // 
            this.btnNoSugar.BackgroundImage = global::SlayTea.Properties.Resources._16;
            this.btnNoSugar.Location = new System.Drawing.Point(17, 18);
            this.btnNoSugar.Name = "btnNoSugar";
            this.btnNoSugar.Size = new System.Drawing.Size(170, 118);
            this.btnNoSugar.TabIndex = 19;
            this.btnNoSugar.UseVisualStyleBackColor = true;
            this.btnNoSugar.Click += new System.EventHandler(this.btnNoSugar_Click);
            // 
            // gbDiscount
            // 
            this.gbDiscount.BackColor = System.Drawing.Color.Transparent;
            this.gbDiscount.Controls.Add(this.btn100Discount);
            this.gbDiscount.Controls.Add(this.btn50Discount);
            this.gbDiscount.Controls.Add(this.btn30Discount);
            this.gbDiscount.Controls.Add(this.btn10Discount);
            this.gbDiscount.Controls.Add(this.btnNoDiscount);
            this.gbDiscount.Location = new System.Drawing.Point(10, 248);
            this.gbDiscount.Name = "gbDiscount";
            this.gbDiscount.Size = new System.Drawing.Size(639, 328);
            this.gbDiscount.TabIndex = 30;
            this.gbDiscount.TabStop = false;
            this.gbDiscount.Text = "Discount";
            this.gbDiscount.Visible = false;
            // 
            // btn100Discount
            // 
            this.btn100Discount.BackgroundImage = global::SlayTea.Properties.Resources._25;
            this.btn100Discount.Location = new System.Drawing.Point(339, 191);
            this.btn100Discount.Name = "btn100Discount";
            this.btn100Discount.Size = new System.Drawing.Size(170, 118);
            this.btn100Discount.TabIndex = 28;
            this.btn100Discount.UseVisualStyleBackColor = true;
            this.btn100Discount.Click += new System.EventHandler(this.btn100Discount_Click);
            // 
            // btn50Discount
            // 
            this.btn50Discount.BackgroundImage = global::SlayTea.Properties.Resources._24;
            this.btn50Discount.Location = new System.Drawing.Point(125, 191);
            this.btn50Discount.Name = "btn50Discount";
            this.btn50Discount.Size = new System.Drawing.Size(170, 118);
            this.btn50Discount.TabIndex = 27;
            this.btn50Discount.UseVisualStyleBackColor = true;
            this.btn50Discount.Click += new System.EventHandler(this.btn50Discount_Click);
            // 
            // btn30Discount
            // 
            this.btn30Discount.BackgroundImage = global::SlayTea.Properties.Resources._23;
            this.btn30Discount.Location = new System.Drawing.Point(448, 17);
            this.btn30Discount.Name = "btn30Discount";
            this.btn30Discount.Size = new System.Drawing.Size(170, 118);
            this.btn30Discount.TabIndex = 26;
            this.btn30Discount.UseVisualStyleBackColor = true;
            this.btn30Discount.Click += new System.EventHandler(this.btn30Discount_Click);
            // 
            // btn10Discount
            // 
            this.btn10Discount.BackgroundImage = global::SlayTea.Properties.Resources._22;
            this.btn10Discount.Location = new System.Drawing.Point(231, 17);
            this.btn10Discount.Name = "btn10Discount";
            this.btn10Discount.Size = new System.Drawing.Size(170, 118);
            this.btn10Discount.TabIndex = 25;
            this.btn10Discount.UseVisualStyleBackColor = true;
            this.btn10Discount.Click += new System.EventHandler(this.btn10Discount_Click);
            // 
            // btnNoDiscount
            // 
            this.btnNoDiscount.BackgroundImage = global::SlayTea.Properties.Resources._21;
            this.btnNoDiscount.Location = new System.Drawing.Point(17, 17);
            this.btnNoDiscount.Name = "btnNoDiscount";
            this.btnNoDiscount.Size = new System.Drawing.Size(170, 118);
            this.btnNoDiscount.TabIndex = 24;
            this.btnNoDiscount.UseVisualStyleBackColor = true;
            this.btnNoDiscount.Click += new System.EventHandler(this.btnNoDiscount_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackgroundImage = global::SlayTea.Properties.Resources.orderbtn;
            this.btnRecord.Location = new System.Drawing.Point(21, 602);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(50, 50);
            this.btnRecord.TabIndex = 31;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackgroundImage = global::SlayTea.Properties.Resources.Discount;
            this.btnDiscount.Location = new System.Drawing.Point(658, 360);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(144, 81);
            this.btnDiscount.TabIndex = 7;
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnSugar
            // 
            this.btnSugar.BackgroundImage = global::SlayTea.Properties.Resources.Sugar;
            this.btnSugar.Location = new System.Drawing.Point(658, 273);
            this.btnSugar.Name = "btnSugar";
            this.btnSugar.Size = new System.Drawing.Size(144, 81);
            this.btnSugar.TabIndex = 6;
            this.btnSugar.UseVisualStyleBackColor = true;
            this.btnSugar.Click += new System.EventHandler(this.btnSugar_Click);
            // 
            // btnIce
            // 
            this.btnIce.BackgroundImage = global::SlayTea.Properties.Resources.Ice;
            this.btnIce.Location = new System.Drawing.Point(658, 186);
            this.btnIce.Name = "btnIce";
            this.btnIce.Size = new System.Drawing.Size(144, 81);
            this.btnIce.TabIndex = 5;
            this.btnIce.UseVisualStyleBackColor = true;
            this.btnIce.Click += new System.EventHandler(this.btnIce_Click);
            // 
            // btnTopping
            // 
            this.btnTopping.BackgroundImage = global::SlayTea.Properties.Resources.Topping;
            this.btnTopping.Location = new System.Drawing.Point(658, 99);
            this.btnTopping.Name = "btnTopping";
            this.btnTopping.Size = new System.Drawing.Size(144, 81);
            this.btnTopping.TabIndex = 4;
            this.btnTopping.UseVisualStyleBackColor = true;
            this.btnTopping.Click += new System.EventHandler(this.btnTopping_Click);
            // 
            // btnTea
            // 
            this.btnTea.BackgroundImage = global::SlayTea.Properties.Resources.Tea;
            this.btnTea.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnTea.Location = new System.Drawing.Point(658, 12);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(144, 81);
            this.btnTea.TabIndex = 3;
            this.btnTea.UseVisualStyleBackColor = true;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRemove.ForeColor = System.Drawing.Color.Crimson;
            this.btnRemove.Location = new System.Drawing.Point(411, 601);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 51);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::SlayTea.Properties.Resources.bg_SlayTea;
            this.ClientSize = new System.Drawing.Size(822, 683);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.gbDiscount);
            this.Controls.Add(this.gbSugar);
            this.Controls.Add(this.gbIce);
            this.Controls.Add(this.gbTea);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnSugar);
            this.Controls.Add(this.btnIce);
            this.Controls.Add(this.btnTopping);
            this.Controls.Add(this.btnTea);
            this.Controls.Add(this.orderGridView);
            this.Name = "frmMain";
            this.Text = "Slay Tea";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.gbTea.ResumeLayout(false);
            this.gbTopping.ResumeLayout(false);
            this.gbIce.ResumeLayout(false);
            this.gbSugar.ResumeLayout(false);
            this.gbDiscount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.Button btnTopping;
        private System.Windows.Forms.Button btnIce;
        private System.Windows.Forms.Button btnSugar;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnLemonTea;
        private System.Windows.Forms.Button btnPFTea;
        private System.Windows.Forms.Button btnPeachTea;
        private System.Windows.Forms.Button btnMGTea;
        private System.Windows.Forms.Button btnThaiTea;
        private System.Windows.Forms.Button btnMilkTea;
        private System.Windows.Forms.GroupBox gbTea;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.Button btnCreamCheese;
        private System.Windows.Forms.Button btnCoconutJelly;
        private System.Windows.Forms.Button btnPopPearl;
        private System.Windows.Forms.Button btnPudding;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnNoTopping;
        private System.Windows.Forms.GroupBox gbIce;
        private System.Windows.Forms.Button btnFullIce;
        private System.Windows.Forms.Button btnHaftIce;
        private System.Windows.Forms.Button btnNoIce;
        private System.Windows.Forms.GroupBox gbSugar;
        private System.Windows.Forms.Button btn100Sugar;
        private System.Windows.Forms.Button btn75Sugar;
        private System.Windows.Forms.Button btn50Sugar;
        private System.Windows.Forms.Button btn25Sugar;
        private System.Windows.Forms.Button btnNoSugar;
        private System.Windows.Forms.GroupBox gbDiscount;
        private System.Windows.Forms.Button btn100Discount;
        private System.Windows.Forms.Button btn50Discount;
        private System.Windows.Forms.Button btn30Discount;
        private System.Windows.Forms.Button btn10Discount;
        private System.Windows.Forms.Button btnNoDiscount;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnRemove;
    }
}