using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleThrasher : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject) {
            col.gameObject.SetActive(false);
        }
    }
}
