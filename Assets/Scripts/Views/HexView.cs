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
        void OnDrawGizmos()
        {
            this.transform.GetComponentInChildren<TextMesh>().text = model.hexCoordModel.ToString();
        }
    }
}

