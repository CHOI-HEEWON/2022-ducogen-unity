using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePos;

    // AudioSource 컴포넌트 저장할 변수
    private AudioSource audio;

    // 발생시킨 음원 파일을 저장할 변수
    public AudioClip fireSfx;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        // 게임오브젝트 또는 프리팹 생성하는 메소드
        // Instantiate(생성할객체, 위치, 각도)
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);

        // 총 발사 사운드 실행
        audio.PlayOneShot(fireSfx, 1.0f);
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
