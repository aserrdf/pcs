using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    //싱글턴 객체
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

                //4. 화면에 점수 변화
                currentScoreUI.text = "현재점수 : " + currentScore.ToString("D8");

                //목표: 최고점수를 표시하고 싶다.
                //1번 현재 점수가 최고 점수보다 크니까
                //만약 현재점수가 최대점수를 초과 했다면
                if (currentScore > bestScore)
                {
                    //2번 최고점수를 갱신 시킨다
                    bestScore = currentScore;
                    //3번 최고점수를 ui에 표시
                    bestScoreUI.text = "최고점수 :" + bestScore;
                    //목표 최고점수를 저장하곳싶다!!
                    PlayerPrefs.SetInt("Best Score", bestScore);
                }
            }
        }
    }
    //현재점수 UI;
    public Text currentScoreUI;
    //현재점수
    //인스펙터 창에서 가리기
    [System.NonSerialized] // = HideInInspector
    private int currentScore;

    //목표: 최고점수를 표시라고 싶다.
    //필요속성: 최고점수 ui, 최고점수 기억
    public Text bestScoreUI;
    //최고점수
    private int bestScore;

    //현재 점수가 최고점수보다 크니깐
    //최고점수를 갱신 시킨다.
    //최고 점수 ui표시

    //목표:최고점수를 불러와서 베스트 스코엉 점수에 활당하고 화면에 표시하고 싶다~~
    //순서: 최고점수를 불러와 베스트스코어에 넣어주기
    //최고점수를 화면에 표시하기

    private void Start()
    {
        //순서1 최고점수를 불러와 베스트 스코어에 넣어주기
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        //순서2 최고점수를 화면에 표시하기
        bestScoreUI.text = "최고점수 : " + bestScore;
    }



    

    public int GetScore()
}