using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models{
    public class HexModel : MonoBehaviour {
        // Use this for initialization
        public HexCoordModel HexCoordModel;
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

    }
}