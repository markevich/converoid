using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models;

namespace Views
{
    public class HexView : MonoBehaviour
    {
        private HexModel Model;
        void Start(){
            Model = GetComponent<HexModel>();
        }
        void OnDrawGizmos()
        {
            this.transform.GetComponentInChildren<TextMesh>().text = Model.HexCoordModel.ToString();
        }
    }
}

