namespace SoftBlade.View.Purchase
{
    partial class AddPurchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerie = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReference = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNIT = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCodeProvider = new MetroFramework.Controls.MetroComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProvider = new MetroFramework.Controls.MetroComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSublTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.rtObservation = new System.Windows.Forms.RichTextBox();
            this.gridPurchase = new MetroFramework.Controls.MetroGrid();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbCodeProduct = new MetroFramework.Controls.MetroComboBox();
            this.cmbProduct = new MetroFramework.Controls.MetroComboBox();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.ckGenerateCode = new MetroFramework.Controls.MetroCheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblWithoutIVA = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtDate = new MetroFramework.Controls.MetroDateTime();
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.btnAddProvider = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Serie";
            // 
            // txtSerie
            // 
            // 
            // 
            // 
            this.txtSerie.CustomButton.Image = null;
            this.txtSerie.CustomButton.Location = new System.Drawing.Point(119, 2);
            this.txtSerie.CustomButton.Name = "";
            this.txtSerie.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtSerie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSerie.CustomButton.TabIndex = 1;
            this.txtSerie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSerie.CustomButton.UseSelectable = true;
            this.txtSerie.CustomButton.Visible = false;
            this.txtSerie.Lines = new string[0];
            this.txtSerie.Location = new System.Drawing.Point(166, 73);
            this.txtSerie.MaxLength = 32767;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.PasswordChar = '\0';
            this.txtSerie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSerie.SelectedText = "";
            this.txtSerie.SelectionLength = 0;
            this.txtSerie.SelectionStart = 0;
            this.txtSerie.ShortcutsEnabled = true;
            this.txtSerie.Size = new System.Drawing.Size(139, 22);
            this.txtSerie.TabIndex = 1;
            this.txtSerie.UseSelectable = true;
            this.txtSerie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSerie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(335, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(678, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha";
            // 
            // txtReference
            // 
            // 
            // 
            // 
            this.txtReference.CustomButton.Image = null;
            this.txtReference.CustomButton.Location = new System.Drawing.Point(156, 2);
            this.txtReference.CustomButton.Name = "";
            this.txtReference.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReference.CustomButton.TabIndex = 1;
            this.txtReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReference.CustomButton.UseSelectable = true;
            this.txtReference.CustomButton.Visible = false;
            this.txtReference.Lines = new string[0];
            this.txtReference.Location = new System.Drawing.Point(456, 73);
            this.txtReference.MaxLength = 32767;
            this.txtReference.Name = "txtReference";
            this.txtReference.PasswordChar = '\0';
            this.txtReference.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReference.SelectedText = "";
            this.txtReference.SelectionLength = 0;
            this.txtReference.SelectionStart = 0;
            this.txtReference.ShortcutsEnabled = true;
            this.txtReference.Size = new System.Drawing.Size(176, 22);
            this.txtReference.TabIndex = 4;
            this.txtReference.UseSelectable = true;
            this.txtReference.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReference.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15F);
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proveedores";
            // 
            // cmbNIT
            // 
            this.cmbNIT.FormattingEnabled = true;
            this.cmbNIT.ItemHeight = 23;
            this.cmbNIT.Location = new System.Drawing.Point(156, 161);
            this.cmbNIT.Name = "cmbNIT";
            this.cmbNIT.Size = new System.Drawing.Size(154, 29);
            this.cmbNIT.TabIndex = 7;
            this.cmbNIT.UseSelectable = true;
            this.cmbNIT.SelectedIndexChanged += new System.EventHandler(this.cmbNIT_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F);
            this.label5.Location = new System.Drawing.Point(84, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "NIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F);
            this.label6.Location = new System.Drawing.Point(372, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Código";
            // 
            // cmbCodeProvider
            // 
            this.cmbCodeProvider.FormattingEnabled = true;
            this.cmbCodeProvider.ItemHeight = 23;
            this.cmbCodeProvider.Location = new System.Drawing.Point(464, 158);
            this.cmbCodeProvider.Name = "cmbCodeProvider";
            this.cmbCodeProvider.Size = new System.Drawing.Size(176, 29);
            this.cmbCodeProvider.TabIndex = 10;
            this.cmbCodeProvider.UseSelectable = true;
            this.cmbCodeProvider.SelectedIndexChanged += new System.EventHandler(this.cmbCodeProvider_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F);
            this.label7.Location = new System.Drawing.Point(678, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre";
            // 
            // cmbProvider
            // 
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.ItemHeight = 23;
            this.cmbProvider.Location = new System.Drawing.Point(779, 158);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(197, 29);
            this.cmbProvider.TabIndex = 12;
            this.cmbProvider.UseSelectable = true;
            this.cmbProvider.SelectedIndexChanged += new System.EventHandler(this.cmbProvider_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15F);
            this.label8.Location = new System.Drawing.Point(23, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Detalle De Compra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F);
            this.label9.Location = new System.Drawing.Point(23, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Código de Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F);
            this.label10.Location = new System.Drawing.Point(25, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10F);
            this.label11.Location = new System.Drawing.Point(331, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F);
            this.label12.Location = new System.Drawing.Point(335, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cantidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F);
            this.label13.Location = new System.Drawing.Point(338, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "SubTotal";
            // 
            // lblSublTotal
            // 
            this.lblSublTotal.AutoSize = true;
            this.lblSublTotal.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblSublTotal.Location = new System.Drawing.Point(508, 353);
            this.lblSublTotal.Name = "lblSublTotal";
            this.lblSublTotal.Size = new System.Drawing.Size(18, 18);
            this.lblSublTotal.TabIndex = 19;
            this.lblSublTotal.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F);
            this.label16.Location = new System.Drawing.Point(622, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 18);
            this.label16.TabIndex = 24;
            this.label16.Text = "Observaciones";
            // 
            // rtObservation
            // 
            this.rtObservation.Location = new System.Drawing.Point(757, 249);
            this.rtObservation.Name = "rtObservation";
            this.rtObservation.Size = new System.Drawing.Size(169, 53);
            this.rtObservation.TabIndex = 25;
            this.rtObservation.Text = "";
            // 
            // gridPurchase
            // 
            this.gridPurchase.AllowUserToResizeRows = false;
            this.gridPurchase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPurchase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPurchase.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridPurchase.EnableHeadersVisualStyles = false;
            this.gridPurchase.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPurchase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPurchase.Location = new System.Drawing.Point(41, 374);
            this.gridPurchase.Name = "gridPurchase";
            this.gridPurchase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPurchase.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridPurchase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPurchase.Size = new System.Drawing.Size(975, 110);
            this.gridPurchase.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 12F);
            this.label17.Location = new System.Drawing.Point(844, 487);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 18);
            this.label17.TabIndex = 27;
            this.label17.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblTotal.Location = new System.Drawing.Point(952, 487);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 17);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "0";
            // 
            // cmbCodeProduct
            // 
            this.cmbCodeProduct.FormattingEnabled = true;
            this.cmbCodeProduct.ItemHeight = 23;
            this.cmbCodeProduct.Location = new System.Drawing.Point(176, 250);
            this.cmbCodeProduct.Name = "cmbCodeProduct";
            this.cmbCodeProduct.Size = new System.Drawing.Size(134, 29);
            this.cmbCodeProduct.TabIndex = 29;
            this.cmbCodeProduct.UseSelectable = true;
            this.cmbCodeProduct.SelectedIndexChanged += new System.EventHandler(this.cmbCodeProduct_SelectedIndexChanged);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.ItemHeight = 23;
            this.cmbProduct.Location = new System.Drawing.Point(176, 303);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(134, 29);
            this.cmbProduct.TabIndex = 30;
            this.cmbProduct.UseSelectable = true;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(121, 2);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(456, 249);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(141, 22);
            this.txtPrice.TabIndex = 31;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(121, 2);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(456, 277);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(141, 22);
            this.txtQuantity.TabIndex = 32;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // ckGenerateCode
            // 
            this.ckGenerateCode.AutoSize = true;
            this.ckGenerateCode.Location = new System.Drawing.Point(456, 101);
            this.ckGenerateCode.Name = "ckGenerateCode";
            this.ckGenerateCode.Size = new System.Drawing.Size(106, 15);
            this.ckGenerateCode.TabIndex = 42;
            this.ckGenerateCode.Text = "Generar Código";
            this.ckGenerateCode.UseSelectable = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 10F);
            this.label14.Location = new System.Drawing.Point(335, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Precio sin IVA";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9F);
            this.label18.Location = new System.Drawing.Point(359, 328);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 14);
            this.label18.TabIndex = 44;
            this.label18.Text = "IVA";
            // 
            // lblWithoutIVA
            // 
            this.lblWithoutIVA.AutoSize = true;
            this.lblWithoutIVA.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblWithoutIVA.Location = new System.Drawing.Point(508, 305);
            this.lblWithoutIVA.Name = "lblWithoutIVA";
            this.lblWithoutIVA.Size = new System.Drawing.Size(15, 14);
            this.lblWithoutIVA.TabIndex = 45;
            this.lblWithoutIVA.Text = "0";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblIVA.Location = new System.Drawing.Point(508, 328);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(15, 14);
            this.lblIVA.TabIndex = 46;
            this.lblIVA.Text = "0";
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Verdana", 12F);
            this.label21.Location = new System.Drawing.Point(338, 351);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(214, 2);
            this.label21.TabIndex = 47;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 10F);
            this.label19.Location = new System.Drawing.Point(335, 249);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 17);
            this.label19.TabIndex = 50;
            this.label19.Text = "Precio Unitario";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(779, 73);
            this.dtDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 29);
            this.dtDate.TabIndex = 51;
            // 
            // btnAddDetails
            // 
            this.btnAddDetails.BackColor = System.Drawing.Color.White;
            this.btnAddDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddDetails.FlatAppearance.BorderSize = 2;
            this.btnAddDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDetails.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetails.Image = global::SoftBlade.Properties.Resources.add;
            this.btnAddDetails.Location = new System.Drawing.Point(983, 269);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(36, 34);
            this.btnAddDetails.TabIndex = 41;
            this.btnAddDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDetails.UseVisualStyleBackColor = false;
            this.btnAddDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.White;
            this.addProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addProduct.FlatAppearance.BorderSize = 2;
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.Image = global::SoftBlade.Properties.Resources.add;
            this.addProduct.Location = new System.Drawing.Point(231, 206);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(35, 31);
            this.addProduct.TabIndex = 40;
            this.addProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.BackColor = System.Drawing.Color.White;
            this.btnAddProvider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddProvider.FlatAppearance.BorderSize = 2;
            this.btnAddProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProvider.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProvider.Image = global::SoftBlade.Properties.Resources.add;
            this.btnAddProvider.Location = new System.Drawing.Point(156, 122);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(35, 31);
            this.btnAddProvider.TabIndex = 38;
            this.btnAddProvider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProvider.UseVisualStyleBackColor = false;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::SoftBlade.Properties.Resources.save;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(863, 509);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(156, 32);
            this.btnNew.TabIndex = 37;
            this.btnNew.Text = "Guardar";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnDelete.Image = global::SoftBlade.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(983, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 33);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 547);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblWithoutIVA);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ckGenerateCode);
            this.Controls.Add(this.btnAddDetails);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.btnAddProvider);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.cmbCodeProduct);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.gridPurchase);
            this.Controls.Add(this.rtObservation);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblSublTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbProvider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCodeProvider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbNIT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label1);
            this.Name = "AddPurchase";
            this.Text = "Agregar Compras";
            ((System.ComponentModel.ISupportInitialize)(this.gridPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtReference;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cmbNIT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox cmbCodeProvider;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox cmbProvider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSublTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox rtObservation;
        private MetroFramework.Controls.MetroGrid gridPurchase;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTotal;
        private MetroFramework.Controls.MetroComboBox cmbCodeProduct;
        private MetroFramework.Controls.MetroComboBox cmbProduct;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAddProvider;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button btnAddDetails;
        private MetroFramework.Controls.MetroCheckBox ckGenerateCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblWithoutIVA;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private MetroFramework.Controls.MetroDateTime dtDate;
    }
}