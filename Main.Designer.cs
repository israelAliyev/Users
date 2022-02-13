namespace AdminPanel
{
    partial class Formmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formmain));
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.lbl_bday = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.tb_firstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_lastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_bday = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_mail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_insert = new Guna.UI2.WinForms.Guna2Button();
            this.btn_new = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(654, 74);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersWidth = 62;
            this.dgv_data.RowTemplate.Height = 28;
            this.dgv_data.Size = new System.Drawing.Size(784, 328);
            this.dgv_data.TabIndex = 34;
            this.dgv_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellClick);
            // 
            // lbl_bday
            // 
            this.lbl_bday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_bday.BackColor = System.Drawing.Color.LightGray;
            this.lbl_bday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bday.Location = new System.Drawing.Point(140, 350);
            this.lbl_bday.Name = "lbl_bday";
            this.lbl_bday.Size = new System.Drawing.Size(147, 52);
            this.lbl_bday.TabIndex = 29;
            this.lbl_bday.Text = "Birthday";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lastname.BackColor = System.Drawing.Color.LightGray;
            this.lbl_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.Location = new System.Drawing.Point(138, 182);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(165, 42);
            this.lbl_lastname.TabIndex = 28;
            this.lbl_lastname.Text = "Last Name";
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_firstname.BackColor = System.Drawing.Color.LightGray;
            this.lbl_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.Location = new System.Drawing.Point(138, 87);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(185, 47);
            this.lbl_firstname.TabIndex = 27;
            this.lbl_firstname.Text = "First Name";
            // 
            // lbl_mail
            // 
            this.lbl_mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_mail.BackColor = System.Drawing.Color.LightGray;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.Location = new System.Drawing.Point(140, 269);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(100, 45);
            this.lbl_mail.TabIndex = 26;
            this.lbl_mail.Text = "Mail";
            // 
            // tb_firstname
            // 
            this.tb_firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_firstname.Animated = true;
            this.tb_firstname.AutoRoundedCorners = true;
            this.tb_firstname.BackColor = System.Drawing.Color.LightGray;
            this.tb_firstname.BorderColor = System.Drawing.Color.Purple;
            this.tb_firstname.BorderRadius = 29;
            this.tb_firstname.BorderThickness = 2;
            this.tb_firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_firstname.DefaultText = "";
            this.tb_firstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_firstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_firstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_firstname.DisabledState.Parent = this.tb_firstname;
            this.tb_firstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_firstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_firstname.FocusedState.Parent = this.tb_firstname;
            this.tb_firstname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_firstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_firstname.HoverState.Parent = this.tb_firstname;
            this.tb_firstname.IconLeftSize = new System.Drawing.Size(40, 40);
            this.tb_firstname.Location = new System.Drawing.Point(309, 74);
            this.tb_firstname.Margin = new System.Windows.Forms.Padding(4);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.PasswordChar = '\0';
            this.tb_firstname.PlaceholderText = "";
            this.tb_firstname.SelectedText = "";
            this.tb_firstname.ShadowDecoration.Parent = this.tb_firstname;
            this.tb_firstname.Size = new System.Drawing.Size(301, 60);
            this.tb_firstname.TabIndex = 43;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_lastname.Animated = true;
            this.tb_lastname.AutoRoundedCorners = true;
            this.tb_lastname.BackColor = System.Drawing.Color.LightGray;
            this.tb_lastname.BorderColor = System.Drawing.Color.Purple;
            this.tb_lastname.BorderRadius = 29;
            this.tb_lastname.BorderThickness = 2;
            this.tb_lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_lastname.DefaultText = "";
            this.tb_lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_lastname.DisabledState.Parent = this.tb_lastname;
            this.tb_lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_lastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_lastname.FocusedState.Parent = this.tb_lastname;
            this.tb_lastname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_lastname.HoverState.Parent = this.tb_lastname;
            this.tb_lastname.IconLeftSize = new System.Drawing.Size(40, 40);
            this.tb_lastname.Location = new System.Drawing.Point(309, 164);
            this.tb_lastname.Margin = new System.Windows.Forms.Padding(4);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.PasswordChar = '\0';
            this.tb_lastname.PlaceholderText = "";
            this.tb_lastname.SelectedText = "";
            this.tb_lastname.ShadowDecoration.Parent = this.tb_lastname;
            this.tb_lastname.Size = new System.Drawing.Size(301, 60);
            this.tb_lastname.TabIndex = 44;
            // 
            // tb_bday
            // 
            this.tb_bday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bday.Animated = true;
            this.tb_bday.AutoRoundedCorners = true;
            this.tb_bday.BackColor = System.Drawing.Color.LightGray;
            this.tb_bday.BorderColor = System.Drawing.Color.Purple;
            this.tb_bday.BorderRadius = 29;
            this.tb_bday.BorderThickness = 2;
            this.tb_bday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_bday.DefaultText = "";
            this.tb_bday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_bday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_bday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_bday.DisabledState.Parent = this.tb_bday;
            this.tb_bday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_bday.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_bday.FocusedState.Parent = this.tb_bday;
            this.tb_bday.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_bday.HoverState.Parent = this.tb_bday;
            this.tb_bday.IconLeftSize = new System.Drawing.Size(40, 40);
            this.tb_bday.Location = new System.Drawing.Point(309, 342);
            this.tb_bday.Margin = new System.Windows.Forms.Padding(4);
            this.tb_bday.Name = "tb_bday";
            this.tb_bday.PasswordChar = '\0';
            this.tb_bday.PlaceholderText = "";
            this.tb_bday.SelectedText = "";
            this.tb_bday.ShadowDecoration.Parent = this.tb_bday;
            this.tb_bday.Size = new System.Drawing.Size(301, 60);
            this.tb_bday.TabIndex = 45;
            // 
            // tb_mail
            // 
            this.tb_mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_mail.Animated = true;
            this.tb_mail.AutoRoundedCorners = true;
            this.tb_mail.BackColor = System.Drawing.Color.LightGray;
            this.tb_mail.BorderColor = System.Drawing.Color.Purple;
            this.tb_mail.BorderRadius = 29;
            this.tb_mail.BorderThickness = 2;
            this.tb_mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mail.DefaultText = "";
            this.tb_mail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_mail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_mail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_mail.DisabledState.Parent = this.tb_mail;
            this.tb_mail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_mail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_mail.FocusedState.Parent = this.tb_mail;
            this.tb_mail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_mail.HoverState.Parent = this.tb_mail;
            this.tb_mail.IconLeftSize = new System.Drawing.Size(40, 40);
            this.tb_mail.Location = new System.Drawing.Point(309, 254);
            this.tb_mail.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.PasswordChar = '\0';
            this.tb_mail.PlaceholderText = "";
            this.tb_mail.SelectedText = "";
            this.tb_mail.ShadowDecoration.Parent = this.tb_mail;
            this.tb_mail.Size = new System.Drawing.Size(301, 60);
            this.tb_mail.TabIndex = 46;
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_insert.Animated = true;
            this.btn_insert.AutoRoundedCorners = true;
            this.btn_insert.BackColor = System.Drawing.Color.LightGray;
            this.btn_insert.BorderColor = System.Drawing.Color.Purple;
            this.btn_insert.BorderRadius = 27;
            this.btn_insert.CheckedState.Parent = this.btn_insert;
            this.btn_insert.CustomImages.Parent = this.btn_insert;
            this.btn_insert.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_insert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.HoverState.Parent = this.btn_insert;
            this.btn_insert.Image = ((System.Drawing.Image)(resources.GetObject("btn_insert.Image")));
            this.btn_insert.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_insert.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_insert.Location = new System.Drawing.Point(144, 493);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.ShadowDecoration.Parent = this.btn_insert;
            this.btn_insert.Size = new System.Drawing.Size(204, 57);
            this.btn_insert.TabIndex = 47;
            this.btn_insert.Text = "Insert";
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click_1);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_new.Animated = true;
            this.btn_new.AutoRoundedCorners = true;
            this.btn_new.BackColor = System.Drawing.Color.LightGray;
            this.btn_new.BorderColor = System.Drawing.Color.Purple;
            this.btn_new.BorderRadius = 27;
            this.btn_new.CheckedState.Parent = this.btn_new;
            this.btn_new.CustomImages.Parent = this.btn_new;
            this.btn_new.FillColor = System.Drawing.Color.GreenYellow;
            this.btn_new.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.HoverState.Parent = this.btn_new;
            this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
            this.btn_new.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_new.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_new.Location = new System.Drawing.Point(471, 493);
            this.btn_new.Name = "btn_new";
            this.btn_new.ShadowDecoration.Parent = this.btn_new;
            this.btn_new.Size = new System.Drawing.Size(220, 57);
            this.btn_new.TabIndex = 48;
            this.btn_new.Text = "New";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.Animated = true;
            this.btn_update.AutoRoundedCorners = true;
            this.btn_update.BackColor = System.Drawing.Color.LightGray;
            this.btn_update.BorderColor = System.Drawing.Color.Purple;
            this.btn_update.BorderRadius = 27;
            this.btn_update.CheckedState.Parent = this.btn_update;
            this.btn_update.CustomImages.Parent = this.btn_update;
            this.btn_update.FillColor = System.Drawing.Color.MediumOrchid;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.HoverState.Parent = this.btn_update;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_update.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_update.Location = new System.Drawing.Point(791, 493);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShadowDecoration.Parent = this.btn_update;
            this.btn_update.Size = new System.Drawing.Size(220, 57);
            this.btn_update.TabIndex = 49;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Animated = true;
            this.btn_delete.AutoRoundedCorners = true;
            this.btn_delete.BackColor = System.Drawing.Color.LightGray;
            this.btn_delete.BorderColor = System.Drawing.Color.Purple;
            this.btn_delete.BorderRadius = 27;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.FillColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_delete.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_delete.Location = new System.Drawing.Point(1154, 493);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(220, 57);
            this.btn_delete.TabIndex = 50;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // Formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1518, 611);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_bday);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.lbl_bday);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_firstname);
            this.Controls.Add(this.lbl_mail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Formmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Label lbl_bday;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_mail;
        private Guna.UI2.WinForms.Guna2TextBox tb_firstname;
        private Guna.UI2.WinForms.Guna2TextBox tb_lastname;
        private Guna.UI2.WinForms.Guna2TextBox tb_bday;
        private Guna.UI2.WinForms.Guna2TextBox tb_mail;
        private Guna.UI2.WinForms.Guna2Button btn_insert;
        private Guna.UI2.WinForms.Guna2Button btn_new;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
    }
}