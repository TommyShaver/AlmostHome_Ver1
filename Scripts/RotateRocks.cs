using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRocks : MonoBehaviour
{
    [SerializeField] float _rockSpeed;
    [SerializeField] float _randomNumber;
    public int _randomScaleNum;
    // Start is called before the first frame update
    void Start()
    {
        //Call Random Values for rocks
        _rockSpeed = Random.Range(10.0f, 90.0f);
        _randomNumber = Random.Range(-1, 1);
        _randomScaleNum = Random.Range(1, 11);

        //Change localScale on spawn. 
        transform.localScale += new Vector3(_randomScaleNum, _randomScaleNum, 0);
    }

    // Update is called once per frame
    void Update()
    {

        // Change roation of rock
        if(_randomNumber == -1)
        {
            transform.Rotate(_rockSpeed * Time.deltaTime * Vector3.forward);
        }
        else
        {
            transform.Rotate(_rockSpeed * Time.deltaTime * Vector3.back);
        }
    }

}
