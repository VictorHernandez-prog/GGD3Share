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
        
    }

}