using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;
using HTC.UnityPlugin.Utility;
using HTC.UnityPlugin.Vive;
using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using GrabberPool = HTC.UnityPlugin.Utility.ObjectPool<Draggable.Grabber>;

public class Button : MonoBehaviour
{
    //public Canvas canvas;
    //public Canvas gameingCanvas;

    public void OnClick()
    {
        bool isView = !gameObject.activeSelf;//액티브 상태를 반환한다(켜져있는지 안켜져있는지)
        gameObject.SetActive(isView);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
