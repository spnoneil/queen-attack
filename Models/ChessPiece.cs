using System;

namespace Game.Models {
  
  public class ChessPiece {

    public int XCoord {get; set; }
    public int YCoord {get; set; }
    public ChessPiece(int xCoord, int yCoord)
    {
      XCoord = xCoord;
      YCoord = yCoord;
    }

  }
}