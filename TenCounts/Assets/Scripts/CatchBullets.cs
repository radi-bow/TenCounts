﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchBullets : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet"){
            Destroy(collision.gameObject);
        }
    }

}
