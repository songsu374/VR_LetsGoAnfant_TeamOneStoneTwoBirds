using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.Extras;

public class ImageChange : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    public Sprite EastImage; //동쪽 이미지
    public Sprite WestImage; //서쪽 이미지
    public Sprite SouthImage; //남쪽 이미지
    public Sprite NorthImage; //북쪽 이미지
    public Image ImageRender;
    int count = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        laserPointer.PointerClick += PointerClick;
        ImageRender.sprite = EastImage;
    }

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {
        if (eventArgs.target.CompareTag("next"))
        {
            count = count + 1;
            if (count == 1)
            {
                ImageRender.sprite = WestImage;
            }
            else if (count == 2)
            {
                ImageRender.sprite = SouthImage;
            }
            else if (count == 3)
            {
                ImageRender.sprite = NorthImage;
            }

        }
        else if (eventArgs.target.CompareTag("before"))
        {
            count = count - 1;
            if (count == 2)
            {
                ImageRender.sprite = SouthImage;
            }
            else if (count == 1)
            {
                ImageRender.sprite = WestImage;
            }
            else if (count == 0)
            {
                ImageRender.sprite = EastImage;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}