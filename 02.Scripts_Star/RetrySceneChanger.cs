using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using UnityEngine.SceneManagement;

public class RetrySceneChanger : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    // Start is called before the first frame update
    void Start()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {
        if (eventArgs.target.CompareTag("retry"))
        {
            ReloadScene();

            Time.timeScale = 1;
        }

        if (eventArgs.target.CompareTag("Exit"))
        {
            SceneManager.LoadScene("GameSelect");
            Time.timeScale = 1;
        }
    }

    public void ReloadScene()
    {
        //현재의 씬을 취득
        var scene = SceneManager.GetActiveScene();

        //현재의 씬을 다시 로드한다.
        SceneManager.LoadScene("Star_game");
    }

}
