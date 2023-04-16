using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 5f;
    Score score;
    GameManager gm;

    private void Awake()
    {
        score = FindObjectOfType<Score>();
        gm = FindObjectOfType<GameManager>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        rb.velocity = newVelocity;
    }

 
    public void Die()
    {
        Destroy(gameObject);
        score.setDead();
        gm.EndGame();
    }
}
