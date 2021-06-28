using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTheEnemy : MonoBehaviour
{
    public AudioSource audioData;
    public AudioClip poof;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            audioData.clip = poof;
            audioData.Play();
            Destroy(other.gameObject);

        }
    }
}
