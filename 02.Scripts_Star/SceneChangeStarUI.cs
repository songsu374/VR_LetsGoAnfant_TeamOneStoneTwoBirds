using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Valve.VR.Extras;

public class SceneChangeStarUI : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    // Start is called before the first frame update
    void Start()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {

        if (eventArgs.target.CompareTag("play"))
        {
            SceneManager.LoadScene("Star_game");
        }

        if (eventArgs.target.CompareTag("Back"))
        {
            SceneManager.LoadScene("GameSelect");
        }
    }
}
