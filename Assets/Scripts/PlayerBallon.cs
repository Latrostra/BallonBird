using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBallon : MonoBehaviour
{
    [SerializeField]
    private float thrust = 30f;
    private Rigidbody2D rigidbody2D;
    private IInput input;
    private Health health;

    private void Awake() {
        rigidbody2D = GetComponent<Rigidbody2D>();
        input = GetComponent<IInput>();
        health = GetComponent<Health>();
        health.OnDeath += OnDeathHandler;
    }

    private void FixedUpdate() {
        if (input.GetInput()) {
            rigidbody2D.velocity += new Vector2(0, thrust * Time.deltaTime);
        }
    }

    public void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Enemy") {
            TakeDamage();
        }
    }
    
    public void TakeDamage() {
        health.SetHealth(1);
    }

    public void OnDeathHandler() {
        SceneLoader.Instance.LoadGameOverScene();
    }
}
