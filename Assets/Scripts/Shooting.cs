using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform gunTip;
    public GameObject bullet;

    [Header("Bullet Attributes")]
    public float bulletSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject instantiatedBullet = Instantiate(bullet, gunTip.position, Quaternion.identity);
            Rigidbody bulletRB = instantiatedBullet.GetComponent<Rigidbody>();

            bulletRB.AddForce(gunTip.forward * bulletSpeed, ForceMode.Impulse);
        }
    }
}
