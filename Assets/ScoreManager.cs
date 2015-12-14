using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {
    static TextMesh text;
    public static int score;
	// Use this for initialization
	void Awake () {
        text = GetComponent<TextMesh>();
        score = 0;
	}
	
	// Update is called once per frame
	public static void UpdateScoreText () {
        if (score < 10)
        {
            text.text = "00000000" + score;
        }else if (score < 100)
        {
            text.text = "0000000" + score;
        }else if(score < 1000)
        {
            text.text = "000000" + score;
        }
        else if (score < 10000)
        {
            text.text = "00000" + score;
        }
        else if (score < 100000)
        {
            text.text = "0000" + score;
        }
        else if (score < 1000000)
        {
            text.text = "000" + score;
        }
        else if (score < 10000000)
        {
            text.text = "00" + score;
        }
        else if (score < 100000000)
        {
            text.text = "0" + score;
        }else
        {
            text.text = "" + score;
        }

    }

    public static void UpdateScore(int i)
    {
        score += i;
        if (score > 999999999)
        {
            score = 999999999;
        }
        UpdateScoreText();
        
    }
}
