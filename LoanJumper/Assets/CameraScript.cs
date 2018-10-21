using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (player.transform.position.y > gameObject.transform.position.y)
        {
            gameObject.transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z); ;
        }

        if (player.transform.position.y <= gameObject.transform.position.y - 7)
        {
            Destroy(player);
        }
        else if (player.transform.position.x <= gameObject.transform.position.x - 7)
        {
            Destroy(player);
        }
        else if (player.transform.position.x >= gameObject.transform.position.x + 7)
        {
            Destroy(player);
        }
    }
}
