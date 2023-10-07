using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T9KeyboardApp
{
    public class AddTextButton : Button
    {
        private static int x = -1;
        private static readonly int numPerRow = 7;
        private readonly TextBox tetheredBox;
        private readonly String appliedText;
        private readonly Point topPosition = new(462, 493);
        private static readonly Point step = new(84, 46);

        public AddTextButton(TextBox target, String text)
        {
            x++;
            Location = new Point(
                topPosition.X + (x % numPerRow) * step.X,
                topPosition.Y + (x / numPerRow) * step.Y
            );

            tetheredBox = target;
            appliedText = text;
            Text = appliedText;
            Click += AddText;
            BackColor = Color.Silver;
            UseVisualStyleBackColor = true;
            FlatAppearance.BorderColor = Color.Gray;
            FlatAppearance.BorderSize = 2;
            FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);

            Size = new Size(78, 38);
            FlatStyle = FlatStyle.Flat;
        }

        private void AddText(object? sender, EventArgs e)
        {
            tetheredBox.Text += appliedText;
            tetheredBox.Select();
        }
    }
}
