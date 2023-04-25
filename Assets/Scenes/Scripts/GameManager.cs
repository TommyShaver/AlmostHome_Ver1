using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerControls _player;

    public ParticleSystem _explosion;
    

    
    public void AstroidDestroyed(Asteroid asteroid)
    {
        this._explosion.transform.position = asteroid.transform.position;
        this._explosion.Play();
    }
}
