namespace C968
{
    partial class Main_Form
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
            lbl_title = new Label();
            lbl_parts = new Label();
            lbl_products = new Label();
            listBox_parts = new ListBox();
            listBox_products = new ListBox();
            btn_parts_search = new Button();
            btn_products_search = new Button();
            tb_parts_search = new TextBox();
            tb_products_search = new TextBox();
            btn_parts_add = new Button();
            btn_parts_modify = new Button();
            btn_parts_delete = new Button();
            btn_products_delete = new Button();
            btn_products_modify = new Button();
            btn_products_add = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(9, 9);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(348, 31);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Inventory Management System";
            // 
            // lbl_parts
            // 
            lbl_parts.AutoSize = true;
            lbl_parts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_parts.Location = new Point(12, 104);
            lbl_parts.Name = "lbl_parts";
            lbl_parts.Size = new Size(61, 28);
            lbl_parts.TabIndex = 1;
            lbl_parts.Text = "Parts";
            // 
            // lbl_products
            // 
            lbl_products.AutoSize = true;
            lbl_products.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_products.Location = new Point(620, 104);
            lbl_products.Name = "lbl_products";
            lbl_products.Size = new Size(95, 28);
            lbl_products.TabIndex = 2;
            lbl_products.Text = "Products";
            // 
            // listBox_parts
            // 
            listBox_parts.FormattingEnabled = true;
            listBox_parts.Location = new Point(9, 135);
            listBox_parts.Name = "listBox_parts";
            listBox_parts.Size = new Size(550, 224);
            listBox_parts.TabIndex = 3;
            // 
            // listBox_products
            // 
            listBox_products.FormattingEnabled = true;
            listBox_products.Location = new Point(620, 135);
            listBox_products.Name = "listBox_products";
            listBox_products.Size = new Size(550, 224);
            listBox_products.TabIndex = 4;
            // 
            // btn_parts_search
            // 
            btn_parts_search.Location = new Point(234, 98);
            btn_parts_search.Name = "btn_parts_search";
            btn_parts_search.Size = new Size(94, 29);
            btn_parts_search.TabIndex = 5;
            btn_parts_search.Text = "Search";
            btn_parts_search.UseVisualStyleBackColor = true;
            // 
            // btn_products_search
            // 
            btn_products_search.Location = new Point(845, 98);
            btn_products_search.Name = "btn_products_search";
            btn_products_search.Size = new Size(94, 29);
            btn_products_search.TabIndex = 6;
            btn_products_search.Text = "Search";
            btn_products_search.UseVisualStyleBackColor = true;
            // 
            // tb_parts_search
            // 
            tb_parts_search.Location = new Point(334, 100);
            tb_parts_search.Name = "tb_parts_search";
            tb_parts_search.Size = new Size(225, 27);
            tb_parts_search.TabIndex = 7;
            // 
            // tb_products_search
            // 
            tb_products_search.Location = new Point(945, 98);
            tb_products_search.Name = "tb_products_search";
            tb_products_search.Size = new Size(225, 27);
            tb_products_search.TabIndex = 8;
            // 
            // btn_parts_add
            // 
            btn_parts_add.Location = new Point(265, 365);
            btn_parts_add.Name = "btn_parts_add";
            btn_parts_add.Size = new Size(94, 29);
            btn_parts_add.TabIndex = 9;
            btn_parts_add.Text = "Add";
            btn_parts_add.UseVisualStyleBackColor = true;
            // 
            // btn_parts_modify
            // 
            btn_parts_modify.Location = new Point(365, 365);
            btn_parts_modify.Name = "btn_parts_modify";
            btn_parts_modify.Size = new Size(94, 29);
            btn_parts_modify.TabIndex = 10;
            btn_parts_modify.Text = "Modify";
            btn_parts_modify.UseVisualStyleBackColor = true;
            // 
            // btn_parts_delete
            // 
            btn_parts_delete.Location = new Point(465, 365);
            btn_parts_delete.Name = "btn_parts_delete";
            btn_parts_delete.Size = new Size(94, 29);
            btn_parts_delete.TabIndex = 11;
            btn_parts_delete.Text = "Delete";
            btn_parts_delete.UseVisualStyleBackColor = true;
            // 
            // btn_products_delete
            // 
            btn_products_delete.Location = new Point(1077, 365);
            btn_products_delete.Name = "btn_products_delete";
            btn_products_delete.Size = new Size(94, 29);
            btn_products_delete.TabIndex = 14;
            btn_products_delete.Text = "Delete";
            btn_products_delete.UseVisualStyleBackColor = true;
            // 
            // btn_products_modify
            // 
            btn_products_modify.Location = new Point(977, 365);
            btn_products_modify.Name = "btn_products_modify";
            btn_products_modify.Size = new Size(94, 29);
            btn_products_modify.TabIndex = 13;
            btn_products_modify.Text = "Modify";
            btn_products_modify.UseVisualStyleBackColor = true;
            // 
            // btn_products_add
            // 
            btn_products_add.Location = new Point(877, 365);
            btn_products_add.Name = "btn_products_add";
            btn_products_add.Size = new Size(94, 29);
            btn_products_add.TabIndex = 12;
            btn_products_add.Text = "Add";
            btn_products_add.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(1076, 512);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 15;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1182, 553);
            Controls.Add(btn_exit);
            Controls.Add(btn_products_delete);
            Controls.Add(btn_products_modify);
            Controls.Add(btn_products_add);
            Controls.Add(btn_parts_delete);
            Controls.Add(btn_parts_modify);
            Controls.Add(btn_parts_add);
            Controls.Add(tb_products_search);
            Controls.Add(tb_parts_search);
            Controls.Add(btn_products_search);
            Controls.Add(btn_parts_search);
            Controls.Add(listBox_products);
            Controls.Add(listBox_parts);
            Controls.Add(lbl_products);
            Controls.Add(lbl_parts);
            Controls.Add(lbl_title);
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private Label lbl_parts;
        private Label lbl_products;
        private ListBox listBox_parts;
        private ListBox listBox_products;
        private Button btn_parts_search;
        private Button btn_products_search;
        private TextBox tb_parts_search;
        private TextBox tb_products_search;
        private Button btn_parts_add;
        private Button btn_parts_modify;
        private Button btn_parts_delete;
        private Button btn_products_delete;
        private Button btn_products_modify;
        private Button btn_products_add;
        private Button btn_exit;
    }
}
