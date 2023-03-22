using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KitchenStuffCounter : MonoBehaviour
{
    public int kitchenStuffCount = 0;
    private int totalObjects;
    public int activeObjects;

    public int numKitchenStuff;

    public float percentage;
    public DirtBar Healthbar;

    private void Start()
    {

        KitchenStuffCounterFunction();
        activeObjects = 0 + kitchenStuffCount;     
    }

    private void Update()
    {
      //  Healthbar.SetHealthBar(activeObjects);
        // Debug.Log(activeObjects + "activeObjects");
        percentage = ((float)activeObjects / kitchenStuffCount * 100f);
        Debug.Log(percentage + "%");

    }

    void KitchenStuffCounterFunction()
    {
        // Find all GameObjects with the "KitchenStuff" layer and increment the counter for each one
        foreach (GameObject obj in GameObject.FindObjectsOfType<GameObject>())
        {
            if (obj.layer == LayerMask.NameToLayer("KitchenStuff"))
            {
                kitchenStuffCount++;
            }
        }



        // Log the number of GameObjects with the "KitchenStuff" layer found
      //  Debug.Log("Found " + kitchenStuffCount + " GameObject(s) with the \"KitchenStuff\" layer.");
    }


    public void SetBarSizeByPercentage(GameObject bar, float p)
    {
        GameObject[] kitchenStuffObjects = GameObject.FindGameObjectsWithTag("KitchenStuff");
        numKitchenStuff = kitchenStuffObjects.Length;
        Debug.Log("Number of KitchenStuff objects: " + numKitchenStuff);
    }
}
