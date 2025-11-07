using UnityEngine;
using UnityEngine.SceneManagement;

public class playbuttonscript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("game");
    }
}