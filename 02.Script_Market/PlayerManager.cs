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
using Random = UnityEngine.Random;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;


    public AudioClip clip;

    public Canvas list1;
    public Canvas list2;
    public int ran;

    public Text scoreText;
    public Text endscoreText;

   
    float time;
    public Canvas endCanvas;
    public Canvas gameingCanvas;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ListOnClick()
    {
        //bool isView = !gameObject.activeSelf;//액티브 상태를 반환한다(켜져있는지 안켜져있는지)
        //gameObject.SetActive(isView);
    }

    public void OnStart()
    {
        int ran = Random.Range(0, 2);

        switch (ran)
        {
            case 0:
                list1.gameObject.SetActive(true);
                list2.gameObject.SetActive(false);
                if (gameObject.CompareTag("List1"))
                {

                    gameObject.SetActive(false);

                    // 올바른 물건을 잡았을 시 점수 125 증가
                    Basket.instance.score += 125;
                    scoreText.text = "점수 : " + Basket.instance.score.ToString();

                }
                else
                {
                    gameObject.SetActive(false);
                    if (Basket.instance.score > 30)
                    {
                        Basket.instance.score -= 30;
                    }
                    else
                    {
                        Basket.instance.score = 0;
                    }
                    scoreText.text = "점수 : " + Basket.instance.score.ToString();
                }
                
                break;
            case 1:
                list1.gameObject.SetActive(false);
                list2.gameObject.SetActive(true);
               
                if (gameObject.CompareTag("List2"))
                {
                    gameObject.SetActive(false);

                    // 올바른 물건을 잡았을 시 점수 125 증가
                    Basket.instance.score += 125;
                    scoreText.text = "점수 : " + Basket.instance.score.ToString();

                }
                else
                {

                    // 적절하지 않은 물건을 잡았을 시 점수 30 감소
                    Basket.instance.score -= 30;
                    //scoreText.text = "SCORE : " + score.ToString();
                }
                break;

        }
    }

    public void GoSelect()
    {
        SceneManager.LoadScene("GameSelect");

    }

    //void OnTriggerEnter(Collider col)
    //{   
    //    if (col.gameObject.tag == "List1")
    //    {
    //        gameObject.SetActive(false);

    //        // 올바른 물건을 잡았을 시 점수 125 증가
    //        score += 125;
    //        scoreText.text = "SCORE : " + score.ToString();      
    //        //Destroy(col.gameObject);

    //    }
    //    else if(col.gameObject.tag == "List2")
    //    {
    //        gameObject.SetActive(false);

    //        // 올바른 물건을 잡았을 시 점수 125 증가
    //        score += 125;
    //        scoreText.text = "SCORE : " + score.ToString();
    //        //Destroy(col.gameObject);

    //    }

    //}

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {

        if (eventArgs.target.CompareTag("Start"))
        {
            OnStart();

        }

    }
  /*  public IEnumerator TimeAttack()
    {
        time = 31;
        while (true)
        {
            time -= 1;
            timeText.text = string.Format("{0:#,#}", "TIME : " + time);

            yield return new WaitForSeconds(1f);

            if (time < 1)
            {
                StopAllCoroutines();
                endscoreText.text = "점수   :   " + HighScore.instance.score.ToString();  // 싱글톤 패턴을 사용하여 포인터핸들러의 score을 가져온다.
                endCanvas.gameObject.SetActive(true);  // 결과물 canvas를 띄운다.
                gameingCanvas.gameObject.SetActive(false);
            }
        }

    }
    */
}
