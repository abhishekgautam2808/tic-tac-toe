using System;

namespace tic_tac_toe_18_
{
    class Program
    {    
        public static  bool inputCorrect=true;
        public  static int player = 2;
        public static  int input = 0;
        public static int turns = 0;

        static void Main(string[] args)
        {
            do
            {
                if (player == 1)
                {
                    player = 2;
                    EnterXOr0(player, input);
                }
                else
                {
                    player = 1;
                    EnterXOr0(player, input);
                }
                SetField();
                #region
                //checking for winner
                char[] playerChars = new char[2] {'X','O' } ;
                foreach(char playerChar in playerChars)
                {
                    if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar)) ||
                           ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))||
                           ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))||
                           ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))||
                           ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))||
                           ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))||
                           ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))||
                           ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar)))
                        {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine();
                            Console.WriteLine("we have player1 as a winner");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("we have player2 as a winner");
                        }
                        Console.WriteLine("enter any key to reset");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if( turns==10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("we have a draw");
                        Console.WriteLine("enter any key to reset");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }
                #endregion
                #region
                //checking for valid inputs
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("player {0}: chhose your field",player);
                    try
                    {
                        input = int.Parse(Console.ReadLine());
                     }
                    catch (Exception)
                    {
                        Console.WriteLine("enter valid input");
                        throw;
                    }
                    if (input == 1 && (playField[0, 0] == '1'))
                    {
                        inputCorrect = true;
                    }
                        
                    else if (input == 2 && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if (input == 3 && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if (input == 4 && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if (input == 5 && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if (input == 6 && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if (input == 7 && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if (input == 8 && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if (input == 9 && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("enter valid input(no cheating)");
                        inputCorrect=false;                     
                    }
                } while (!inputCorrect);
#endregion
            } while (true);          
        }
        static char[,] playField = new char[,]
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }       
        };
        static char[,] IniatialPlayField = new char[,]
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };
        public static void ResetField()
        {
          playField =IniatialPlayField;
            SetField();
            turns = 0;
        }
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |   {2} ",playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |   {2} ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |   {2} ", playField[2, 0], playField[2, 1], playField[2, 2]);
            turns += 1;
        }
        public static void EnterXOr0(int player,int input)
        {
            char playerSign = ' ';
            if (player == 1)
            {
                playerSign = 'O';              
            }
            else
            {
                playerSign = 'X';
            }
            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;

            }
        }
    }
}
