using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GameManagerInstance;
    [SerializeField] private GameObject EndZone1;
    [SerializeField] private GameObject EndZone2;

    private void Awake()
    {
        if (GameManagerInstance != null && GameManagerInstance != this)
            Destroy(gameObject);
        else
            GameManagerInstance = this;
    }

    void Start()
    {
    }

    void Update()
    {
    }
    
}