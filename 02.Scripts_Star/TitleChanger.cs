
using UnityEngine;
using Valve.VR.Extras;
using UnityEngine.SceneManagement;

public class TitleChanger : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    // Start is called before the first frame update
    void Start()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {
        if (eventArgs.target.CompareTag("start"))
        {
            SceneManager.LoadScene("GameSelect");
        }
    }
}
