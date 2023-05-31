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
    AudioSource audioSource;
    public AudioClip bulletSound;


    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

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
            PlaySound(bulletSound);
            var bullet = Instantiate(bulletPrefab, transform.Find("BulletSpawn").position, transform.Find("BulletSpawn").rotation);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

}
