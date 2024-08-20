using System;
using System.Windows.Forms;

namespace GuessNumberGame
{
    public partial class Form1 : Form
    {
        private int targetNumber;
        private int attempts;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Khởi tạo số ngẫu nhiên và số lần thử
            Random random = new Random();
            targetNumber = random.Next(1, 101); // Số từ 1 đến 100
            attempts = 0;
            lblMessage.Text = "Nhập số từ 1 đến 100 và nhấn 'Đoán'!";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guessedNumber;
            if (int.TryParse(txtGuess.Text, out guessedNumber))
            {
                attempts++;
                if (guessedNumber < targetNumber)
                {
                    lblMessage.Text = "Số đoán thấp hơn. Thử lại!";
                }
                else if (guessedNumber > targetNumber)
                {
                    lblMessage.Text = "Số đoán cao hơn. Thử lại!";
                }
                else
                {
                    lblMessage.Text = $"Chúc mừng! Bạn đã đoán đúng số {targetNumber} sau {attempts} lần thử.";
                    // Bắt đầu lại trò chơi
                    InitializeGame();
                }
            }
            else
            {
                lblMessage.Text = "Vui lòng nhập một số hợp lệ!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}