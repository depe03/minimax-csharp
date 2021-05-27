using System;
using System.Collections.Generic;
using System.Text;
using minimax.core.adversarial;

namespace minimax.tictactoe2
{
    public class Game : IGame<State, Action, Player>
    {
        
        public List<Action> GetActions(State state)
        {
            List<Action> action = new List<Action>();
            Action tmp;
            int[,] campo = state.campo;
            Player giocatoreCorrente = state.giocatoreCorrente;
            for (int row=0;row<3;row++){

                for(int col=0; col<3; col++){

                    if(campo[row,col]==-1){
                        action.Add(tmp);
                    }
                }

            }
            return action;
        }

        //Facile
        public State GetInitialState()
        {
            State state = new State();
            int[,] campo = new int[3,3];
            for (int row=0;row<3;row++){

                for(int col=0; col<3; col++){

                    campo[row,col] = -1;
                }

            }
            Player giocatoreCorrente = Player.Cross;
        }

        //Facile
        public Player GetPlayer(State state)
        {
            throw new NotImplementedException();
        }

        //Facile
        public Player[] GetPlayers()
        {
            Player[] players = new Player[2] {Player.Cross, Player.Circle};
            return players;
        }

        //Media+
        //CREARE UN NUOVO STATO, NON MODIFICARE LO STATO IN INGRESSO
        public State GetResult(State state, Action action)
        {
            State copyState= new State();

            copyState.campo = (int[,])state.campo.Clone();
            copyState.giocatoreCorrente = state.giocatoreCorrente;
            //Creare un nuovo stato
            //Copiare il contenuto dello stato precedente nel nuovo stato
            //Invertire il giocatore (se era Cross mettere Circle, e viceversa)
            //Inserire la mossa nel nuovo stato
            //Ritornare il nuovo stato

            
        }

        //Difficile+
        public double GetUtility(State state, Player player)
        {
            int winner = Vincitore(state);
            if(IsTerminal(state)){
                if(winner==(int)player){
                    return int.MaxValue=-1;
                }
                else if(winner == -1){
                    return 0;
                }
                else{
                    return int.MinValue = 1;
                }
            }
            
        }


        //Difficile
        public bool IsTerminal(State state)
        {
            for (int row=0;row<3;row++){

                for(int col=0; col<3; col++)
                {

                    if(campo[0,col]!=null && campo[0,col] == 1 || campo[0,col] == -1)
                    {

                    }
                    else if(campo[1,col]!=null  && campo[1,col] == 1 || campo[1,col] == -1)
                    {

                    } 
                    else if(campo[2,col]!=null  && campo[2,col] == 1 || campo[2,col] == -1)
                    {

                    }

                }

            }
            //Se c'è un tris verticale, ritorna true
            //Se c'è un tris orizzontale, ritorna true
            //Se c'è un tris diagonale, ritorna true
            //Se la board è piena, ritorna true
            return false;
        }
    }
}

