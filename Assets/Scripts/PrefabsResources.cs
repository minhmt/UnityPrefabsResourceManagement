using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PrefabsResources : MonoBehaviour
{
    public GameObject[] prefabsArray;
    public List<GameObject> prefabsList;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        prefabsArray = Resources.LoadAll<GameObject>("worldPrefabs/standardObjects/NPC1");
        prefabsList = Resources.LoadAll<GameObject>("worldPrefabs/standardObjects").ToList();

        SpawnPrefabs();
    }

    private void SpawnPrefabs()
    {
        for (i = 0; i < 5; i++)
        {
            Vector3 randomSpawnPos = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
            Instantiate(Resources.Load<GameObject>("worldPrefabs/standardObjects/NPC1"), randomSpawnPos, Quaternion.identity);
        }

        for (i = 0; i < 5; i++)
        {
            Vector3 randomSpawnPos = new Vector3(Random.Range(-10, 11), 20, Random.Range(-10, 11));
            Instantiate(Resources.Load<GameObject>("worldPrefabs/standardObjects/NPC2"), randomSpawnPos, Quaternion.identity);
        }



        Debug.Log(prefabsArray);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
