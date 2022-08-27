using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Score : MonoBehaviour
{
    public static Score instance;

    Text uiText; //UITEXT 컴포넌트

    public int Points; //현재 점수의 컴포넌트

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

    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
    }
    public void AddScore(int addPoint)
    {
        Points += addPoint; //현재 포인트에 더함

        uiText.text = string.Format("점수 : {0:D2}점", Points);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
