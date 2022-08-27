using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("RemainTimer").GetComponent<RemainTimer>().currentTime == 0.0f)
        {
            SceneManager.LoadScene("North_Result");
        }
    }
}
