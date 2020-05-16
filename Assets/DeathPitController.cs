using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPitController : MonoBehaviour
{
    public delegate void Death(GameObject obj);
    public static event Death DeathEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DeathEvent(collision.gameObject);
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
