using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public bool _isDead = false;
    public GameObject _shipDeath;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Rock")
        {
            Debug.Log("Dead");
            _isDead = true;
            Destroy(this.gameObject);
            GameObject effect = Instantiate(_shipDeath, transform.position, Quaternion.identity);
            Destroy(effect, 2f);
        }
    }
}
