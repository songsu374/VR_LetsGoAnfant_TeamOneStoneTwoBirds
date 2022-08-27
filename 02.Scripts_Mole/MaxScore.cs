using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;



[RequireComponent(typeof(Text))]
public class MaxScore : MonoBehaviour
{
    //[SerializeField] Text resultText;   //RESULTTEXT 컴포넌트 (게임 점수 Text 넣기)
    [SerializeField] Text highText;     //HIGHSCORE 컴포넌트 (최고 점수 Text 넣기)
    public Text scoreRenew;

    int result;     //점수
    private int savedScore = 0; //최고 점수 

    void Awake()
    {
        savedScore = PlayerPrefs.GetInt("southtest", 0);       //최고 점수 값 반환
        highText.text = string.Format("최고 점수 : {0:D2}점", savedScore);
    }

    // Start is called before the first frame update
    void Start()
    {
        //resultText = GetComponent<Text>();
        highText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //result = GameObject.Find("score").GetComponent<Score>().Points; //게임 점수 가져오기
        result = PointerHandler.instance.score;

        //resultText.text = string.Format("점수 : {0:D2}점", result); // 게임 점수 출력(실행 안됨)

        if (result > savedScore)
        {
            PlayerPrefs.SetInt("southtest", result);   //savedScore 보다 result 값이 크면 southcore에(키) 값 지정 후 저장
            PlayerPrefs.Save(); //저장
            scoreRenew.gameObject.SetActive(true);
        }

    }
}
