using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("I'm alive");

        //Transform tr = GetComponent<Transform>();
        //transform.Translate(10, 0, 0);
        Debug.Log("new transfrom" + transform.position);
	}
	
	// Update is called once per frame
    float speed = 2f;
	void FixedUpdate() {
 //      float distance = speed * Time.deltaTime * Input.GetAxis("Horizontal");
 //       transform.Translate(0.1f, 0, 0);
	}

    void AndroidUpdate(string message) {
        float amount= float.Parse(message);
        transform.Translate(amount, 0, 0);

        AndroidJavaClass myClass = new AndroidJavaClass("lv.edi.testing.UnityPlayerActivity");
        AndroidJavaObject myObject = myClass.CallStatic<AndroidJavaObject>("instance");
        myObject.Call("testMethod", new object[] { "Message massing to android works!" });
       
    }

    void Test2(string message)
    {
        Debug.Log("Test2called" + message);
    }
}
