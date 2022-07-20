using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float v;
    private float h;
    private float r;

    public float moveSpeed = 8.0f;
    public float turnSpeed = 50.0f;

    public Animation anim;

    private void Awake()
    {
        
    }

    void Start()
    {
        anim = GetComponent<Animation>();
        anim.Play("Idle");
    }
  
    void Update()
    {
        v = Input.GetAxis("Vertical"); // -1.0f ~ 1.0f
        h = Input.GetAxis("Horizontal");
        r = Input.GetAxis("Mouse X");

        //transform.position += new Vector3(0, 0, 0.01f); // Z�� 0.01f ����
        //transform.Translate(Vector3.forward * v * 0.01f);
        //transform.Translate(Vector3.right * h * 0.01f);

        // X + Y
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        // Z
        transform.Translate(moveDir.normalized * moveSpeed * Time.deltaTime );
        // Rotation
        transform.Rotate(Vector3.up * r * turnSpeed * Time.deltaTime );

        PlayerAnimation();
    }

    void PlayerAnimation()
    {
        if (v >= 0.1f) // 전진
        {
            //anim.Play("RunF");
            anim.CrossFade("RunF");
        }
        else if (v <= -0.1f) // 후진
        {
            anim.CrossFade("RunB");
        }
        else if (h >= 0.1f) // 오른쪽
        {
            anim.CrossFade("RunR");
        }
        else if (h <= -0.1f) // 왼쪽
        {
            anim.CrossFade("RunL");
        }
        else
        {
            anim.CrossFade("Idle");
        }
    }

    /*  Normalized Vector
     
        Vector3.forward = new Vector3(0, 0, 1);
        Vector3.up      = new Vector3(0, 1, 0);
        Vector3.right   = new Vector3(1, 0, 0);

        Vector3.one     = new Vector3(1, 1, 1);
        Vector3.zero    = new Vector3(0, 0, 0);
     */

    private void FixedUpdate()
    {
        
    }

    private void LateUpdate()
    {
        
    }
}
