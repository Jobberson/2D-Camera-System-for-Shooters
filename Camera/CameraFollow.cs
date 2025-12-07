using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{   
    /// <summary>
    /// This is the script that makes the camera follow the player around the maps.
    /// Always use this script with the player
    /// </summary>

    [Header("Player Transform")]
    [SerializeField] private Transform followObj;
    
    [Header("Camera")]
    [SerializeField] Camera cam;
    [SerializeField] private float FollowSpeed = 2f;

    [Header("Variables")]
    [SerializeField] private float yOffset = 1f; // changes de position y value of the camera

    void Update()
    {
        Vector3 newPos = new(followObj.position.x, followObj.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }

}
