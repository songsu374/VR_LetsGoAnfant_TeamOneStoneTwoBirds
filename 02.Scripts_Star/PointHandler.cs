using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Valve.VR.Extras;
using Valve.VR;
using Debug = UnityEngine.Debug;
using UnityEngine.UI;

public class PointHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    [SerializeField] int point = 10;
    Score score;
    public SteamVR_Action_Vibration hapticAction;

    

    // Start is called before the first frame update
    void Start()
    {
        laserPointer.PointerClick += PointerClick;
        var gameObj = GameObject.FindWithTag("Score");
        score = gameObj.GetComponent<Score>();
        
    }

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {

        if (GameObject.Find("pCylinder1").GetComponent<StarChange>().ran == 0)
        {
            if (eventArgs.target.CompareTag("red"))
            {
                score.AddScore(point);
                GameObject.Find("pCylinder1").GetComponent<StarChange>().Start();
            }
            else
            {
                PlayVibration();
               
            }
        }
        else if (GameObject.Find("pCylinder1").GetComponent<StarChange>().ran == 1)
        {
            if (eventArgs.target.CompareTag("yellow"))
            {
                score.AddScore(point);
                GameObject.Find("pCylinder1").GetComponent<StarChange>().Start();
            }
            else
            {
                PlayVibration();
               
            }
        }
        else if (GameObject.Find("pCylinder1").GetComponent<StarChange>().ran == 2)
        {
            if (eventArgs.target.CompareTag("green"))
            {
                score.AddScore(point);
                GameObject.Find("pCylinder1").GetComponent<StarChange>().Start();
            }
            else
            {
                PlayVibration();
                
            }
        }
        else if (GameObject.Find("pCylinder1").GetComponent<StarChange>().ran == 3)
        {
            if (eventArgs.target.CompareTag("blue"))
            {
                score.AddScore(point);
                GameObject.Find("pCylinder1").GetComponent<StarChange>().Start();
            }
            else
            {
                PlayVibration();
               
            }
        }
    }
   
    public void PlayVibration()
    {
        Pulse(1, 150, 75, SteamVR_Input_Sources.LeftHand);
        Pulse(1, 150, 75, SteamVR_Input_Sources.RightHand);
    }

    private void Pulse(float duration, float frequency, float amplitude, SteamVR_Input_Sources source)
    {
        hapticAction.Execute(0, duration, frequency, amplitude, source);
        Debug.Log("Pulse" + source.ToString());
    }
}