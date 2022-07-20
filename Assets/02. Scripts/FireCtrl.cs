using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePos;

    // AudioSource ������Ʈ ������ ����
    private AudioSource audio;

    // �߻���Ų ���� ������ ������ ����
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
        // ���ӿ�����Ʈ �Ǵ� ������ �����ϴ� �޼ҵ�
        // Instantiate(�����Ұ�ü, ��ġ, ����)
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);

        // �� �߻� ���� ����
        audio.PlayOneShot(fireSfx, 1.0f);
    }
    
    /*
        �浹���� Call Back Function (Evnet)

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
