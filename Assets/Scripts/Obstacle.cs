using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollsionEnter2D(Collision2D col) {
        if (col.gameObject) {
            col.gameObject.GetComponent<PlayerBallon>().TakeDamage();
        }
    }
}
