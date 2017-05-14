using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hex{
	public class Hex : MonoBehaviour {
		// Use this for initialization
		public HexCoord HexCoord;
		public bool Selected, previouslySelected = false;
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			if(Selected){
				GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,.3f);
			}else if(previouslySelected){
				GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
			}
			previouslySelected = Selected;
			Selected = false;
		}

		void OnDrawGizmos()
		{
			this.transform.GetComponentInChildren<TextMesh>().text = HexCoord.ToString();
		}
	}
}