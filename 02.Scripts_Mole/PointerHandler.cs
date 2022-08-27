using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;

public class PointerHandler : MonoBehaviour
{

    public static PointerHandler instance;

    public SteamVR_LaserPointer laserPointer;
    public Text scoreText;
    public GameObject hitEffect;
    public Canvas canvas;
    public Canvas gamingCanvas;

    public AudioClip clip;

    public int score;
    //public GameObject particle;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        laserPointer.PointerClick += PointerClick;
        score = 0;
    }

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {

        if (eventArgs.target.CompareTag("Monster"))
        {
            
            eventArgs.target.gameObject.SetActive(false);

            // 몬스터를 잡으면 점수 125 증가
            score += 125;
            scoreText.text = "SCORE  :  " + score.ToString();

            // hitEffect 파티클을 몬스터 위치에 생성
            // 2초 후 파괴
            GameObject hiteff = Instantiate(hitEffect);
            hiteff.transform.position = eventArgs.target.gameObject.transform.position;
            Destroy(hiteff, 2f);

            SoundManager.instance.SFXPlay("MoleCatch",clip);        // 두더지 잡는 사운드 재생

            
        }

        if (eventArgs.target.CompareTag("Play"))
        {
            MonsterManager.instance.StartCoroutine("TimeAttack");
            canvas.gameObject.SetActive(false);
            gamingCanvas.gameObject.SetActive(true);

            MonsterManager.instance.interval1 = 1.8f;
            MonsterManager.instance.interval2 = 2.3f;
            MonsterManager.instance.StartCoroutine("monster1Up");
            MonsterManager.instance.StartCoroutine("monster2Up");

        }

        if (eventArgs.target.CompareTag("Exit"))
        {
            // 게임 선택 씬으로 이동
            SceneManager.LoadScene("GameSelect");
        }

        if (eventArgs.target.CompareTag("Replay"))
        {

            SceneManager.LoadScene("Mole_Game");
           
        }
    }
}
