using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    // 충돌이 발생했을 때 한 번 호출되는 콜백함수
    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 객체가 Bullter인지 확인
        if (collision.gameObject.CompareTag("BULLET"))
        {
            // 총알 삭제
            Destroy(collision.gameObject);
        }
    }
}
