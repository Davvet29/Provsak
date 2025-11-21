using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthScript : MonoBehaviour
{
    private int maxHealth = 3;
    private int currentHealth;
    [SerializeField] private TMP_Text healthText;
    private float invincibleTimer;
    [SerializeField] private SpriteRenderer playerSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerSprite = GameObject.Find("Player").GetComponent<SpriteRenderer>();
        currentHealth = maxHealth;   
    }

    // Update is called once per frame
    void Update()
    {
        if (invincibleTimer >= 0)
        {
            invincibleTimer -= Time.deltaTime;
        }
        else
        {
            playerSprite.color = Color.white;
        }
        healthText.text = "Health: " + currentHealth;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    public void OnDamageTaken()
    {
        if (invincibleTimer <= 0)
        {
            playerSprite.color = Color.red;
            currentHealth -= 1;
            invincibleTimer = 1;
        }
    }
}
