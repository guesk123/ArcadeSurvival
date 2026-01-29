using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed = 3f;
    Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        collision.gameObject
            .GetComponent<PlayerHealth>()
            .TakeDamage(1);
    }
}
}