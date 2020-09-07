using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloatVariableUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private FloatVariable score;

    private void OnEnable() {
        text.text = score.value.ToString();
    }
}
