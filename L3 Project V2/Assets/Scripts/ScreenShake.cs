using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public Transform cam;

    public float shakeTime = 0;
    public float shakeAmount = 0.7f;
    public float damping = 1;
    Vector3 initPos;

    void Update()
    {
        if (shakeTime > 0)
        {
            cam.localPosition = initPos + Random.insideUnitSphere * shakeAmount;
            shakeTime -= Time.deltaTime * damping;
        }
    }

    public void TriggerShake(float t, float d)
    {
        damping = d;
        shakeTime = t;
        initPos = cam.localPosition;
    }
}
