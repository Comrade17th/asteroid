using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    float xPos;


    //int age = 2; // 1 2 3 4...
    //string name = " от в сапогах"; //
    //float length = 0.8f; // 1.2   100.1   50.9
    //bool is_home = true; // true false

    // Start is called before the first frame update
    void Start()
    {
        xPos = transform.position.x; // заносим начальную позицую

    }

    // Update is called once per frame
    void Update()
    {
        xPos += speed * Time.deltaTime;
        transform.position = new Vector2(xPos, transform.position.y);
    }
}
