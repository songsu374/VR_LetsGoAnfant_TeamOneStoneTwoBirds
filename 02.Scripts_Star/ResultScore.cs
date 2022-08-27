using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ResultScore : MonoBehaviour
{

    [SerializeField] Text highText; //HIGHSCORE 컴포넌트
    public Text scoreRenew;

    int result; //점수
    private int savedScore = 0; //최고 점수 

    void Awake()
    {
        savedScore = PlayerPrefs.GetInt("eastscore", 0); //최고 점수 값 반환
        highText.text = string.Format("최고 점수 : {0:D2}점", savedScore);
    }

    // Start is called before the first frame update
    void Start()
    {
        highText = GetComponent<Text>();

    }
    // Update is called once per frame
    void Update()
    {
        result = Score.instance.Points; //게임 점수 가져오기

        if (result > savedScore)
        {
            PlayerPrefs.SetInt("eastscore", result); //savedScore 보다 result 값이 크면 eastcore에(키) 값 지정 후 저장
            PlayerPrefs.Save(); //저장
            scoreRenew.gameObject.SetActive(true);
        }

    }
}
