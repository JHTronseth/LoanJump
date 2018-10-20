using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GjeldScript : MonoBehaviour {
    /*Vector3 velocity = 0.0f;
    float floorHeighi = 0.05f;
    float sleepThreshold = 0.05f;
    float gravity = -9.8f; */

	// Use this for initialization
	void Start () {
        //transform.position = new Vector3(0.0f, 1.5f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.up * Time.deltaTime);
	}

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "PowerUp") {
            //GetComponent<PlayerScript>().death();
            Destroy(Player.gameObject)
        }
    } */
}
