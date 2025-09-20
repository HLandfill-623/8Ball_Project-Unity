using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballShake : MonoBehaviour
{
    public float movementSpeed;

    public float rotationSpeed = 100f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 5;)
            {
                transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
                i++;
            }
        }

     

    }
}
