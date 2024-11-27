namespace project.win
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            btnCircleArea = new Button();
            txtRadius = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            btnTriangleArea = new Button();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            btnHexagonArea = new Button();
            txtHexagonWidth = new TextBox();
            button1 = new Button();
            lblResult = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Coral;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Location = new Point(40, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวนพื้นที่วงกลม";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 60);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "รัศมี";
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(419, 66);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(170, 29);
            btnCircleArea.TabIndex = 1;
            btnCircleArea.Text = "คำนวนพื้นที่วงกลม";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(139, 61);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(200, 27);
            txtRadius.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 128, 0);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnTriangleArea);
            groupBox2.Controls.Add(txtWidth);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Location = new Point(40, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(595, 160);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวนพื้นที่สามเหลียม";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 119);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 6;
            label5.Text = "ตามมาตรฐาน";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 58);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 5;
            label4.Text = "ความสุง";
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Location = new Point(419, 80);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(170, 29);
            btnTriangleArea.TabIndex = 4;
            btnTriangleArea.Text = "คำนวนพื้นที่สามเหลี่ยม";
            btnTriangleArea.UseVisualStyleBackColor = true;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(139, 112);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(200, 27);
            txtWidth.TabIndex = 1;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(139, 58);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(200, 27);
            txtHeight.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.OrangeRed;
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(btnHexagonArea);
            groupBox3.Controls.Add(txtHexagonWidth);
            groupBox3.Location = new Point(40, 455);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(595, 125);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวนพื้นที่หกเหลี่ยม";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 63);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 7;
            label6.Text = "ความสุงตามมาตรฐาน";
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Location = new Point(419, 58);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(152, 29);
            btnHexagonArea.TabIndex = 4;
            btnHexagonArea.Text = "คำนวนพื้นที่หกเหลี่ยม";
            btnHexagonArea.UseVisualStyleBackColor = true;
            btnHexagonArea.Click += btnHexagonArea_Click;
            // 
            // txtHexagonWidth
            // 
            txtHexagonWidth.Location = new Point(139, 60);
            txtHexagonWidth.Name = "txtHexagonWidth";
            txtHexagonWidth.Size = new Size(200, 27);
            txtHexagonWidth.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Location = new Point(285, 610);
            button1.Name = "button1";
            button1.Size = new Size(350, 29);
            button1.TabIndex = 3;
            button1.Text = "IF YOU WANT TO CLOSE PLESE CLICK HERE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Salmon;
            lblResult.Font = new Font("Leelawadee UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(663, 265);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(197, 315);
            lblResult.TabIndex = 4;
            lblResult.Text = ".......";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(707, 235);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 5;
            label2.Text = "พื้นที่ตารางคำนวน";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(872, 651);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "โปรเเกรมคำนวนพื้นที่";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private Button btnCircleArea;
        private TextBox txtRadius;
        private Button btnTriangleArea;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private Button btnHexagonArea;
        private TextBox txtHexagonWidth;
        private Label lblResult;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label2;
    }
}
