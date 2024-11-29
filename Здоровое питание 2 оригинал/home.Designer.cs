namespace Здоровое_питание_2_оригинал
{
    partial class home
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "овсяноблин" }, -1, Color.Empty, SystemColors.Menu, new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "творог с бананом" }, -1, Color.Empty, SystemColors.Menu, null);
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            избранноеToolStripMenuItem = new ToolStripMenuItem();
            гланыйЭкранToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PapayaWhip;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(632, 42);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, избранноеToolStripMenuItem, гланыйЭкранToolStripMenuItem });
            менюToolStripMenuItem.ForeColor = Color.DarkGoldenrod;
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(103, 38);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(332, 44);
            toolStripMenuItem1.Text = "Личный кабинет";
            // 
            // избранноеToolStripMenuItem
            // 
            избранноеToolStripMenuItem.Name = "избранноеToolStripMenuItem";
            избранноеToolStripMenuItem.Size = new Size(332, 44);
            избранноеToolStripMenuItem.Text = "Избранное";
            // 
            // гланыйЭкранToolStripMenuItem
            // 
            гланыйЭкранToolStripMenuItem.Name = "гланыйЭкранToolStripMenuItem";
            гланыйЭкранToolStripMenuItem.Size = new Size(332, 44);
            гланыйЭкранToolStripMenuItem.Text = "Гланый экран";
            // 
            // listView1
            // 
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem2.Checked = true;
            listViewItem2.IndentCount = 1;
            listViewItem2.StateImageIndex = 2;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(12, 197);
            listView1.Name = "listView1";
            listView1.Size = new Size(506, 349);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 943);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "home";
            Text = "home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem избранноеToolStripMenuItem;
        private ToolStripMenuItem гланыйЭкранToolStripMenuItem;
        private ListView listView1;
    }
}