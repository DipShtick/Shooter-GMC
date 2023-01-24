using System.Collections;
using UnityEngine;

public class MaximusDeletus : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(GetAllZombies());
    }

    GameObject[] zombies;
    IEnumerator GetAllZombies()
    {
        zombies = GameObject.FindGameObjectsWithTag("Zombie");

        yield return new WaitForSecondsRealtime(5);
        
        DestroyAllZombies();
        StartCoroutine(GetAllZombies());
    }
    public void DestroyAllZombies()
    {
        for (int i = 0; i < zombies.Length; i++)
        {
            Destroy(zombies[i]);
        }
    }
}
