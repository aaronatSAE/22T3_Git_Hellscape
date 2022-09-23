using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform gunTip;
    public GameObject bullet;
    List<GameObject> bullets = new List<GameObject>();

    [Header("Bullet Attributes")]
    public float bulletSpeed;

    float timer = 5f, originalTimer = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject instantiatedBullet = Instantiate(bullet, gunTip.position, Quaternion.identity);
            Rigidbody bulletRB = instantiatedBullet.GetComponent<Rigidbody>();

            bulletRB.AddForce(gunTip.forward * bulletSpeed, ForceMode.Impulse);

            bullets.Add(instantiatedBullet);
        }

        if (bullets.Count > 0)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                Destroy(bullets[0]);

                timer = originalTimer;
            }
        }
    }
}
