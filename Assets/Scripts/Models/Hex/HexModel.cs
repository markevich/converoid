using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models{
    public class HexModel : MonoBehaviour {
        // Use this for initialization
        public HexCoordModel hexCoordModel;
        public bool selected, previouslySelected = false;
        void Start () {
            
        }
        
        // Update is called once per frame
        void Update () {
            if(selected){
                GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,.3f);
            }else if(previouslySelected){
                GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
            }
            previouslySelected = selected;
            selected = false;
        }

    }
}