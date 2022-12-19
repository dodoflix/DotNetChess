using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DotNetChess.Objects
{
    public class ChessBoardCell
    {
        private string name;
        private int x, y;
        private Button button;
        private ChessPiece piece;

        public int Width { get; set; }
        public int Height { get; set; }
        public Brush Background { get; set; }

        public ChessBoardCell(string name, int x, int y) {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public Button Create()
        {
            button = new Button();
            button.Width = Width;
            button.Height = Height;
            button.Background = Background;

            button.Click += Button_Click;

            return button;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(name);
        }
    }
}
