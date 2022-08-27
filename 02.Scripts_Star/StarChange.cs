using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StarChange : MonoBehaviour
{
    Renderer sp;
    public int ran;
    // Start is called before the first frame update
    public void Start()
    {
        sp = gameObject.GetComponent<Renderer>();
        sp.material.color = Color.white;
        ran = UnityEngine.Random.Range(0, 4);
        Invoke("A", 1f);
    }

    void A()
    {
        if(ran == 0)
        {
            sp.material.color = Color.red;
            Invoke("W", 0.5f);
        }
        else if(ran == 1)
        {
            sp.material.color = Color.yellow;
            Invoke("W", 0.5f);
        }
        else if(ran == 2)
        {
            sp.material.color = Color.green;
            Invoke("W", 0.5f);
        }
        else if (ran == 3)
        {
            sp.material.color = Color.blue;
            Invoke("W", 0.5f);
        }
    }

    void W()
    {
        sp.material.color = Color.white;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
