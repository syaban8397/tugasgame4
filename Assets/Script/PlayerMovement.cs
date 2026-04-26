using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 move;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();

        string inputKey = "";

        if (move == Vector2.up)
            inputKey = "W";
        else if (move == Vector2.down)
            inputKey = "S";
        else if (move == Vector2.left)
            inputKey = "A";
        else if (move == Vector2.right)
            inputKey = "D";

        Debug.Log(inputKey + " → " + move);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
}