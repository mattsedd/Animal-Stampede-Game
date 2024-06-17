using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Get the input manager working
        horizontalInput = Input.GetAxis("Horizontal");

        //get the player moving left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //set up a boundary using IF statement
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }

        if(Input.GetKeyDown(KeyCode.Space))
            {
            // when we press the space bar, launch food projectile from player

            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
