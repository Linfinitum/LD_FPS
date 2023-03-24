using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesDeathCounter : MonoBehaviour
{
    public int enemyCounter;
    Gamekit3D.GameCommands.SimpleTranslator door;
    private void Start()
    {
        door = GetComponent<Gamekit3D.GameCommands.SimpleTranslator>();
    }

    public void DecreaseCounter()
    {
        enemyCounter--;
        if(enemyCounter ==0)
        {
            door.activate = true;
            //Destroy(gameObject);
        }
    }
}
