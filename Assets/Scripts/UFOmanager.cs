using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject BaseUFO;
    public Vector3 MinimumArea;
    public Vector3 MaximumArea;
    public int UFOcount = 0;
    public int MaxUFOcount = 35;
    void Start()
    {
        
        InvokeRepeating("SpawnUFO", 0f, 2f);

    }

    //Chunk of code for spawn area and limiting spawns
    void SpawnUFO()
    {
        if (UFOcount < MaxUFOcount)
        {
            float randomX = Random.Range(MinimumArea.x, MaximumArea.x);
            float randomY = Random.Range(MinimumArea.y, MaximumArea.y);

            Vector3 randomSpawnPosition = new Vector3(randomX, randomY, 0);

            GameObject Newobject = Instantiate(BaseUFO, randomSpawnPosition, Quaternion.identity);
            Destroy(Newobject, 4f);

            UFOcount++;
        }
        else
        {
            CancelInvoke("SpawnUFO");
        }    
    }
    
}   
