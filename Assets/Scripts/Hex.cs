using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex {
	//Q - column
	public int Q;
	//R - row
	public int R;
	public int S;

	public int radius = 1;
	public Hex(int column, int row){
		this.Q = column;
		this.R = row;
		this.S = -( column + row );
	}

	public Vector3 Position(){
		var x = HexHorizontalSpacing() * (this.Q + this.R/2f);
		var y = HexVerticalSpacing() * this.R;

		return new Vector3(x, y ,0);
	}

	public float HexWidth(){
		return Mathf.Sqrt(3)/2f * HexHeight();
	}
	public int HexHeight(){
		return radius * 2;
	}
	public float HexVerticalSpacing(){
		return HexHeight() * 0.75f;
	}

	public float HexHorizontalSpacing(){
		return HexWidth();
	}
}
