using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    public GameObject catPrefab;
    float frequency = 15f;
    float timeSinceLastSpawn = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if(timeSinceLastSpawn >= frequency)
        {
            SpawnCat();
            timeSinceLastSpawn = 0;
            UpdateFrequency();
        }
    }

    void SpawnCat()
    {
        print("new cat, meow :3");
        GameObject newCat = Instantiate(catPrefab, new Vector3(2, 1, 0), Quaternion.identity);
    }

    void UpdateFrequency()
    {
        print(MileageTracker.instance.TheMileage());
        if(MileageTracker.instance.shouldUpdate && frequency > 5)
        {
            frequency -= 1f;
        }
    }

    
}
