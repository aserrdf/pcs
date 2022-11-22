using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    //�̱��� ��ü
    public static ScoreManager instance=null;

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }

    public int Score
    {
        get
        {
            return currentScore;
        }

        set
        {
            public void SetScore(int value)
            {
                currentScore++;

                //4. ȭ�鿡 ���� ��ȭ
                currentScoreUI.text = "�������� : " + currentScore.ToString("D8");

                //��ǥ: �ְ������� ǥ���ϰ� �ʹ�.
                //1�� ���� ������ �ְ� �������� ũ�ϱ�
                //���� ���������� �ִ������� �ʰ� �ߴٸ�
                if (currentScore > bestScore)
                {
                    //2�� �ְ������� ���� ��Ų��
                    bestScore = currentScore;
                    //3�� �ְ������� ui�� ǥ��
                    bestScoreUI.text = "�ְ����� :" + bestScore;
                    //��ǥ �ְ������� �����ϰ��ʹ�!!
                    PlayerPrefs.SetInt("Best Score", bestScore);
                }
            }
        }
    }
    //�������� UI;
    public Text currentScoreUI;
    //��������
    //�ν����� â���� ������
    [System.NonSerialized] // = HideInInspector
    private int currentScore;

    //��ǥ: �ְ������� ǥ�ö�� �ʹ�.
    //�ʿ�Ӽ�: �ְ����� ui, �ְ����� ���
    public Text bestScoreUI;
    //�ְ�����
    private int bestScore;

    //���� ������ �ְ��������� ũ�ϱ�
    //�ְ������� ���� ��Ų��.
    //�ְ� ���� uiǥ��

    //��ǥ:�ְ������� �ҷ��ͼ� ����Ʈ ���ھ� ������ Ȱ���ϰ� ȭ�鿡 ǥ���ϰ� �ʹ�~~
    //����: �ְ������� �ҷ��� ����Ʈ���ھ �־��ֱ�
    //�ְ������� ȭ�鿡 ǥ���ϱ�

    private void Start()
    {
        //����1 �ְ������� �ҷ��� ����Ʈ ���ھ �־��ֱ�
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        //����2 �ְ������� ȭ�鿡 ǥ���ϱ�
        bestScoreUI.text = "�ְ����� : " + bestScore;
    }



    

    public int GetScore()
}