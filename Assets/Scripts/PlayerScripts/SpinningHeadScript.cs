using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningHeadScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Input.GetAxis("Mouse Y")*-1, 0f, 0f);
    }
}
