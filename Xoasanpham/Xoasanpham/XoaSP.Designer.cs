namespace Xoasanpham
{
    partial class XoaSP
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
            label2 = new Label();
            panel1 = new Panel();
            masp = new TextBox();
            delete = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 113);
            label2.Name = "label2";
            label2.Size = new Size(773, 37);
            label2.TabIndex = 3;
            label2.Text = "Nhập Mã BoardGame cần xóa (Mã BoardGame là mã sản phẩm)";
            // 
            // panel1
            // 
            panel1.Controls.Add(masp);
            panel1.Controls.Add(delete);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(222, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 731);
            panel1.TabIndex = 2;
            // 
            // masp
            // 
            masp.Location = new Point(357, 243);
            masp.Name = "masp";
            masp.Size = new Size(534, 43);
            masp.TabIndex = 3;
            // 
            // delete
            // 
            delete.Location = new Point(689, 485);
            delete.Name = "delete";
            delete.Size = new Size(324, 135);
            delete.TabIndex = 2;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 243);
            label1.Name = "label1";
            label1.Size = new Size(202, 37);
            label1.TabIndex = 0;
            label1.Text = "Mã BoardGame";
            // 
            // XoaSP
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 997);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "XoaSP";
            Text = "XoaSP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private TextBox masp;
        private Button delete;
        private Label label1;
    }
}