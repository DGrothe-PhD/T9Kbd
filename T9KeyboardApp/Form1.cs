namespace T9KeyboardApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                textBox1.Text += " ";
            }
            else if (int.TryParse("" + e.KeyChar, out int _))
            {
                foreach (Button b in Controls)
                {
                    if (b.Text[0] == e.KeyChar)
                    {
                        ButtonClick(b, new EventArgs());
                        break;
                    }
                }
            }
        }

        bool timerIsRunning = false;
        Button? buttonPressed = null;
        private void TypeLetter()
        {
            if (buttonPressed != null
                && int.TryParse("" + buttonPressed.Text[0], out int index)
            )
                textBox1.Text += Buttons.buttons[index].Key();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (buttonPressed != sender as Button)
            {
                if (timerIsRunning) StopTimer();
                StartTimer();
            }
            if (!timerIsRunning)
            {
                StartTimer();
            }

            buttonPressed = sender as Button;
            if (int.TryParse("" + buttonPressed?.Text[0], out int index))
                Buttons.buttons[index].Hit();
        }

        int counter = 0;
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox1.Text += Environment.NewLine;
            }
            else if (e.KeyCode == Keys.F3)
            {
                Clipboard.SetText(textBox1.Text);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
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
    }
}
