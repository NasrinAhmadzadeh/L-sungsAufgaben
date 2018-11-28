using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Vehicle
    {
        private Position _position;
        public Position Position { get { return _position; } set { _position = value; } }

        public Vehicle(Position initialPositon)
        {
            _position = initialPositon;
        }
        public void RunMultipleCommand(string commands, int gridSize)
        {

            char[] commandsArray = commands.ToCharArray();
            for (int i = 0; i < commandsArray.Length; i++)
            {

                RunSingleCommand(commandsArray[i], gridSize);
            }
        }
        private void RunSingleCommand(char cammand, int gridSize)
        {
            switch (cammand.ToString().ToUpper())
            {
                case "F":
                    {
                        MoveForward(gridSize);
                        break;
                    }
                case "B":
                    {
                        MoveBack(gridSize);
                        break;
                    }
                case "L":
                    {
                        // MoveLeft(gridSize);
                        TurnLeft(Direction.W);
                        break;
                    }
                case "R":
                    {
                        //MoveRight(gridSize);
                        TurnRight(Direction.E);
                        break;
                    }

                default:

                    break;
            }

        }
        private void MoveBack(int gridSize)
        {

            if (_position.Dire == Direction.N)
            {
                _position.Y--;
                if (_position.Y < 0)
                {
                    _position.Y = gridSize - 1;
                }
            }
            else if (_position.Dire == Direction.S)
            {
                _position.Y++;
                if (_position.Y > gridSize - 1)
                {
                    _position.Y = 0;

                }
            }
            else if (_position.Dire == Direction.W)
            {
                _position.X++;
                if (_position.X > gridSize - 1)
                {
                    _position.X = 0;
                }
            }
            else
            {
                _position.X--;

                if (_position.X < 0)
                {
                    _position.X = gridSize - 1;
                }
            }


            Console.WriteLine("Rover bewegt sich nach Hinten und die neue Position ist (" + Position.X + "," + Position.Y + ")");

        }

        private void MoveForward(int gridSize)
        {
            if (_position.Dire == Direction.N)
            {
                _position.Y++;
                if (_position.Y > (gridSize - 1))
                {
                    _position.Y = 0;
                }
            }
            else if (_position.Dire == Direction.S)
            {
                _position.Y--;
                if (_position.Y < 0)
                {
                    _position.Y = gridSize - 1;

                }
            }
            else if (_position.Dire == Direction.W)
            {
                _position.X--;
                if (_position.X < 0)
                {
                    _position.X = gridSize - 1;
                }
            }
            else
            {
                _position.X++;

                if (_position.X > gridSize - 1)
                {
                    _position.X = 0;
                }
            }


            Console.WriteLine("Rover bewegt sich nach vorne und die neue Position ist (" + Position.X + "," + Position.Y + ")");

        }

        //void Turn(Direction dire)
        //{
        //    _position.Dire = dire;
        //}
        void TurnLeft(Direction dire)
        {
            if (_position.Dire == Direction.W)
            {
                _position.Dire = Direction.S;
            }
            else if (_position.Dire == Direction.E)
            {
                _position.Dire = Direction.N;
            }
            else
                _position.Dire = dire;
        }

        void TurnRight(Direction dire)
        {

            if (_position.Dire == Direction.E)
            {
                _position.Dire = Direction.S;


            }
            else if (_position.Dire == Direction.W)
            {
                _position.Dire = Direction.N;
            }
            else
                _position.Dire = dire;
        }

    }

}
