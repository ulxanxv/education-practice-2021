
namespace binmath
{
    partial class MainForm
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
            this.transferFormButton = new System.Windows.Forms.Button();
            this.additionFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transferFormButton
            // 
            this.transferFormButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transferFormButton.Location = new System.Drawing.Point(23, 14);
            this.transferFormButton.Margin = new System.Windows.Forms.Padding(5);
            this.transferFormButton.Name = "transferFormButton";
            this.transferFormButton.Size = new System.Drawing.Size(542, 34);
            this.transferFormButton.TabIndex = 0;
            this.transferFormButton.Text = "Перевести число из бинарной в десятичную систему";
            this.transferFormButton.UseVisualStyleBackColor = true;
            // 
            // additionFormButton
            // 
            this.additionFormButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionFormButton.Location = new System.Drawing.Point(23, 63);
            this.additionFormButton.Margin = new System.Windows.Forms.Padding(5);
            this.additionFormButton.Name = "additionFormButton";
            this.additionFormButton.Size = new System.Drawing.Size(542, 34);
            this.additionFormButton.TabIndex = 1;
            this.additionFormButton.Text = "Произвести сложение бинарных чисел";
            this.additionFormButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 111);
            this.Controls.Add(this.additionFormButton);
            this.Controls.Add(this.transferFormButton);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(600, 150);
            this.MinimumSize = new System.Drawing.Size(600, 150);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Действия с двоичными числами";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button transferFormButton;
        private System.Windows.Forms.Button additionFormButton;
    }
}

