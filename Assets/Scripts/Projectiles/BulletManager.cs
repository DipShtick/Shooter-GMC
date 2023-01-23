using UnityEngine;

public class BulletManager : MonoBehaviour
{   
    Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public float BulletSpeed = 7f;
    void FixedUpdate()
    {
        rb.velocity = rb.position * BulletSpeed;   
    }
}
