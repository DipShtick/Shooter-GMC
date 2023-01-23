using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public Behaviour[] disableOnDeath;

    public const float maxHP = 100;
    public float health = maxHP;

    public void TakeDamage(float amount)
    {
	    health -= amount; 

	    if(health <= 0)
	    {
		    health = 0;
		    Die();
	    }
}

    void Die()
    {
	    //Disable all the components inside the disableOnDeath array that you will assign from the inspector
	    foreach(Behaviour behaviour in disableOnDeath)
	    {
		    behaviour.enabled = false;
	    }
    }
}
