using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private FloatVariable score;

    [SerializeField]
    private TextMeshProUGUI text;

    private void OnEnable() {
        score.value = 0;
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject) {
            if (col.gameObject.tag == "Enemy") {
                score.value += 1;
                UpdateText();
            }
        }
    }

    private void UpdateText() {
        text.text = "Score: " + score.value.ToString();
    }
}
