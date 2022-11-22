using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 dir;
    public float speed = 5;
    //���� ���� �ּ� �����
    public GameObject explosionFactory;
    void Start()
    {
        //30% Ȯ���� player����, �������� �Ʒ���
        //0���� 9���� 10���� ���߿� �ϳ��� �������� �����´� 
        int randomVelue = Random.Range(0, 10);
        //���� 3���� ������ �÷��̾� ��?��
        if(randomVelue < 3)
        {
            //�÷��̾ ã�Ƽ� target���� �Ѵ�.
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;

            //������ ũ�⸦ 1�� �ϰ�ʹ�.
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
    }
    void Update()
    {
        //���� ���ϱ�
        transform.position += dir * speed * Time.deltaTime;
    }
    void OnCollisionEnter(Collision other)
    {
        //0. ���� �ٸ� ��ü�� �浹 �����ϱ�
        //1. Scene���� ScoreManager��ü�� ã�ƿ���
        GameObject smObject = GameObject.Find("ScoreManager");

        //2. ScoreManager GameObject���� Component�� �����´�
        ScoreManager sm = smObject.GetComponent<ScoreManager>();

        ScoreManager.Instance.SetScore(ScoreManager.GetScore() + 1);
        //3. ScoreManager Ŭ������ �Ӽ��� ���� �Ҵ��Ѵ�.
        

        //���� ȿ�� ����
        GameObject explosion = Instantiate(explosionFactory);
        //���� ȿ�� ��ġ �̵�
        explosion.transform.position = transform.position;
        //�� �װ�
        Destroy(other.gameObject);
        //�� ����
        Destroy(gameObject);
    }
}