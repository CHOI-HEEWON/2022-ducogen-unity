using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullter : MonoBehaviour
{
    // �浹�� �߻����� �� �� �� ȣ��Ǵ� �ݹ��Լ�
    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ��ü�� Bullter���� Ȯ��
        if (collision.gameObject.CompareTag("BULLET"))
        {
            // �Ѿ� ����
            Destroy(collision.gameObject);
        }
    }
}
