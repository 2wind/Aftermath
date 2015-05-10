using UnityEngine;
using System.Collections;

public class CsPaper : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        

	}
    void OnMouseDown()
    {
        Vector3 a = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        a.Set(a.x, a.y, gameObject.transform.position.z);
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, a, 1);
    }

}
