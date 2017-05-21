using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class ApplicationController: MonoBehaviour
    {
        public void OnNotification(string p_event_path, Object p_target, params object[] p_data)
        {
            Debug.LogError(string.Format("Received unexpected event {0}", p_event_path));
        }
    }
}

