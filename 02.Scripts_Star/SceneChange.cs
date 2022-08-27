using UnityEngine;
using Valve.VR.Extras;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    public AudioClip clip;

    public GameObject East;
    public GameObject West;
    public GameObject South;
    public GameObject North;

    public GameObject Eastbtn;
    public GameObject Westbtn;
    public GameObject Southbtn;
    public GameObject Northbtn;

    void Start()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {

        //동쪽 - 별 게임
        if (eventArgs.target.CompareTag("East"))
        {
            East.gameObject.SetActive(true);

            Eastbtn.gameObject.SetActive(false);
            Westbtn.gameObject.SetActive(false);
            Southbtn.gameObject.SetActive(false);
            Northbtn.gameObject.SetActive(false);

            SoundManager.instance.SFXPlay("BtnClick", clip);
        }

        if (eventArgs.target.CompareTag("EastPlay"))
        {
            SceneManager.LoadScene("StarUI");
        }

        if (eventArgs.target.CompareTag("EastPrev"))
        {
            East.gameObject.SetActive(false);

            Eastbtn.gameObject.SetActive(true);
            Westbtn.gameObject.SetActive(true);
            Southbtn.gameObject.SetActive(true);
            Northbtn.gameObject.SetActive(true);

            SoundManager.instance.SFXPlay("BtnClick", clip);
        }


        //서쪽 - 행성 몬스터
        if (eventArgs.target.CompareTag("West"))
        {
            West.gameObject.SetActive(true);

            Eastbtn.gameObject.SetActive(false);
            Westbtn.gameObject.SetActive(false);
            Southbtn.gameObject.SetActive(false);
            Northbtn.gameObject.SetActive(false);

            SoundManager.instance.SFXPlay("BtnClick", clip);
        }

        if (eventArgs.target.CompareTag("WestPlay"))
        {
            SceneManager.LoadScene("Mole_Game");
        }

        if (eventArgs.target.CompareTag("WestPrev"))
        {
            West.gameObject.SetActive(false);

            Eastbtn.gameObject.SetActive(true);
            Westbtn.gameObject.SetActive(true);
            Southbtn.gameObject.SetActive(true);
            Northbtn.gameObject.SetActive(true);

            SoundManager.instance.SFXPlay("BtnClick", clip);
        }


        //남쪽 - 두더지 게임
        if (eventArgs.target.CompareTag("South"))
        {
            South.gameObject.SetActive(true);

            Eastbtn.gameObject.SetActive(false);
            Westbtn.gameObject.SetActive(false);
            Southbtn.gameObject.SetActive(false);
            Northbtn.gameObject.SetActive(false);

            SoundManager.instance.SFXPlay("BtnClick", clip);
        }

        if (eventArgs.target.CompareTag("SouthPlay"))
        {
            SceneManager.LoadScene("Market");
        }

        if (eventArgs.target.CompareTag("SouthPrev"))
        {
            South.gameObject.SetActive(false);

            Eastbtn.gameObject.SetActive(true);
            Westbtn.gameObject.SetActive(true);
            Southbtn.gameObject.SetActive(true);
            Northbtn.gameObject.SetActive(true);

            SoundManager.instance.SFXPlay("BtnClick", clip);
        }



        //북쪽 - 퍼즐
        if (eventArgs.target.CompareTag("North"))
        {
            North.gameObject.SetActive(true);

            Eastbtn.gameObject.SetActive(false);
            Westbtn.gameObject.SetActive(false);
            Southbtn.gameObject.SetActive(false);
            Northbtn.gameObject.SetActive(false);

            SoundManager.instance.SFXPlay("BtnClick", clip);
        }

        if (eventArgs.target.CompareTag("NorthPlay"))
        {
            SceneManager.LoadScene("North_Title");
        }

        if (eventArgs.target.CompareTag("NorthPrev"))
        {
            North.gameObject.SetActive(false);

            Eastbtn.gameObject.SetActive(true);
            Westbtn.gameObject.SetActive(true);
            Southbtn.gameObject.SetActive(true);
            Northbtn.gameObject.SetActive(true);

            SoundManager.instance.SFXPlay("BtnClick", clip);
        }

        // 메인 화면으로 돌아가기
        if (eventArgs.target.CompareTag("GoHome"))
        {
            SceneManager.LoadScene("TitleScene");

            SoundManager.instance.SFXPlay("BtnClick", clip);
        }

        
    }
}
