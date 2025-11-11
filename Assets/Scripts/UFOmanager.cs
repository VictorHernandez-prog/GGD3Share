using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject UFO;
    public Vector3 MinimumArea;
    public Vector3 MaximumArea;
    public int UFOcount = 0;
    public int MaxUFOcount = 35;
    void Start()
    {
        
        InvokeRepeating("SpawnUFO", 0f, 1f);
    }
    void SpawnUFO()
    {
        if (UFOcount < MaxUFOcount)
        {
            float randomX = Random.Range(MinimumArea.x, MaximumArea.x);
            float randomY = Random.Range(MinimumArea.y, MaximumArea.y);

            Vector3 randomSpawnPosition = new Vector3(randomX, randomY, 0);

            Instantiate(UFO, randomSpawnPosition, Quaternion.identity);

            UFOcount++;
        }
        else
        {
            CancelInvoke("SpawnUFO");
        }    
    }
    
}   
