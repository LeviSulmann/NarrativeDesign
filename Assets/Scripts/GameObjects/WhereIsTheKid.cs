using UnityEngine;
using System.Collections.Generic;

public class WhereIsTheKid : MonoBehaviour
{
    public List<GameObject> kids;
    private float timer = 0f;
    private float interval = 5f;
    private int kiddoCount = 0;

    void Start()
    {
        // Find all GameObjects with the "Kids" tag and add them to the kids list
        GameObject[] kidArray = GameObject.FindGameObjectsWithTag("Kids");
        foreach (GameObject kid in kidArray)
        {
            kids.Add(kid);
            kid.SetActive(false);
        }

        
    }

    void Update()
    {
        GekkeFunctie();
    }


    public void GekkeFunctie()
    {

        timer += Time.deltaTime;

        if (timer >= interval)
        {
            // Randomly choose one of the kids from the list
            int randomIndex = Random.Range(0, kids.Count);
            GameObject randomKid = kids[randomIndex];

            // Set the randomly chosen kid inactive
            randomKid.SetActive(true);


            GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Kids");

            // Set all objects with the "MyTag" tag to inactive
            foreach (GameObject obj in objectsWithTag)
            {
                obj.SetActive(false);
                if (timer >= 7)
                {
                    Debug.Log("Hij is er"); 
                   
                }

            }

            timer = 0f;
        }
    }
}