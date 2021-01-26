
namespace Pizzeria.Forms
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ContactInfoLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AdresLabel = new System.Windows.Forms.Label();
            this.AdresTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.GetCheck = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.PromoCodeTextBox = new System.Windows.Forms.TextBox();
            this.PromoCodeLabel = new System.Windows.Forms.Label();
            this.CheckPromoCodeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderPriceLabel = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стоимость без скидки: ";
            // 
            // ContactInfoLabel
            // 
            this.ContactInfoLabel.AutoSize = true;
            this.ContactInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactInfoLabel.Location = new System.Drawing.Point(12, 113);
            this.ContactInfoLabel.Name = "ContactInfoLabel";
            this.ContactInfoLabel.Size = new System.Drawing.Size(241, 13);
            this.ContactInfoLabel.TabIndex = 2;
            this.ContactInfoLabel.Text = "Контактный телефон и адрес доставки";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(73, 136);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(239, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 139);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(32, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Имя:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(12, 165);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(55, 13);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "Телефон:";
            // 
            // AdresLabel
            // 
            this.AdresLabel.AutoSize = true;
            this.AdresLabel.Location = new System.Drawing.Point(12, 192);
            this.AdresLabel.Name = "AdresLabel";
            this.AdresLabel.Size = new System.Drawing.Size(41, 13);
            this.AdresLabel.TabIndex = 6;
            this.AdresLabel.Text = "Адрес:";
            // 
            // AdresTextBox
            // 
            this.AdresTextBox.Location = new System.Drawing.Point(73, 189);
            this.AdresTextBox.Name = "AdresTextBox";
            this.AdresTextBox.Size = new System.Drawing.Size(239, 20);
            this.AdresTextBox.TabIndex = 7;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(73, 162);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(239, 20);
            this.PhoneNumberTextBox.TabIndex = 8;
            // 
            // GetCheck
            // 
            this.GetCheck.BackColor = System.Drawing.Color.ForestGreen;
            this.GetCheck.CausesValidation = false;
            this.GetCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetCheck.FlatAppearance.BorderSize = 0;
            this.GetCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetCheck.ForeColor = System.Drawing.Color.White;
            this.GetCheck.Location = new System.Drawing.Point(191, 229);
            this.GetCheck.Name = "GetCheck";
            this.GetCheck.Size = new System.Drawing.Size(121, 23);
            this.GetCheck.TabIndex = 10;
            this.GetCheck.TabStop = false;
            this.GetCheck.Text = "Получить чек";
            this.GetCheck.UseVisualStyleBackColor = false;
            this.GetCheck.Click += new System.EventHandler(this.GetCheck_Click);
            // 
            // BackButton
            // 
            this.BackButton.CausesValidation = false;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(12, 229);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 11;
            this.BackButton.TabStop = false;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PromoCodeTextBox
            // 
            this.PromoCodeTextBox.Location = new System.Drawing.Point(80, 12);
            this.PromoCodeTextBox.Name = "PromoCodeTextBox";
            this.PromoCodeTextBox.Size = new System.Drawing.Size(138, 20);
            this.PromoCodeTextBox.TabIndex = 13;
            // 
            // PromoCodeLabel
            // 
            this.PromoCodeLabel.AutoSize = true;
            this.PromoCodeLabel.Location = new System.Drawing.Point(12, 15);
            this.PromoCodeLabel.Name = "PromoCodeLabel";
            this.PromoCodeLabel.Size = new System.Drawing.Size(62, 13);
            this.PromoCodeLabel.TabIndex = 12;
            this.PromoCodeLabel.Text = "Промокод:";
            // 
            // CheckPromoCodeButton
            // 
            this.CheckPromoCodeButton.CausesValidation = false;
            this.CheckPromoCodeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPromoCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckPromoCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPromoCodeButton.Location = new System.Drawing.Point(224, 10);
            this.CheckPromoCodeButton.Name = "CheckPromoCodeButton";
            this.CheckPromoCodeButton.Size = new System.Drawing.Size(88, 23);
            this.CheckPromoCodeButton.TabIndex = 14;
            this.CheckPromoCodeButton.TabStop = false;
            this.CheckPromoCodeButton.Text = "Расчитать";
            this.CheckPromoCodeButton.UseVisualStyleBackColor = true;
            this.CheckPromoCodeButton.Click += new System.EventHandler(this.CheckPromoCodeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Итоговая стоимость:";
            // 
            // OrderPriceLabel
            // 
            this.OrderPriceLabel.Location = new System.Drawing.Point(140, 47);
            this.OrderPriceLabel.Name = "OrderPriceLabel";
            this.OrderPriceLabel.Size = new System.Drawing.Size(172, 13);
            this.OrderPriceLabel.TabIndex = 16;
            this.OrderPriceLabel.Text = "100";
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalAmountLabel.ForeColor = System.Drawing.Color.Green;
            this.TotalAmountLabel.Location = new System.Drawing.Point(162, 69);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(150, 16);
            this.TotalAmountLabel.TabIndex = 17;
            this.TotalAmountLabel.Text = "100";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(324, 259);
            this.Controls.Add(this.TotalAmountLabel);
            this.Controls.Add(this.OrderPriceLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CheckPromoCodeButton);
            this.Controls.Add(this.PromoCodeTextBox);
            this.Controls.Add(this.PromoCodeLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.GetCheck);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.AdresTextBox);
            this.Controls.Add(this.AdresLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ContactInfoLabel);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ContactInfoLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label AdresLabel;
        private System.Windows.Forms.TextBox AdresTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Button GetCheck;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox PromoCodeTextBox;
        private System.Windows.Forms.Label PromoCodeLabel;
        private System.Windows.Forms.Button CheckPromoCodeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label OrderPriceLabel;
        private System.Windows.Forms.Label TotalAmountLabel;
    }
}