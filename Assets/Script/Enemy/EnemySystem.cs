using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    public void DestroyEnemy()
    {
        Destroy(this.gameObject);
    }
}
