﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CNCNPM
{
    public partial class Thi : Form
    {
        public Thi()
        {
            InitializeComponent();
        }
        private List<Question> CreateListQuestion() 
        {
            List<Question> questions = new List<Question>();
            questions.Add(new Question()
            {
                QuestionText = "Hành tinh nào lớn nhất trong hệ mặt trời",
                AnswerList = new List<Answer>()
                {
                    new Answer(){
                        id = "1",
                        AnswerText = "Cau A: Trái Đất"
                    },
                    new Answer(){
                        id = "2",
                        AnswerText = "Cau B: Sao Mộc"
                    },
                    new Answer(){
                        id = "3",
                        AnswerText = "Cau C: Sao Thổ"
                    },
                    new Answer(){
                        id = "4",
                        AnswerText = "Cau D: Sao Thiên Vương"
                    }
                },
                id = "1",
                AnswerCorrect = "1"
            });
            questions.Add(new Question()
            {
                QuestionText = "Giảm thời gian hồi chiêu trong LOL tối đa là bao nhiêu",
                AnswerList = new List<Answer>()
                {
                    new Answer(){
                        id = "5",
                        AnswerText = "Cau A: 30%"
                    },
                    new Answer(){
                        id = "6",
                        AnswerText = "Cau B: 35%"
                    },
                    new Answer(){
                        id = "7",
                        AnswerText = "Cau C: 40%"
                    },
                    new Answer(){
                        id = "8",
                        AnswerText = "Cau D: 45%"
                    }
                },
                id = "2",
                AnswerCorrect = "8"
            });
            return questions;
        }
        private void Thi_Load(object sender, EventArgs e)
        {
            FulScreen();
        }

        private void FulScreen()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fl = new Form1();
            fl.Show();
        }
    }
}