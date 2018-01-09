using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsoFix : MonoBehaviour {

    public bool fix = true;
    //If active is set to true, The fix will be applied at each frame, useful if the camera rotate
    public bool active = false;
    public Vector3 fixPosition = new Vector3(-45f, 0f, 0f);
    public Vector3 charPosition = new Vector3(-0.15f,0.25f,0.2f);

    private void OnEnable()
    {
        Fix();
    }

    private void Update()
    {
        if (active)
            Fix();
    }

    private void Fix()
    {
        if (fix)
        {
            this.transform.Translate(charPosition);
            this.transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward) * Quaternion.Euler(fixPosition);    
        }
    }
}
