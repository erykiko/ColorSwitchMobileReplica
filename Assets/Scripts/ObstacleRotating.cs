using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotating : MonoBehaviour
{
    public float rotatingSpeed = 100f;
    private void Update() {
        transform.Rotate(0f, 0f, rotatingSpeed * Time.deltaTime);
    }
}
