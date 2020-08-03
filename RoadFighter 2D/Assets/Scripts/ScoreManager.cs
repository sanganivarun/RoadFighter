using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    #region INSTANTIATE
    public static ScoreManager sm = null;

    void OnEnable()
    {
        ScoreManager.sm = this;
    }
    #endregion

    private float score = 0;

    public Text scoreText;

    public void UpdateScore()
    {
        score += Time.deltaTime * 2f;

        scoreText.text = (Mathf.FloorToInt(score)).ToString();
    }

    void FixedUpdate()
    {
        UpdateScore();
    }


}
