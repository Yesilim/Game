using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        // Her buton için ayrı lastNumber saklamak için değişkenler tanımlandı
        int? lastNumber1 = null;
        int? lastNumber2 = null;
        int? lastNumber3 = null;
        int? lastNumber4 = null;
        int? lastNumber5 = null;
        int? lastNumber6 = null;
        int? lastNumber7 = null;
        int? lastNumber8 = null;
        int? lastNumber9 = null;

        // Seçilen kartları saklayan liste
        List<Button> selectedButtons = new List<Button>();
        List<int> selectedNumbers = new List<int>();

        List<int> cards = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5 };
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button1, ref lastNumber1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button2, ref lastNumber2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button3, ref lastNumber3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button4, ref lastNumber4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button5, ref lastNumber5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button6, ref lastNumber6);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button7, ref lastNumber7);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button8, ref lastNumber8);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button9, ref lastNumber9);

        }
        private void HandleButtonClick(Button button, ref int? lastNumber)
        {
            if (lastNumber != null)
            {
                button.Text = lastNumber.ToString();
                AddToSelected(button, lastNumber.Value);
                return;
            }

            if (cards.Count > 0)
            {
                int randomIndex = random.Next(cards.Count);
                int randomnumber = cards[randomIndex];
                button.Text = randomnumber.ToString();
                cards.RemoveAt(randomIndex);
                lastNumber = randomnumber;

                AddToSelected(button, randomnumber);
            }
        }

        private void AddToSelected(Button button, int number)
        {
            selectedButtons.Add(button);
            selectedNumbers.Add(number);

            if (selectedButtons.Count == 2)
            {
                CheckSelectedCards();
            }
        }

        private void CheckSelectedCards()
        {
            if (selectedNumbers[0] != selectedNumbers[1])
            {
                selectedButtons[0].Text = "";
                selectedButtons[1].Text = "";
            }

            selectedButtons.Clear();
            selectedNumbers.Clear();
        }
    }
}
