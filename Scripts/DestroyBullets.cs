using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullets : MonoBehaviour
{
    [SerializeField] float _xRange = 15.0f;
    [SerializeField] float _yRange = 15.0f;
    // Update is called once per frame
    void Update()
    {
       if(transform.position.x >= _xRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.x <= -_xRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.y >= _yRange)
        {
            Destroy(gameObject);
        }
        if (transform.position.y <= -_yRange)
        {
            Destroy(gameObject);
        }
    }
}
