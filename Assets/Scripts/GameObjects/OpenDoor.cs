using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private SpriteRenderer PLS;
    private Collider2D Col;
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
        Debug.Log("het werkt");
        PLS.enabled = false;
        Col.enabled = false;
        StartCoroutine(TimerDoor());
    }

    IEnumerator TimerDoor()
    {
        yield return new WaitForSeconds(3);
        PLS.enabled = true;
        Col.enabled = true;
    }
}
