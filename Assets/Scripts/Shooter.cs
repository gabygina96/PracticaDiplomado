using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.Oculus;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float forceBullet;
    public bool isActive = false;
    private GameObject tmpBullet;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && isActive){
            tmpBullet = Instantiate(bulletPrefab,transform.position,Quaternion.identity);
            tmpBullet.transform.up = transform.forward;
            tmpBullet.GetComponent<Rigidbody>().AddForce(transform.forward * forceBullet, ForceMode.Impulse);
        }
    }
}
