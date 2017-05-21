using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Application : MonoBehaviour {
    [HideInInspector]
    public ApplicationModel model;
    [HideInInspector]
    public ApplicationView view;
    [HideInInspector]
    public ApplicationController controller;

    void Start()
    {
        model = GameObject.FindObjectOfType<ApplicationModel>();
        view = GameObject.FindObjectOfType<ApplicationView>();
        controller = GameObject.FindObjectOfType<ApplicationController>();
    }
}
