using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidBehaviour : MonoBehaviour
{
    RandomPlaceKiddo RPK;
    public bool KiddeoDetected;
    public int KiddoCount;
    //public OpenDoor opendoor;
    public GameObject Door;
    public int timeElapsed;

    private float timer;



    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(0, 10);
        RPK = FindObjectOfType<RandomPlaceKiddo>();
        RPK.ChairKiddo.GetComponent<SpriteRenderer>().enabled = false;
       // opendoor = gameObject.GetComponentInParent<OpenDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("timer" + timeElapsed);
        if (this.gameObject.GetComponent<SpriteRenderer>().enabled == false)
        {
            this.gameObject.GetComponent<Collider2D>().enabled = false;
        }
     
     

        if(Door.gameObject.GetComponent<OpenDoor>().DoorIsOpen == true)
        {
            if(this.gameObject.GetComponent<SpriteRenderer>().enabled == true)
            {
                timer += Time.deltaTime;
                if (timer >= 0.1f)
                {
                    this.gameObject.GetComponent<Collider2D>().enabled = true;
                    timer = 0f;
                }

                
                Debug.Log("halloo");
            }
            
        }

        Physics2D.IgnoreLayerCollision(0, 10);
       
    }

    private void OnMouseDown()
    {

            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            RPK.StopAllCoroutines();
            StartCoroutine(Timer());
            RPK.ChairKiddo.GetComponent<SpriteRenderer>().enabled = true;
  
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(8);
        RPK.KindGaatWeerVerstoppen();
        RPK.ChairKiddo.GetComponent<SpriteRenderer>().enabled = false;

    }



}
