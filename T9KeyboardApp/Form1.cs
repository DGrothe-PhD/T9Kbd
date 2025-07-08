using System;
using System.ComponentModel;

namespace T9KeyboardApp
{
    public partial class Form1 : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Mode EntryMode { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<AddTextButton> AddTextButtons { get; set; }
        int counter = 0;
        bool timerIsRunning = false;
        Button? buttonPressed = null;

        public Form1()
        {
            InitializeComponent();
            AddTextButtons =
            [
                new(textBox1, "lich"), new(textBox1, "heit"), new(textBox1, "keit"), 
                new(textBox1, "schaft"),new(textBox1, "ung"),
            ];
            foreach (AddTextButton button in AddTextButtons)
            {
                Controls.Add(button);
                button.Show();
            }

            textBox1.Height = 480;
            EntryMode = Mode.Normal;
            DisplayEntryMode();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }

        #region keyhandler
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            ;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                textBox1.Text += " ";
            }
            else if (e.KeyChar == '#')
            {
                SwitchMode();
            }
            else // if (int.TryParse("" + e.KeyChar, out int _))
            {
                foreach (var b in Controls.OfType<Button>())
                {
                    if (b.Text[0] == e.KeyChar)
                    {
                        ButtonClick(b, new EventArgs());
                        break;
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    textBox1.Text += Environment.NewLine;
                    break;
                case Keys.F3:
                    Clipboard.SetText(textBox1.Text);
                    break;
                case Keys.F6:
                    textBox1.Text = "";
                    break;
                case Keys.Back:
                    textBox1.Text = textBox1.Text.Backspace();
                    break;
                case Keys.F1:
                    MessageBox.Show("F3 : Copy to clipboard" + Environment.NewLine
                        + "F6 : Clear field" + Environment.NewLine
                        + "..." + Environment.NewLine
                    );
                    break;
            }
        }
        #endregion
        private void TypeLetter()
        {
            char? c = buttonPressed?.Text[0];
            if (buttonPressed != null
                && int.TryParse("" + c, out int index) )
            {
                textBox1.Text += Buttons.buttons[index].Key(EntryMode);
            }
            else
            {
                textBox1.Text += OperatorWrite(c);
            }

            if (EntryMode == Mode.Capital)
            {
                EntryMode = Mode.Normal;
                DisplayEntryMode();
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (buttonPressed != sender as Button)
            {
                if (timerIsRunning) StopTimer();
                StartTimer();
            }
            if (!timerIsRunning && EntryMode != Mode.Numeric)
            {
                StartTimer();
            }

            buttonPressed = sender as Button;
            if (int.TryParse("" + buttonPressed?.Text[0], out int index))
            {
                Buttons.buttons[index].Hit();
                lblActiveChar.Text = "" + Buttons.buttons[index].Value().ToString();
            }
            else
            {
                OperatorButton(buttonPressed?.Text[0]);
            }

            textBox1.Select();
        }

        private void OperatorButton(char? name)
        {
            if (name == null)
                return;
            ButtonKey? representingButton
                = name switch
                {
                    ',' => Buttons.buttons[10],
                    '-' => Buttons.buttons[11],
                    '/' => Buttons.buttons[12],
                    '*' => Buttons.buttons[13],
                    '+' => Buttons.buttons[14],
                    _ => null
                };
            representingButton?.Hit();
            lblActiveChar.Text = "" + representingButton?.Value();
        }

        private char? OperatorWrite(char? name)
        {
            return name switch
            {
                ',' => Buttons.buttons[10].Key(EntryMode),
                '-' => Buttons.buttons[11].Key(EntryMode),
                '/' => Buttons.buttons[12].Key(EntryMode),
                '*' => Buttons.buttons[13].Key(EntryMode),
                '+' => Buttons.buttons[14].Key(EntryMode),
                _ => null,
            };
        }

        private void TimerKeysWait_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > 6)
            {
                StopTimer();
            }
        }

        private void StartTimer()
        {
            counter = 0;
            timerKeysWait.Start();
            timerIsRunning = true;
            textBox1.BackColor = Color.IndianRed;
        }
        private void StopTimer()
        {
            textBox1.BackColor = Color.LawnGreen;
            timerKeysWait.Stop();
            counter = 0;
            timerIsRunning = false;
            TypeLetter();
            textBox1.BackColor = Color.Moccasin;
        }


        private void ButtonModeSwitch_Click(object sender, EventArgs e)
        {
            SwitchMode();
            textBox1.Select();
        }

        private void SwitchMode()
        {
            EntryMode = (Mode)((int)(EntryMode + 1) % 4);
            DisplayEntryMode();
        }

        private void DisplayEntryMode() => lblEntryMode.Text = Params.EntryModes[(int)EntryMode];

        private void Button_MFG_Click(object sender, EventArgs e)
        {
            textBox1.Text += Environment.NewLine + Environment.NewLine
                + "Mit freundlichen Grüßen" + Environment.NewLine
                + Environment.NewLine;
            textBox1.Select();
        }

        private void BtnSGDH_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Sehr geehrte Damen und Herren," + Environment.NewLine
                + Environment.NewLine;
            textBox1.Select();
        }

        private void BtnAnrede_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Liebe";
            textBox1.Select();
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Hallo ";
            textBox1.Select();
        }

        private void BtnGruss_Click(object sender, EventArgs e)
        {
            textBox1.Text += Environment.NewLine + Environment.NewLine
                + "Herzliche Grüße" + Environment.NewLine
                + Environment.NewLine;
            textBox1.Select();
        }

        private void BtnAWDS_Click(object sender, EventArgs e)
        {
            textBox1.Text += Environment.NewLine + Environment.NewLine
                + "Auf Wiedersehen!" + Environment.NewLine
                + Environment.NewLine;
            textBox1.Select();
        }
    }
}
