using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    [SerializeField]
    private float speed = 0.5f;
    private Material material;

    private void Awake() {
        material = GetComponent<Renderer>().material;
    }

    private void Update() {
        float offset = speed * Time.time; 
        material.mainTextureOffset = new Vector2(offset, 0);
    }
}
