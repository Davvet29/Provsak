using UnityEngine;

public class EnemyWalkingScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Rigidbody2D rb;
    private Vector2 velocity;
    [SerializeField] private int walkingDirection = 1;
    [SerializeField] private int speed = 5;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private BoxCollider2D sideCheckCollider;
    private float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (sideCheckCollider.IsTouchingLayers(groundLayer) || timer >= 7)
        {
            timer = 0;
            walkingDirection *= -1;
        }
        
        velocity = new Vector2(walkingDirection * speed, 0);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = velocity;
    }
}
