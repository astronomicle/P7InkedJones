using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingForward : MonoBehaviour
{
    public float speed = 50.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
