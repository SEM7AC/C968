namespace C968
{
    partial class Modify_Part
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
            btn_part_modify_cancel = new Button();
            btn_part_modify_save = new Button();
            tb_part_modify_mi_cn = new TextBox();
            tb_part_modify_min = new TextBox();
            tb_part_modify_max = new TextBox();
            tb_part_modify_priceCost = new TextBox();
            tb_part_modify_inventory = new TextBox();
            tb_part_modify_name = new TextBox();
            tb_part_modify_id = new TextBox();
            lbl_part_modify_mi_cn = new Label();
            lbl_part_modify_max = new Label();
            lbl_part_modify_min = new Label();
            lbl_part_modify_priceCost = new Label();
            lbl_part_modify_inventory = new Label();
            lbl_part_modify_name = new Label();
            lbl_part_modify_id = new Label();
            rb_part_modify_outsourced = new RadioButton();
            rb_part_modify_inHouse = new RadioButton();
            lbl_part_modify_title = new Label();
            SuspendLayout();
            // 
            // btn_part_modify_cancel
            // 
            btn_part_modify_cancel.Location = new Point(409, 310);
            btn_part_modify_cancel.Name = "btn_part_modify_cancel";
            btn_part_modify_cancel.Size = new Size(75, 23);
            btn_part_modify_cancel.TabIndex = 37;
            btn_part_modify_cancel.Text = "Cancel";
            btn_part_modify_cancel.UseVisualStyleBackColor = true;
            btn_part_modify_cancel.Click += btn_part_modify_cancel_Click;
            // 
            // btn_part_modify_save
            // 
            btn_part_modify_save.Location = new Point(328, 310);
            btn_part_modify_save.Name = "btn_part_modify_save";
            btn_part_modify_save.Size = new Size(75, 23);
            btn_part_modify_save.TabIndex = 36;
            btn_part_modify_save.Text = "Save";
            btn_part_modify_save.UseVisualStyleBackColor = true;
            btn_part_modify_save.Click += btn_part_modify_save_Click;
            // 
            // tb_part_modify_mi_cn
            // 
            tb_part_modify_mi_cn.Location = new Point(188, 222);
            tb_part_modify_mi_cn.Name = "tb_part_modify_mi_cn";
            tb_part_modify_mi_cn.Size = new Size(170, 23);
            tb_part_modify_mi_cn.TabIndex = 35;
            // 
            // tb_part_modify_min
            // 
            tb_part_modify_min.Location = new Point(297, 193);
            tb_part_modify_min.Name = "tb_part_modify_min";
            tb_part_modify_min.Size = new Size(61, 23);
            tb_part_modify_min.TabIndex = 34;
            // 
            // tb_part_modify_max
            // 
            tb_part_modify_max.Location = new Point(188, 193);
            tb_part_modify_max.Name = "tb_part_modify_max";
            tb_part_modify_max.Size = new Size(69, 23);
            tb_part_modify_max.TabIndex = 33;
            // 
            // tb_part_modify_priceCost
            // 
            tb_part_modify_priceCost.Location = new Point(188, 164);
            tb_part_modify_priceCost.Name = "tb_part_modify_priceCost";
            tb_part_modify_priceCost.Size = new Size(170, 23);
            tb_part_modify_priceCost.TabIndex = 32;
            // 
            // tb_part_modify_inventory
            // 
            tb_part_modify_inventory.Location = new Point(188, 135);
            tb_part_modify_inventory.Name = "tb_part_modify_inventory";
            tb_part_modify_inventory.Size = new Size(170, 23);
            tb_part_modify_inventory.TabIndex = 31;
            // 
            // tb_part_modify_name
            // 
            tb_part_modify_name.Location = new Point(188, 105);
            tb_part_modify_name.Name = "tb_part_modify_name";
            tb_part_modify_name.Size = new Size(170, 23);
            tb_part_modify_name.TabIndex = 30;
            // 
            // tb_part_modify_id
            // 
            tb_part_modify_id.Location = new Point(188, 74);
            tb_part_modify_id.Name = "tb_part_modify_id";
            tb_part_modify_id.Size = new Size(170, 23);
            tb_part_modify_id.TabIndex = 29;
            // 
            // lbl_part_modify_mi_cn
            // 
            lbl_part_modify_mi_cn.Location = new Point(32, 227);
            lbl_part_modify_mi_cn.Name = "lbl_part_modify_mi_cn";
            lbl_part_modify_mi_cn.Size = new Size(150, 15);
            lbl_part_modify_mi_cn.TabIndex = 28;
            lbl_part_modify_mi_cn.Text = "Machine ID";
            lbl_part_modify_mi_cn.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_modify_max
            // 
            lbl_part_modify_max.AutoSize = true;
            lbl_part_modify_max.Location = new Point(153, 198);
            lbl_part_modify_max.Name = "lbl_part_modify_max";
            lbl_part_modify_max.Size = new Size(29, 15);
            lbl_part_modify_max.TabIndex = 27;
            lbl_part_modify_max.Text = "Max";
            lbl_part_modify_max.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_modify_min
            // 
            lbl_part_modify_min.AutoSize = true;
            lbl_part_modify_min.Location = new Point(263, 199);
            lbl_part_modify_min.Name = "lbl_part_modify_min";
            lbl_part_modify_min.Size = new Size(28, 15);
            lbl_part_modify_min.TabIndex = 26;
            lbl_part_modify_min.Text = "Min";
            lbl_part_modify_min.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_modify_priceCost
            // 
            lbl_part_modify_priceCost.AutoSize = true;
            lbl_part_modify_priceCost.Location = new Point(114, 172);
            lbl_part_modify_priceCost.Name = "lbl_part_modify_priceCost";
            lbl_part_modify_priceCost.Size = new Size(68, 15);
            lbl_part_modify_priceCost.TabIndex = 25;
            lbl_part_modify_priceCost.Text = "Price / Cost";
            lbl_part_modify_priceCost.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_modify_inventory
            // 
            lbl_part_modify_inventory.AutoSize = true;
            lbl_part_modify_inventory.Location = new Point(125, 143);
            lbl_part_modify_inventory.Name = "lbl_part_modify_inventory";
            lbl_part_modify_inventory.Size = new Size(57, 15);
            lbl_part_modify_inventory.TabIndex = 24;
            lbl_part_modify_inventory.Text = "Inventory";
            lbl_part_modify_inventory.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_modify_name
            // 
            lbl_part_modify_name.AutoSize = true;
            lbl_part_modify_name.Location = new Point(143, 113);
            lbl_part_modify_name.Name = "lbl_part_modify_name";
            lbl_part_modify_name.Size = new Size(39, 15);
            lbl_part_modify_name.TabIndex = 23;
            lbl_part_modify_name.Text = "Name";
            lbl_part_modify_name.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl_part_modify_id
            // 
            lbl_part_modify_id.AutoSize = true;
            lbl_part_modify_id.Location = new Point(164, 82);
            lbl_part_modify_id.Name = "lbl_part_modify_id";
            lbl_part_modify_id.Size = new Size(18, 15);
            lbl_part_modify_id.TabIndex = 22;
            lbl_part_modify_id.Text = "ID";
            lbl_part_modify_id.TextAlign = ContentAlignment.TopRight;
            // 
            // rb_part_modify_outsourced
            // 
            rb_part_modify_outsourced.AutoSize = true;
            rb_part_modify_outsourced.Location = new Point(235, 15);
            rb_part_modify_outsourced.Name = "rb_part_modify_outsourced";
            rb_part_modify_outsourced.Size = new Size(87, 19);
            rb_part_modify_outsourced.TabIndex = 21;
            rb_part_modify_outsourced.Text = "Outsourced";
            rb_part_modify_outsourced.UseVisualStyleBackColor = true;
            rb_part_modify_outsourced.CheckedChanged += rb_part_modify_outsourced_CheckedChanged;
            // 
            // rb_part_modify_inHouse
            // 
            rb_part_modify_inHouse.AutoSize = true;
            rb_part_modify_inHouse.Checked = true;
            rb_part_modify_inHouse.Location = new Point(155, 14);
            rb_part_modify_inHouse.Name = "rb_part_modify_inHouse";
            rb_part_modify_inHouse.Size = new Size(74, 19);
            rb_part_modify_inHouse.TabIndex = 20;
            rb_part_modify_inHouse.TabStop = true;
            rb_part_modify_inHouse.Text = "In-House";
            rb_part_modify_inHouse.UseVisualStyleBackColor = true;
            rb_part_modify_inHouse.CheckedChanged += rb_part_modify_inHouse_CheckedChanged;
            // 
            // lbl_part_modify_title
            // 
            lbl_part_modify_title.AutoSize = true;
            lbl_part_modify_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_part_modify_title.Location = new Point(16, 11);
            lbl_part_modify_title.Name = "lbl_part_modify_title";
            lbl_part_modify_title.Size = new Size(100, 21);
            lbl_part_modify_title.TabIndex = 19;
            lbl_part_modify_title.Text = "Modify Part";
            // 
            // Modify_Part
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 345);
            Controls.Add(btn_part_modify_cancel);
            Controls.Add(btn_part_modify_save);
            Controls.Add(tb_part_modify_mi_cn);
            Controls.Add(tb_part_modify_min);
            Controls.Add(tb_part_modify_max);
            Controls.Add(tb_part_modify_priceCost);
            Controls.Add(tb_part_modify_inventory);
            Controls.Add(tb_part_modify_name);
            Controls.Add(tb_part_modify_id);
            Controls.Add(lbl_part_modify_mi_cn);
            Controls.Add(lbl_part_modify_max);
            Controls.Add(lbl_part_modify_min);
            Controls.Add(lbl_part_modify_priceCost);
            Controls.Add(lbl_part_modify_inventory);
            Controls.Add(lbl_part_modify_name);
            Controls.Add(lbl_part_modify_id);
            Controls.Add(rb_part_modify_outsourced);
            Controls.Add(rb_part_modify_inHouse);
            Controls.Add(lbl_part_modify_title);
            Name = "Modify_Part";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modify_Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_part_modify_cancel;
        private Button btn_part_modify_save;
        private TextBox tb_part_modify_mi_cn;
        private TextBox tb_part_modify_min;
        private TextBox tb_part_modify_max;
        private TextBox tb_part_modify_priceCost;
        private TextBox tb_part_modify_inventory;
        private TextBox tb_part_modify_name;
        private TextBox tb_part_modify_id;
        private Label lbl_part_modify_mi_cn;
        private Label lbl_part_modify_max;
        private Label lbl_part_modify_min;
        private Label lbl_part_modify_priceCost;
        private Label lbl_part_modify_inventory;
        private Label lbl_part_modify_name;
        private Label lbl_part_modify_id;
        private RadioButton rb_part_modify_outsourced;
        private RadioButton rb_part_modify_inHouse;
        private Label lbl_part_modify_title;
    }
}