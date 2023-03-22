using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private SpriteRenderer PLS;
    private Collider2D Col;
    public bool DoorIsOpen;
    Vector3 mousePositionOffset;
    // Start is called before the first frame update
    void Start()
    {
       PLS =  this.gameObject.GetComponent<SpriteRenderer>();
       Col = this.gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreLayerCollision(10, 7, false);
    }
    private void OnMouseDown()
    { 
        PLS.enabled = false;
        Col.enabled = false;
        DoorIsOpen = true;
        StartCoroutine(TimerDoor());
    }

    IEnumerator TimerDoor()
    {
        yield return new WaitForSeconds(2);
        PLS.enabled = true;
        Col.enabled = true;
        DoorIsOpen = true;
    }
}
