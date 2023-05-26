using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;   
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    public Animator playerAnim;
    private Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
       
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
     
        

        if (Input.GetKey(KeyCode.W))
        {
            playerAnim.SetTrigger("Run_trig");
            playerAnim.ResetTrigger("Idle_trig");
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        }
        else
        {
            playerAnim.ResetTrigger("Run_trig");
            playerAnim.SetTrigger("Idle_trig");
        }
    }

    public void Shooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }
    }
}