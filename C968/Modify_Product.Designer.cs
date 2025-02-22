namespace C968
{
    partial class Modify_Product
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
            dg_modify_product_ap = new DataGridView();
            dg_modify_product_cp = new DataGridView();
            btn_product_modify_cancel = new Button();
            btn_product_modify_save = new Button();
            btn_product_modify_delete = new Button();
            btn_product_modify_add = new Button();
            btn_product_modify_search = new Button();
            tb_product_modify_max = new TextBox();
            tb_product_modify_min = new TextBox();
            tb_product_modify_price = new TextBox();
            tb_product_modify_inventory = new TextBox();
            tb_product_modify_name = new TextBox();
            tb_product_modify_ID = new TextBox();
            tb_product_modify_search = new TextBox();
            lbl_modify_product_max = new Label();
            lbl_modify_product_min = new Label();
            lbl_modify_product_price = new Label();
            lbl_modify_product_inventory = new Label();
            lbl_modify_product_name = new Label();
            lbl_modify_product_ID = new Label();
            lbl_modify_product_title = new Label();
            lbl_modify_product_cp = new Label();
            lbl_modify_product_ap = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_modify_product_ap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_modify_product_cp).BeginInit();
            SuspendLayout();
            // 
            // dg_modify_product_ap
            // 
            dg_modify_product_ap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_modify_product_ap.Location = new Point(286, 326);
            dg_modify_product_ap.Name = "dg_modify_product_ap";
            dg_modify_product_ap.RowHeadersWidth = 51;
            dg_modify_product_ap.Size = new Size(596, 188);
            dg_modify_product_ap.TabIndex = 41;
            // 
            // dg_modify_product_cp
            // 
            dg_modify_product_cp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_modify_product_cp.Location = new Point(286, 81);
            dg_modify_product_cp.Name = "dg_modify_product_cp";
            dg_modify_product_cp.RowHeadersWidth = 51;
            dg_modify_product_cp.Size = new Size(596, 188);
            dg_modify_product_cp.TabIndex = 40;
            // 
            // btn_product_modify_cancel
            // 
            btn_product_modify_cancel.Location = new Point(784, 520);
            btn_product_modify_cancel.Name = "btn_product_modify_cancel";
            btn_product_modify_cancel.Size = new Size(94, 29);
            btn_product_modify_cancel.TabIndex = 39;
            btn_product_modify_cancel.Text = "Cancel";
            btn_product_modify_cancel.UseVisualStyleBackColor = true;
            btn_product_modify_cancel.Click += btn_modify_product_cancel_Click;
            // 
            // btn_product_modify_save
            // 
            btn_product_modify_save.Location = new Point(684, 520);
            btn_product_modify_save.Name = "btn_product_modify_save";
            btn_product_modify_save.Size = new Size(94, 29);
            btn_product_modify_save.TabIndex = 38;
            btn_product_modify_save.Text = "Save";
            btn_product_modify_save.UseVisualStyleBackColor = true;
            btn_product_modify_save.Click += btn_product_modify_save_Click;
            // 
            // btn_product_modify_delete
            // 
            btn_product_modify_delete.Location = new Point(891, 326);
            btn_product_modify_delete.Name = "btn_product_modify_delete";
            btn_product_modify_delete.Size = new Size(94, 29);
            btn_product_modify_delete.TabIndex = 37;
            btn_product_modify_delete.Text = "Delete";
            btn_product_modify_delete.UseVisualStyleBackColor = true;
            btn_product_modify_delete.Click += btn_product_modify_delete_Click;
            // 
            // btn_product_modify_add
            // 
            btn_product_modify_add.Location = new Point(888, 240);
            btn_product_modify_add.Name = "btn_product_modify_add";
            btn_product_modify_add.Size = new Size(94, 29);
            btn_product_modify_add.TabIndex = 36;
            btn_product_modify_add.Text = "Add";
            btn_product_modify_add.UseVisualStyleBackColor = true;
            // 
            // btn_product_modify_search
            // 
            btn_product_modify_search.Location = new Point(581, 48);
            btn_product_modify_search.Name = "btn_product_modify_search";
            btn_product_modify_search.Size = new Size(94, 29);
            btn_product_modify_search.TabIndex = 35;
            btn_product_modify_search.Text = "Search";
            btn_product_modify_search.UseVisualStyleBackColor = true;
            // 
            // tb_product_modify_max
            // 
            tb_product_modify_max.BorderStyle = BorderStyle.FixedSingle;
            tb_product_modify_max.Location = new Point(90, 314);
            tb_product_modify_max.Name = "tb_product_modify_max";
            tb_product_modify_max.Size = new Size(125, 27);
            tb_product_modify_max.TabIndex = 34;
            tb_product_modify_max.TextChanged += tb_product_modify_max_TextChanged;
            // 
            // tb_product_modify_min
            // 
            tb_product_modify_min.BorderStyle = BorderStyle.FixedSingle;
            tb_product_modify_min.Location = new Point(90, 356);
            tb_product_modify_min.Name = "tb_product_modify_min";
            tb_product_modify_min.Size = new Size(125, 27);
            tb_product_modify_min.TabIndex = 33;
            tb_product_modify_min.TextChanged += tb_product_modify_min_TextChanged;
            // 
            // tb_product_modify_price
            // 
            tb_product_modify_price.BorderStyle = BorderStyle.FixedSingle;
            tb_product_modify_price.Location = new Point(90, 272);
            tb_product_modify_price.Name = "tb_product_modify_price";
            tb_product_modify_price.Size = new Size(125, 27);
            tb_product_modify_price.TabIndex = 32;
            tb_product_modify_price.TextChanged += tb_product_modify_price_TextChanged;
            // 
            // tb_product_modify_inventory
            // 
            tb_product_modify_inventory.BorderStyle = BorderStyle.FixedSingle;
            tb_product_modify_inventory.Location = new Point(90, 230);
            tb_product_modify_inventory.Name = "tb_product_modify_inventory";
            tb_product_modify_inventory.Size = new Size(125, 27);
            tb_product_modify_inventory.TabIndex = 31;
            tb_product_modify_inventory.TextChanged += tb_product_modify_inventory_TextChanged;
            // 
            // tb_product_modify_name
            // 
            tb_product_modify_name.BorderStyle = BorderStyle.FixedSingle;
            tb_product_modify_name.Location = new Point(90, 188);
            tb_product_modify_name.Name = "tb_product_modify_name";
            tb_product_modify_name.Size = new Size(125, 27);
            tb_product_modify_name.TabIndex = 30;
            tb_product_modify_name.TextChanged += tb_product_modify_name_TextChanged;
            // 
            // tb_product_modify_ID
            // 
            tb_product_modify_ID.BorderStyle = BorderStyle.FixedSingle;
            tb_product_modify_ID.Location = new Point(90, 146);
            tb_product_modify_ID.Name = "tb_product_modify_ID";
            tb_product_modify_ID.ReadOnly = true;
            tb_product_modify_ID.Size = new Size(125, 27);
            tb_product_modify_ID.TabIndex = 29;
            // 
            // tb_product_modify_search
            // 
            tb_product_modify_search.BorderStyle = BorderStyle.FixedSingle;
            tb_product_modify_search.Location = new Point(681, 48);
            tb_product_modify_search.Name = "tb_product_modify_search";
            tb_product_modify_search.Size = new Size(201, 27);
            tb_product_modify_search.TabIndex = 28;
            // 
            // lbl_modify_product_max
            // 
            lbl_modify_product_max.AutoSize = true;
            lbl_modify_product_max.Location = new Point(43, 316);
            lbl_modify_product_max.Name = "lbl_modify_product_max";
            lbl_modify_product_max.Size = new Size(37, 20);
            lbl_modify_product_max.TabIndex = 27;
            lbl_modify_product_max.Text = "Max";
            lbl_modify_product_max.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_modify_product_min
            // 
            lbl_modify_product_min.AutoSize = true;
            lbl_modify_product_min.Location = new Point(46, 358);
            lbl_modify_product_min.Name = "lbl_modify_product_min";
            lbl_modify_product_min.Size = new Size(34, 20);
            lbl_modify_product_min.TabIndex = 26;
            lbl_modify_product_min.Text = "Min";
            lbl_modify_product_min.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_modify_product_price
            // 
            lbl_modify_product_price.AutoSize = true;
            lbl_modify_product_price.Location = new Point(39, 274);
            lbl_modify_product_price.Name = "lbl_modify_product_price";
            lbl_modify_product_price.Size = new Size(41, 20);
            lbl_modify_product_price.TabIndex = 25;
            lbl_modify_product_price.Text = "Price";
            lbl_modify_product_price.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_modify_product_inventory
            // 
            lbl_modify_product_inventory.AutoSize = true;
            lbl_modify_product_inventory.Location = new Point(14, 232);
            lbl_modify_product_inventory.Name = "lbl_modify_product_inventory";
            lbl_modify_product_inventory.Size = new Size(70, 20);
            lbl_modify_product_inventory.TabIndex = 24;
            lbl_modify_product_inventory.Text = "Inventory";
            lbl_modify_product_inventory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_modify_product_name
            // 
            lbl_modify_product_name.AutoSize = true;
            lbl_modify_product_name.Location = new Point(31, 190);
            lbl_modify_product_name.Name = "lbl_modify_product_name";
            lbl_modify_product_name.Size = new Size(49, 20);
            lbl_modify_product_name.TabIndex = 23;
            lbl_modify_product_name.Text = "Name";
            lbl_modify_product_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_modify_product_ID
            // 
            lbl_modify_product_ID.AutoSize = true;
            lbl_modify_product_ID.Location = new Point(56, 148);
            lbl_modify_product_ID.Name = "lbl_modify_product_ID";
            lbl_modify_product_ID.Size = new Size(24, 20);
            lbl_modify_product_ID.TabIndex = 22;
            lbl_modify_product_ID.Text = "ID";
            lbl_modify_product_ID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_modify_product_title
            // 
            lbl_modify_product_title.AutoSize = true;
            lbl_modify_product_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_modify_product_title.Location = new Point(37, 18);
            lbl_modify_product_title.Name = "lbl_modify_product_title";
            lbl_modify_product_title.Size = new Size(160, 28);
            lbl_modify_product_title.TabIndex = 21;
            lbl_modify_product_title.Text = "Modify Product";
            // 
            // lbl_modify_product_cp
            // 
            lbl_modify_product_cp.AutoSize = true;
            lbl_modify_product_cp.Location = new Point(286, 48);
            lbl_modify_product_cp.Name = "lbl_modify_product_cp";
            lbl_modify_product_cp.Size = new Size(125, 20);
            lbl_modify_product_cp.TabIndex = 42;
            lbl_modify_product_cp.Text = "All Canidate Parts";
            // 
            // lbl_modify_product_ap
            // 
            lbl_modify_product_ap.AutoSize = true;
            lbl_modify_product_ap.Location = new Point(286, 293);
            lbl_modify_product_ap.Name = "lbl_modify_product_ap";
            lbl_modify_product_ap.Size = new Size(116, 20);
            lbl_modify_product_ap.TabIndex = 43;
            lbl_modify_product_ap.Text = "Associated Parts";
            // 
            // Modify_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 566);
            Controls.Add(lbl_modify_product_ap);
            Controls.Add(lbl_modify_product_cp);
            Controls.Add(dg_modify_product_ap);
            Controls.Add(dg_modify_product_cp);
            Controls.Add(btn_product_modify_cancel);
            Controls.Add(btn_product_modify_save);
            Controls.Add(btn_product_modify_delete);
            Controls.Add(btn_product_modify_add);
            Controls.Add(btn_product_modify_search);
            Controls.Add(tb_product_modify_max);
            Controls.Add(tb_product_modify_min);
            Controls.Add(tb_product_modify_price);
            Controls.Add(tb_product_modify_inventory);
            Controls.Add(tb_product_modify_name);
            Controls.Add(tb_product_modify_ID);
            Controls.Add(tb_product_modify_search);
            Controls.Add(lbl_modify_product_max);
            Controls.Add(lbl_modify_product_min);
            Controls.Add(lbl_modify_product_price);
            Controls.Add(lbl_modify_product_inventory);
            Controls.Add(lbl_modify_product_name);
            Controls.Add(lbl_modify_product_ID);
            Controls.Add(lbl_modify_product_title);
            Name = "Modify_Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modify_Product";
            ((System.ComponentModel.ISupportInitialize)dg_modify_product_ap).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_modify_product_cp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg_modify_product_ap;
        private DataGridView dg_modify_product_cp;
        private Button btn_product_modify_cancel;
        private Button btn_product_modify_save;
        private Button btn_product_modify_delete;
        private Button btn_product_modify_add;
        private Button btn_product_modify_search;
        private TextBox tb_product_modify_max;
        private TextBox tb_product_modify_min;
        private TextBox tb_product_modify_price;
        private TextBox tb_product_modify_inventory;
        private TextBox tb_product_modify_name;
        private TextBox tb_product_modify_ID;
        private TextBox tb_product_modify_search;
        private Label lbl_modify_product_max;
        private Label lbl_modify_product_min;
        private Label lbl_modify_product_price;
        private Label lbl_modify_product_inventory;
        private Label lbl_modify_product_name;
        private Label lbl_modify_product_ID;
        private Label lbl_modify_product_title;
        private Label lbl_modify_product_cp;
        private Label lbl_modify_product_ap;
    }
}