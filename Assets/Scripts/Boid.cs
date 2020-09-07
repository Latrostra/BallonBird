using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour
{  
    public float speed = 600f;
    private void OnEnable() {
        Enemy();
    }

    public void Enemy() {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, Random.Range(250f, 400f)));
    }
}
