using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    Rigidbody2D rb2d;
    [SerializeField] private float maxHSpeed;
    [SerializeField] private float velocityIncrements;
    [SerializeField] private float jumpForce;
    bool hasJumped = true;
    bool isGrounded = false;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private GameObject groundChecker;

    // Use this for initialization
    void Start () {
       Console.WriteLine("Hello World!");
    }
	
	// Update is called once per frame
	void Update () {
        //animator.SetBool("isGrounded", isGrounded);
        //animator.SetFloat("velocityX", rb2d.velocity.x);

        if (rb2d.velocity.x < -0.01)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (rb2d.velocity.x > 0.01)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        } 

        if (Input.GetAxis("Jump") == 0 && hasJumped)
        {
            hasJumped = false;
        }
       /* timeSinceBullet += Time.deltaTime;
        if (timeSinceBullet > bulletCooldown
            && Input.GetMouseButtonDown(0)
            && bulletCount > 0)
        {
            fireBullet();
        } */
    }

    private void FixedUpdate()
    {
        float hAxis = Input.GetAxis("Horizontal");
        Vector2 newVelocity = rb2d.velocity + (hAxis * velocityIncrements * Vector2.right * Time.fixedDeltaTime);

        if (hAxis == 0)
        {
            newVelocity.x *= .90f * (1 - Time.fixedDeltaTime);
        }

        if (newVelocity.x < 0 && hAxis > 0)
        {
            newVelocity.x *= .8f * (1 - Time.fixedDeltaTime);
        }
        if (newVelocity.x > 0 && hAxis < 0)
        {
            newVelocity.x *= .8f * (1 - Time.fixedDeltaTime);
        }
        newVelocity.x = Mathf.Clamp(newVelocity.x, -maxHSpeed, maxHSpeed);

        rb2d.velocity = newVelocity;

        isGrounded = checkForGroundCollisions();

        rb2d.velocity = newVelocity;
        if (Input.GetAxis("Jump") == 1 && !hasJumped && isGrounded && rb2d.velocity.y <= 0)
        {
            newVelocity.y = 0;
            rb2d.velocity = newVelocity;
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            hasJumped = true;
        }

    }

    private bool checkForGroundCollisions()
    {
        Vector2 center = groundChecker.transform.position;
        Vector2 size = groundChecker.GetComponent<BoxCollider2D>().size;
        Collider2D firstOverlappingCollider = Physics2D.OverlapBox(center, size, 0f, groundMask);
        if (firstOverlappingCollider == null)
            return false;
        return true;
    } 

    private void Awake()
    {
        //timeSinceBullet = 10;
        rb2d = GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
        //updateBulletText();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wave")
        {
            Destroy(gameObject);
        }
    }
}
