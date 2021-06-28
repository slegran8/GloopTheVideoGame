using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int currentCoin;

    public Text coinText;

    public Text healthText;

    public GameObject portal;

    // Start is called before  the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(currentCoin >= 3)
        {
            portal.SetActive(true);
        }
        else
        {
            portal.SetActive(false);
        }
    }

    public void AddCoin(int coinToAdd)
    {
        currentCoin += coinToAdd;
        coinText.text = "Coin " + currentCoin + " out of 3";
  
    }

    public void HealthPrinted(int CurrentHealth)
    {
        healthText.text = "Health: " + CurrentHealth;
    }
}
