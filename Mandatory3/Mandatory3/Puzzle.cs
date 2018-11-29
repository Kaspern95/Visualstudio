using System;
using System.Collections.Generic;

namespace Mandatory3
{
    class Puzzle
    {
        private Piece[][] gamePieces = new Piece[3][]; //jagged array (array of arrays)
        public Piece[][] GamePieces
        {
            get { return gamePieces; }
            private set
            {
                gamePieces = value;
            }
        }
        /// <summary>
        /// Generate arrays in jagged array
        /// Instatiate Piece objects in jagged array 
        /// </summary>
        public Puzzle()
        {
            gamePieces[0] = new Piece[3];
            gamePieces[1] = new Piece[3];
            gamePieces[2] = new Piece[3];

            gamePieces[0][0] = new Piece(1);
            gamePieces[0][1] = new Piece(2);
            gamePieces[0][2] = new Piece(3);
            gamePieces[1][0] = new Piece(4);
            gamePieces[1][1] = new Piece(5);
            gamePieces[1][2] = new Piece(6);
            gamePieces[2][0] = new Piece(7);
            gamePieces[2][1] = new Piece(8);
            gamePieces[2][2] = new Piece(0);

            Mix();
        }
        /// <summary>
        /// Random mix PieceValues in game
        /// </summary>
        /// 
        public int Win(int number)
        {
            if (gamePieces[0][0].PieceValue == 1 && gamePieces[0][1].PieceValue == 2 && gamePieces[0][2].PieceValue == 3 
                && gamePieces[1][0].PieceValue == 4 && gamePieces[1][1].PieceValue == 5 && gamePieces[1][2].PieceValue == 6 
                && gamePieces[2][0].PieceValue == 7 && gamePieces[2][1].PieceValue == 8 && gamePieces[2][2].PieceValue == 0)
            {
                number = 1;
            }
            else
            {
                number = 0;
            }
            return number;
        }
        public void Mix()
        {
            List<int> rndNrList = new List<int>();
            Random rnd = new Random();
            int number = 0;
            for (int i = 0; i <= 8; i++)
            {
                rndNrList.Add(i);
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                    number = rnd.Next(0, rndNrList.Count);
                    gamePieces[i][j].PieceValue = rndNrList[number];
                    rndNrList.Remove(rndNrList[number]);
                    
                }

            }
            
        }

        /// <summary>
        /// Test if swap is valid and if valid swap piecevalues
        /// </summary>
        public void TestAndSwap(int fromRow, int fromCol, int toRow, int toCol)
        {
            Swap(fromRow, fromCol, toRow, toCol);
        }
        /// <summary>
        /// Swap pieceValue for two pieces in game
        /// </summary>
        private void Swap(int fromRow, int fromCol, int toRow, int toCol)
        {
            int tmpValue = GamePieces[toRow][toCol].PieceValue;
            GamePieces[toRow][toCol].PieceValue = GamePieces[fromRow][fromCol].PieceValue;
            GamePieces[fromRow][fromCol].PieceValue = tmpValue;
        }
    }
}
