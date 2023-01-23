using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public float damage;
    public string enemyTag; 

    void OnCollisionEnter2D(Collision2D other)
    {
	    if(other.gameObject.tag == enemyTag)
        {
		    other.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
	    }
    }

}
