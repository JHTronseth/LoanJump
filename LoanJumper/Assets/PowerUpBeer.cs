﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBeer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            print("Here");
            Destroy(gameObject);
        }

        if (collision.tag == "Wave")
        {
            print("Here");
            Destroy(gameObject);
        }
    }
}