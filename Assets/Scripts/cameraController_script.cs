using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController_script : MonoBehaviour
{
    public GameObject target;
    public float cameraSpeed;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 pos = Vector2.Lerp((Vector2)transform.position, (Vector2)target.transform.position, cameraSpeed*Time.fixedDeltaTime);
        transform.position = new Vector3(pos.x, pos.y, transform.position.z);
    }
}
