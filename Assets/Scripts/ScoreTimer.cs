using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTimer : MonoBehaviour
{
    public float score = 0f;
    public float pointTime = 1f;

    public TextMeshProUGUI scoreValue;
    public TextMeshProUGUI finalScoreValue;

    private void Update()
    {
        scoreValue.text = ((int)score).ToString();
        finalScoreValue.text = ((int)score).ToString();
        score += pointTime * Time.deltaTime;
    }

}
