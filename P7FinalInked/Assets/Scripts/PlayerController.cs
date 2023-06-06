using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float bulletSpeed = 1000.0f;
    public float speed = 10.0f;
    public GameObject bulletPrefab;
    public Transform projectileSpawnPoint;
    public Animator playerAnim;
    private Rigidbody playerRb;
    public Vector2 turn;
    public int damageAmount = 20;

    private EnemyController enemyController;
    public float timeInvincible = 2.0f;
    bool isInvincible;
    float invincibleTimer;

    public int health { get { return currentHealth; } }

    private int currentHealth;
    public int maxHealth = 100;
    private Transform playerTransform;


    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();


        currentHealth = maxHealth;

        playerTransform = GameObject.FindGameObjectWithTag("Enemy").transform;

    }




    void Update()
    {


        turn.x += Input.GetAxis("Mouse X");

        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.localRotation = Quaternion.Euler(0, turn.x, 0);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.W))
        {
            playerAnim.SetTrigger("Run_trig");
            playerAnim.ResetTrigger("Idle_trig");
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        }




        if (Input.GetKey(KeyCode.A))
        {
            playerAnim.SetTrigger("Run_trig");
            playerAnim.ResetTrigger("Idle_trig");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }




        if (Input.GetKey(KeyCode.S))
        {
            playerAnim.SetTrigger("Run_trig");
            playerAnim.ResetTrigger("Idle_trig");
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        }




        if (Input.GetKey(KeyCode.D))
        {
            playerAnim.SetTrigger("Run_trig");
            playerAnim.ResetTrigger("Idle_trig");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }



    }



    public void Shooting()
    {
        if (Input.GetMouseButtonDown(0))
        {

            var bullet = Instantiate(bulletPrefab, transform.Find("BulletSpawn").position, transform.Find("BulletSpawn").rotation);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);

        }
    }




    private void OnTriggerEnter(Collider other)
    {
        
    }

}
    

