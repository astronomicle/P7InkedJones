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
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerAnim.SetTrigger("Run_trig");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
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