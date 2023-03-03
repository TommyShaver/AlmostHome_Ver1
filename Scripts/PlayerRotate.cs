using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] float _playerRotateSpeed;
    [SerializeField] float _horizontalInput;


    //This is how you do this. 
    public ParticleSystem _partSystem;
    // Start is called before the first frame update
    void Start()
    {
         
        _partSystem.Stop();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(_horizontalInput * _playerRotateSpeed * Time.deltaTime * Vector3.back);
        if(_horizontalInput == 1)
        {
            _partSystem.Play();
        }
    }
}
