using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    public GameObject hitEffect;

    [SerializeField]
    public int bulletDamage;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D aster)
    {
        if(aster.tag == "Asteroid")
        {
            Enemy asteroid = aster.GetComponent<Enemy>();
            if (asteroid != null)
            {
                asteroid.TakeDamage(bulletDamage);
            }

            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.2f);
            Destroy(gameObject);
        }
        
    }

}
