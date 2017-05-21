using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models;
using Controllers;
using Views;

public class Application : MonoBehaviour {
    [HideInInspector]
    public ApplicationModel rootModel;
    [HideInInspector]
    public ApplicationView rootView;
    [HideInInspector]
    public ApplicationController rootController;

    private List<ApplicationController> allControllers;

    public static Application Instance { get; protected set; }
    void Start()
    {
        allControllers = new List<ApplicationController>();

        rootModel = GameObject.FindObjectOfType<ApplicationModel>();
        rootView = GameObject.FindObjectOfType<ApplicationView>();
        rootController = GameObject.FindObjectOfType<ApplicationController>();

        allControllers.Add(rootController);

    }

    // Iterates all Controllers and delegates the notification data
    // This method can easily be found because every class is “BounceElement” and has an “app” 
    // instance.
    public void Notify(string p_event_path, Object p_target, params object[] p_data)
    {
        foreach(var c in allControllers)
        {
            c.OnNotification(p_event_path,p_target,p_data);
        }
    }
}
