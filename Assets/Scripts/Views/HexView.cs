using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models;

namespace Views
{
    public class HexView : MonoBehaviour
    {
        private HexModel model;
        void Start(){
            model = GetComponent<HexModel>();
        }

        /// <summary>
        /// Update is called every frame, if the MonoBehaviour is enabled.
        /// </summary>
        void Update()
        {
            if(model.selected){
                GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,.3f);
            } else
            {
                GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
            }
        }
        void OnDrawGizmos()
        {
            this.transform.GetComponentInChildren<TextMesh>().text = model.hexCoordModel.ToString();
        }
    }
}

