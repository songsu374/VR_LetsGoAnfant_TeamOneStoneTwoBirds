using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

//Grab 확인용 스크립트 

public class ActionTest : MonoBehaviour{

    public SteamVR_Input_Sources HandType; //왼손 오른손 모두사용
    public SteamVR_Action_Boolean grabAction; //그랩액션

   
    void Update(){
        if(GetGrab()){
            Debug.Log("Grab" + HandType);
        }
        
    }

    //잡기 액션이 활성화 되면
    public bool GetGrab()
    {
        return grabAction.GetActive(HandType);

    }
}
