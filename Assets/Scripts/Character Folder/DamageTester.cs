using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DamageTester : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerAtm.DealDamage(enemyAtm.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            enemyAtm.DealDamage(playerAtm.gameObject);
        }
    }
}
