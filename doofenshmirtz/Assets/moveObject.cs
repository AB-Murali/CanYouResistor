using System.Xml.Serialization;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    private Vector3 offset;
    private float zCoord;
    public int ResistanceVal = 1;
    public GameObject numberObj;
    public Sprite sp;

    private SpriteRenderer spR;

    private void Start()
    {
       spR = numberObj.GetComponent<SpriteRenderer>();
        spR.sprite = sp;
    }

    void OnMouseDown()
    {
        zCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + offset;
    }
}
