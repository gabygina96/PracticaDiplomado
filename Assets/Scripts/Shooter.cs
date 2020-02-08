using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shooter : MonoBehaviour
{
    public XRGrabInteractable gun;
    
    public GameObject bulletPrefab;
    public float forceBullet;
    public bool isActive = false;
    private GameObject tmpBullet;

    void Start() {
        gun.onActivate.AddListener(TriggerPulled);
    }


    void TriggerPulled(XRBaseInteractor obj) {
        if(isActive){
            tmpBullet = Instantiate(bulletPrefab,transform.position,Quaternion.identity);
            tmpBullet.transform.up = transform.forward;
            tmpBullet.GetComponent<Rigidbody>().AddForce(transform.forward * forceBullet, ForceMode.Impulse);
        }
    }
}
