﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputModel : MonoBehaviour
{
    public Vector2 movement { get; private set; }
    public bool sliding { get; private set; }
    public bool jump { get; private set; }
    
    #region EVENTS
    //events
    //public event FireAction OnFire;
    //public event AltFireAction OnAltFire;
    #endregion //EVENTS
    void Start()
    {
        movement = Vector2.zero;
        sliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            sliding = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            sliding = false;
        }
        jump = Input.GetKeyDown(KeyCode.Space);

        if (Input.GetMouseButtonDown(0))
        {
            //InvokeFire();
        }
        if (Input.GetMouseButtonDown(1))
        {
            //InvokeAltFire();
        }
    }
 
    void InvokeFire()
    {
        
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
       // OnFire?.Invoke(direction / direction.magnitude);
    }
    void InvokeAltFire()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; //WARNING Vector3 stuff. If we do anything with zepth,  we may run into some weirdness here.
       // OnAltFire?.Invoke(direction / direction.magnitude);
    }
}
