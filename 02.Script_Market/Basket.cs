using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;
using HTC.UnityPlugin.Utility;
//using HTC.UnityPlugin.Vive;
using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using GrabberPool = HTC.UnityPlugin.Utility.ObjectPool<Draggable.Grabber>;


[RequireComponent(typeof(Text))]
public class Basket : MonoBehaviour
{

    public static Basket instance;

    Text uiText; //UITEXT 컴포넌트
    public Text scoreText;

    public int Points { get; private set; } //현재 점수의 컴포넌트

    public int score;

    float time;
    public Canvas endCanvas;
    public Canvas gameingCanvas;
    public Text timeText;

    public AudioClip clip;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
    }

    public void AddScore(int score)
    {
        Points += score; //현재 포인트에 더함

        uiText.text = string.Format("점수 : {0:D2}점", Points);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "List1")
        {


            // 올바른 물건을 잡았을 시 점수 125 증가
            score += 125;
            scoreText.text = "점수 : " + score.ToString();

            SoundManager.instance.SFXPlay("MoleCatch", clip);

            Destroy(col.gameObject);
            if (score == 500)
            {
                
            }

      
        }
        else if (col.gameObject.tag == "List2")
        {
            col.gameObject.SetActive(false);

            // 올바른 물건을 잡았을 시 점수 125 증가
            score += 125;
            scoreText.text = "점수 : " + score.ToString();
            Destroy(col.gameObject);

            SoundManager.instance.SFXPlay("MoleCatch", clip);
        }

    }

}
