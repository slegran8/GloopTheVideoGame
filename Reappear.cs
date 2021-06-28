using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reappear : MonoBehaviour
{
    public float Seconds = 2;

    Vector3 iniScale;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            iniScale = transform.localScale;
            StartCoroutine(Poof());
            StartCoroutine(Wizard());
        }
    }
  

    IEnumerator Poof()
    {
        yield return new WaitForSeconds(Seconds);
        transform.localScale = Vector3.zero;
    }

    IEnumerator Wizard()
    {
        yield return new WaitForSeconds(4);
        transform.localScale = iniScale;
    }



}
