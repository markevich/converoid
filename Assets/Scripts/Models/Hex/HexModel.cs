using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models{
    public class HexModel : MonoBehaviour {
        // Use this for initialization
        public HexCoordModel hexCoordModel;
        public bool selected = false;
        void Start () {
            
        }
        
        // Update is called once per frame
        void FixedUpdate () {
            selected = false;
        }

    }
}