using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaroLANServer
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel ChessBoard;

        public Panel ChessBoard1 { get => ChessBoard; set => ChessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName1 { get => PlayerName; set => PlayerName = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        public Stack<PlayInfo> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }

        private List<Player> player;

        private int currentPlayer;

        private TextBox PlayerName;

        private PictureBox playerMark;

        private List<List<Button>>matrix;

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }
        private Stack<PlayInfo> playTimeLine;
        #endregion
        #region Initialize
        public ChessBoardManager(Panel ChessBoard, TextBox playerName, PictureBox mark)
        {
            this.ChessBoard = ChessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = mark;
            this.Player = new List<Player>()
            {
                new Player("Mino", Image.FromFile(Application.StartupPath + "\\Resources\\teacher1.png")),
                new Player("Yoon", Image.FromFile(Application.StartupPath + "\\Resources\\teacher2.png"))
            };           
        }
        #endregion
        #region Methods
        public void DrawChessBroard()
        {
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();
            PlayTimeLine = new Stack<PlayInfo>(); 
            currentPlayer = 0;
            ChangePlayer();
            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            Mark(btn);
            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), CurrentPlayer));
            currentPlayer = currentPlayer == 1 ? 0 : 1;
            ChangePlayer();
            if (playerMarked != null)
                playerMarked(this, new EventArgs());
            if (isEndGame(btn))
            {
                EndGame();
            }           
        }
        public void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }
        public bool Undo()
        {
            if (PlayTimeLine.Count <= 0)
                return false;
            PlayInfo oldPoint = PlayTimeLine.Pop();
            Button btn = matrix[oldPoint.Point.Y][oldPoint.Point.X];
            btn.BackgroundImage = null;
            
            if (PlayTimeLine.Count <= 0 )
            {
                CurrentPlayer = 0;
            }
            else
            {
                oldPoint = PlayTimeLine.Peek();
                CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
            }
            ChangePlayer();
            return true;
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimaryDiagonal(btn) || isEndSub(btn);
        }
        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);
            return point;
        }
        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X + 1; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLeft + countRight == 5;
        }

        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }

        private bool isEndPrimaryDiagonal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.Y - i; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X + i >= Cons.CHESS_BOARD_WIDTH)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }

        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.Y - i; i++)
            {
                if (point.X + i > Cons.CHESS_BOARD_WIDTH || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X - i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }
               
        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[currentPlayer].Mark;
        }

        private void ChangePlayer()
        {
            PlayerName.Text = Player[currentPlayer].Name;

            PlayerMark.Image = Player[currentPlayer].Mark;
        }
        #endregion

    }
}
