using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{

    private GameLogic gameLogic;
    private Rigidbody rb;
    private Variables var;
    public GameObject shadow;
    public bool capsize = false;

    //Boats
    public GameObject boat0;
    public GameObject boat1;
    public GameObject boat2;
    public GameObject boat3;
    public GameObject cannons;

    //Weapons
    public GameObject rockPrefab;
    public GameObject bulletPrefab;
    public GameObject cannonballPrefab;
    private float nextFire = 0.0f;

    //Health
    public int health;

    //Speed
    private int speed;

    //Attack Speed
    private float fireRate;

    //Turn Speed
    private int tSpeed;

    //Audio
    public AudioSource damage;
    public AudioSource deadMen;
    public AudioSource win;
    private bool deadMenPlayed = false;
    private bool winPlayed = false;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        var = GameObject.Find("Variables").GetComponent<Variables>();
        gameLogic = GameObject.Find("GameUI").GetComponent<GameLogic>();

        //Hide children
        boat0.SetActive(false);
        boat1.SetActive(false);
        boat2.SetActive(false);
        boat3.SetActive(false);
        cannons.SetActive(false);

        //Set Models
        //Health
        if (var.healthLevel == 0)
        {
            health = 10;
            boat0.SetActive(true);
        }

        if (var.healthLevel == 1)
        {
            health = 20;
            boat1.SetActive(true);
        }

        if (var.healthLevel == 2)
        {
            health = 50;
            boat2.SetActive(true);
        }

        if (var.healthLevel == 3)
        {
            health = 100;
            boat3.SetActive(true);
        }

        //Attack
        if (var.attackLevel == 2 || var.attackLevel == 3)
        {
            cannons.SetActive(true);
        }

        //Speed
        if (var.speedLevel == 0)
        {
            speed = 30000;
        }
        if (var.speedLevel == 1)
        {
            speed = 40000;
        }
        if (var.speedLevel == 2)
        {
            speed = 60000;
        }
        if (var.speedLevel == 3)
        {
            speed = 80000;
        }

        //Attack SPeed
        if (var.aSpeedLevel == 0)
        {
            fireRate = 2f;
        }
        if (var.aSpeedLevel == 1)
        {
            fireRate = 1.5f;
        }
        if (var.aSpeedLevel == 2)
        {
            fireRate = 1f;
        }
        if (var.aSpeedLevel == 3)
        {
            fireRate = .5f;
        }

        //Turn Speed
        if (var.tSpeedLevel == 0)
        {
            tSpeed = 30;
        }
        if (var.tSpeedLevel == 1)
        {
            tSpeed = 50;
        }
        if (var.tSpeedLevel == 2)
        {
            tSpeed = 75;
        }
        if (var.tSpeedLevel == 3)
        {
            tSpeed = 100;
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Hide cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        if (health > 0 && !capsize)
        {
            //Turn left
            if (KeyBindingManager.GetKey(KeyAction.left))
            {
                transform.Rotate(-transform.up * tSpeed * Time.deltaTime);
            }

            //Turn right
            if (KeyBindingManager.GetKey(KeyAction.right))
            {
                transform.Rotate(transform.up * tSpeed * Time.deltaTime);
            }

            //If boat is flipped, reset game.
            if (transform.rotation.eulerAngles.z >= 170f && transform.rotation.eulerAngles.z <= 190f)
            {
                capsize = true;
                StartCoroutine(Capsize());
                if (!deadMenPlayed)
                {
                    deadMen.Play();
                    deadMenPlayed = true;
                }
            }

            //Play win sound
            if (gameLogic.gameWon)
            {
                if (!winPlayed)
                {
                    win.Play();
                    winPlayed = true;
                }
            }
        }
        else
        {
            //Play die sound and restart
            GetComponent<FloatingGameEntityRealist>().enabled = false;
            StartCoroutine(Sunk());
            if (!deadMenPlayed)
            {
                deadMen.Play();
                deadMenPlayed = true;
            }

            var.booty = 0;
        }
    }


    void FixedUpdate()
    {

        if (health > 0 && !capsize)
        {
            //Movement
            if (KeyBindingManager.GetKey(KeyAction.forward))
            {
                //rb.velocity += transform.forward * var.speed;
                rb.AddForce(transform.forward * speed);
            }

            if (KeyBindingManager.GetKey(KeyAction.backward))
            {
                //rb.velocity -= transform.forward * var.speed;
                rb.AddForce(-transform.forward * speed);
            }

            //Projectiles
            if (KeyBindingManager.GetKey(KeyAction.attack1) && Time.time > nextFire)
            {
                //Rock
                if (var.attackLevel == 0)
                {
                    GameObject rock = Instantiate(rockPrefab, GameObject.Find("playerRock").transform.position, transform.rotation);
                    rock.tag = "Player Rock";
                    Rigidbody rockrb = rock.GetComponent<Rigidbody>();
                    rockrb.AddForce(transform.up * 300f, ForceMode.Impulse);
                    rockrb.AddForce(shadow.transform.forward * 150f, ForceMode.Impulse);
                }

                //Guns
                if (var.attackLevel == 1)
                {
                    GameObject bullet1 = Instantiate(bulletPrefab, GameObject.Find("playerGuns").transform.position, transform.rotation);
                    bullet1.tag = "Player Bullet";
                    Rigidbody bullet1rb = bullet1.GetComponent<Rigidbody>();
                    bullet1rb.AddForce(shadow.transform.forward * 300f, ForceMode.Impulse);

                    GameObject bullet2 = Instantiate(bulletPrefab, GameObject.Find("playerGuns").transform.position, transform.rotation);
                    bullet2.tag = "Player Bullet";
                    Rigidbody bullet2rb = bullet2.GetComponent<Rigidbody>();
                    bullet2rb.AddForce((shadow.transform.forward + shadow.transform.right).normalized * 300f, ForceMode.Impulse);

                    GameObject bullet3 = Instantiate(bulletPrefab, GameObject.Find("playerGuns").transform.position, transform.rotation);
                    bullet3.tag = "Player Bullet";
                    Rigidbody bullet3rb = bullet3.GetComponent<Rigidbody>();
                    bullet3rb.AddForce((shadow.transform.forward - shadow.transform.right).normalized * 300f, ForceMode.Impulse);
                }

                //Cannons
                if (var.attackLevel == 2 || var.attackLevel == 3)
                {
                    //Left cannon
                    if (Camera.main.transform.localRotation.eulerAngles.y > 180 && Camera.main.transform.localRotation.eulerAngles.y <= 315)
                    {
                        GameObject cannonball1 = Instantiate(cannonballPrefab, GameObject.Find("cannonLeft1").transform.position, transform.rotation);
                        cannonball1.tag = "Player Cannonball";
                        cannonball1.GetComponent<AudioSource>().Play();
                        Rigidbody cannonball1rb = cannonball1.GetComponent<Rigidbody>();
                        cannonball1rb.AddForce(-transform.right * 500f, ForceMode.Impulse);

                        GameObject cannonball2 = Instantiate(cannonballPrefab, GameObject.Find("cannonLeft2").transform.position, transform.rotation);
                        cannonball2.tag = "Player Cannonball";
                        Rigidbody cannonball2rb = cannonball2.GetComponent<Rigidbody>();
                        cannonball2rb.AddForce(-transform.right * 500f, ForceMode.Impulse);
                    }

                    //Right cannon
                    if (Camera.main.transform.localRotation.eulerAngles.y >= 45 && Camera.main.transform.localRotation.eulerAngles.y < 180)
                    {
                        GameObject cannonball3 = Instantiate(cannonballPrefab, GameObject.Find("cannonRight1").transform.position, transform.rotation);
                        cannonball3.tag = "Player Cannonball";
                        cannonball3.GetComponent<AudioSource>().Play();
                        Rigidbody cannonball3rb = cannonball3.GetComponent<Rigidbody>();
                        cannonball3rb.AddForce(transform.right * 500f, ForceMode.Impulse);

                        GameObject cannonball4 = Instantiate(cannonballPrefab, GameObject.Find("cannonRight2").transform.position, transform.rotation);
                        cannonball4.tag = "Player Cannonball";
                        Rigidbody cannonball4rb = cannonball4.GetComponent<Rigidbody>();
                        cannonball4rb.AddForce(transform.right * 500f, ForceMode.Impulse);
                    }

                    //Front cannon
                    if (Camera.main.transform.localRotation.eulerAngles.y >= 0 && Camera.main.transform.localRotation.eulerAngles.y <= 45)
                    {
                        GameObject cannonballFront = Instantiate(cannonballPrefab, GameObject.Find("cannonFront").transform.position, transform.rotation);
                        cannonballFront.tag = "Player Cannonball";
                        cannonballFront.GetComponent<AudioSource>().Play();
                        Rigidbody cannonballFrontrb = cannonballFront.GetComponent<Rigidbody>();
                        cannonballFrontrb.AddForce(transform.forward * 500f, ForceMode.Impulse);
                    }
                    if (Camera.main.transform.localRotation.eulerAngles.y >= 315 && Camera.main.transform.localRotation.eulerAngles.y <= 360)
                    {
                        GameObject cannonballFront = Instantiate(cannonballPrefab, GameObject.Find("cannonFront").transform.position, transform.rotation);
                        cannonballFront.tag = "Player Cannonball";
                        cannonballFront.GetComponent<AudioSource>().Play();
                        Rigidbody cannonballFrontrb = cannonballFront.GetComponent<Rigidbody>();
                        cannonballFrontrb.AddForce(transform.forward * 500f, ForceMode.Impulse);
                    }
                }

                nextFire = Time.time + fireRate;
            }

            if (KeyBindingManager.GetKey(KeyAction.attack2) && Time.time > nextFire)
            {
                if (var.attackLevel == 3)
                {
                    GameObject bullet1 = Instantiate(bulletPrefab, GameObject.Find("playerGuns").transform.position, transform.rotation);
                    bullet1.tag = "Player Bullet";
                    Rigidbody bullet1rb = bullet1.GetComponent<Rigidbody>();
                    bullet1rb.AddForce(shadow.transform.forward * 300f, ForceMode.Impulse);

                    GameObject bullet2 = Instantiate(bulletPrefab, GameObject.Find("playerGuns").transform.position, transform.rotation);
                    bullet2.tag = "Player Bullet";
                    Rigidbody bullet2rb = bullet2.GetComponent<Rigidbody>();
                    bullet2rb.AddForce((shadow.transform.forward + shadow.transform.right).normalized * 300f, ForceMode.Impulse);

                    GameObject bullet3 = Instantiate(bulletPrefab, GameObject.Find("playerGuns").transform.position, transform.rotation);
                    bullet3.tag = "Player Bullet";
                    Rigidbody bullet3rb = bullet3.GetComponent<Rigidbody>();
                    bullet3rb.AddForce((shadow.transform.forward - shadow.transform.right).normalized * 300f, ForceMode.Impulse);

                    nextFire = Time.time + fireRate;
                }
            }

            //Controller Projectiles
            //if (Input.GetAxis("DPad Horizontal") == 1 && Time.time > nextFire)
            //{
            //    GameObject rock = Instantiate(rockPrefab, new Vector3(transform.position.x + 1, transform.position.y + 4, transform.position.z + 1), transform.rotation);
            //    Rigidbody rockrb = rock.GetComponent<Rigidbody>();
            //    rockrb.AddForce(new Vector3(1, 2, 0) * 150f, ForceMode.Impulse);
            //    nextFire = Time.time + fireRate;
            //}

            //if (Input.GetAxis("DPad Horizontal") == -1 && Time.time > nextFire)
            //{
            //    GameObject rock = Instantiate(rockPrefab, new Vector3(transform.position.x - 1, transform.position.y + 4, transform.position.z + 1), transform.rotation);
            //    Rigidbody rockrb = rock.GetComponent<Rigidbody>();
            //    rockrb.AddForce(new Vector3(-1, 2, 0) * 150f, ForceMode.Impulse);
            //    nextFire = Time.time + fireRate;
            //}

            //if (Input.GetAxis("DPad Vertical") == 1 && Time.time > nextFire)
            //{
            //    GameObject rock = Instantiate(rockPrefab, new Vector3(transform.position.x, transform.position.y + 4, transform.position.z + 5), transform.rotation);
            //    Rigidbody rockrb = rock.GetComponent<Rigidbody>();
            //    rockrb.AddForce(new Vector3(0, 2, 1) * 150f, ForceMode.Impulse);
            //    nextFire = Time.time + fireRate;
            //}

            //if (Input.GetAxis("DPad Vertical") == -1 && Time.time > nextFire)
            //{
            //    GameObject rock = Instantiate(rockPrefab, new Vector3(transform.position.x, transform.position.y + 4, transform.position.z - 3), transform.rotation);
            //    Rigidbody rockrb = rock.GetComponent<Rigidbody>();
            //    rockrb.AddForce(new Vector3(0, 2, -1) * 150f, ForceMode.Impulse);
            //    nextFire = Time.time + fireRate;
            //}
        }
    }

    IEnumerator Capsize()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Upgrades_v2");
    }

    IEnumerator Sunk()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Upgrades_v2");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (health > 0)
        {
            if (other.gameObject.tag == "Enemy Rock")
            {
                health -= 10;
                damage.Play();
            }

            if (other.gameObject.tag == "Enemy Bullet")
            {
                health -= 10;
                damage.Play();
            }

            if (other.gameObject.tag == "Enemy Cannonball")
            {
                health -= 20;
                damage.Play();
            }
        }
    }
}
