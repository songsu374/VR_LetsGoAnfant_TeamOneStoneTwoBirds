using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NorthResult : MonoBehaviour
{
    int northscore;
    [SerializeField] Text northText;

    // Start is called before the first frame update
    void Start()
    {
        northscore = ScoreManager.instance.currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        northText.text = string.Format("맞춘 개수 : {0:D2}개", northscore);
    }
}

