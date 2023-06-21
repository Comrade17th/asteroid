using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFollow : MonoBehaviour
{
    public float speed;
    public float distance;
    private Transform playerPos;
    //public bool isFollowing = false;

    //runs before start
    private void Awake()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, playerPos.position) > distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        }
    }
}
