using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//닿으면 점수 +10 바닥부분

public enum ItemType
{
    Score,
}


public class Item : MonoBehaviour
{
    public ItemType itemType; //아이템유형

    public int extraScore; //점수 추가


}
