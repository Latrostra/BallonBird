using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Transform of the camera to shake. Grabs the gameObject's transform
    // if null.
    [SerializeField]
    public Transform camTransform;

    // How long the object should shake for.
    public float shakeDuration = 0f;

    // Amplitude of the shake. A larger value shakes the camera harder.
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;
    public float shakeElapsedDuration;

    Vector3 originalPos;

    void Awake()
    {
        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    void OnEnable()
    {
        originalPos = camTransform.localPosition;
        shakeElapsedDuration = shakeDuration;
    }

    public void Update()
    {
        if (shakeElapsedDuration > 0)
        {
            camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

            shakeElapsedDuration -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shakeElapsedDuration = 0f;
            camTransform.localPosition = originalPos;
            gameObject.SetActive(false);
        }
    }
}

