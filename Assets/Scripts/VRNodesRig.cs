using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRNodesRig : MonoBehaviour
{
    public GameObject head;
    public GameObject leftHand;
    public GameObject rightHand;

    
    void Update()
    {
        head.transform.SetPositionAndRotation(InputTracking.GetLocalPosition(XRNode.Head), InputTracking.GetLocalRotation(XRNode.Head));
        leftHand.transform.SetPositionAndRotation(InputTracking.GetLocalPosition(XRNode.LeftHand), InputTracking.GetLocalRotation(XRNode.LeftHand));
        rightHand.transform.SetPositionAndRotation(InputTracking.GetLocalPosition(XRNode.RightHand), InputTracking.GetLocalRotation(XRNode.RightHand));
    }
}
