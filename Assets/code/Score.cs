using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text GameScore;
    public float ScoreAmmount;
    public float increaseScore;

    // Start is called before the first frame update
    void Start()
    {
        ScoreAmmount = 0f;
        increaseScore = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        GameScore.text = (int)ScoreAmmount + "";
        ScoreAmmount += increaseScore * Time.deltaTime;


    }
}
