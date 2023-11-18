namespace Laba1Sem2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddProduct = new Button();
            CorzinaLook = new Button();
            CartBalance = new Button();
            SuspendLayout();
            // 
            // AddProduct
            // 
            AddProduct.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddProduct.Location = new Point(138, 35);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(555, 74);
            AddProduct.TabIndex = 0;
            AddProduct.Text = "Добавить Продукты";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // CorzinaLook
            // 
            CorzinaLook.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CorzinaLook.Location = new Point(138, 142);
            CorzinaLook.Name = "CorzinaLook";
            CorzinaLook.Size = new Size(555, 74);
            CorzinaLook.TabIndex = 1;
            CorzinaLook.Text = "Просмотреть Корзину";
            CorzinaLook.UseVisualStyleBackColor = true;
            CorzinaLook.Click += CorzinaLook_Click;
            // 
            // CartBalance
            // 
            CartBalance.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CartBalance.Location = new Point(138, 254);
            CartBalance.Name = "CartBalance";
            CartBalance.Size = new Size(555, 74);
            CartBalance.TabIndex = 2;
            CartBalance.Text = "Балансировка Корзины";
            CartBalance.UseVisualStyleBackColor = true;
            CartBalance.Click += CartBalance_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CartBalance);
            Controls.Add(CorzinaLook);
            Controls.Add(AddProduct);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += MainForm_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AddProduct;
        private Button CorzinaLook;
        private Button CartBalance;
    }
}