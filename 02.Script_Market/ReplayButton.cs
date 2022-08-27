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

public class ReplayButton : MonoBehaviour
{
    public void Replay()
    {
        //SceneManager.LoadScene(4);
        SceneManager.LoadScene("Market");

    }

    public void Exit()
    {
        //메인화면으로 나가기
        SceneManager.LoadScene("GameSelect");
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
