using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMove : MonoBehaviour
{
    private float movementSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
    }
}
