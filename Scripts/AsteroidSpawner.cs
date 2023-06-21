using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    /// <summary>
    /// how often should spawn go on
    /// </summary>
    public float spawnTimer;

    /// <summary>
    /// prefab of object to spawn
    /// </summary>
    public Transform asteroid;

    /// <summary>
    /// prefab of object to spawn
    /// </summary>
    public Transform asteroidFollow;


    /// <summary>
    /// height and width of the field to be spawned
    /// </summary>
    public float spawnX = 20f, spawnY = 10f;

    //
    public float chanceToSpawnFollow = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //asteroid = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControllerScript.instance.isStarted == false)
            return;

        spawnTimer += Time.deltaTime;
        if(spawnTimer > 2)
        {
            //// ##stage 2.2
            //Instantiate(asteroid, new Vector3(Random.Range(10, -10), Random.Range(-5, 5), 0), transform.rotation);

            // force to spawn around spawn zone
            if (Random.Range(0, 100) < chanceToSpawnFollow)
                Spawn(asteroidFollow);
            else
                Spawn(asteroid);
            spawnTimer = 0;
        }
    }

    private void Spawn(Transform asteroid)
    {
        Instantiate(asteroid, new Vector3(Random.Range(-spawnX / 2, spawnX / 2), Random.Range(-spawnY / 2, spawnY / 2), 0), transform.rotation);
    }
}
