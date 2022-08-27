using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ControllerGrab : MonoBehaviour
{
    public SteamVR_Input_Sources handType; //왼손 오른손 모두 사용
    public SteamVR_Behaviour_Pose controllerPose; //컨트롤러 정보
    public SteamVR_Action_Boolean grabAction;

    private GameObject collidingObject; //현재 충돌중인 객체
    private GameObject objectInhand; //잡은 객체

    void Update()
    {
        //잡는버튼 누를때
        if (grabAction.GetLastStateDown(handType))
        {
            if (collidingObject)
            {
                GrabObject();
            }
        }

        //잡는버튼 땔 때
        if (grabAction.GetLastStateUp(handType))
        {
            if (collidingObject)
            {
                GrabObject();
            }
        }
    }

    //충돌 시작 되는 순간
    public void OnTriggerEnter(Collider other)
    {
        SetColliderObject(other);
    }


    //충돌중일 때
    public void OnTriggerStay(Collider other)
    {
        SetColliderObject(other);
    }

    //충돌 끝나는 순간
    public void OnTriggerExit(Collider other)
    {
        if (!collidingObject)
        {
            return;
        }
        collidingObject = null;
    }

    //충돌중인 객체로 설정
    private void SetColliderObject(Collider col)
    {
        if (collidingObject || !col.GetComponent<Rigidbody>())
        {
            return;
        }

        collidingObject = col.gameObject;
    }

    //객체를 잡음
    private void GrabObject()
    {
        objectInhand = collidingObject; //잡은 객체로 설정
        collidingObject = null; //충돌객체

        var joint = AddFixedJoint();
        joint.connectedBody = objectInhand.GetComponent<Rigidbody>();
    }

    //FixedJoint 객체 하나로 묶어 고정
    //breakForce 조인트가 제거되도록 하기위해 필요한 힘의 크기
    //breakTorque 조인트가 제거되도록 하기위한 토크

    private FixedJoint AddFixedJoint()
    {
        FixedJoint fx = gameObject.AddComponent<FixedJoint>();
        fx.breakForce = 2000;
        fx.breakTorque = 2000;
        return fx;
    }

    //객체를 놓음
    //controllerPose.GetVeloecity() 컨트롤러 속도
    //controllerpose. GetAngularVelocity() 컨트롤러 각 속도

    private void ReleaseObject()
    {
        if (GetComponent<FixedJoint>())
        {

            GetComponent<FixedJoint>().connectedBody = null;
            Destroy(GetComponent<FixedJoint>());

            objectInhand.GetComponent<Rigidbody>().velocity =
                controllerPose.GetVelocity();
            objectInhand.GetComponent<Rigidbody>().angularVelocity =
               controllerPose.GetVelocity();


        }
        objectInhand = null;
    }
}