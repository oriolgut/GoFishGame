using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class GoFish : Form
    {
        private Game _game;
        public GoFish()
        {
            InitializeComponent();
        }

        private void UpdateForm()
        {
            listBoxCardsInHand.Items.Clear();
            foreach (string cardName in _game.GetPlayerCardNames())
                listBoxCardsInHand.Items.Add(cardName);
            textBoxBooks.Text = _game.DescribeBooks();
            textBoxGameProgress.Text += _game.DescribePlayerHands();
            textBoxGameProgress.SelectionStart = textBoxGameProgress.Text.Length;
            textBoxGameProgress.ScrollToCaret();
        }

        private void OnButtonStartTheGameClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Please enter your name", "Can't start game yet");
                return;
            }
            _game = new Game(textBoxName.Text, new List<string> { "Joe", "Bob" }, textBoxGameProgress);
            buttonStartTheGame.Enabled = false;
            textBoxName.Enabled = false;
            buttonAskForCard.Enabled = true;
            listBoxCardsInHand.Enabled = true;
            UpdateForm();
        }

        private void OnButtonAskForCardClick(object sender, EventArgs e)
        {
            textBoxGameProgress.Text = "";

            if(listBoxCardsInHand.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a card");
                return;
            }

            if(_game.PlayOneRound(listBoxCardsInHand.SelectedIndex))
            {
                textBoxGameProgress.Text += "The winner is... " + _game.GetWinnerName();
                textBoxBooks.Text = _game.DescribeBooks();
                buttonAskForCard.Enabled = false;
                listBoxCardsInHand.Enabled = false;
            }
            else
            {
                UpdateForm();
            }
        }
    }
}
