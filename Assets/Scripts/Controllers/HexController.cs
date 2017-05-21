using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class HexController : MonoBehaviour
    {
        void Update()
        {
            var hexModel = MouseController.Instance.GetMouseOverHex();
            hexModel.selected = true;
        }
    }
}
