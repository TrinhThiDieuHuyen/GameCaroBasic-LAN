using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaroLANServer
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;        
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlChessBoard, txbPlayerName, pctbMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            prcbCoolDown.Step = Cons.COOL_DOWN_STEP;
            prcbCoolDown.Maximum = Cons.COOL_DOWN_TIME;
            prcbCoolDown.Value = 0;
            tmCoolDown.Interval = Cons.COOL_DOWN_INTERVAL;            
            NewGame();
            
        }

        #region Methods

        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            MessageBox.Show("Finish Game!");
        }
        void NewGame()
        {
            prcbCoolDown.Value = 0;
            tmCoolDown.Stop();
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.DrawChessBroard();            
        }
        void Undo()
        {
            ChessBoard.Undo();
        }
        void Quit()
        {
           Application.Exit();
        }
        
        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            tmCoolDown.Start();
            prcbCoolDown.Value = 0;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void TmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();
            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {               
                EndGame();               
            }
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the game?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)                
            e.Cancel = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }
        private void btnLAN_Click(object sender, EventArgs e)
        {
            #endregion
        }
    }
}



