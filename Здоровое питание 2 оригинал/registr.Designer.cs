namespace Здоровое_питание_2_оригинал
{
    partial class registr
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
            userSurnamefield = new TextBox();
            loginfield = new TextBox();
            userNameField = new TextBox();
            passfield = new TextBox();
            label1 = new Label();
            buttonregester = new Button();
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
            panel1.Size = new Size(632, 52);
            panel1.TabIndex = 1;
            // 
            // closebutton
            // 
            closebutton.AutoSize = true;
            closebutton.Cursor = Cursors.Hand;
            closebutton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closebutton.ForeColor = Color.Wheat;
            closebutton.Location = new Point(592, 0);
            closebutton.Name = "closebutton";
            closebutton.Size = new Size(40, 45);
            closebutton.TabIndex = 0;
            closebutton.Text = "X";
            closebutton.Click += closebutton_Click;
            // 
            // userSurnamefield
            // 
            userSurnamefield.Font = new Font("Times New Roman", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userSurnamefield.Location = new Point(80, 432);
            userSurnamefield.Multiline = true;
            userSurnamefield.Name = "userSurnamefield";
            userSurnamefield.Size = new Size(472, 78);
            userSurnamefield.TabIndex = 2;
            userSurnamefield.Enter += userSurnamefield_Enter;
            userSurnamefield.Leave += userSurnamefield_Leave;
            // 
            // loginfield
            // 
            loginfield.Font = new Font("Times New Roman", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginfield.Location = new Point(80, 564);
            loginfield.Multiline = true;
            loginfield.Name = "loginfield";
            loginfield.Size = new Size(472, 78);
            loginfield.TabIndex = 3;
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Times New Roman", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameField.Location = new Point(80, 315);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(472, 78);
            userNameField.TabIndex = 4;
            // 
            // passfield
            // 
            passfield.Font = new Font("Times New Roman", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passfield.Location = new Point(80, 688);
            passfield.Multiline = true;
            passfield.Name = "passfield";
            passfield.Size = new Size(472, 78);
            passfield.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 30F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(43, 78);
            label1.Name = "label1";
            label1.Size = new Size(548, 113);
            label1.TabIndex = 6;
            label1.Text = "Регистрация";
            // 
            // buttonregester
            // 
            buttonregester.FlatAppearance.BorderSize = 0;
            buttonregester.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            buttonregester.FlatStyle = FlatStyle.Flat;
            buttonregester.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonregester.ForeColor = Color.Tan;
            buttonregester.Location = new Point(103, 806);
            buttonregester.Name = "buttonregester";
            buttonregester.Size = new Size(422, 66);
            buttonregester.TabIndex = 7;
            buttonregester.Text = "Зарегестрироваться";
            buttonregester.UseVisualStyleBackColor = true;
            buttonregester.Click += buttonregester_Click;
            // 
            // registr
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 943);
            Controls.Add(buttonregester);
            Controls.Add(label1);
            Controls.Add(passfield);
            Controls.Add(userNameField);
            Controls.Add(loginfield);
            Controls.Add(userSurnamefield);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registr";
            Text = "registr";
            MouseDown += registr_MouseDown;
            MouseMove += registr_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label closebutton;
        private TextBox userSurnamefield;
        private TextBox loginfield;
        private TextBox userNameField;
        private TextBox passfield;
        private Label label1;
        private Button buttonregester;
    }
}