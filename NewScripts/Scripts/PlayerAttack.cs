using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float blinkInterval;
    public GameObject attack;
    public bool IsActive = false;
    // Start is called before the first frame update
    void Start()
    {


        attack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Attack(1.0f, 1.0f));
        }
    }


    void StopAttack()
    {
        StopCoroutine("Attack");
        IsActive = false;

        attack.SetActive(false);
    }

    IEnumerator Attack(float attackTime, float waitTime)
    {
        IsActive = true;
        while (true)
        {
            attack.SetActive(true);
            yield return new WaitForSeconds(attackTime);
            attack.SetActive(false);
            yield return new WaitForSeconds(waitTime);

            break;
        } 
       
    }

   


}
