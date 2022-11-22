using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //�����ð����� ���� ������ EnemyManager��ġ�� �� �̵�
    //�����ð� == �����ð�(����ð�, �� ������ �ʿ�)
    //1. �ð��� �帣�� 2. ���� �ð��� �����ð��� �Ǹ� 3. �� ���� 4. EnemyManager��ġ�� �̵�

    //����ð�
    float currentTime;
    //�����ð�
    public float createTime;
    //�� ������
    public GameObject enemyFactory;

    //�� ���� �ð��� �������� �ϰ�;� ���󿡸� �ּҽð��� �ִ�ð�

    //�ּҽð�
    float minTime = 1f;
    float maxTime = 5f;
    void Start()
    {
        createTime = Random.Range(minTime, maxTime);    
    }
    void Update()
    {
        //�ð��� �帧
        currentTime += Time.deltaTime;
        //���� ����ð��� �����ð��� �Ǹ�
        if(currentTime > createTime)
        {
            //�� ���� �� EnemyManager��ġ�� �̵�
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            currentTime = 0;
            createTime = Random.Range(minTime, maxTime);
        }
    }
}