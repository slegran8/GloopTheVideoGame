using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab_Coin : MonoBehaviour
{
    public int value;

    public GameObject CoinPickup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddCoin(value);

            Instantiate(CoinPickup, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }
}
