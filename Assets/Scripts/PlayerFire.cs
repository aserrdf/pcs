using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    float curDelay = 0;
    float maxDelay = 0.1f;
    //�Ѿ� ������ ����
    public GameObject bulletFactory;
    //�ѱ�
    public GameObject firePosition;
    void Update()
    {
        curDelay += Time.deltaTime;
        if (curDelay >= maxDelay)
        {
            if (Input.GetButton("Fire1"))
            {
                //�Ѿ� ����
                GameObject bullet = Instantiate(bulletFactory);
                bullet.transform.position = transform.position;
                curDelay = 0;
            }
        }
    }
}