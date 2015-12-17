using UnityEngine;
using System.Collections;

public class BallManager : MonoBehaviour {
    static TextMesh text;
    public int StartBalls;
    public int MaxBalls;
    static int _max;
    public static int balls;
	// Use this for initialization
	void Awake () {
        balls = StartBalls;
        _max = MaxBalls;
        text = GetComponent<TextMesh>();
        UpdateBallText();
    }
	
	// Update is called once per frame
	static void UpdateBallText () {
        text.text = "Balls: " + balls;
    }

    public static void addBall()
    {
        if (balls < _max)
        {
            balls++;
        }
        UpdateBallText();
    }

    public static void removeBall()
    {
        if (balls > 0)
        {
            balls--;
        }
        UpdateBallText();
    }
}
