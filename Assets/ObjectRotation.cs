using UnityEngine;
using System.Collections;

public class ObjectRotation : MonoBehaviour {

	// Use this for initialization
    Quaternion initialRotation;
	void Start () {
        initialRotation = transform.rotation;
 
        
        if (this.gameObject.name == "mixamorig:RightUpLeg"){
            transform.localRotation = Quaternion.Inverse(transform.parent.rotation)*initialRotation;
            //transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 90.0f)*initialRotation;

        }
        Debug.Log("new rotation" + transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.name == "mixamorig:Hips")
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);
            //transform.Rotate(0, 0, 90, Space.World);
        }
	}

    void SetRotation(string quaternion){
        string[] components = quaternion.Split(',');
        Debug.Log("Setting rotation. date received " + quaternion);
        float x = float.Parse(components[0]);
        float y = float.Parse(components[1]);
        float z = float.Parse(components[2]);
        float w = float.Parse(components[3]);
        Debug.Log("Parsed components: " + x + " " + " " + y + " " + z + " " + w);
        transform.rotation.Set(x, y, z, w);
        
    }
}
