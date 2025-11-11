using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

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

    public void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
