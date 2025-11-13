using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using static UnityEngine.Rendering.DebugUI;

public class Human : MonoBehaviour
{
    public float Dropspeed = 5f;

    void Start()
    {
      
    }
    void Update()
    {
        transform.Translate(Vector3.down * Dropspeed * Time.deltaTime);
    }

    public int HumanValue = -10;
    public void OnMouseDown()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.AddScore(HumanValue);
        }
        Destroy(gameObject);
    }
}
