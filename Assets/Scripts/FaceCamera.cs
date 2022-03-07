using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    void Update()
    {
        // rotate the canvas to be facing the player correctly
        Vector3 v = player.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(player.transform.position - v);
        transform.Rotate(0, 180, 0);
    }
}
