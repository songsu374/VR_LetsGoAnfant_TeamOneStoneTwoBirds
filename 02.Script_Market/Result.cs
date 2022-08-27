using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class Result : MonoBehaviour
{
    [SerializeField] Text uiText; //UITEXT 컴포넌트
    [SerializeField] Text highText; //HIGHSCORE 컴포넌트


    [SerializeField] GameObject result;

    int endSocre; //점수
    private int savedScore = 0; //최고 점수 

    void Awake()
    {
        savedScore = PlayerPrefs.GetInt("savescore", 0); //최고 점수 가져오기
        highText.text = string.Format("최고 점수 : {0:D2}점", savedScore.ToString("0"));
    }

    // Start is called before the first frame update
    void Start()
    {

        
        result.SetActive(false);
        //GameOver.SetActive(false);
        //GameStart.SetActive(true);
        Invoke("D", 60f);
    }

    void D()
    {
        result.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        endSocre = Basket.instance.score; //게임 점수 가져오기

        uiText.text = string.Format("점수 : {0:D2}점", endSocre.ToString("0"));

        if (endSocre > savedScore)
        {
            PlayerPrefs.SetInt("savescore", endSocre); //savedScore 보다 result 값이 크면 savescore에 값 지정 후 저장
            PlayerPrefs.Save();
        }

        //if (GameObject.Find("Time").GetComponent<Timer>().currentTime == 0.0f)
        //{
        //    Invoke("D",60f);
        //    //result.SetActive(true);
        //    //GameOver.SetActive(true);
        //}
    }
}

