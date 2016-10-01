using UnityEngine;
using System.Collections;

public class RoomCallerLst {

	public int Direction;
	public int tipe;
	public int WallPos;

	public RoomCallerLst(int newDirection,int newTipe, int newWallPos)
	{
		Direction=newDirection;
		tipe=newTipe;
		WallPos=newWallPos;
	}
}
