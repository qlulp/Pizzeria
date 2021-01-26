
namespace Pizzeria
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
            this.ProductsListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtomPanel = new System.Windows.Forms.Panel();
            this.MakeOrder = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.ButtomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsListPanel
            // 
            this.ProductsListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsListPanel.AutoScroll = true;
            this.ProductsListPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProductsListPanel.Enabled = false;
            this.ProductsListPanel.Location = new System.Drawing.Point(0, 0);
            this.ProductsListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ProductsListPanel.Name = "ProductsListPanel";
            this.ProductsListPanel.Padding = new System.Windows.Forms.Padding(10);
            this.ProductsListPanel.Size = new System.Drawing.Size(644, 344);
            this.ProductsListPanel.TabIndex = 0;
            // 
            // ButtomPanel
            // 
            this.ButtomPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtomPanel.CausesValidation = false;
            this.ButtomPanel.Controls.Add(this.MakeOrder);
            this.ButtomPanel.Controls.Add(this.PasswordLabel);
            this.ButtomPanel.Controls.Add(this.PasswordTextBox);
            this.ButtomPanel.Controls.Add(this.LoginLabel);
            this.ButtomPanel.Controls.Add(this.LoginTextBox);
            this.ButtomPanel.Controls.Add(this.SignInButton);
            this.ButtomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtomPanel.Location = new System.Drawing.Point(0, 342);
            this.ButtomPanel.Name = "ButtomPanel";
            this.ButtomPanel.Size = new System.Drawing.Size(644, 100);
            this.ButtomPanel.TabIndex = 1;
            // 
            // MakeOrder
            // 
            this.MakeOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.MakeOrder.CausesValidation = false;
            this.MakeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MakeOrder.FlatAppearance.BorderSize = 0;
            this.MakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeOrder.ForeColor = System.Drawing.Color.White;
            this.MakeOrder.Location = new System.Drawing.Point(501, 36);
            this.MakeOrder.Name = "MakeOrder";
            this.MakeOrder.Size = new System.Drawing.Size(121, 23);
            this.MakeOrder.TabIndex = 5;
            this.MakeOrder.TabStop = false;
            this.MakeOrder.Text = "Оформить заказ";
            this.MakeOrder.UseVisualStyleBackColor = false;
            this.MakeOrder.Click += new System.EventHandler(this.MakeOrder_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 57);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(51, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль: ";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(69, 54);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(12, 25);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(44, 13);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Логин: ";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(69, 22);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox.TabIndex = 1;
            // 
            // SignInButton
            // 
            this.SignInButton.CausesValidation = false;
            this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.Location = new System.Drawing.Point(194, 36);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 23);
            this.SignInButton.TabIndex = 0;
            this.SignInButton.TabStop = false;
            this.SignInButton.Text = "Войти";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 442);
            this.Controls.Add(this.ButtomPanel);
            this.Controls.Add(this.ProductsListPanel);
            this.MinimumSize = new System.Drawing.Size(660, 480);
            this.Name = "Form1";
            this.Text = "Асортимент";
            this.ButtomPanel.ResumeLayout(false);
            this.ButtomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ProductsListPanel;
        private System.Windows.Forms.Panel ButtomPanel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button MakeOrder;
    }
}

