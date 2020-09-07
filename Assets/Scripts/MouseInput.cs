using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour, IInput
{
    public bool GetInput() {
        return Input.GetMouseButton(0);
    }
}
