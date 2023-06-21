using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    ////##done before
    //Vector2 direction;
    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private float speed;

    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        //// ###done before###
        // direction = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        //// ###done before###
        direction = randomVector3Except(-2, 2);

    }

    // Update is called once per frame
    void Update()
    {
        //// ###done before###
        //float inputMagnitude = Mathf.Clamp01(direction.magnitude);
        //direction.Normalize();

        //transform.Translate(direction * speed * inputMagnitude * Time.deltaTime, Space.World);

        //Quaternion toRotaion = Quaternion.LookRotation(Vector3.forward, direction);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotaion, rotationSpeed * Time.deltaTime);
        //// ###done before###

        //// ##stage1##
        //transform.position += new Vector3(0, -1, 0) * Time.deltaTime;

        //// ##stage2.1##
        //transform.position += new Vector3(Random.Range(-2, 2), Random.Range(-2, 2), 0) * Time.deltaTime;
        //transform.Rotate(0, 0, 0.2f);

        //// ##stage2.2##
        //transform.position += new Vector3(Random.Range(-2, 2), Random.Range(-2, 2), 0) * Time.deltaTime;
        //transform.Rotate(0, 0, rotationSpeed);

        // ##HomeWork##
        // moved "new Vector..." to the Start() function
        // in cause to avoid the same direction of all asteroids
        transform.position += direction * Time.deltaTime;
        transform.Rotate(0, 0, rotationSpeed);
    }


    /// <summary>
    /// returns random Vector3 expect case (x = 0, y = 0) 
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="except"></param>
    /// <returns></returns>
    private Vector3 randomVector3Except(int min, int max, int except = 0)
    {
        Vector3 result;
        do
        {
            result = new Vector3(Random.Range(min, max), Random.Range(min, max), 0);
        } while (result.x == except && result.y == except);
        return result;
    }

}
