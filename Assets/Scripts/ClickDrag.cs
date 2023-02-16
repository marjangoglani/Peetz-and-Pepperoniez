using UnityEngine;

public class ClickDrag : MonoBehaviour
{

    public LayerMask draggableMask;
    GameObject selectedObject;
    bool isDragging;
    // Start is called before the first frame update
    void Start()
    {
        isDragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, draggableMask);
            if (hit.collider != null && hit.collider.tag == "Pepperoni")
            {
                //Debug.Log(hit.collider.gameObject.name);
                selectedObject = hit.collider.gameObject;
                isDragging = true;

            }
        }

        if (isDragging)
        {
            Vector3 position = mousePosition();
            selectedObject.transform.position = position;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }

    Vector3 mousePosition()
    {
        return Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10)); // 10 because the camera is 10 units away from the scene
    }
}
