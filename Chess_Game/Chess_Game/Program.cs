﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Chess_Game
{
    
    class Chess : Form
    {
        public Button[,] btns = new Button[8, 8];

        public Button prevButton;
        public bool isMoving = false;
        public int currPlayer;
        public Button btn_restart = new Button();

        public int[,] map = new int[8, 8]
        {
            {15,14,13,12,11,13,14,15 },
            {16,16,16,16,16,16,16,16 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {26,26,26,26,26,26,26,26 },
            {25,24,23,22,21,23,24,25 },
        };

        public void init()
        {
            map = new int[8, 8]
            {
            {15,14,13,12,11,13,14,15 },
            {16,16,16,16,16,16,16,16 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {0,0,0,0,0,0,0,0 },
            {26,26,26,26,26,26,26,26 },
            {25,24,23,22,21,23,24,25 },
            };

            currPlayer = 1;
            CreateMap();
        }

        public void CreateMap()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    btns[i, j] = new Button();

                    Button btn = new Button();
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point(j * 50, i * 50);
                    switch (map[i, j])
                    {
                        case 11:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.vuatrang;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 12:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.hautrang;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 13:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.tuongtrang;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 14:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.nguatrang;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 15:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.xetrang;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 16:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.chottrang;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;

                        case 21:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.vuaden;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 22:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.hauden;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 23:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.tuongden;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 24:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.strategy;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 25:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.xeden;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case 26:
                            btn.BackgroundImage = global::Chess_Game.Properties.Resources.chotden;
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            break;

                        default:
                            break;
                    }

                    btn.BackColor = Color.White;
                    btn.Click += new EventHandler(OnFigurePress);
                    this.Controls.Add(btn);

                    btns[i, j] = btn;
                }
            }
        }

        public void OnFigurePress(object sender, EventArgs e)
        {
            // Bắt event click button
            Button pressedButton = sender as Button;
            // Nếu prevButton có giá trị thì set white lại cho nó
            if (prevButton != null)
                prevButton.BackColor = Color.White;

            //Console.WriteLine(pressedButton.Location.Y);
            //Console.WriteLine(map[pressedButton.Location.Y / 50, pressedButton.Location.X / 50]); 

            // Check các vị trí có thể đổi màu
            if (map[pressedButton.Location.Y/50, pressedButton.Location.X/50] != 0 && map[pressedButton.Location.Y / 50, pressedButton.Location.X / 50]/ 10 == currPlayer)
            {
                pressedButton.BackColor = Color.Red;
                isMoving = true;
            }
            else
            {
                if(isMoving)
                {
                    // Lấy vị trí mà đối tượng vừa chọn
                    int temp = map[pressedButton.Location.Y / 50, pressedButton.Location.X / 50];
                    map[pressedButton.Location.Y / 50, pressedButton.Location.X / 50] = map[prevButton.Location.Y / 50, prevButton.Location.X / 50];
                    map[prevButton.Location.Y / 50, prevButton.Location.X / 50] = temp;

                    // Thay đổi background của đối tượng vừa chọn
                    pressedButton.BackgroundImage = prevButton.BackgroundImage;
                    pressedButton.BackgroundImageLayout = ImageLayout.Stretch;

                    // Reset background cho đối tượng
                    prevButton.BackgroundImage = null;


                    isMoving = false;
                    SwitchPlayer();
                }
            }
            

            prevButton = pressedButton;
        }

        // Hàm dùng để chuyển lượt chơi cho 2 player
        public void SwitchPlayer()
        {
            if (currPlayer == 1)
                currPlayer = 2;
            else currPlayer = 1;
        }
        public Chess()
        {
            
            this.Text = "Chess Game";
            this.Height = 450;
            this.Width = 500;
            this.CenterToScreen();

            btn_restart.Text = "Restart";
            btn_restart.Location = new Point(405, 200);
            btn_restart.Size = new Size(70, 40);
            btn_restart.Click += new EventHandler(btn_Click);

            this.Controls.Add(btn_restart);
            //chessSpires = new Bitmap("strategy.png");
            // btn1.BackgroundImage = part;
            //Image part = new Bitmap(50, 50);
            //Graphics g = Graphics.FromImage(part);
            //g.DrawImage(chessSpires, new Rectangle(0, 0, 50, 50), 0, 0, 150, 150, GraphicsUnit.Pixel);

            init();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            init();
        }
        static void Main(string[] args)
        {

            Chess f_chess = new Chess();
            Application.Run(f_chess);
        }
    }
}