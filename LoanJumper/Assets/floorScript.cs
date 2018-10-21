using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class floorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
       /* if (flip == )
        {
            transform.Rotate(new Vector3(0, 180, 0));
        } */
	}

    internal void flip()
    {
        print("flippen skjer");
        transform.Rotate(0, 180, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wave")
        {
            print("Here");
            Destroy(gameObject);
        }
    }
}
