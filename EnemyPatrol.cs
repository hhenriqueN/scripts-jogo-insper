using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public Transform pointA;
    public Transform pointB;
    private Vector3 target;

    void Start()
    {
        if (pointA != null) target = pointA.position;
    }

    void Update()
    {
        if (GameManager.gameOver) return; // Para de mover se o jogo acabar

        if (pointA != null && pointB != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, target) < 0.1f)
            {
                target = target == pointA.position ? pointB.position : pointA.position;
            }
        }
    }

    // Quando o inimigo encosta no Player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.SetEnemyHit(); // Ativa o Game Over
        }
    }
}
