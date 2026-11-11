namespace toli_bichig
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Англи = new DataGridViewTextBoxColumn();
            Монгол = new DataGridViewTextBoxColumn();
            Орос = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Хайх:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGreen;
            textBox1.ForeColor = Color.ForestGreen;
            textBox1.Location = new Point(559, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "Санасан үгс";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 359);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(559, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 27);
            textBox3.TabIndex = 5;
            textBox3.Text = "Хоосон";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(63, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(527, 27);
            textBox4.TabIndex = 7;
            textBox4.Text = "Хайх үг...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 9);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 8;
            label2.Text = "Хэл:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(359, 359);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(180, 27);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(623, 362);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(165, 27);
            textBox6.TabIndex = 10;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 362);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 11;
            label3.Text = "Англи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 362);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 12;
            label4.Text = "Монгол";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(559, 362);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 13;
            label5.Text = "Орос";
            label5.Click += label5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Англи, Монгол, Орос });
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(541, 258);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(649, 6);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(112, 27);
            textBox7.TabIndex = 15;
            textBox7.Text = "Бүгд";
            // 
            // button1
            // 
            button1.Location = new Point(12, 392);
            button1.Name = "button1";
            button1.Size = new Size(96, 36);
            button1.TabIndex = 16;
            button1.Text = "Нэмэх";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(445, 392);
            button2.Name = "button2";
            button2.Size = new Size(94, 37);
            button2.TabIndex = 17;
            button2.Text = "Санах";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(344, 393);
            button3.Name = "button3";
            button3.Size = new Size(94, 36);
            button3.TabIndex = 18;
            button3.Text = "Цэвэрлэх";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(228, 393);
            button4.Name = "button4";
            button4.Size = new Size(110, 36);
            button4.TabIndex = 19;
            button4.Text = "Устгах";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(114, 393);
            button5.Name = "button5";
            button5.Size = new Size(108, 36);
            button5.TabIndex = 20;
            button5.Text = "Засах";
            button5.UseVisualStyleBackColor = true;
            // 
            // Англи
            // 
            Англи.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Англи.DataPropertyName = "one";
            Англи.HeaderText = "Англи";
            Англи.MinimumWidth = 6;
            Англи.Name = "Англи";
            Англи.ToolTipText = "one";
            // 
            // Монгол
            // 
            Монгол.HeaderText = "Монгол";
            Монгол.MinimumWidth = 6;
            Монгол.Name = "Монгол";
            Монгол.Width = 125;
            // 
            // Орос
            // 
            Орос.HeaderText = "Орос";
            Орос.MinimumWidth = 6;
            Орос.Name = "Орос";
            Орос.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn Англи;
        private DataGridViewTextBoxColumn Монгол;
        private DataGridViewTextBoxColumn Орос;
    }
}