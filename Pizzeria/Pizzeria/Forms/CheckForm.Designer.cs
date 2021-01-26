
namespace Pizzeria.Forms
{
    partial class CheckForm
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
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.CheckTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.BackColor = System.Drawing.Color.ForestGreen;
            this.SaveToFileButton.CausesValidation = false;
            this.SaveToFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveToFileButton.FlatAppearance.BorderSize = 0;
            this.SaveToFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveToFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveToFileButton.ForeColor = System.Drawing.Color.White;
            this.SaveToFileButton.Location = new System.Drawing.Point(246, 293);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(147, 23);
            this.SaveToFileButton.TabIndex = 11;
            this.SaveToFileButton.TabStop = false;
            this.SaveToFileButton.Text = "Сохранить в файл";
            this.SaveToFileButton.UseVisualStyleBackColor = false;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.CausesValidation = false;
            this.FinishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishButton.Location = new System.Drawing.Point(12, 293);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(85, 23);
            this.FinishButton.TabIndex = 12;
            this.FinishButton.TabStop = false;
            this.FinishButton.Text = "Завершить";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // CheckTextBox
            // 
            this.CheckTextBox.Location = new System.Drawing.Point(12, 12);
            this.CheckTextBox.Multiline = true;
            this.CheckTextBox.Name = "CheckTextBox";
            this.CheckTextBox.ReadOnly = true;
            this.CheckTextBox.Size = new System.Drawing.Size(381, 275);
            this.CheckTextBox.TabIndex = 13;
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 328);
            this.Controls.Add(this.CheckTextBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.SaveToFileButton);
            this.Name = "CheckForm";
            this.Text = "Чек";
            this.Load += new System.EventHandler(this.CheckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveToFileButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.TextBox CheckTextBox;
    }
}