using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    private Animator fireAnim;

    [SerializeField]
    public float health;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float rotationSpeed;
    // Start is called before the first frame update

    private void Awake()
    {
        fireAnim = transform.GetChild(3).GetComponent<Animator>();
        shipAnim = transform.GetComponent<Animator>();
    }



    private Animator shipAnim;
    private bool hit = true;
    //private void Awake()
    //{
    //    fireAnim = transform.GetChild(2).GetComponent<Animator>();
    //    
    //}

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControllerScript.instance.isStarted == false)
            return;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);

        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();
        transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);



        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -22.5f, 22.5f),
            Mathf.Clamp(transform.position.y, -12.6f, 12.6f));

        if (movementDirection != Vector2.zero)
        {
            Quaternion toRotaion = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotaion, rotationSpeed * Time.deltaTime);
        }

        if (movementDirection == Vector2.zero)
            fireAnim.SetBool("isFireing", false);
        else
            fireAnim.SetBool("isFireing", true);
    }

    IEnumerator HitBoxOff()
    {
        hit = false;
        shipAnim.SetTrigger("Hit");
        yield return new WaitForSeconds(1.5f);
        hit = true;
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.tag == "Asteroid")
    //    {
    //        if (hit)
    //        {
    //            StartCoroutine(HitBoxOff());
    //            health--;
    //            Destroy(GameObject.Find("healthBar").transform.GetChild(0).gameObject);
    //        }
                
    //    }
    //}

}
