using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBeer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.Rotate(new Vector3(0, 180, 0));
    }
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.forward);
        
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
