
namespace Pizzeria.Controls
{
    partial class ProductCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.AddLabel = new System.Windows.Forms.Label();
            this.RemoveLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceLabel1 = new System.Windows.Forms.Label();
            this.ProductImagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(45, 176);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(53, 20);
            this.CountTextBox.TabIndex = 1;
            this.CountTextBox.Text = "0";
            this.CountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountTextBox.WordWrap = false;
            this.CountTextBox.TextChanged += new System.EventHandler(this.CountTextBox_TextChanged);
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddLabel.Location = new System.Drawing.Point(104, 175);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(21, 24);
            this.AddLabel.TabIndex = 2;
            this.AddLabel.Text = "+";
            this.AddLabel.Click += new System.EventHandler(this.AddLabel_Click);
            // 
            // RemoveLabel
            // 
            this.RemoveLabel.AutoSize = true;
            this.RemoveLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveLabel.Location = new System.Drawing.Point(20, 171);
            this.RemoveLabel.Name = "RemoveLabel";
            this.RemoveLabel.Size = new System.Drawing.Size(19, 25);
            this.RemoveLabel.TabIndex = 3;
            this.RemoveLabel.Text = "-";
            this.RemoveLabel.Click += new System.EventHandler(this.RemoveLabel_Click);
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameLabel.Location = new System.Drawing.Point(19, 13);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(103, 31);
            this.ProductNameLabel.TabIndex = 4;
            this.ProductNameLabel.Text = "Название";
            // 
            // PriceLabel
            // 
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.PriceLabel.Location = new System.Drawing.Point(60, 43);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(62, 23);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "100";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceLabel1
            // 
            this.PriceLabel1.AutoSize = true;
            this.PriceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.PriceLabel1.Location = new System.Drawing.Point(19, 47);
            this.PriceLabel1.Name = "PriceLabel1";
            this.PriceLabel1.Size = new System.Drawing.Size(45, 13);
            this.PriceLabel1.TabIndex = 6;
            this.PriceLabel1.Text = "Цена: ";
            // 
            // ProductImagePictureBox
            // 
            this.ProductImagePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ProductImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ProductImagePictureBox.Image")));
            this.ProductImagePictureBox.Location = new System.Drawing.Point(22, 70);
            this.ProductImagePictureBox.Name = "ProductImagePictureBox";
            this.ProductImagePictureBox.Size = new System.Drawing.Size(100, 100);
            this.ProductImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductImagePictureBox.TabIndex = 0;
            this.ProductImagePictureBox.TabStop = false;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.PriceLabel1);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.RemoveLabel);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.ProductImagePictureBox);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(145, 211);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductImagePictureBox;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Label RemoveLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label PriceLabel1;
    }
}
