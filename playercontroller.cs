using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20f;
    public float xRange = 20f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // met deze code kan de speler niet van het veld af
    void Update()
    {
        if ( transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if ( transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput =Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //vuurt een object af van de speler
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
    
}
