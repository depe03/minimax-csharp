using System;
namespace minimax.tictactoe
{
    public class Action
    {
        private int row;
        private int col;
        public Action(int row,int col)
        {
            this.row=row;
            this.col=col;
        }

        public int row
        {
            get{return row;}
        }

        public int col
        {
            get{return col;}
        }
    }
}
