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
            lblEntryMode = new Label();
            label1 = new Label();
            lblActiveChar = new Label();
            btnMFG = new Button();
            btnSGDH = new Button();
            btnAnrede = new Button();
            btnHello = new Button();
            btnGruss = new Button();
            btnAWDS = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleDescription = "Textfeld";
            textBox1.AccessibleName = " ";
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(463, 16);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.MaximumSize = new Size(1300, 624);
            textBox1.MinimumSize = new Size(10, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(758, 460);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += Form1_KeyPress;
            textBox1.KeyUp += Form1_KeyUp;
            // 
            // button1
            // 
            button1.AccessibleDescription = "Taste 1";
            button1.AccessibleName = "1, Leerzeichen, Anführungzeichen";
            button1.Font = new Font("Microsoft Sans Serif", 12F);
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
            button2.AccessibleDescription = "Taste 2";
            button2.AccessibleName = "2, A, B, oder C";
            button2.Font = new Font("Microsoft Sans Serif", 12F);
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
            button3.AccessibleDescription = "Taste 3";
            button3.AccessibleName = "3, D, E, F";
            button3.Font = new Font("Microsoft Sans Serif", 12F);
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
            button4.AccessibleDescription = "Taste 4";
            button4.AccessibleName = "4, G, H, I";
            button4.Font = new Font("Microsoft Sans Serif", 12F);
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
            button5.AccessibleDescription = "Taste 5";
            button5.AccessibleName = "5, J, K, L";
            button5.Font = new Font("Microsoft Sans Serif", 12F);
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
            button6.AccessibleDescription = "Taste 6";
            button6.AccessibleName = "6, M, N, O";
            button6.Font = new Font("Microsoft Sans Serif", 12F);
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
            button7.AccessibleDescription = "Taste 7";
            button7.AccessibleName = "7, P, Q, R, S";
            button7.Font = new Font("Microsoft Sans Serif", 12F);
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
            button8.AccessibleDescription = "Taste 8";
            button8.AccessibleName = "8, T, U, V";
            button8.Font = new Font("Microsoft Sans Serif", 12F);
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
            button9.AccessibleDescription = "Taste 9";
            button9.AccessibleName = "9, W, X, Y, Z";
            button9.Font = new Font("Microsoft Sans Serif", 12F);
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
            button10.AccessibleDescription = "Taste Null";
            button10.AccessibleName = "Null, At-Zeichen, Grad, Prozent";
            button10.Font = new Font("Microsoft Sans Serif", 13.8F);
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
            buttonModeSwitch.AccessibleDescription = "Rautetaste";
            buttonModeSwitch.AccessibleName = "Rautetaste, Umschalten, Feststellen, Zifferneingabe";
            buttonModeSwitch.Font = new Font("Microsoft Sans Serif", 12F);
            buttonModeSwitch.Location = new Point(249, 489);
            buttonModeSwitch.Margin = new Padding(4, 5, 4, 5);
            buttonModeSwitch.Name = "buttonModeSwitch";
            buttonModeSwitch.Size = new Size(117, 111);
            buttonModeSwitch.TabIndex = 11;
            buttonModeSwitch.Text = "#\r\nAa123";
            buttonModeSwitch.UseVisualStyleBackColor = true;
            buttonModeSwitch.Click += ButtonModeSwitch_Click;
            // 
            // button12
            // 
            button12.AccessibleDescription = "Plustaste";
            button12.AccessibleName = "Plus, kaufmännisches Und";
            button12.Font = new Font("Microsoft Sans Serif", 12F);
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
            button13.AccessibleDescription = "Minustaste";
            button13.AccessibleName = "Minus, Unterstrich, Gleich";
            button13.Font = new Font("Microsoft Sans Serif", 12F);
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
            button14.AccessibleDescription = "Taste Stern";
            button14.AccessibleName = "Stern, Dachel";
            button14.Font = new Font("Microsoft Sans Serif", 24F);
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
            button15.AccessibleDescription = "Taste Geteilt";
            button15.AccessibleName = "Schrägstrich, Backslash, senkrechter Strich";
            button15.Font = new Font("Microsoft Sans Serif", 12F);
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
            button16.AccessibleDescription = "Kommataste";
            button16.AccessibleName = "Komma, Punkt, Ausrufezeichen, Fragezeichen, Doppelpunkt, Semikolon";
            button16.Font = new Font("Microsoft Sans Serif", 24F);
            button16.Location = new Point(374, 490);
            button16.Margin = new Padding(4, 5, 4, 5);
            button16.Name = "button16";
            button16.Size = new Size(69, 111);
            button16.TabIndex = 16;
            button16.Text = ",";
            button16.UseVisualStyleBackColor = true;
            button16.Click += ButtonClick;
            // 
            // lblEntryMode
            // 
            lblEntryMode.BackColor = SystemColors.ControlLightLight;
            lblEntryMode.BorderStyle = BorderStyle.FixedSingle;
            lblEntryMode.Font = new Font("Cambria", 10.8F, FontStyle.Bold);
            lblEntryMode.Location = new Point(249, 25);
            lblEntryMode.Name = "lblEntryMode";
            lblEntryMode.Size = new Size(117, 36);
            lblEntryMode.TabIndex = 17;
            lblEntryMode.Text = "Abc";
            lblEntryMode.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 25);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 18;
            label1.Text = "Mode";
            // 
            // lblActiveChar
            // 
            lblActiveChar.BackColor = Color.AntiqueWhite;
            lblActiveChar.BorderStyle = BorderStyle.FixedSingle;
            lblActiveChar.Font = new Font("Cambria", 10.8F, FontStyle.Bold);
            lblActiveChar.Location = new Point(374, 25);
            lblActiveChar.Name = "lblActiveChar";
            lblActiveChar.Size = new Size(69, 36);
            lblActiveChar.TabIndex = 19;
            lblActiveChar.Text = "x";
            lblActiveChar.UseMnemonic = false;
            // 
            // btnMFG
            // 
            btnMFG.BackColor = Color.NavajoWhite;
            btnMFG.FlatAppearance.BorderColor = Color.Gray;
            btnMFG.FlatAppearance.BorderSize = 2;
            btnMFG.Location = new Point(1140, 493);
            btnMFG.Name = "btnMFG";
            btnMFG.Size = new Size(78, 38);
            btnMFG.TabIndex = 23;
            btnMFG.Text = "MFG";
            btnMFG.UseVisualStyleBackColor = false;
            btnMFG.Click += Button_MFG_Click;
            // 
            // btnSGDH
            // 
            btnSGDH.BackColor = Color.NavajoWhite;
            btnSGDH.FlatAppearance.BorderColor = Color.Gray;
            btnSGDH.FlatAppearance.BorderSize = 2;
            btnSGDH.Location = new Point(1056, 493);
            btnSGDH.Name = "btnSGDH";
            btnSGDH.Size = new Size(78, 38);
            btnSGDH.TabIndex = 24;
            btnSGDH.Text = "SGDH";
            btnSGDH.UseVisualStyleBackColor = false;
            btnSGDH.Click += BtnSGDH_Click;
            // 
            // btnAnrede
            // 
            btnAnrede.BackColor = Color.NavajoWhite;
            btnAnrede.FlatAppearance.BorderColor = Color.Gray;
            btnAnrede.FlatAppearance.BorderSize = 2;
            btnAnrede.Location = new Point(1056, 537);
            btnAnrede.Name = "btnAnrede";
            btnAnrede.Size = new Size(78, 38);
            btnAnrede.TabIndex = 25;
            btnAnrede.Text = "Liebe";
            btnAnrede.UseVisualStyleBackColor = false;
            btnAnrede.Click += BtnAnrede_Click;
            // 
            // btnHello
            // 
            btnHello.BackColor = Color.NavajoWhite;
            btnHello.FlatAppearance.BorderColor = Color.Gray;
            btnHello.FlatAppearance.BorderSize = 2;
            btnHello.Location = new Point(972, 537);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(78, 38);
            btnHello.TabIndex = 26;
            btnHello.Text = "Hallo";
            btnHello.UseVisualStyleBackColor = false;
            btnHello.Click += BtnHello_Click;
            // 
            // btnGruss
            // 
            btnGruss.BackColor = Color.NavajoWhite;
            btnGruss.FlatAppearance.BorderColor = Color.Gray;
            btnGruss.FlatAppearance.BorderSize = 2;
            btnGruss.Location = new Point(1140, 537);
            btnGruss.Name = "btnGruss";
            btnGruss.Size = new Size(78, 38);
            btnGruss.TabIndex = 27;
            btnGruss.Text = "Herzl.";
            btnGruss.UseVisualStyleBackColor = false;
            btnGruss.Click += BtnGruss_Click;
            // 
            // btnAWDS
            // 
            btnAWDS.BackColor = Color.NavajoWhite;
            btnAWDS.FlatAppearance.BorderColor = Color.Gray;
            btnAWDS.FlatAppearance.BorderSize = 2;
            btnAWDS.Location = new Point(972, 493);
            btnAWDS.Name = "btnAWDS";
            btnAWDS.Size = new Size(78, 38);
            btnAWDS.TabIndex = 28;
            btnAWDS.Text = "AWDS!";
            btnAWDS.UseVisualStyleBackColor = false;
            btnAWDS.Click += BtnAWDS_Click;
            // 
            // Form1
            // 
            AccessibleDescription = "T9 Tastatur. Geben Sie Text mit der Nummerntastatur ein, ungefähr wie auf alten Handys.";
            AccessibleName = "T9 Tastatur";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 629);
            Controls.Add(btnAWDS);
            Controls.Add(btnGruss);
            Controls.Add(btnHello);
            Controls.Add(btnAnrede);
            Controls.Add(btnSGDH);
            Controls.Add(btnMFG);
            Controls.Add(lblActiveChar);
            Controls.Add(label1);
            Controls.Add(lblEntryMode);
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
        private Label lblEntryMode;
        private Label label1;
        private Label lblActiveChar;
        private Button btnMFG;
        private Button btnSGDH;
        private Button btnAnrede;
        private Button btnHello;
        private Button btnGruss;
        private Button btnAWDS;
    }
}

