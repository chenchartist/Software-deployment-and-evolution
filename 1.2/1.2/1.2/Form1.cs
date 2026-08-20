using System;
using System.Windows.Forms;

namespace TextProcessor
{
    public class Form1 : Form
    {
        private TextBox inputBox;
        private Label resultsLabel;

        public Form1()
        {
            Text = "Word Counter";
            Width = 400;
            Height = 300;

            // Text input
            inputBox = new TextBox();
            inputBox.Multiline = true;
            inputBox.Dock = DockStyle.Top;
            inputBox.Height = 150;
            inputBox.Text = "Paste your text here...";
            Controls.Add(inputBox);

            // Button to count
            Button countBtn = new Button();
            countBtn.Text = "Count Words";
            countBtn.Width = 100;
            countBtn.Top = 160;
            countBtn.Click += CountBtn_Click;
            Controls.Add(countBtn);

            // Results label
            resultsLabel = new Label();
            resultsLabel.Top = 200;
            resultsLabel.Left = 10;
            resultsLabel.Width = 360;
            resultsLabel.Height = 50;
            resultsLabel.BorderStyle = BorderStyle.FixedSingle;
            resultsLabel.Font = new System.Drawing.Font("Arial", 14);
            Controls.Add(resultsLabel);
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputBox.Text) || inputBox.Text == "Paste your text here...")
            {
                MessageBox.Show("Enter some text first!");
                return;
            }

            int wordCount = inputBox.Text.Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            resultsLabel.Text = "Word Count: " + wordCount;
        }
    }
}