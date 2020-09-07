using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    private void Update() {
        Enemy();
    }

    public void Enemy() {
        transform.Translate(-transform.right * speed * Time.deltaTime);
    }
}
