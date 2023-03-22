using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    // Start is called before the first frame update
    Camera camera;
    Vector3 mousePositionOffset;
    public bool HoldingObject;
    public KitchenStuffCounter KC;


    private void Start()
    {
    
    }
    private void Update()
    {
        Physics2D.IgnoreLayerCollision(7, 10, false);
        KC = FindObjectOfType<KitchenStuffCounter>();
    }
    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        HoldingObject = true;
        // Capture the mouse.offset
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseUp()
    {
        Physics2D.IgnoreLayerCollision(7, 10,false);
       
        HoldingObject = false;
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + mousePositionOffset;

        Physics2D.IgnoreLayerCollision(7, 10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Physics2D.IgnoreLayerCollision(7, 10, false);


        if (HoldingObject == false && collision.gameObject.layer == LayerMask.NameToLayer("Bin"))
        {
            Destroy(this.gameObject);
            KC.activeObjects--;     
        }

   }
}
