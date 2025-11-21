using UnityEngine;
using UnityEngine.Events;

public class EnemyDamageScript : MonoBehaviour
{
    private UnityEvent OnHitPlayer;
    int damage = 1;
    [SerializeField] private BoxCollider2D sideCheckCollider;
    [SerializeField] private LayerMask playerLayer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (OnHitPlayer == null)
            OnHitPlayer = new UnityEvent();
        OnHitPlayer.AddListener( GameObject.Find("HealthText").GetComponent<HealthScript>().OnDamageTaken);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (sideCheckCollider.IsTouchingLayers(playerLayer))
        {
            Debug.Log("TOUCHING PLAYER");
            OnHitPlayer?.Invoke();
        }
    }
}
