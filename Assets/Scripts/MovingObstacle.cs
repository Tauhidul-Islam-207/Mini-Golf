using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public float speed = 1f;
    public float leftLimit = -0.5f;
    public float rightLimit = 0.5f;

    private Vector3 direction = Vector3.right;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x >= rightLimit)
        {
            direction = Vector3.left;
        }

        else if (transform.position.x <= leftLimit)
        {
            direction = Vector3.right;
        }
    }
}
