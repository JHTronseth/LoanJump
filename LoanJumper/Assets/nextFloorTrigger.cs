using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextFloorTrigger : MonoBehaviour {

    [SerializeField] private GameObject FloorType1;
    //[SerializeField] private bool Flip;
    //[SerializeField] private int FloorChoice;
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
            //Velge en tilfeldig floor å spawne
            float Floorchoice = Random.Range(0, 10);
            print(Floorchoice);
            //Velge om flooren skal flippes eller ikke
            float Flipp = Random.Range(0, 2);
            print("Flipp?" + Flipp);
            //print(Random.Range(0, 1));
            //if(flip == 1)
            //{
                FloorType1.transform.Rotate(0, 180, 0);
            //}
        }
    }
}
