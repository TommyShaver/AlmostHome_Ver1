using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullets : MonoBehaviour
{
    [SerializeField] float _xRange = 15.0f;
    [SerializeField] float _yRange = 15.0f;

    public GameObject _hitEffect;
    // Update is called once per frame

    void Update()
    {
        DestroyOutOfBounds();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Rock")
        {
            GameObject _effect = Instantiate(_hitEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(_effect, 0.5f);
        }
    }


    void DestroyOutOfBounds()
    {
        if (transform.position.x >= _xRange)
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
