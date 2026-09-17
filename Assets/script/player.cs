using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movehorizontal = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(movehorizontal * speed, rb.linearVelocity.y);

        Debug.Log(Input.GetAxis("Horizontal"));

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, 5f),ForceMode2D.Impulse);
        }
    }
}
