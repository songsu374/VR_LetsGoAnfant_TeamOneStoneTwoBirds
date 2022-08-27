using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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

//[RequireComponent(typeof(Text))]

public class HighScore : MonoBehaviour
{
    public static HighScore instance;

    public Text scoreText; //RESULTEXT 컴포넌트 (게임 점수 Text 넣기)
    public Text highText; //HIGHSCORE 컴포넌트 (최고 점수 Text 넣기)

    public int score;

    int result; //점수
    private int savedScore = 0; //최고 점수 

    float time;
    public Canvas endCanvas;
    public Canvas gameingCanvas;
    public Text timeText;
   
    

    //public Text endscoreText;

    void Awake()
    {
        //savedScore = PlayerPrefs.GetInt("savescore", 0); //최고 점수 값 반환
        //highText.text = string.Format("최고 점수 : {0:D2}점", savedScore);
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        highText = GetComponent<Text>();

    }
    // Update is called once per frame
    void Update()
    {
        //result = GameObject.Find("score").GetComponent<Score>().Points; //게임 점수 가져오기

        //scoreText.text = string.Format("점수 : {0:D2}점", result); // 게임 점수 출력(실행 안됨)

        //if (result > savedScore)
        //{
        //    PlayerPrefs.SetInt("southscore", result); //savedScore 보다 result 값이 크면 southscore에(키) 값 지정 후 저장
        //    PlayerPrefs.Save(); //저장
        //}

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Start")
        {
            endCanvas.gameObject.SetActive(false);
            gameingCanvas.gameObject.SetActive(true);
        }
    }
}