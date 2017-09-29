using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Towers : MonoBehaviour
{

    public GameObject tower0;
    public GameObject tower1;
    public GameObject tower2;
    private Variables var;
    private GameLogic logic;
    public GameObject closestEnemy;
    private float dist;

    //Projectile
    public GameObject projectile;
    private float fireRate = 2f;
    private float nextFire = 0.0f;
    private int range = 100;

    // Use this for initialization
    void Start()
    {
        var = GameObject.Find("Variables").GetComponent<Variables>();
        logic = GameObject.Find("GameUI").GetComponent<GameLogic>();
        closestEnemy = null;
        dist = 1000;

        //Hide towers
        tower0.SetActive(false);
        tower1.SetActive(false);
        tower2.SetActive(false);

        //Set models
        if (gameObject.name == "NE")
        {
            if (var.NElevel == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.NElevel == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.NElevel == 3)
            {
                tower2.SetActive(true);
            }
        }

        if (gameObject.name == "NW")
        {
            if (var.NWlevel == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.NWlevel == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.NWlevel == 3)
            {
                tower2.SetActive(true);
            }
        }

        if (gameObject.name == "S")
        {
            if (var.Slevel == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.Slevel == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.Slevel == 3)
            {
                tower2.SetActive(true);
            }
        }

        if (gameObject.name == "E")
        {
            if (var.Elevel == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.Elevel == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.Elevel == 3)
            {
                tower2.SetActive(true);
            }
        }

        if (gameObject.name == "SW")
        {
            if (var.SWlevel == 1)
            {
                tower0.SetActive(true);
            }
            else if (var.SWlevel == 2)
            {
                tower1.SetActive(true);
            }
            else if (var.SWlevel == 3)
            {
                tower2.SetActive(true);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

        //Find closest enemy
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;

        foreach (GameObject enemy in logic.enemies)
        {
            if (!enemy.GetComponent<Enemy>().dead)
            {
                Vector3 diff = enemy.transform.position - transform.position;
                float curDistance = diff.sqrMagnitude;

                if (curDistance < distance)
                {
                    closestEnemy = enemy;
                    distance = curDistance;
                }
            }

        }

        //Shoot
        if (closestEnemy != null)
        {
            dist = Vector3.Distance(transform.position, closestEnemy.transform.position);
        }

        if (dist <= range && Time.time > nextFire)
        {
            GameObject proj = Instantiate(projectile, transform.position, Quaternion.identity);
            proj.transform.SetParent(gameObject.transform);

            nextFire = Time.time + fireRate;
        }


    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
        if (closestEnemy != null)
        {
            Debug.DrawLine(transform.position, closestEnemy.transform.position, Color.red);
        }
    }
}
