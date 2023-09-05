using System;

namespace T9KeyboardApp
{
    public partial class Form1 : Form
    {
        public Mode EntryMode { get; set; }
        int counter = 0;
        bool timerIsRunning = false;
        Button? buttonPressed = null;

        public Form1()
        {
            InitializeComponent();
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
                foreach (var b in Controls)
                {
                    if (b is Button && ((Button)b).Text[0] == e.KeyChar)
                    {
                        ButtonClick(b, new EventArgs());
                        break;
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Text += Environment.NewLine;
            }
            else if (e.KeyCode == Keys.F3)
            {
                Clipboard.SetText(textBox1.Text);
            }
            else if (e.KeyCode == Keys.F6)
            {
                textBox1.Text = "";
            }
            else if (e.KeyCode == Keys.Back)
            {
                textBox1.Text = textBox1.Text.Backspace();
            }
        }
        #endregion
        private void TypeLetter()
        {
            char? c = buttonPressed?.Text[0];
            if (buttonPressed != null
                && int.TryParse("" + c, out int index)
            )
                textBox1.Text += Buttons.buttons[index].Key(EntryMode);
            else
                textBox1.Text += OperatorWrite(c);

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
                lblActiveChar.Text = "" + Buttons.buttons[index].Value();
            }
            else OperatorButton(buttonPressed?.Text[0]);

            textBox1.Select();
        }

        private void OperatorButton(char? name)
        {
            if (name == null)
                return;
            switch (name)
            {
                case ',':
                    Buttons.buttons[10].Hit();
                    break;
                case '-':
                    Buttons.buttons[11].Hit();
                    break;
                case '/':
                    Buttons.buttons[12].Hit();
                    break;
                case '*':
                    Buttons.buttons[13].Hit();
                    break;
                case '+':
                    Buttons.buttons[14].Hit();
                    break;
            }
        }

        private char? OperatorWrite(char? name)
        {
            char? value = null;
            if (name == null)
                return value;
            switch (name)
            {
                case ',':
                    return Buttons.buttons[10].Key(EntryMode);
                case '-':
                    return Buttons.buttons[11].Key(EntryMode);
                case '/':
                    return Buttons.buttons[12].Key(EntryMode);
                case '*':
                    return Buttons.buttons[13].Key(EntryMode);
                case '+':
                    return Buttons.buttons[14].Key(EntryMode);
                default:
                    return value;
            }
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
    }
}
