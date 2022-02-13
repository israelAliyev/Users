namespace AdminPanel
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.chb_passwordsignup = new System.Windows.Forms.CheckBox();
            this.btn_signuplogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clearsignup = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_passwordsignup = new System.Windows.Forms.Label();
            this.lbl_usernamesignup = new System.Windows.Forms.Label();
            this.lbl_error2 = new System.Windows.Forms.Label();
            this.lbl_signup = new System.Windows.Forms.Label();
            this.btn_signup = new Guna.UI2.WinForms.Guna2Button();
            this.tb_passwordsignup = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_usernamesignup = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_confirmpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // chb_passwordsignup
            // 
            this.chb_passwordsignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chb_passwordsignup.AutoSize = true;
            this.chb_passwordsignup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chb_passwordsignup.Location = new System.Drawing.Point(551, 349);
            this.chb_passwordsignup.Name = "chb_passwordsignup";
            this.chb_passwordsignup.Size = new System.Drawing.Size(147, 24);
            this.chb_passwordsignup.TabIndex = 24;
            this.chb_passwordsignup.Text = "Show password";
            this.chb_passwordsignup.UseVisualStyleBackColor = true;
            // 
            // btn_signuplogin
            // 
            this.btn_signuplogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_signuplogin.BackColor = System.Drawing.SystemColors.Control;
            this.btn_signuplogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signuplogin.ForeColor = System.Drawing.Color.Purple;
            this.btn_signuplogin.Location = new System.Drawing.Point(447, 600);
            this.btn_signuplogin.Name = "btn_signuplogin";
            this.btn_signuplogin.Size = new System.Drawing.Size(138, 49);
            this.btn_signuplogin.TabIndex = 23;
            this.btn_signuplogin.Text = "Login";
            this.btn_signuplogin.UseVisualStyleBackColor = false;
            this.btn_signuplogin.Click += new System.EventHandler(this.btn_signuplogin_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(395, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Already you have an Account?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_clearsignup
            // 
            this.btn_clearsignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clearsignup.Animated = true;
            this.btn_clearsignup.AutoRoundedCorners = true;
            this.btn_clearsignup.BackColor = System.Drawing.SystemColors.Control;
            this.btn_clearsignup.BorderColor = System.Drawing.Color.Purple;
            this.btn_clearsignup.BorderRadius = 27;
            this.btn_clearsignup.CheckedState.Parent = this.btn_clearsignup;
            this.btn_clearsignup.CustomImages.Parent = this.btn_clearsignup;
            this.btn_clearsignup.FillColor = System.Drawing.Color.Plum;
            this.btn_clearsignup.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearsignup.ForeColor = System.Drawing.Color.Purple;
            this.btn_clearsignup.HoverState.Parent = this.btn_clearsignup;
            this.btn_clearsignup.Location = new System.Drawing.Point(343, 490);
            this.btn_clearsignup.Name = "btn_clearsignup";
            this.btn_clearsignup.ShadowDecoration.Parent = this.btn_clearsignup;
            this.btn_clearsignup.Size = new System.Drawing.Size(355, 57);
            this.btn_clearsignup.TabIndex = 21;
            this.btn_clearsignup.Text = "Clear";
            // 
            // lbl_passwordsignup
            // 
            this.lbl_passwordsignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_passwordsignup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_passwordsignup.Location = new System.Drawing.Point(339, 153);
            this.lbl_passwordsignup.Name = "lbl_passwordsignup";
            this.lbl_passwordsignup.Size = new System.Drawing.Size(117, 26);
            this.lbl_passwordsignup.TabIndex = 20;
            this.lbl_passwordsignup.Text = "Password";
            this.lbl_passwordsignup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_usernamesignup
            // 
            this.lbl_usernamesignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_usernamesignup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_usernamesignup.Location = new System.Drawing.Point(339, 53);
            this.lbl_usernamesignup.Name = "lbl_usernamesignup";
            this.lbl_usernamesignup.Size = new System.Drawing.Size(117, 26);
            this.lbl_usernamesignup.TabIndex = 19;
            this.lbl_usernamesignup.Text = "Username";
            this.lbl_usernamesignup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_error2
            // 
            this.lbl_error2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_error2.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error2.ForeColor = System.Drawing.Color.Red;
            this.lbl_error2.Location = new System.Drawing.Point(373, 376);
            this.lbl_error2.Name = "lbl_error2";
            this.lbl_error2.Size = new System.Drawing.Size(287, 28);
            this.lbl_error2.TabIndex = 18;
            this.lbl_error2.Text = "*Username or password is incorrect";
            this.lbl_error2.Visible = false;
            // 
            // lbl_signup
            // 
            this.lbl_signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_signup.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signup.ForeColor = System.Drawing.Color.Purple;
            this.lbl_signup.Location = new System.Drawing.Point(440, -2);
            this.lbl_signup.Name = "lbl_signup";
            this.lbl_signup.Size = new System.Drawing.Size(145, 44);
            this.lbl_signup.TabIndex = 17;
            this.lbl_signup.Text = "Sign Up";
            this.lbl_signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_signup
            // 
            this.btn_signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_signup.Animated = true;
            this.btn_signup.AutoRoundedCorners = true;
            this.btn_signup.BackColor = System.Drawing.SystemColors.Control;
            this.btn_signup.BorderColor = System.Drawing.Color.Purple;
            this.btn_signup.BorderRadius = 27;
            this.btn_signup.CheckedState.Parent = this.btn_signup;
            this.btn_signup.CustomImages.Parent = this.btn_signup;
            this.btn_signup.FillColor = System.Drawing.Color.Purple;
            this.btn_signup.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.White;
            this.btn_signup.HoverState.Parent = this.btn_signup;
            this.btn_signup.Location = new System.Drawing.Point(343, 410);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.ShadowDecoration.Parent = this.btn_signup;
            this.btn_signup.Size = new System.Drawing.Size(355, 57);
            this.btn_signup.TabIndex = 16;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // tb_passwordsignup
            // 
            this.tb_passwordsignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_passwordsignup.Animated = true;
            this.tb_passwordsignup.AutoRoundedCorners = true;
            this.tb_passwordsignup.BorderColor = System.Drawing.Color.Purple;
            this.tb_passwordsignup.BorderRadius = 27;
            this.tb_passwordsignup.BorderThickness = 2;
            this.tb_passwordsignup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_passwordsignup.DefaultText = "";
            this.tb_passwordsignup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_passwordsignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_passwordsignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_passwordsignup.DisabledState.Parent = this.tb_passwordsignup;
            this.tb_passwordsignup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_passwordsignup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_passwordsignup.FocusedState.Parent = this.tb_passwordsignup;
            this.tb_passwordsignup.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordsignup.ForeColor = System.Drawing.Color.Black;
            this.tb_passwordsignup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_passwordsignup.HoverState.Parent = this.tb_passwordsignup;
            this.tb_passwordsignup.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_passwordsignup.IconLeft")));
            this.tb_passwordsignup.IconLeftSize = new System.Drawing.Size(40, 40);
            this.tb_passwordsignup.Location = new System.Drawing.Point(343, 183);
            this.tb_passwordsignup.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_passwordsignup.Name = "tb_passwordsignup";
            this.tb_passwordsignup.PasswordChar = '*';
            this.tb_passwordsignup.PlaceholderText = "";
            this.tb_passwordsignup.SelectedText = "";
            this.tb_passwordsignup.ShadowDecoration.Parent = this.tb_passwordsignup;
            this.tb_passwordsignup.Size = new System.Drawing.Size(355, 57);
            this.tb_passwordsignup.TabIndex = 15;
            this.tb_passwordsignup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_usernamesignup
            // 
            this.tb_usernamesignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_usernamesignup.Animated = true;
            this.tb_usernamesignup.AutoRoundedCorners = true;
            this.tb_usernamesignup.BorderColor = System.Drawing.Color.Purple;
            this.tb_usernamesignup.BorderRadius = 27;
            this.tb_usernamesignup.BorderThickness = 2;
            this.tb_usernamesignup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_usernamesignup.DefaultText = "";
            this.tb_usernamesignup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_usernamesignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_usernamesignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_usernamesignup.DisabledState.Parent = this.tb_usernamesignup;
            this.tb_usernamesignup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_usernamesignup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_usernamesignup.FocusedState.Parent = this.tb_usernamesignup;
            this.tb_usernamesignup.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usernamesignup.ForeColor = System.Drawing.Color.Black;
            this.tb_usernamesignup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_usernamesignup.HoverState.Parent = this.tb_usernamesignup;
            this.tb_usernamesignup.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_usernamesignup.IconLeft")));
            this.tb_usernamesignup.IconLeftSize = new System.Drawing.Size(30, 30);
            this.tb_usernamesignup.Location = new System.Drawing.Point(343, 92);
            this.tb_usernamesignup.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_usernamesignup.Name = "tb_usernamesignup";
            this.tb_usernamesignup.PasswordChar = '\0';
            this.tb_usernamesignup.PlaceholderText = "";
            this.tb_usernamesignup.SelectedText = "";
            this.tb_usernamesignup.ShadowDecoration.Parent = this.tb_usernamesignup;
            this.tb_usernamesignup.Size = new System.Drawing.Size(355, 57);
            this.tb_usernamesignup.TabIndex = 14;
            this.tb_usernamesignup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(339, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Confirm Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_confirmpassword
            // 
            this.tb_confirmpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_confirmpassword.Animated = true;
            this.tb_confirmpassword.AutoRoundedCorners = true;
            this.tb_confirmpassword.BorderColor = System.Drawing.Color.Purple;
            this.tb_confirmpassword.BorderRadius = 27;
            this.tb_confirmpassword.BorderThickness = 2;
            this.tb_confirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_confirmpassword.DefaultText = "";
            this.tb_confirmpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_confirmpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_confirmpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_confirmpassword.DisabledState.Parent = this.tb_confirmpassword;
            this.tb_confirmpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_confirmpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_confirmpassword.FocusedState.Parent = this.tb_confirmpassword;
            this.tb_confirmpassword.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirmpassword.ForeColor = System.Drawing.Color.Black;
            this.tb_confirmpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_confirmpassword.HoverState.Parent = this.tb_confirmpassword;
            this.tb_confirmpassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_confirmpassword.IconLeft")));
            this.tb_confirmpassword.IconLeftSize = new System.Drawing.Size(40, 40);
            this.tb_confirmpassword.Location = new System.Drawing.Point(343, 285);
            this.tb_confirmpassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_confirmpassword.Name = "tb_confirmpassword";
            this.tb_confirmpassword.PasswordChar = '*';
            this.tb_confirmpassword.PlaceholderText = "";
            this.tb_confirmpassword.SelectedText = "";
            this.tb_confirmpassword.ShadowDecoration.Parent = this.tb_confirmpassword;
            this.tb_confirmpassword.Size = new System.Drawing.Size(355, 57);
            this.tb_confirmpassword.TabIndex = 25;
            this.tb_confirmpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_confirmpassword);
            this.Controls.Add(this.chb_passwordsignup);
            this.Controls.Add(this.btn_signuplogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_clearsignup);
            this.Controls.Add(this.lbl_passwordsignup);
            this.Controls.Add(this.lbl_usernamesignup);
            this.Controls.Add(this.lbl_error2);
            this.Controls.Add(this.lbl_signup);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.tb_passwordsignup);
            this.Controls.Add(this.tb_usernamesignup);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_passwordsignup;
        private System.Windows.Forms.Button btn_signuplogin;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_clearsignup;
        private System.Windows.Forms.Label lbl_passwordsignup;
        private System.Windows.Forms.Label lbl_usernamesignup;
        private System.Windows.Forms.Label lbl_error2;
        private System.Windows.Forms.Label lbl_signup;
        private Guna.UI2.WinForms.Guna2Button btn_signup;
        private Guna.UI2.WinForms.Guna2TextBox tb_passwordsignup;
        private Guna.UI2.WinForms.Guna2TextBox tb_usernamesignup;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tb_confirmpassword;
    }
}