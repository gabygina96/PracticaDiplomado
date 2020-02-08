using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{
    public GameObject gunPrefab;
    public GameObject gunWeapon;
    public Shooter shooter;

    public void GrabWeapon() {
        Destroy(gunPrefab.gameObject);
        gunWeapon.SetActive(true);
        shooter.isActive = true;
    }

}

