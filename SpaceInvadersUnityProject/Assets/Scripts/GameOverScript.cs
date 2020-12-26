using System;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    [HideInInspector] public bool isGameOver = false;
    [SerializeField] private GameObject gameObjectToEnableOnGameOver;

    private void Start()
    {
        gameObjectToEnableOnGameOver.SetActive(false);
    }

    private void Update()
    {
        if (isGameOver)
        {
            gameObjectToEnableOnGameOver.SetActive(true);
            
        }
        
    }
}
