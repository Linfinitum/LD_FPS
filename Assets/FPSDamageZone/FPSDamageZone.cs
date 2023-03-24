using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSDamageZone : MonoBehaviour
{
    public float cooldown = 0.5f;
    public float damage = 2;
    bool canDealDamage = true;
    float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= cooldown)
            canDealDamage = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if(canDealDamage)
            {
                Debug.Log(timer);
                other.GetComponent<Health>().TakeDamage(damage, other.transform.gameObject);
                canDealDamage = false;
                timer = 0;
            }  
        }
    }
}
