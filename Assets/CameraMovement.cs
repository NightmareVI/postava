using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float cameraSpeed, _fastSpeed ;
    [SerializeField] GameObject player;
    [SerializeField] float offset;
    private Vector3 target;
    private Vector3 Ytarget;

    void LateUpdate(){
    Ytarget = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    transform.position = Vector3.Lerp(transform.position, Ytarget, _fastSpeed*Time.deltaTime);
    if (player.transform.position.x + offset > transform.position.x){
        target = new Vector3 (player.transform.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, target, _fastSpeed*Time.deltaTime);}
        else{
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);}
    }
   
}
   
