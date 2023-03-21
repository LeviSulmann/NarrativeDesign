using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlaceKiddo : MonoBehaviour
{

    public GameObject Kid1;
    public GameObject Kid2;
    public GameObject Kid3;
    public GameObject Kid4;
    public GameObject Kid5;
    public GameObject Kid6;
    public GameObject Kid7;
    public GameObject Kid8;
    public GameObject Kid9;

    private KidBehaviour KB;


    // Start is called before the first frame update
    void Start()
    {
        // even voor de test heb ik kid1 op true gezet wel veranderen !!!!!!!!!!!!!!!!!!!
       Kid1.GetComponent<SpriteRenderer>().enabled=false;
       Kid2.GetComponent<SpriteRenderer>().enabled=false;
       Kid3.GetComponent<SpriteRenderer>().enabled=false;
       Kid4.GetComponent<SpriteRenderer>().enabled=false;
       Kid5.GetComponent<SpriteRenderer>().enabled=false;
       Kid6.GetComponent<SpriteRenderer>().enabled=false;
       Kid7.GetComponent<SpriteRenderer>().enabled=false;
       Kid8.GetComponent<SpriteRenderer>().enabled=false;
       Kid9.GetComponent<SpriteRenderer>().enabled=false;

        

        StartCoroutine(Timer());

    }

    // Update is called once per frame
    void Update()
    {

        KB = FindObjectOfType<KidBehaviour>();

   }

    public void WichKid()
    {

        //   if (NPC_Dance.whichAnimCheck == true)
        //  {
        int whichKid = Random.Range(1, 9);
        if (whichKid == 1)
        {
            Kid1.GetComponent<SpriteRenderer>().enabled = true;
            Kid2.GetComponent<SpriteRenderer>().enabled = false;
            Kid3.GetComponent<SpriteRenderer>().enabled = false;
            Kid4.GetComponent<SpriteRenderer>().enabled = false;
            Kid5.GetComponent<SpriteRenderer>().enabled = false;
            Kid6.GetComponent<SpriteRenderer>().enabled = false;
            Kid7.GetComponent<SpriteRenderer>().enabled = false;
            Kid8.GetComponent<SpriteRenderer>().enabled = false;
            Kid9.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (whichKid == 2)
        {
            Kid1.GetComponent<SpriteRenderer>().enabled = false;
            Kid2.GetComponent<SpriteRenderer>().enabled = true;
            Kid3.GetComponent<SpriteRenderer>().enabled = false;
            Kid4.GetComponent<SpriteRenderer>().enabled = false;
            Kid5.GetComponent<SpriteRenderer>().enabled = false;
            Kid6.GetComponent<SpriteRenderer>().enabled = false;
            Kid7.GetComponent<SpriteRenderer>().enabled = false;
            Kid8.GetComponent<SpriteRenderer>().enabled = false;
            Kid9.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (whichKid == 3)
        {
            Kid1.GetComponent<SpriteRenderer>().enabled = false;
            Kid2.GetComponent<SpriteRenderer>().enabled = false;
            Kid3.GetComponent<SpriteRenderer>().enabled = true;
            Kid4.GetComponent<SpriteRenderer>().enabled = false;
            Kid5.GetComponent<SpriteRenderer>().enabled = false;
            Kid6.GetComponent<SpriteRenderer>().enabled = false;
            Kid7.GetComponent<SpriteRenderer>().enabled = false;
            Kid8.GetComponent<SpriteRenderer>().enabled = false;
            Kid9.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (whichKid == 4)
        {
            Kid1.GetComponent<SpriteRenderer>().enabled = false;
            Kid2.GetComponent<SpriteRenderer>().enabled = false;
            Kid3.GetComponent<SpriteRenderer>().enabled = false;
            Kid4.GetComponent<SpriteRenderer>().enabled = true;
            Kid5.GetComponent<SpriteRenderer>().enabled = false;
            Kid6.GetComponent<SpriteRenderer>().enabled = false;
            Kid7.GetComponent<SpriteRenderer>().enabled = false;
            Kid8.GetComponent<SpriteRenderer>().enabled = false;
            Kid9.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (whichKid == 5)
        {
            Kid1.GetComponent<SpriteRenderer>().enabled = false;
            Kid2.GetComponent<SpriteRenderer>().enabled = false;
            Kid3.GetComponent<SpriteRenderer>().enabled = false;
            Kid4.GetComponent<SpriteRenderer>().enabled = false;
            Kid5.GetComponent<SpriteRenderer>().enabled = true;
            Kid6.GetComponent<SpriteRenderer>().enabled = false;
            Kid7.GetComponent<SpriteRenderer>().enabled = false;
            Kid8.GetComponent<SpriteRenderer>().enabled = false;
            Kid9.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (whichKid == 6)
        {
            Kid1.GetComponent<SpriteRenderer>().enabled = false;
            Kid2.GetComponent<SpriteRenderer>().enabled = false;
            Kid3.GetComponent<SpriteRenderer>().enabled = false;
            Kid4.GetComponent<SpriteRenderer>().enabled = false;
            Kid5.GetComponent<SpriteRenderer>().enabled = false;
            Kid6.GetComponent<SpriteRenderer>().enabled = true;
            Kid7.GetComponent<SpriteRenderer>().enabled = false;
            Kid8.GetComponent<SpriteRenderer>().enabled = false;
            Kid9.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (whichKid == 7)
        {
            Kid1.GetComponent<SpriteRenderer>().enabled = false;
            Kid2.GetComponent<SpriteRenderer>().enabled = false;
            Kid3.GetComponent<SpriteRenderer>().enabled = false;
            Kid4.GetComponent<SpriteRenderer>().enabled = false;
            Kid5.GetComponent<SpriteRenderer>().enabled = false;
            Kid6.GetComponent<SpriteRenderer>().enabled = false;
            Kid7.GetComponent<SpriteRenderer>().enabled = true;
            Kid8.GetComponent<SpriteRenderer>().enabled = false;
            Kid9.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (whichKid == 8)
        {
            Kid1.GetComponent<SpriteRenderer>().enabled = false;
            Kid2.GetComponent<SpriteRenderer>().enabled = false;
            Kid3.GetComponent<SpriteRenderer>().enabled = false;
            Kid4.GetComponent<SpriteRenderer>().enabled = false;
            Kid5.GetComponent<SpriteRenderer>().enabled = false;
            Kid6.GetComponent<SpriteRenderer>().enabled = false;
            Kid7.GetComponent<SpriteRenderer>().enabled = false;
            Kid8.GetComponent<SpriteRenderer>().enabled = true;
            Kid9.GetComponent<SpriteRenderer>().enabled = false;
        }


        if (whichKid == 9)
        {
            Kid1.GetComponent<SpriteRenderer>().enabled = false;
            Kid2.GetComponent<SpriteRenderer>().enabled = false;
            Kid3.GetComponent<SpriteRenderer>().enabled = false;
            Kid4.GetComponent<SpriteRenderer>().enabled = false;
            Kid5.GetComponent<SpriteRenderer>().enabled = false;
            Kid6.GetComponent<SpriteRenderer>().enabled = false;
            Kid7.GetComponent<SpriteRenderer>().enabled = false;
            Kid7.GetComponent<SpriteRenderer>().enabled = false;
            Kid8.GetComponent<SpriteRenderer>().enabled = false;
            Kid9.GetComponent<SpriteRenderer>().enabled = true;
        }

       // BaseState();


    }

    IEnumerator BaseState()
    {


        yield return new WaitForSeconds(4);


    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();
        yield return new WaitForSeconds(5);
        WichKid();


    }

}
