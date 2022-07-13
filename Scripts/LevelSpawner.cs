using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    public GameObject Template;
    public GameObject TemplateEmpty;
    public GameObject SpawnTo;
    private float DistanceTravelled = 0;

    private void Start()
    {
        GameObject Spawned = Instantiate(TemplateEmpty, SpawnTo.transform);
        Spawned.transform.parent = transform;
        SpawnTo.transform.position += new Vector3(0, 0, -20);
        GameObject Spawned1 = Instantiate(TemplateEmpty, SpawnTo.transform);
        Spawned1.transform.parent = transform;
        SpawnTo.transform.position += new Vector3(0, 0, -20);
        GameObject Spawned2 = Instantiate(TemplateEmpty, SpawnTo.transform);
        Spawned2.transform.parent = transform;
    }

    public void Update()
    {
        transform.position += new Vector3(0, 0, 5 * Time.deltaTime);

        if(transform.position.z - DistanceTravelled >= 20)
        {
            DistanceTravelled = transform.position.z;
            GameObject Spawned = Instantiate(Template, SpawnTo.transform);
            Spawned.transform.parent = transform;
        }
    }
}
