using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;

public class SceneChangeNorthResult : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    // Start is called before the first frame update
    void Start()
    {
        laserPointer.PointerClick += PointerClick;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {

        //다시하기
        if (eventArgs.target.CompareTag("Retry"))
        {
            SceneManager.LoadScene("North_Title");
        }

        //게임 선택 창으로 나가기
        if (eventArgs.target.CompareTag("backbutton"))
        {
            SceneManager.LoadScene("GameSelect");
        }
    }
}
