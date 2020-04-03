namespace HomeWork7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.perright = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.perleft = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.angleright = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.angleleft = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.colorpen = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.depth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(553, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 37);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "递归深度:";
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(96, 8);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(100, 25);
            this.depth.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.length);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(553, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 33);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "主干长度:";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(96, 3);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(100, 25);
            this.length.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.perright);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(531, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 34);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "右分支长度比:";
            // 
            // perright
            // 
            this.perright.Location = new System.Drawing.Point(118, 3);
            this.perright.Name = "perright";
            this.perright.Size = new System.Drawing.Size(100, 25);
            this.perright.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.perleft);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(531, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 35);
            this.panel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "左分支长度比:";
            // 
            // perleft
            // 
            this.perleft.Location = new System.Drawing.Point(118, 4);
            this.perleft.Name = "perleft";
            this.perleft.Size = new System.Drawing.Size(100, 25);
            this.perleft.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.angleright);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(531, 261);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 34);
            this.panel5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "右分支角度:";
            // 
            // angleright
            // 
            this.angleright.Location = new System.Drawing.Point(118, 4);
            this.angleright.Name = "angleright";
            this.angleright.Size = new System.Drawing.Size(100, 25);
            this.angleright.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.angleleft);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(531, 312);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(222, 33);
            this.panel6.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "左分支角度:";
            // 
            // angleleft
            // 
            this.angleleft.Location = new System.Drawing.Point(118, 4);
            this.angleleft.Name = "angleleft";
            this.angleleft.Size = new System.Drawing.Size(100, 25);
            this.angleleft.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.colorpen);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(531, 367);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(222, 32);
            this.panel7.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "画笔颜色:";
            // 
            // colorpen
            // 
            this.colorpen.Location = new System.Drawing.Point(118, 4);
            this.colorpen.Name = "colorpen";
            this.colorpen.Size = new System.Drawing.Size(100, 25);
            this.colorpen.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox perright;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox perleft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox angleright;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox angleleft;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox colorpen;
        private System.Windows.Forms.Button button2;
    }
}

