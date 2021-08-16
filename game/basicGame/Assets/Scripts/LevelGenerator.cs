using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    [SerializeField] private Transform levelStart;
    [SerializeField] private List<Transform> EazySection;
    [SerializeField] private Transform ScoreTable;
    private Vector3 lastSectionEnd;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ScoreTable, new Vector3(0, 5), Quaternion.identity);
    }

    private void Awake()
    {
        int i = 1;
        while (i < 10) {
            SpawnSection(i);
            i += 1;
        }
    }

    private void SpawnSection(int x)
    { 
        Transform levelSection = SpawnSectionAt(new Vector3(x * 90, -450.00E-2f));
        //if(levelSection != null)
        //{
        //    lastSectionEnd = levelSection.Find("EndPoint").position;
        //}
    }

    private Transform SpawnSectionAt(Vector3 position)
    {
        Transform levelSection = Instantiate(EazySection[Random.Range(0, EazySection.Count)], position, Quaternion.identity);
        return levelSection;
    }


    // Update is called once per frame
    void Update()
    {
        int score = player.GetScore();
        Transform table = ScoreTable.Find("Score");
    }
}
