using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerProjectile : MonoBehaviour
{

    private Rigidbody rb;
    private Towers closest;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        closest = GetComponentInParent<Towers>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(closest.closestEnemy.transform.position);

    }

    private void FixedUpdate()
    {
        rb.velocity = transform.forward * 50;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
