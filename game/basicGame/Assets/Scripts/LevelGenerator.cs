using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform Section;
    [SerializeField] private List<Transform> Obsticle;
    private float spawnSectionTime = 8f;
    private float spawnObsticleTime = 3f;

    private void Awake()
    {
        SpawnSection();
        spawnObsticleTime = ApplicationInstance.SharedInstance.GetMode() * 1f;
        InvokeRepeating("SpawnSection", spawnSectionTime, spawnSectionTime);
        InvokeRepeating("SpawnObsticle", spawnObsticleTime, spawnObsticleTime);
    }

    private void SpawnSection()
    {
        float x = 90;
        float y = -450.00E-2f;
        Vector3 position = new Vector3(x, y);
        Instantiate(Section, position, Quaternion.identity);
    }

    private void SpawnObsticle()
    {
        float x = 10;
        float y = -350.00E-2f;
        Vector3 position = new Vector3(x, y);
        Instantiate(Obsticle[Random.Range(0, Obsticle.Count)], position, Quaternion.identity);
    }

}
