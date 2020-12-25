using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private GameOverScript _gameOverScript;
    
    private void Start()
    {
        _gameOverScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameOverScript>();
    }

    private void OnTriggerEnter2D(Collider2D hitObject)
    {
        if (hitObject.CompareTag("Enemy"))
        {
            _gameOverScript.isGameOver = true;
            Destroy(gameObject);   
        }
    }
}
