using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnEnnemiesDeath : MonoBehaviour
{
    public EnemiesDeathCounter counter;

    private void OnDestroy()
    {
        counter.DecreaseCounter();        
    }

}
