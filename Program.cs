using System;
using System.Collections.Generic;
using Game.Models;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      //Create a new chess board
      int[,] chessBoard = new int[7, 7];
      int queenXCoord = coordinatePrompt("X", "Queen");
      int queenYCoord = coordinatePrompt("Y", "Queen");
      int chessXCoord = coordinatePrompt("X", "Random Chess Piece");
      int chessYCoord = coordinatePrompt("Y", "Random Chess Piece");

      ChessPiece newQueen = new ChessPiece(queenXCoord, queenYCoord);
      ChessPiece newRandomPiece = new ChessPiece(chessXCoord, chessYCoord);
      bool yesAttack = newQueen.QueenAttack(newQueen.YCoord, newQueen.XCoord, newRandomPiece.YCoord, newRandomPiece.XCoord);
      if (yesAttack == true)
      {
        Console.WriteLine("Your queen can attack!");
      }
      else
      {
        Console.WriteLine("Sorry, no attack can be made there, champ");
      }
    }

    public static int coordinatePrompt(string coordinate, string chessPiece) {
      Console.Write($"Input {coordinate} coordinates for {chessPiece} ({coordinate}): ");
      int numCoordinate = int.Parse(Console.ReadLine());
      while (numCoordinate > 8)
      {
        Console.Write("Please input valid coordinates between 1 and 8: ");
        numCoordinate = int.Parse(Console.ReadLine());
      }
      return numCoordinate;
    }
  }

}

