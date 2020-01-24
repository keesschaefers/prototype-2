using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour
{
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // zo kan de speler bewegen
    void Update()
    {
        transform.Translate(Vector3.forward *Time.deltaTime * speed);
    }
}
