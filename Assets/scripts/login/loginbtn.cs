using UnityEngine;
using System.Collections;

public class loginbtn : MonoBehaviour {

	public static UIImageButton button;
	
	// Use this for initialization
	void Start () {
		button = GetComponent<UIImageButton>();
		
		if(init_screen.inst != null)
			init_screen.inst.close_screen();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
