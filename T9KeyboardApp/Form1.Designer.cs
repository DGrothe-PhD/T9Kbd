namespace T9KeyboardApp
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            timerKeysWait = new System.Windows.Forms.Timer(components);
            buttonModeSwitch = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(463, 16);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.MaximumSize = new Size(1300, 624);
            textBox1.MinimumSize = new Size(10, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(758, 583);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += Form1_KeyPress;
            textBox1.KeyUp += Form1_KeyUp;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(-1, 125);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(117, 111);
            button1.TabIndex = 1;
            button1.Text = "1\r\no_o";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(124, 125);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(117, 111);
            button2.TabIndex = 2;
            button2.Text = "2\r\nABC";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonClick;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(249, 125);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(117, 111);
            button3.TabIndex = 3;
            button3.Text = "3\r\nDEF";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonClick;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(-1, 245);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(117, 111);
            button4.TabIndex = 4;
            button4.Text = "4\r\nGHI";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ButtonClick;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(124, 245);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(117, 111);
            button5.TabIndex = 5;
            button5.Text = "5\r\nJKL";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ButtonClick;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(249, 245);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(117, 111);
            button6.TabIndex = 6;
            button6.Text = "6\r\nMNO";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ButtonClick;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(-1, 365);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(117, 111);
            button7.TabIndex = 7;
            button7.Text = "7\r\nPQRS";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ButtonClick;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(124, 365);
            button8.Margin = new Padding(4, 5, 4, 5);
            button8.Name = "button8";
            button8.Size = new Size(117, 111);
            button8.TabIndex = 8;
            button8.Text = "8\r\nTUV";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ButtonClick;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(249, 365);
            button9.Margin = new Padding(4, 5, 4, 5);
            button9.Name = "button9";
            button9.Size = new Size(117, 111);
            button9.TabIndex = 9;
            button9.Text = "9\r\nWXYZ";
            button9.UseVisualStyleBackColor = true;
            button9.Click += ButtonClick;
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(124, 489);
            button10.Margin = new Padding(4, 5, 4, 5);
            button10.Name = "button10";
            button10.Size = new Size(117, 111);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ButtonClick;
            // 
            // timerKeysWait
            // 
            timerKeysWait.Interval = 150;
            timerKeysWait.Tick += TimerKeysWait_Tick;
            // 
            // buttonModeSwitch
            // 
            buttonModeSwitch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModeSwitch.Location = new Point(249, 489);
            buttonModeSwitch.Margin = new Padding(4, 5, 4, 5);
            buttonModeSwitch.Name = "buttonModeSwitch";
            buttonModeSwitch.Size = new Size(117, 111);
            buttonModeSwitch.TabIndex = 11;
            buttonModeSwitch.Text = "#\r\nAa123";
            buttonModeSwitch.UseVisualStyleBackColor = true;
            buttonModeSwitch.Click += buttonModeSwitch_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(374, 365);
            button12.Margin = new Padding(4, 5, 4, 5);
            button12.Name = "button12";
            button12.Size = new Size(69, 111);
            button12.TabIndex = 12;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = true;
            button12.Click += ButtonClick;
            // 
            // button13
            // 
            button13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(374, 245);
            button13.Margin = new Padding(4, 5, 4, 5);
            button13.Name = "button13";
            button13.Size = new Size(69, 111);
            button13.TabIndex = 13;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += ButtonClick;
            // 
            // button14
            // 
            button14.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(-1, 489);
            button14.Margin = new Padding(4, 5, 4, 5);
            button14.Name = "button14";
            button14.Size = new Size(117, 110);
            button14.TabIndex = 14;
            button14.Text = "*";
            button14.UseVisualStyleBackColor = true;
            button14.Click += ButtonClick;
            // 
            // button15
            // 
            button15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(374, 125);
            button15.Margin = new Padding(4, 5, 4, 5);
            button15.Name = "button15";
            button15.Size = new Size(69, 110);
            button15.TabIndex = 15;
            button15.Text = "/";
            button15.UseVisualStyleBackColor = true;
            button15.Click += ButtonClick;
            // 
            // button16
            // 
            button16.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(374, 490);
            button16.Margin = new Padding(4, 5, 4, 5);
            button16.Name = "button16";
            button16.Size = new Size(69, 111);
            button16.TabIndex = 16;
            button16.Text = ",";
            button16.UseVisualStyleBackColor = true;
            button16.Click += ButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 629);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(buttonModeSwitch);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "T9 Dictionary";
            KeyPress += Form1_KeyPress;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer timerKeysWait;
        private Button buttonModeSwitch;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
    }
}

