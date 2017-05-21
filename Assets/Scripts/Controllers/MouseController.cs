using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models;

namespace Controllers
{

    public class MouseController : MonoBehaviour
    {
        // The world-position of the mouse last frame.
        private Vector3 currentFramePosition;
        public static MouseController Instance;

        void Start()
        {
            if(Instance == null)
            {
                Instance = this;
            }
        }
        void Update()
        {
            currentFramePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        /// <summary>
        /// Gets the mouse position in world space.
        /// </summary>
        public Vector3 MousePosition
        {
            get { return currentFramePosition; }
        }

        public HexModel GetMouseOverHex()
        {
            return HexWorldController.Instance.GetHexAtWorldCoord(MousePosition);
        }
    }
}
