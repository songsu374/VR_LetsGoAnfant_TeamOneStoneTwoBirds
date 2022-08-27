﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Item"))
        {
            Item item = other.GetComponent<Item>();

            if(item.itemType == ItemType.Score)
            {
                ScoreManager.extraScore += item.extraScore;
            }

            Destroy(other.gameObject);
        }
    }
    
        
    
}
