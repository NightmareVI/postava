using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float cameraSpeed, cameraSpeed2;
    [SerializeField] GameObject player;

    void Update()
    {if (player.transform.position.x>transform.position.x){
        transform.position += new Vector3(cameraSpeed2 * Time.deltaTime, 0, 0);}
        else if (player.transform.position.x<transform.position.x){
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);}
    }
   
}
   
