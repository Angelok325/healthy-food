namespace Здоровое_питание_2_оригинал
{
    partial class login
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
            panel1 = new Panel();
            closebutton = new Label();
            label1 = new Label();
            loginfield = new TextBox();
            passfield = new TextBox();
            buttonlogin = new Button();
            registrlabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(closebutton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 52);
            panel1.TabIndex = 0;
            // 
            // closebutton
            // 
            closebutton.AutoSize = true;
            closebutton.Cursor = Cursors.Hand;
            closebutton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closebutton.ForeColor = Color.Wheat;
            closebutton.Location = new Point(618, 0);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(40, 45);
            closebutton.TabIndex = 0;
            closebutton.Text = "X";
            closebutton.Click += closebutton_Click;
            closebutton.MouseEnter += closebutton_MouseEnter;
            closebutton.MouseLeave += closebutton_MouseLeave;
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 30F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(65, 146);
            label1.Name = "label1";
            label1.Size = new Size(548, 113);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // loginfield
            // 
            loginfield.Font = new Font("Times New Roman", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginfield.Location = new Point(99, 323);
            loginfield.Multiline = true;
            loginfield.Name = "loginfield";
            loginfield.Size = new Size(472, 78);
            loginfield.TabIndex = 1;
            // 
            // passfield
            // 
            passfield.Font = new Font("Times New Roman", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passfield.Location = new Point(99, 468);
            passfield.Name = "passfield";
            passfield.Size = new Size(472, 87);
            passfield.TabIndex = 2;
            passfield.UseSystemPasswordChar = true;
            // 
            // buttonlogin
            // 
            buttonlogin.FlatAppearance.BorderSize = 0;
            buttonlogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            buttonlogin.FlatStyle = FlatStyle.Flat;
            buttonlogin.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonlogin.ForeColor = Color.Tan;
            buttonlogin.Location = new Point(215, 653);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(245, 66);
            buttonlogin.TabIndex = 3;
            buttonlogin.Text = "Войти";
            buttonlogin.UseVisualStyleBackColor = true;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // registrlabel
            // 
            registrlabel.AutoSize = true;
            registrlabel.Location = new Point(242, 722);
            registrlabel.Name = "registrlabel";
            registrlabel.Size = new Size(207, 32);
            registrlabel.TabIndex = 4;
            registrlabel.Text = "еще нет аккаунта";
            registrlabel.Click += registrlabel_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 1014);
            Controls.Add(registrlabel);
            Controls.Add(buttonlogin);
            Controls.Add(passfield);
            Controls.Add(loginfield);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "login";
            MouseDown += login_MouseDown;
            MouseMove += login_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label closebutton;
        private TextBox loginfield;
        private TextBox passfield;
        private Button buttonlogin;
        private Label registrlabel;
    }
}