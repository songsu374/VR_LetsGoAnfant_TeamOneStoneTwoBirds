using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using UnityEngine.SceneManagement; //씬ㄴ 이동

public class NorthChanger : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    // Start is called before the first frame update
    void Start()
    {
        laserPointer.PointerClick += PointerClick;
    }
    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {
        if (eventArgs.target.CompareTag("startbutton"))
        {
            SceneManager.LoadScene("North_Game");
        }

        // 나가기 버튼을 누르면 게임 선택 창으로 이동
        if (eventArgs.target.CompareTag("backbutton"))
        {
            SceneManager.LoadScene("GameSelect");
        }
    }
  
}
