using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 3f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;

        StartCoroutine("bulletDestroy");
    }
    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerMovement pm = other.GetComponent<PlayerMovement>();
            if (pm != null)
            {
                pm.Die();
                Destroy(gameObject);
            }
        }
        
    }

    IEnumerator bulletDestroy()
    {
        yield return new WaitForSeconds(10f); Destroy(gameObject);
    }
}
