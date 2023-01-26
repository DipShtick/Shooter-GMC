using UnityEngine;

public class ZBehavior : MonoBehaviour
{
  Transform player;
  Vector2 dir;
  Rigidbody2D rb;

  public float speed = 2f;

  HealthManager hm;
  void Awake()
  {
    hm = GetComponent<HealthManager>();

    speed = Random.Range(2f, 15f);
    hm.health = Random.Range(25, 100);
  }

  void Start()
  {
		rb = GetComponent<Rigidbody2D>();
		player = GameObject.FindGameObjectWithTag("Player").transform;
  }

    private void Update()
    {
		  if (player)
      {
        dir = (player.position - transform.position).normalized;
      }
		
    }

    void FixedUpdate()
    {
		  rb.velocity = dir * speed;

		  float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		  rb.rotation = angle;
    }
}
