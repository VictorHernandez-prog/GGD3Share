using UnityEngine;

public class Humanmanager : MonoBehaviour
{
    public GameObject Human;
    public Vector3 MinimumArea;
    public Vector3 MaximumArea;
    public int Humancount = 0;
    public int MaxHumancount = 15;
    void Start()
    {

        InvokeRepeating("SpawnHuman", 0f, 4f);

    }

    //Chunk of code for spawn area and limiting spawns
    void SpawnHuman()
    {
        if (Humancount < MaxHumancount)
        {
            float randomX = Random.Range(MinimumArea.x, MaximumArea.x);

            Vector3 randomSpawnPosition = new Vector3(randomX, 6, 0);

            GameObject Newobject = Instantiate(Human, randomSpawnPosition, Quaternion.identity);
            Destroy(Newobject, 4f);

            Humancount++;
        }
        else
        {
            CancelInvoke("SpawnHuman");
        }
    }
}
