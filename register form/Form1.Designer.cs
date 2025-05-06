namespace register_form
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            panelcontext = new Panel();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            startTimeToolStripMenuItem = new ToolStripMenuItem();
            stopTimeToolStripMenuItem = new ToolStripMenuItem();
            panelcontext1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelcontext.SuspendLayout();
            menuStrip1.SuspendLayout();
            panelcontext1.SuspendLayout();
            SuspendLayout();
            // 
            // panelcontext
            // 
            panelcontext.BackColor = Color.RosyBrown;
            panelcontext.Controls.Add(label2);
            panelcontext.Controls.Add(label1);
            panelcontext.Controls.Add(menuStrip1);
            panelcontext.Location = new Point(0, -3);
            panelcontext.Name = "panelcontext";
            panelcontext.Size = new Size(1402, 113);
            panelcontext.TabIndex = 0;
            panelcontext.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1045, 45);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 0;
            label2.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1281, -44);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1402, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startTimeToolStripMenuItem, stopTimeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // startTimeToolStripMenuItem
            // 
            startTimeToolStripMenuItem.Name = "startTimeToolStripMenuItem";
            startTimeToolStripMenuItem.Size = new Size(160, 26);
            startTimeToolStripMenuItem.Text = "Start Time";
            startTimeToolStripMenuItem.Click += startTimeToolStripMenuItem_Click;
            // 
            // stopTimeToolStripMenuItem
            // 
            stopTimeToolStripMenuItem.Name = "stopTimeToolStripMenuItem";
            stopTimeToolStripMenuItem.Size = new Size(160, 26);
            stopTimeToolStripMenuItem.Text = "Stop Time";
            stopTimeToolStripMenuItem.Click += stopTimeToolStripMenuItem_Click;
            // 
            // panelcontext1
            // 
            panelcontext1.BackColor = Color.Silver;
            panelcontext1.Controls.Add(button3);
            panelcontext1.Controls.Add(button2);
            panelcontext1.Controls.Add(button1);
            panelcontext1.Location = new Point(3, 106);
            panelcontext1.Name = "panelcontext1";
            panelcontext1.Size = new Size(160, 479);
            panelcontext1.TabIndex = 1;
            panelcontext1.Paint += panel3_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(22, 185);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Calculator";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(22, 103);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 27);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(158, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 488);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1256, 569);
            Controls.Add(panel1);
            Controls.Add(panelcontext1);
            Controls.Add(panelcontext);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelcontext.ResumeLayout(false);
            panelcontext.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelcontext1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelcontext;
        private Panel panelcontext1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem startTimeToolStripMenuItem;
        private ToolStripMenuItem stopTimeToolStripMenuItem;
    }
}