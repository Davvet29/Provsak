using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthScript : MonoBehaviour
{
    private int maxHealth = 3;
    private int currentHealth;
    [SerializeField] private TMP_Text healthText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;   
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + currentHealth;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    public void OnDamageTaken()
    {
        currentHealth -= 1;
    }
}
