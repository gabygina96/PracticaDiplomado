using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject decalPrefab;
    private GameObject tmpDecal;
    void OnCollisionEnter(Collision c) {
        ContactPoint hitPoint = c.GetContact(0);
        Quaternion decalRotation = Quaternion.FromToRotation(Vector3.forward,-hitPoint.normal);
        Vector3 decalPosition = hitPoint.point;
        //tmpDecal.transform.parent = objectTransform;
        tmpDecal = Instantiate(decalPrefab,decalPosition,decalRotation);
        tmpDecal.transform.Rotate(180.0f,0.0f,0.0f);
        tmpDecal.transform.Translate(0.0f,0.0f,0.01f);
        tmpDecal.transform.SetParent(c.transform);
                
        //tmpDecal.transform.Translate(0.0f,0.0f,0.05f);
        Destroy(this.gameObject);
    }
}
