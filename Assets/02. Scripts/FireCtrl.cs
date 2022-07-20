using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // method for generating gameobject or prefab
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
    
    /*
        충돌관련 Call Back Function (Evnet)

        if IsTrigger = false
        OnCollisionEnter -> 1
        OnCollisionStay -> n
        OnCollisionExit -> 1

        if IsTrigger = true
        OnTriggerEnter
        OnTriggerStay
        OnTriggerExit
     */
}
