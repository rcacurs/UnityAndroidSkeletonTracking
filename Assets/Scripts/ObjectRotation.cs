using UnityEngine;
using System.Collections;

public class ObjectRotation : MonoBehaviour {

	// Use this for initialization
    Quaternion initialRotation;
    Quaternion externalRotation = Quaternion.Euler(0, 0, 0);

    
	void Start() {
        initialRotation = transform.rotation;
        Debug.Log("Quaternion" + externalRotation);
	}
	
	// Update is called once per frame
	void Update() {
        
	}
    void LateUpdate(){
        transform.rotation = externalRotation*initialRotation;
    }

    void SetRotation(string quaternion){
        string[] components = quaternion.Split(',');
        Debug.Log("Setting rotation. date received " + quaternion);
        float x = float.Parse(components[0]);
        float y = float.Parse(components[1]);
        float z = float.Parse(components[2]);
        float w = float.Parse(components[3]);
        Debug.Log("Parsed components: " + x + " " + " " + y + " " + z + " " + w);
        
        externalRotation = new Quaternion(y, z, w, x);
        
    }
}
