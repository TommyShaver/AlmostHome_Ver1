using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] float _verticalInput;
    [SerializeField] float _playerspeed;
    [SerializeField] float _veritcalPostiveBounds = 0;
    [SerializeField] float _veritcalNegitveBounds = -2.0f;
    [SerializeField] int _stayinXbound = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StayInBounds();
        MoveOnVerticalAxis();
    }
    void StayInBounds()
    {
        // Keep in X bounds
        if (transform.position.x < _stayinXbound)
        {
            transform.position = new Vector2(_stayinXbound, transform.position.y);
        }
        if (transform.position.x > -_stayinXbound)
        {
            transform.position = new Vector2(-_stayinXbound, transform.position.y);
        }

        //Keep in Y bounds
        if (transform.position.y > _veritcalPostiveBounds)
        {
            transform.position = new Vector2(transform.position.x, _veritcalPostiveBounds);
        }
        if (transform.position.y < _veritcalNegitveBounds)
        {
            transform.position = new Vector2(transform.position.x, _veritcalNegitveBounds);
        }

    }
    void MoveOnVerticalAxis()
    {
        _verticalInput = Input.GetAxis("Vertical");
        transform.Translate(_verticalInput * _playerspeed * Time.deltaTime * Vector2.up);
    }
}
