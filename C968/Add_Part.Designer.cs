namespace C968
{
    partial class Add_Part
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
            lbl_part_add_title = new Label();
            rb_part_add_inHouse = new RadioButton();
            rb_part_add_outsourced = new RadioButton();
            lbl_part_add_id = new Label();
            lbl_part_add_name = new Label();
            lbl_part_add_inventory = new Label();
            lbl_part_add_priceCost = new Label();
            lbl_part_add_min = new Label();
            lbl_part_add_max = new Label();
            lbl_part_add_mi_cn = new Label();
            tb_part_add_id = new TextBox();
            tb_part_add_name = new TextBox();
            tb_part_add_inventory = new TextBox();
            tb_part_add_priceCost = new TextBox();
            tb_part_add_max = new TextBox();
            tb_part_add_min = new TextBox();
            tb_part_add_mi_cn = new TextBox();
            btn_part_add_save = new Button();
            btn_part_add_cancel = new Button();
            SuspendLayout();
            // 
            // lbl_part_add_title
            // 
            lbl_part_add_title.AutoSize = true;
            lbl_part_add_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_part_add_title.Location = new Point(3, 8);
            lbl_part_add_title.Name = "lbl_part_add_title";
            lbl_part_add_title.Size = new Size(76, 21);
            lbl_part_add_title.TabIndex = 0;
            lbl_part_add_title.Text = "Add Part";
            // 
            // rb_part_add_inHouse
            // 
            rb_part_add_inHouse.AutoSize = true;
            rb_part_add_inHouse.Checked = true;
            rb_part_add_inHouse.Location = new Point(142, 11);
            rb_part_add_inHouse.Name = "rb_part_add_inHouse";
            rb_part_add_inHouse.Size = new Size(74, 19);
            rb_part_add_inHouse.TabIndex = 1;
            rb_part_add_inHouse.TabStop = true;
            rb_part_add_inHouse.Text = "In-House";
            rb_part_add_inHouse.UseVisualStyleBackColor = true;
            rb_part_add_inHouse.CheckedChanged += radioButton_inHouse_CheckedChanged;
            // 
            // rb_part_add_outsourced
            // 
            rb_part_add_outsourced.AutoSize = true;
            rb_part_add_outsourced.Location = new Point(222, 12);
            rb_part_add_outsourced.Name = "rb_part_add_outsourced";
            rb_part_add_outsourced.Size = new Size(87, 19);
            rb_part_add_outsourced.TabIndex = 2;
            rb_part_add_outsourced.Text = "Outsourced";
            rb_part_add_outsourced.UseVisualStyleBackColor = true;
            rb_part_add_outsourced.CheckedChanged += radioButton_outsourced_CheckedChanged;
            // 
            // lbl_part_add_id
            // 
            lbl_part_add_id.AutoSize = true;
            lbl_part_add_id.Location = new Point(151, 79);
            lbl_part_add_id.Name = "lbl_part_add_id";
            lbl_part_add_id.Size = new Size(18, 15);
            lbl_part_add_id.TabIndex = 3;
            lbl_part_add_id.Text = "ID";
            lbl_part_add_id.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_add_name
            // 
            lbl_part_add_name.AutoSize = true;
            lbl_part_add_name.Location = new Point(130, 110);
            lbl_part_add_name.Name = "lbl_part_add_name";
            lbl_part_add_name.Size = new Size(39, 15);
            lbl_part_add_name.TabIndex = 4;
            lbl_part_add_name.Text = "Name";
            lbl_part_add_name.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_add_inventory
            // 
            lbl_part_add_inventory.AutoSize = true;
            lbl_part_add_inventory.Location = new Point(112, 140);
            lbl_part_add_inventory.Name = "lbl_part_add_inventory";
            lbl_part_add_inventory.Size = new Size(57, 15);
            lbl_part_add_inventory.TabIndex = 5;
            lbl_part_add_inventory.Text = "Inventory";
            lbl_part_add_inventory.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_add_priceCost
            // 
            lbl_part_add_priceCost.AutoSize = true;
            lbl_part_add_priceCost.Location = new Point(101, 169);
            lbl_part_add_priceCost.Name = "lbl_part_add_priceCost";
            lbl_part_add_priceCost.Size = new Size(68, 15);
            lbl_part_add_priceCost.TabIndex = 6;
            lbl_part_add_priceCost.Text = "Price / Cost";
            lbl_part_add_priceCost.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_add_min
            // 
            lbl_part_add_min.AutoSize = true;
            lbl_part_add_min.Location = new Point(250, 196);
            lbl_part_add_min.Name = "lbl_part_add_min";
            lbl_part_add_min.Size = new Size(28, 15);
            lbl_part_add_min.TabIndex = 7;
            lbl_part_add_min.Text = "Min";
            lbl_part_add_min.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_add_max
            // 
            lbl_part_add_max.AutoSize = true;
            lbl_part_add_max.Location = new Point(140, 195);
            lbl_part_add_max.Name = "lbl_part_add_max";
            lbl_part_add_max.Size = new Size(29, 15);
            lbl_part_add_max.TabIndex = 8;
            lbl_part_add_max.Text = "Max";
            lbl_part_add_max.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_add_mi_cn
            // 
            lbl_part_add_mi_cn.Location = new Point(19, 224);
            lbl_part_add_mi_cn.Name = "lbl_part_add_mi_cn";
            lbl_part_add_mi_cn.Size = new Size(150, 15);
            lbl_part_add_mi_cn.TabIndex = 9;
            lbl_part_add_mi_cn.Text = "Machine ID";
            lbl_part_add_mi_cn.TextAlign = ContentAlignment.TopRight;
            // 
            // tb_part_add_id
            // 
            tb_part_add_id.Location = new Point(175, 71);
            tb_part_add_id.Name = "tb_part_add_id";
            tb_part_add_id.Size = new Size(170, 23);
            tb_part_add_id.TabIndex = 10;
            // 
            // tb_part_add_name
            // 
            tb_part_add_name.Location = new Point(175, 102);
            tb_part_add_name.Name = "tb_part_add_name";
            tb_part_add_name.Size = new Size(170, 23);
            tb_part_add_name.TabIndex = 11;
            // 
            // tb_part_add_inventory
            // 
            tb_part_add_inventory.Location = new Point(175, 132);
            tb_part_add_inventory.Name = "tb_part_add_inventory";
            tb_part_add_inventory.Size = new Size(170, 23);
            tb_part_add_inventory.TabIndex = 12;
            // 
            // tb_part_add_priceCost
            // 
            tb_part_add_priceCost.Location = new Point(175, 161);
            tb_part_add_priceCost.Name = "tb_part_add_priceCost";
            tb_part_add_priceCost.Size = new Size(170, 23);
            tb_part_add_priceCost.TabIndex = 13;
            // 
            // tb_part_add_max
            // 
            tb_part_add_max.Location = new Point(175, 190);
            tb_part_add_max.Name = "tb_part_add_max";
            tb_part_add_max.Size = new Size(69, 23);
            tb_part_add_max.TabIndex = 14;
            // 
            // tb_part_add_min
            // 
            tb_part_add_min.Location = new Point(284, 190);
            tb_part_add_min.Name = "tb_part_add_min";
            tb_part_add_min.Size = new Size(61, 23);
            tb_part_add_min.TabIndex = 15;
            // 
            // tb_part_add_mi_cn
            // 
            tb_part_add_mi_cn.Location = new Point(175, 219);
            tb_part_add_mi_cn.Name = "tb_part_add_mi_cn";
            tb_part_add_mi_cn.Size = new Size(170, 23);
            tb_part_add_mi_cn.TabIndex = 16;
            // 
            // btn_part_add_save
            // 
            btn_part_add_save.Location = new Point(315, 307);
            btn_part_add_save.Name = "btn_part_add_save";
            btn_part_add_save.Size = new Size(75, 23);
            btn_part_add_save.TabIndex = 17;
            btn_part_add_save.Text = "Save";
            btn_part_add_save.UseVisualStyleBackColor = true;
            btn_part_add_save.Click += btn_part_save_Click;
            // 
            // btn_part_add_cancel
            // 
            btn_part_add_cancel.Location = new Point(396, 307);
            btn_part_add_cancel.Name = "btn_part_add_cancel";
            btn_part_add_cancel.Size = new Size(75, 23);
            btn_part_add_cancel.TabIndex = 18;
            btn_part_add_cancel.Text = "Cancel";
            btn_part_add_cancel.UseVisualStyleBackColor = true;
            btn_part_add_cancel.Click += btn_part_cancel_Click;
            // 
            // Add_Part
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(483, 342);
            Controls.Add(btn_part_add_cancel);
            Controls.Add(btn_part_add_save);
            Controls.Add(tb_part_add_mi_cn);
            Controls.Add(tb_part_add_min);
            Controls.Add(tb_part_add_max);
            Controls.Add(tb_part_add_priceCost);
            Controls.Add(tb_part_add_inventory);
            Controls.Add(tb_part_add_name);
            Controls.Add(tb_part_add_id);
            Controls.Add(lbl_part_add_mi_cn);
            Controls.Add(lbl_part_add_max);
            Controls.Add(lbl_part_add_min);
            Controls.Add(lbl_part_add_priceCost);
            Controls.Add(lbl_part_add_inventory);
            Controls.Add(lbl_part_add_name);
            Controls.Add(lbl_part_add_id);
            Controls.Add(rb_part_add_outsourced);
            Controls.Add(rb_part_add_inHouse);
            Controls.Add(lbl_part_add_title);
            Name = "Add_Part";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_part_add_title;
        private RadioButton rb_part_add_inHouse;
        private RadioButton rb_part_add_outsourced;
        private Label lbl_part_add_id;
        private Label lbl_part_add_name;
        private Label lbl_part_add_inventory;
        private Label lbl_part_add_priceCost;
        private Label lbl_part_add_min;
        private Label lbl_part_add_max;
        private Label lbl_part_add_mi_cn;
        private TextBox tb_part_add_id;
        private TextBox tb_part_add_name;
        private TextBox tb_part_add_inventory;
        private TextBox tb_part_add_priceCost;
        private TextBox tb_part_add_max;
        private TextBox tb_part_add_min;
        private TextBox tb_part_add_mi_cn;
        private Button btn_part_add_save;
        private Button btn_part_add_cancel;
    }
}