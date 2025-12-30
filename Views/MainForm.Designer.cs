namespace AppHondaDuyDuc.Views
{
    partial class MainForm
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            gbMenu = new GroupBox();
            button1 = new Button();
            panel1 = new Panel();
            gbMenu.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(button1);
            gbMenu.Location = new Point(12, 6);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(133, 432);
            gbMenu.TabIndex = 2;
            gbMenu.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(6, 15);
            button1.Name = "button1";
            button1.Size = new Size(121, 37);
            button1.TabIndex = 3;
            button1.Text = "Quản lý khách hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(151, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 432);
            panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(gbMenu);
            Name = "MainForm";
            Text = "MainForm";
            gbMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private GroupBox gbMenu;
        private Button button1;
        private Panel panel1;
    }
}