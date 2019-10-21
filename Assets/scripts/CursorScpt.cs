using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScpt : MonoBehaviour
{
    /*public Texture2D cursorIMG;
    public int cursorX = 512;
    public int cursorY = 512;*/

    public Sprite paw1;
    public Sprite paw2;

    public SpriteRenderer pawSR;

    private void Start()
    {
        pawSR.sprite = paw1;
    }

    private void Update()
    {
        /*Vector2 cursorPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"),0));
        transform.position = cursorPos;*/
        if(Input.GetMouseButtonDown(0))
        {
            pawSR.sprite = paw2;
        }
        if(Input.GetMouseButtonUp(0))
        {
            pawSR.sprite = paw1;
        }
            


    }

    private void OnGUI()
    {
        /*Event e = Event.current;
        Debug.Log(e.mousePosition);

        GUI.DrawTexture(new Rect(Event.current.mousePosition.x - cursorX / 2,
                                 Event.current.mousePosition.y - cursorY / 2, cursorX, cursorY), cursorIMG);*/

    }
}
