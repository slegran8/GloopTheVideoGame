using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    float blinkInterval = 5.0f; // Turn on/off every second
    public GameObject platform;

    void Start()
    {
        StartCoroutine("OnOff");
    }

    IEnumerator OnOff()
    {
        while (true)
        {
            platform.SetActive(!platform.activeSelf);
            yield return new WaitForSeconds(blinkInterval);
            platform.SetActive(platform.activeSelf);
            yield return new WaitForSeconds(blinkInterval / 2f);
        }
    }

}
