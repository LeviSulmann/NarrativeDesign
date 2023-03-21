using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidBehaviour : MonoBehaviour
{
    RandomPlaceKiddo RPK;
    public bool KiddeoDetected;
    public int KiddoCount;

    // Start is called before the first frame update
    void Start()
    {
        RPK = FindObjectOfType<RandomPlaceKiddo>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        KiddoCount = 1;
    }
}
