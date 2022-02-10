using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningDivider : MonoBehaviour
{
    private const int RotationSpeed = 100;

    void Update()
    {
        transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);
    }
}
