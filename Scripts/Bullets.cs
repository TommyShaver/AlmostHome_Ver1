using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public Transform firepoint;
    public GameObject bulletPRefab;

    public float bulletForce = 20f;

    private PlayerControls _playerControls;


    private void Awake()
    {
        _playerControls = GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {

        if (_playerControls._isDead == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPRefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
