using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform target;
   void Update()
   {
   	    //To make the HealthBar follow the player.
        transform.position = target.transform.position;
   }
}
