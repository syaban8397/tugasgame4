using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public Transform pointA;
    public Transform pointB;

    private bool goingRight = true;

    void Update()
    {
        if (pointA == null || pointB == null) return;

        float direction = goingRight ? 1f : -1f;

        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        if (transform.position.x >= pointB.position.x)
        {
            goingRight = false;
        }
        else if (transform.position.x <= pointA.position.x)
        {
            goingRight = true;
        }

        Vector3 scale = transform.localScale;
        scale.x = goingRight ? Mathf.Abs(scale.x) : -Mathf.Abs(scale.x);
        transform.localScale = scale;
    }
}