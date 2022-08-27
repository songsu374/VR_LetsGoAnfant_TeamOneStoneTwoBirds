using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class ResultUi : MonoBehaviour
{
    [SerializeField] GameObject Result;
    [SerializeField] GameObject GameOver;
    [SerializeField] GameObject GameStart;
    [SerializeField] Text resultText; //RESULTTEXT 컴포넌트

    // Start is called before the first frame update
    void Start()
    {
        Result.SetActive(false);
        GameOver.SetActive(false);
        GameStart.SetActive(true);
        Invoke("D", 1f);
    }

    void D()
    {
        GameStart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.Find("RemainTimer").GetComponent<RemainTimer>().currentTime <= 0.0f)
        {
            Result.SetActive(true);
            GameOver.SetActive(true);
            resultText.text = string.Format("점수 : {0:D2}점", Score.instance.Points);

            Time.timeScale = 0;         // 일시정지
        }
    }
}
