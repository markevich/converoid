using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Hex{
	[Serializable]
	public class HexPosition {
		//Q - column
		public int Q;
		//R - row
		public int R;
		public int S;
		public HexPosition(int column, int row){
			this.Q = column;
			this.R = row;
			this.S = -( column + row );
		}

		public Vector3 Position(){
			var x = HexHorizontalSpacing * (this.Q + this.R/2f);
			var y = HexVerticalSpacing * this.R;

			return new Vector3(x, y ,0);
		}

		private readonly float WIDTH_MULTIPLIER = Mathf.Sqrt(3)/2f;
		public float HexWidth{
			get { return WIDTH_MULTIPLIER * HexHeight; }
		}
		public int HexHeight{
			get{
				//radius(1) * 2
				return 2;
			}
		}
		public float HexVerticalSpacing{
			get{
				//HexHeight * 0.75f
				return 1.5f;
			}
		}

		public float HexHorizontalSpacing{
			get { return HexWidth; }
		}

		public override string ToString(){
			return Q + " " + R;
		}
	}
}