using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    SpriteRenderer playerSpriteRender;

    // Start is called before the first frame update
    void Start()
    {
       playerSpriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(mousePosition.y, LimitDown(), LimitUp()), transform.position.z);
        //transform.position = new Vector3(transform.position.x, Mathf.Clamp(mousePosition.y, -3.8f, 3.8f), transform.position.z);

    }

    float LimitDown()
    {
        return -CameraBounds().y + playerSpriteRender.bounds.extents.y - 0.2f;
    }

    float LimitUp()
    {
        return CameraBounds().y - playerSpriteRender.bounds.extents.y + 0.2f;
    }

    Vector2 CameraBounds()
    {
        return Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }
}
