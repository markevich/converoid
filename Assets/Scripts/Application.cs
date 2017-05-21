using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Application : MonoBehaviour {
    [HideInInspector]
    public Models.Application rootModel;
    [HideInInspector]
    public Views.Application rootView;
    [HideInInspector]
    public Controllers.Application rootController;

    private List<Controllers.Application> AllControllers;
    void Start()
    {
        AllControllers = new List<Controllers.Application>();

        rootModel = GameObject.FindObjectOfType<Models.Application>();
        rootView = GameObject.FindObjectOfType<Views.Application>();
        rootController = GameObject.FindObjectOfType<Controllers.Application>();

        AllControllers.Add(rootController);

    }

    // Iterates all Controllers and delegates the notification data
    // This method can easily be found because every class is “BounceElement” and has an “app” 
    // instance.
    public void Notify(string p_event_path, Object p_target, params object[] p_data)
    {
        foreach(var c in AllControllers)
        {
            c.OnNotification(p_event_path,p_target,p_data);
        }
    }
}
