using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public PlayerController thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        FindObjectOfType<GameManager>().HealthPrinted(currentHealth);

        if(currentHealth < 0){
            SceneManager.LoadScene(0);
        }
    }

    public void HurtPlayer(int damage, Vector3 direction)
    {
        currentHealth -= damage;

        thePlayer.Knockback(direction);
    }

    public void HealPlayer(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
