using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hex{
	public class Hex : MonoBehaviour {
		// Use this for initialization
		public HexPosition HexPosition;
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}

		void OnDrawGizmos()
		{
			this.transform.GetComponentInChildren<TextMesh>().text = HexPosition.ToString();
		}
	}
}