using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    void Start()
    {
		  InvokeRepeating("Spawn", .5f, 2);
    }
    
    Vector3 RandomCircle (Vector3 center, float radius)
    {
        float ang = Random.value * 360;
	    Vector3 pos;

	    pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
	    pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
	    pos.z = center.z;

	    return pos;
    }

    public GameObject zombiePrefab;
    int spawnCounter;
    void Spawn()
    {
	    int numberOfZombies = Random.Range(2 + spawnCounter, 7 + spawnCounter);
      
      for (spawnCounter = 0; spawnCounter < numberOfZombies; spawnCounter++)
      {
        Vector2 position = RandomCircle(Vector3.zero, 20);
        Instantiate(zombiePrefab, position, Quaternion.identity);
      }
    }
}
