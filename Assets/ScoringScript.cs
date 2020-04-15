using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoringScript : MonoBehaviour
{

    public TextMeshProUGUI scoringtext1, scoringtext2;
    public static int scoreP1 = 0, scoreP2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoringtext1.text = scoreP1.ToString();
        scoringtext2.text = scoreP2.ToString();

    }

    // Update is called once per frame
    public void UpdateScore(string wallName)
    {
        if (wallName == "WallVerticalKiri")
        {
            scoreP2 += 1;
            scoringtext2.text = scoreP2.ToString();
        }
        else if (wallName == "WallVerticalKanan")
        {
            scoreP1 += 1;
            scoringtext1.text = scoreP1.ToString();
        }
    }
}
