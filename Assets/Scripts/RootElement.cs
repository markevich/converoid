using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootElement : MonoBehaviour
{
    [HideInInspector]
    public Application app;
    void Start ()
    {
        app =  GameObject.FindObjectOfType<Application>();
    }
}
