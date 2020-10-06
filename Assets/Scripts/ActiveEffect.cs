using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveEffect : MonoBehaviour
{
    [SerializeField]
    private GameObject effectObject;
    

    private void Awake() {
        
    }
    // Active effect on trigger
    private void OnTriggerStay2D(Collider2D col) {
        if (col.gameObject) {
            if (col.gameObject.GetComponent<PlayerBallon>()) {
                effectObject.SetActive(true);
                
            }
        }
    }
}
