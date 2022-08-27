using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int currentScore; //현재점수
    public static int extraScore; //큐브 정답 맞을때 점수 public이용 공유자원되어서 어디서든 extrascore 사용가능

    [SerializeField] Text txt_Score;
    private void Awake()
    {
        // 클래스를 인스턴스화하면 Awake()함수에 해당 스크립트를 꼭 넣어주어야 함
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        currentScore = extraScore; //현재점수에 맞추면 점수추가
        txt_Score.text = currentScore.ToString(); //text를currentScore로 바꿔줌 
    }
}
