using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DotNetChess.Objects
{
    public class ChessBoard
    {
        private int size;
        private Grid grid;

        public ChessBoard(int size) {
            this.size = size;
        }

        public int getSize() { return size; }
        public Grid getGrid() { return grid; }

        private List<ChessPiece> chessPieces = new List<ChessPiece>();

        public void AddPiece(ChessPiece piece) { 
            chessPieces.Add(piece);
        }

        public void RemovePiece(ChessPiece piece) { 
            chessPieces.Remove(piece);
        }

        public List<ChessPiece> GetChessPieces()
        {
            return chessPieces;
        }

        public Grid Create()
        {
            grid = new Grid();
            grid.VerticalAlignment = VerticalAlignment.Center;
            grid.HorizontalAlignment = HorizontalAlignment.Center;
            for (int i = 0; i < size; i++)
            {
                ColumnDefinition column = new ColumnDefinition();
                grid.ColumnDefinitions.Add(column);

                RowDefinition row = new RowDefinition();
                grid.RowDefinitions.Add(row);

                for (int j = 0; j < size; j++)
                {
                    ChessBoardCell cell = new ChessBoardCell($"Cell{i + 1}{j + 1}", i + 1, j + 1)
                    {
                        Width = 50,
                        Height = 50,
                        Background = (i + j) % 2 == 0 ? Brushes.White : Brushes.Gray
                    };
                    var cellUI = cell.Create();

                    Grid.SetRow(cellUI, i);
                    Grid.SetColumn(cellUI, j);
                    grid.Children.Add(cellUI);
                }
            }
            return grid;
        }
    }
}
