using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LorenzSystem : MonoBehaviour
{
    private const float SIGMA = 10;
    private const float RHO = 28;
    private const float BETA = 8f / 3f;

    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        float dt = 0.01f;

        float dx = SIGMA * (y - x) * dt;
        float dy = (x * (RHO - z) - y) * dt;
        float dz = (x * y - BETA * z) * dt;

        transform.position = new Vector3(x + dx, y + dy, z + dz);
    }
}
