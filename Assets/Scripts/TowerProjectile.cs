using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerProjectile : MonoBehaviour
{
    private Rigidbody rb;
    private Tower closest;
    public int damage;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        closest = GetComponentInParent<Tower>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(closest.closestEnemy.transform.position);
        damage = GetComponentInParent<Tower>().damage;
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.forward * 50;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().health -= damage;
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Booty")
        {
            Destroy(gameObject);
        }
    }
}
