using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Test : MonoBehaviour {
	void Start () {
		InputField input = GetComponent<InputField>();
		input.text = "test";

		input.enabled = false;
		input.enabled = true;
	}
}