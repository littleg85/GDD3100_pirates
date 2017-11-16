using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Tower : MonoBehaviour
{

    public GameObject tower0;
    public GameObject tower1;
    public GameObject tower2;
    private int shoot;
    private Variables var;
    private GameLogic logic;
    public GameObject closestEnemy;
    private float dist;

    //Projectile
    public GameObject projectile;
    private float fireRate = 2f;
    private float nextFire = 0.0f;
    private int range = 100;
    public GameObject projSpawn;
    public int damage;

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
            if (var.levelArray[0] == 0)
            {
                shoot = 0;
            }
            else
            {
                shoot = 1;
            }

            if (var.levelArray[0] == 1)
            {
                tower0.SetActive(true);
                damage = 5;
            }
            else if (var.levelArray[0] == 2)
            {
                tower1.SetActive(true);
                damage = 10;
            }
            else if (var.levelArray[0] == 3)
            {
                tower2.SetActive(true);
                damage = 20;
            }
        }

        if (gameObject.name == "E")
        {
            if (var.levelArray[1] == 0)
            {
                shoot = 0;
            }
            else
            {
                shoot = 1;
            }

            if (var.levelArray[1] == 1)
            {
                tower0.SetActive(true);
                damage = 5;
            }
            else if (var.levelArray[1] == 2)
            {
                tower1.SetActive(true);
                damage = 10;
            }
            else if (var.levelArray[1] == 3)
            {
                tower2.SetActive(true);
                damage = 20;
            }
        }

        if (gameObject.name == "S")
        {
            if (var.levelArray[2] == 0)
            {
                shoot = 0;
            }
            else
            {
                shoot = 1;
            }

            if (var.levelArray[2] == 1)
            {
                tower0.SetActive(true);
                damage = 5;
            }
            else if (var.levelArray[2] == 2)
            {
                tower1.SetActive(true);
                damage = 10;
            }
            else if (var.levelArray[2] == 3)
            {
                tower2.SetActive(true);
                damage = 20;
            }
        }

        if (gameObject.name == "SW")
        {
            if (var.levelArray[3] == 0)
            {
                shoot = 0;
            }
            else
            {
                shoot = 1;
            }

            if (var.levelArray[3] == 1)
            {
                tower0.SetActive(true);
                damage = 5;
            }
            else if (var.levelArray[3] == 2)
            {
                tower1.SetActive(true);
                damage = 10;
            }
            else if (var.levelArray[3] == 3)
            {
                tower2.SetActive(true);
                damage = 20;
            }
        }

        if (gameObject.name == "NW")
        {
            if (var.levelArray[4] == 0)
            {
                shoot = 0;
            }
            else
            {
                shoot = 1;
            }

            if (var.levelArray[4] == 1)
            {
                tower0.SetActive(true);
                damage = 5;
            }
            else if (var.levelArray[4] == 2)
            {
                tower1.SetActive(true);
                damage = 10;
            }
            else if (var.levelArray[4] == 3)
            {
                tower2.SetActive(true);
                damage = 20;
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

        if (dist <= range && Time.time > nextFire && shoot == 1)
        {
            GameObject proj = Instantiate(projectile, projSpawn.transform.position, Quaternion.identity);
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
