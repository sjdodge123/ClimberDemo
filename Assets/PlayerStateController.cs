using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateController : MonoBehaviour
{
    private Vector2 spawnPosition;

    private void Awake()
    {
        spawnPosition = transform.position;
        DeathPitController.DeathEvent += IamDead;
    }
    private void OnDisable()
    {
        DeathPitController.DeathEvent -= IamDead;
    }

    private void IamDead(GameObject obj)
    {
        if(gameObject == obj)
        {
            transform.position = spawnPosition;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
