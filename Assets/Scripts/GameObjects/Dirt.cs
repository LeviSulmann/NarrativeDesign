using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{

    public KitchenStuffCounter KC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KC = FindObjectOfType<KitchenStuffCounter>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag == "Sponge")
        {
            StartCoroutine(Delay());
            KC.activeObjects--;
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }
}
