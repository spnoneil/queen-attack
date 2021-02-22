using System;
using System.Collections.Generic;

namespace Game.Models {
  
  public class ChessPiece {

    public int XCoord {get; set; }
    public int YCoord {get; set; }
    public ChessPiece(int xCoord, int yCoord)
    {
      XCoord = xCoord;
      YCoord = yCoord;
    }


    // The Queen class should have a method that takes X and a Y coordinate as arguments, 
    // and returns true if the queen can attack the given space, 
    // and false if it cannot.
    public bool QueenAttack(int queenY, int queenX,  int chessY, int chessX)
    { 
      int x = queenX - chessX;
      int y = queenY - chessY;
      bool ans =  false;
      // Console.WriteLine("X:" + x);
      // Console.WriteLine("Y: " + y);

      if(Math.Abs(x) == Math.Abs(y)) {
        ans = true;
      }

      if (queenY == chessY)
      {
        ans = true;
      }
      
      return ans;
    }
  }
}