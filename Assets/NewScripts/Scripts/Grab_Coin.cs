using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab_Coin : MonoBehaviour
{
    public int value;

    public GameObject BlueCoinPickup;

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

            Instantiate(BlueCoinPickup, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }
}
