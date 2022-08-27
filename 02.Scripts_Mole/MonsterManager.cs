using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterManager : MonoBehaviour
{
    public static MonsterManager instance;

    public GameObject[] mon1;
    public GameObject[] mon2;
    int m;
    int n;
    public float interval1;
    public float interval2;

    public float time;
    public Canvas endCanvas;
    public Canvas gamingCanvas;
    public Text timeText;
    public Text endscoreText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);  /// ????
        }
    }

    void Start()
    {
        time = 31;
        //interval1 = 1.8f;
        //interval2 = 2.3f;

        //StartCoroutine("monster1Up");
        //StartCoroutine("monster2Up");

        //StartCoroutine("TimeAttack");
    }



    IEnumerator monster1Up()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval1);
            m = Random.Range(0, mon1.Length);
            if (!mon1[m].activeSelf)
            {
                mon1[m].SetActive(true);
                //Invoke("DisableObj",0.7f);
            }
        }
    }

    IEnumerator monster2Up()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval2);
            n = Random.Range(0, mon2.Length);
            if (!mon2[n].activeSelf)
            {
                mon2[n].SetActive(true);
                //Invoke("DisableObj",0.7f);
            }
        }
    }

    public IEnumerator TimeAttack()
    {
        
        while (true)
        {
            time -= 1;
            timeText.text = string.Format("{0:#,#}", "남은 시간  :  " + time + " 초");

            yield return new WaitForSeconds(1f);

            //if (time < 1)
            //{
            //    StopAllCoroutines();
            //    endscoreText.text = "점수   :   " + PointerHandler.instance.score.ToString();  // 싱글톤 패턴을 사용하여 포인터핸들러의 score을 가져온다.
            //    endCanvas.gameObject.SetActive(true);  // 결과물 canvas를 띄운다.
            //    //gamingCanvas.gameObject.SetActive(false);
            //}
        }
    }

    private void Update()
    {
        if (time < 1)
        {
            StopAllCoroutines();
            endscoreText.text = "점수   :   " + PointerHandler.instance.score.ToString() + " 점"; // 싱글톤 패턴을 사용하여 포인터핸들러의 score을 가져온다.
            endCanvas.gameObject.SetActive(true);  // 결과물 canvas를 띄운다.
            gamingCanvas.gameObject.SetActive(false);
        }
    }

}
