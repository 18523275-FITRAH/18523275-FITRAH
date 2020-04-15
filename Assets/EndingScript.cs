using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingScript : MonoBehaviour
{
    public TextMeshProUGUI endText;
    // Start is called before the first frame update
    void Start()
    {
        if (ScoringScript.scoreP1 > ScoringScript.scoreP2)
        {
            endText.text = "P1 WIN";
        } else if (ScoringScript.scoreP1 < ScoringScript.scoreP2)
        {
            endText.text = "P2 WIN";
        } else
        {
            endText.text = "DRAW";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
