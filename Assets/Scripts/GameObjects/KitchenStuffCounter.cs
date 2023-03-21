using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KitchenStuffCounter : MonoBehaviour
{
    public int kitchenStuffCount = 0;
    private int totalObjects;
    public int activeObjects;
 //   public GameObject Bar;
    public float percentage;


    private void Start()
    {

        KitchenStuffCounterFunction();
        activeObjects = 0 + kitchenStuffCount;
    }

    private void Update()
    {
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
        p = percentage;
        //bar = Bar;
        // Get the current scale of the bar
        Vector3 currentScale = bar.transform.localScale;

        // Calculate the new scale based on the percentage value
        Vector3 newScale = new Vector3(currentScale.x * p / 100f,
                                       currentScale.y,
                                       currentScale.z);

        // Set the new scale on the bar
        bar.transform.localScale = newScale;
    }
}
