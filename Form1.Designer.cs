namespace WindowsForms1806
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbZap = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblZaprCena = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMarka = new System.Windows.Forms.ComboBox();
            this.lblPatrol = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCena = new System.Windows.Forms.TextBox();
            this.tbxLiter = new System.Windows.Forms.TextBox();
            this.rbtnCena = new System.Windows.Forms.RadioButton();
            this.rbtnLiter = new System.Windows.Forms.RadioButton();
            this.gbCafe = new System.Windows.Forms.GroupBox();
            this.gbPay = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPay2 = new System.Windows.Forms.Label();
            this.lblPay3 = new System.Windows.Forms.Label();
            this.lblPay1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbZap.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbPay.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbZap
            // 
            this.gbZap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbZap.AutoSize = true;
            this.gbZap.Controls.Add(this.tableLayoutPanel3);
            this.gbZap.Location = new System.Drawing.Point(3, 3);
            this.gbZap.Name = "gbZap";
            this.gbZap.Size = new System.Drawing.Size(424, 421);
            this.gbZap.TabIndex = 0;
            this.gbZap.TabStop = false;
            this.gbZap.Text = "Заправка";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(418, 400);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblZaprCena);
            this.panel2.Controls.Add(this.lblCena);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 94);
            this.panel2.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(317, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "рублей";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-72, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // lblZaprCena
            // 
            this.lblZaprCena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZaprCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZaprCena.ForeColor = System.Drawing.Color.Blue;
            this.lblZaprCena.Location = new System.Drawing.Point(141, 37);
            this.lblZaprCena.Name = "lblZaprCena";
            this.lblZaprCena.Size = new System.Drawing.Size(130, 25);
            this.lblZaprCena.TabIndex = 0;
            this.lblZaprCena.Text = "0.00";
            this.lblZaprCena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCena.Location = new System.Drawing.Point(20, 37);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(58, 25);
            this.lblCena.TabIndex = 0;
            this.lblCena.Text = "Цена";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxMarka);
            this.panel1.Controls.Add(this.lblPatrol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 94);
            this.panel1.TabIndex = 2;
            // 
            // cbxMarka
            // 
            this.cbxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxMarka.FormattingEnabled = true;
            this.cbxMarka.Location = new System.Drawing.Point(141, 32);
            this.cbxMarka.Name = "cbxMarka";
            this.cbxMarka.Size = new System.Drawing.Size(130, 33);
            this.cbxMarka.TabIndex = 1;
            this.cbxMarka.Text = "Марка";
            this.cbxMarka.TextChanged += new System.EventHandler(this.cbxMarka_TextChanged);
            // 
            // lblPatrol
            // 
            this.lblPatrol.AutoSize = true;
            this.lblPatrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPatrol.Location = new System.Drawing.Point(20, 35);
            this.lblPatrol.Name = "lblPatrol";
            this.lblPatrol.Size = new System.Drawing.Size(79, 25);
            this.lblPatrol.TabIndex = 0;
            this.lblPatrol.Text = "Бензин";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbxCena);
            this.panel3.Controls.Add(this.tbxLiter);
            this.panel3.Controls.Add(this.rbtnCena);
            this.panel3.Controls.Add(this.rbtnLiter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 94);
            this.panel3.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(315, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "литров";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(317, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "рублей";
            // 
            // tbxCena
            // 
            this.tbxCena.Enabled = false;
            this.tbxCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCena.Location = new System.Drawing.Point(171, 58);
            this.tbxCena.Name = "tbxCena";
            this.tbxCena.Size = new System.Drawing.Size(100, 30);
            this.tbxCena.TabIndex = 2;
            this.tbxCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxLiter
            // 
            this.tbxLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLiter.Location = new System.Drawing.Point(171, 11);
            this.tbxLiter.Name = "tbxLiter";
            this.tbxLiter.Size = new System.Drawing.Size(100, 30);
            this.tbxLiter.TabIndex = 2;
            this.tbxLiter.Text = "0";
            this.tbxLiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxLiter.TextChanged += new System.EventHandler(this.tbxLiter_TextChanged);
            // 
            // rbtnCena
            // 
            this.rbtnCena.AutoSize = true;
            this.rbtnCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCena.Location = new System.Drawing.Point(25, 60);
            this.rbtnCena.Name = "rbtnCena";
            this.rbtnCena.Size = new System.Drawing.Size(99, 29);
            this.rbtnCena.TabIndex = 1;
            this.rbtnCena.Text = "Сумма";
            this.rbtnCena.UseVisualStyleBackColor = true;
            this.rbtnCena.CheckedChanged += new System.EventHandler(this.rbtnCena_CheckedChanged);
            // 
            // rbtnLiter
            // 
            this.rbtnLiter.AutoSize = true;
            this.rbtnLiter.Checked = true;
            this.rbtnLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnLiter.Location = new System.Drawing.Point(25, 12);
            this.rbtnLiter.Name = "rbtnLiter";
            this.rbtnLiter.Size = new System.Drawing.Size(99, 29);
            this.rbtnLiter.TabIndex = 0;
            this.rbtnLiter.TabStop = true;
            this.rbtnLiter.Text = "Объём";
            this.rbtnLiter.UseVisualStyleBackColor = true;
            this.rbtnLiter.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbCafe
            // 
            this.gbCafe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCafe.AutoSize = true;
            this.gbCafe.Location = new System.Drawing.Point(433, 3);
            this.gbCafe.Name = "gbCafe";
            this.gbCafe.Size = new System.Drawing.Size(546, 421);
            this.gbCafe.TabIndex = 1;
            this.gbCafe.TabStop = false;
            this.gbCafe.Text = "Кафе";
            // 
            // gbPay
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbPay, 2);
            this.gbPay.Controls.Add(this.tableLayoutPanel2);
            this.gbPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPay.Location = new System.Drawing.Point(3, 430);
            this.gbPay.Name = "gbPay";
            this.gbPay.Size = new System.Drawing.Size(976, 170);
            this.gbPay.TabIndex = 2;
            this.gbPay.TabStop = false;
            this.gbPay.Text = "Оплата";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.10204F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.73684F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.15789F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblPay2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPay3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblPay1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnPay, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(93, 44);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 116);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начислено:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Скидка:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "К оплате:";
            // 
            // lblPay2
            // 
            this.lblPay2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPay2.AutoSize = true;
            this.lblPay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPay2.ForeColor = System.Drawing.Color.Blue;
            this.lblPay2.Location = new System.Drawing.Point(318, 44);
            this.lblPay2.Name = "lblPay2";
            this.lblPay2.Size = new System.Drawing.Size(23, 25);
            this.lblPay2.TabIndex = 0;
            this.lblPay2.Text = "0";
            // 
            // lblPay3
            // 
            this.lblPay3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPay3.AutoSize = true;
            this.lblPay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPay3.ForeColor = System.Drawing.Color.Blue;
            this.lblPay3.Location = new System.Drawing.Point(318, 83);
            this.lblPay3.Name = "lblPay3";
            this.lblPay3.Size = new System.Drawing.Size(23, 25);
            this.lblPay3.TabIndex = 0;
            this.lblPay3.Text = "0";
            // 
            // lblPay1
            // 
            this.lblPay1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPay1.AutoSize = true;
            this.lblPay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPay1.ForeColor = System.Drawing.Color.Blue;
            this.lblPay1.Location = new System.Drawing.Point(318, 6);
            this.lblPay1.Name = "lblPay1";
            this.lblPay1.Size = new System.Drawing.Size(23, 25);
            this.lblPay1.TabIndex = 0;
            this.lblPay1.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(347, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "рублей";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(347, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "рублей";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(347, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "рублей";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPay.Location = new System.Drawing.Point(479, 41);
            this.btnPay.Name = "btnPay";
            this.tableLayoutPanel2.SetRowSpan(this.btnPay, 2);
            this.btnPay.Size = new System.Drawing.Size(302, 72);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Оплатить";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbZap, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbPay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbCafe, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.9369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.0631F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 603);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(820, 570);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbZap.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbPay.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbZap;
        private System.Windows.Forms.GroupBox gbCafe;
        private System.Windows.Forms.GroupBox gbPay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPay1;
        private System.Windows.Forms.Label lblPay2;
        private System.Windows.Forms.Label lblPay3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxMarka;
        private System.Windows.Forms.Label lblPatrol;
        private System.Windows.Forms.Label lblZaprCena;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCena;
        private System.Windows.Forms.TextBox tbxLiter;
        private System.Windows.Forms.RadioButton rbtnCena;
        private System.Windows.Forms.RadioButton rbtnLiter;
    }
}

