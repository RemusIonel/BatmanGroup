using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
    float destroyTimer = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", destroyTimer);
    }

    // Update is called once per frame
    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
