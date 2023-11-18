namespace Laba1Sem2
{
    partial class AddProductForm
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
            listBox1 = new ListBox();
            label1 = new Label();
            AddItem = new Button();
            listBox2 = new ListBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(265, 319);
            listBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(221, 24);
            label1.TabIndex = 6;
            label1.Text = "Доступные Продукты:";
            // 
            // AddItem
            // 
            AddItem.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AddItem.Location = new Point(283, 153);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(200, 76);
            AddItem.TabIndex = 7;
            AddItem.Text = "Добавить в корзину";
            AddItem.UseVisualStyleBackColor = true;
            AddItem.Click += AddItem_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(489, 43);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(265, 319);
            listBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(489, 14);
            label2.Name = "label2";
            label2.Size = new Size(153, 24);
            label2.TabIndex = 9;
            label2.Text = "Ваша корзина:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 413);
            button1.Name = "button1";
            button1.Size = new Size(120, 25);
            button1.TabIndex = 10;
            button1.Text = "Вернуться назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(AddItem);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProductForm";
            FormClosed += AddProductForm_FormClosed;
            Load += AddProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private Label label1;
        private Button AddItem;
        private ListBox listBox2;
        private Label label2;
        private Button button1;
    }
}