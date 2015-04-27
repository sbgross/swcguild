using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    class GameManager
    {
        private string _player1Name = "";
        private string _player2Name = "";
        public string tempCoordinate = "";
        private string _playerResponse = "";
        private string _direction;
        private string _userShot = "";
        FireShotResponse response;
        public Coordinate _shotCoordinate;
        private ShipDirection _shipDirection;
        private ShipType _shipType;
        private ShipPlacement _response;
        private int _xCoordinate;
        private int _yCoordinate;
        private bool _validPlayerName = false;
        private bool _player1Turn = true;

        public Board player1Board = new Board();
        public Board player2Board = new Board();

        private Dictionary<string, ShipDirection> DirectionDecode = new Dictionary<string, ShipDirection>
        {
            {"U", ShipDirection.Up},
            {"D", ShipDirection.Down},
            {"R", ShipDirection.Right},
            {"L", ShipDirection.Left}
        };
      
        internal void SetUp()
        {            
            DisplayGameGrid();
            PlaceFleet();
            _player1Turn = !_player1Turn;
            PlaceFleet();
            _player1Turn = !_player1Turn;
        }

        public void PlayGame()
        {            
            DisplayGameGrid();
            Console.WriteLine("Now that the fleets are in place, it's time to start shooting!\n");

            do
            {
                
                if (_player1Turn)
                {
                    Console.Write("{0}, fire a shot at a coordinate in your opponent's fleet: ", _player1Name);
                }
                else
                {
                    Console.Write("{0}, fire a shot at a coordinate in your opponent's fleet: ", _player2Name);
                }

                _userShot = Console.ReadLine().ToUpper();

                while (_userShot.Length < 2)
                {
                    Console.WriteLine("That is not a valid coordinate. Please enter a letter A through J followed by a");
                    Console.Write("number 1 through 10: ");
                    _userShot = Console.ReadLine().ToUpper();
                }
                                              
                ValidateCoordinateLetterNumber(_userShot);

                response = (_player1Turn)
                    ? player2Board.FireShot(new Coordinate(_xCoordinate, _yCoordinate))
                    : player1Board.FireShot(new Coordinate(_xCoordinate, _yCoordinate));

                if (response.ShotStatus != ShotStatus.Invalid && response.ShotStatus != ShotStatus.Duplicate)
                {
                    Console.Clear();
                    DisplayGameGrid();
                }

                ShotStatusMessaging(response);

                if (response.ShotStatus == ShotStatus.Duplicate || response.ShotStatus == ShotStatus.Invalid)
                {
                    Console.ReadKey();
                    continue;
                }

                if (response.ShotStatus != ShotStatus.Victory)
                {
                    Console.Write("Press any key to start a new player shot turn.");
                    Console.ReadKey();
                    Console.Clear();
                    _player1Turn = !_player1Turn;
                    DisplayGameGrid();                    
                }                
            } while (response.ShotStatus != ShotStatus.Victory);
            
            Console.Write("Press any key.");
            Console.ReadKey();
            player1Board.ShotHistory.Clear();
            player2Board.ShotHistory.Clear();
            Console.Clear();
        }

        private void ShotStatusMessaging(FireShotResponse _shotResponse)
        {
            switch (_shotResponse.ShotStatus)
            {
                case ShotStatus.Invalid:
                    Console.WriteLine("That isn't a valid coordinate.");
                    break;
                case ShotStatus.Duplicate:
                    Console.WriteLine("You have already fired at that coordinate. Press any key to shoot again.");
                    break;
                case ShotStatus.Miss:
                    Console.WriteLine("Shot missed.");
                    break;
                case ShotStatus.Hit:
                    Console.WriteLine("Your shot hit a ship!");
                    break;
                case ShotStatus.HitAndSunk:
                    Console.WriteLine("Your shot hit and sunk {0}'s {1}!", (_player1Turn) ? _player2Name : _player1Name,_shotResponse.ShipImpacted);
                    break;
                case ShotStatus.Victory:
                    Console.WriteLine("Your shot sunk the last ship! Victory is yours!");
                    break;
            }
        }

        private void ShipPlacementRequest()
        {
            var request = new PlaceShipRequest
            {
                Coordinate = new Coordinate(_xCoordinate,_yCoordinate),
                Direction = _shipDirection,
                ShipType = _shipType
            };

            if (_player1Turn)
            {
                _response = player1Board.PlaceShip(request);
            }
            else
            {
                _response = player2Board.PlaceShip(request);
            }

            switch (_response)
            {
                case ShipPlacement.Overlap:
                    Console.WriteLine("\n*Coordinates result in overlapping ship locations*\n");
                    break;
                case ShipPlacement.NotEnoughSpace:
                    Console.WriteLine("\n*Coordinates exceed board parameters*\n");
                    break;
                case ShipPlacement.Ok:
                    Console.WriteLine("\nShip placed successfully! Press any key to continue.");
                    Console.ReadKey();
                    break;
            }
        }

        private void ValidateShipDirection()
        {
            while (!DirectionDecode.ContainsKey(_direction))
            {                
                Console.Write("That is not a valid direction. Please enter U, D, R or L: ");                    
                _direction = Console.ReadLine().ToUpper();                
            }
            _shipDirection = DirectionDecode[_direction];
        }

        private void ValidateCoordinateLetterNumber(string coordinate)
        {
            bool validInput;
            ColumnDecoder c = new ColumnDecoder();

            do
            {
                _xCoordinate = c.ColumnLetterToNumber(coordinate.Substring(0, 1));
                if (int.TryParse(coordinate.Substring(1), out _yCoordinate) && 
                    (_yCoordinate > 0 && _yCoordinate <11) && _xCoordinate != 0)
                {
                    validInput = true;                    
                }
                else
                {
                    validInput = false;
                    Console.WriteLine("That is not a valid coordinate. Please enter a letter A through J followed by a");
                    Console.Write("number 1 through 10: ");    
                    //this is funky
                    coordinate = Console.ReadLine().ToUpper();
                }  
            } while (!validInput);         
        }

        private void PlaceFleet()
        {
            Console.Clear();
            DisplayGameGrid();
            Console.WriteLine("\nNow it's time to place your fleet on the board above, {0}. Ships will be placed\n" +
                              "on the grid in order of ascending size: Destroyer, Cruiser, Submarine,\n" +
                              "Battleship and Carrier.\n", _player1Turn ? _player1Name : _player2Name); 
            for (int i = 0; i < 5; i++)
            {                
                Enum.TryParse(Enum.GetName(typeof (ShipType), i), out _shipType);
                
                do
                {                                                                                      
                    Console.Write("{0}, enter the coordinates (column letter + row number) where you would like to \n" +
                                    "place the bow of your {1} (ex. A10): ", _player1Turn ? _player1Name : _player2Name, _shipType);
                    tempCoordinate = Console.ReadLine().ToUpper();
                    
                    while (tempCoordinate.Length < 2)
                    {
                        Console.WriteLine("That is not a valid coordinate. Please enter a letter A through J followed by a");
                        Console.Write("number 1 through 10: ");
                        tempCoordinate = Console.ReadLine().ToUpper();
                    }
                    
                    ValidateCoordinateLetterNumber(tempCoordinate);

                    Console.WriteLine("\nEnter the direction the aft of your {0} should point.", _shipType);
                    Console.Write("Valid options are U for Up, D for Down,R for Right and L for Left: ");
                    
                    _direction = Console.ReadLine().ToUpper();
                    ValidateShipDirection();
                    ShipPlacementRequest();
                    if (_response == ShipPlacement.Ok)
                    {
                        Console.Clear();
                        DisplayGameGrid();
                    }
                    
                } while (_response != ShipPlacement.Ok);                
            }         

            
            Console.WriteLine("Fleet placed successfully! Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
        
        public void DisplayGameGrid()
        {            
            Board board = new Board();

            if (_player1Turn)
            {
                board = player2Board;
            }
            else
            {
                board = player1Board;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t    A    B    C    D    E    F    G    H    I    J  \n");
            Console.ResetColor();

            for (int i = 1; i < 11; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t" + i);
                Console.ResetColor();

                for (int j = 1; j < 11; j++)
                {
                    Coordinate shotCoordinate = new Coordinate(j,i);
                    if (board.ShotHistory.ContainsKey(shotCoordinate))
                    {
                        if (board.ShotHistory[shotCoordinate] == ShotHistory.Miss)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            if (i == 10 && j == 1)
                            {
                                Console.Write("  M ");
                            }
                            else
                            {
                                Console.Write("   M ");
                            }
                        }

                        else if (board.ShotHistory[shotCoordinate] == ShotHistory.Hit)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (i == 10 && j == 1)
                            {
                                Console.Write("  H ");
                            }
                            else
                            {
                                Console.Write("   H ");
                            }
                        }
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (i == 10 && j == 1)
                        {
                            Console.Write("  _ ");
                        }
                        else
                        {
                            Console.Write("   _ ");                            
                        }
                        Console.ResetColor();
                    }                
                }        
                Console.WriteLine("\n");
            }
            Console.ResetColor();
        }

        public void RequestPlayerName()
        {
            for (int i = 1; i < 3; i++)
            {
                while (!_validPlayerName)
                {                    
                    Console.Write("Player {0}, please enter your name: ", i);
                    if (i == 1)
                    {
                        _player1Name = Console.ReadLine();
                        Console.Write("Your name will be {0}. Is this correct (Y) or (N)? ", _player1Name);
                    }
                    else
                    {
                        _player2Name = Console.ReadLine();
                        Console.Write("Your name will be {0}. Is this correct (Y) or (N)? ", _player2Name);
                    }
                    _playerResponse = Console.ReadLine().ToUpper();
                    if (_playerResponse == "Y")
                    {
                        _validPlayerName = true;
                    }
                    else
                    {
                        _validPlayerName = false;
                    }                    
                }
                Console.Clear();
                _validPlayerName = false;
            }                                  
        }
        
        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship!\n\n" +
                              "This is a turn-based game in which you attempt to find and destroy your opponent's fleet.\n" +
                              "A fleet consists of Cruiser, Submarine, Destroyer, Battleship and Carrier, all statically placed in\n" +
                              "a 10x10 grid at the beginning of the game. Each turn, you will fire a shot by specifying first\n" +
                              "the column, then the row where you suspect a ship's location. Columns are identified by the letters\n" +
                              "A-I and rows by the numbers 1-10. A shot example is 'C7'. The program will respond with 'Hit' if\n" +
                              "your shot finds its mark and 'Miss' if it lands in an empty grid location. Note: the game will\n" +
                              "track each shot so that you do not duplicate a previous turn. The program will respond with 'Hit\n" +
                              "and Sunk' if your shot meets the damage threshold for each ship. The damage sustainable by each\n" +
                              "ship is as follows:\n\n" +
                              "Destroyer: 2 hits\n" +
                              "Cruiser: 3 hits\n" +
                              "Submarine: 3 hits\n" +
                              "Battleship: 4 hits\n" +
                              "Carrier: 5 hits\n\n" +
                              "The winner is the first player to sink all 5 of their opponent's ships.  Good luck!\n");                              
            Console.Write("Press any key to begin the game.");
            Console.ReadKey();
            Console.Clear();
        }        
    }
}
