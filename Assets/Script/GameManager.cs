using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{

    public float clock = 30.0f;

    void Start()
    {
        clock = 30.0f;
    }
    void Update()
    {
        clock -= Time.deltaTime;

    }
 
}
