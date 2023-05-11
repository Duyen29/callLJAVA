namespace callLJAVA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox33 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(212, 139);
            button1.Name = "button1";
            button1.Size = new Size(148, 113);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox33
            // 
            textBox33.Location = new Point(222, 290);
            textBox33.Multiline = true;
            textBox33.Name = "textBox33";
            textBox33.Size = new Size(116, 103);
            textBox33.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(223, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(137, 23);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 30);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "nhap a";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 95);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "nhap b";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 303);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "ket qua";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox33);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox33;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}