using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI Funnytext;
    public TextMeshProUGUI Finalscore;
    public int finalTask;
    void Start()
    {
        Finalscore.text = ScoreManager.Scoretotal.ToString();
        if (ScoreManager.Scoretotal > 0)
        {
            Funnytext.text = "Cool!";
        }
        else if (ScoreManager.Scoretotal < 0)
        {
            Funnytext.text = "Lame.";
        }
        else
        {
            Funnytext.text = "Wow..";
        }
    }

}