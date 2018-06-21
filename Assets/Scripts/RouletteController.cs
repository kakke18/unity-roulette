using System.Collections;
using UnityEngine;

public class RouletteController : MonoBehaviour {
	float rotSpeed = 0;
	bool flag = false;

	private readonly string[] RESULT_NUM = new string[]{
		"1", "2", "3", "4", "5",
		"6", "7", "8", "9", "10"
	};
	public UnityEngine.UI.Text resultLabel;

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			this.rotSpeed = 10;
			this.flag = true;
		}

		transform.Rotate(0, 0, this.rotSpeed);
		this.rotSpeed *= Random.Range(0.80f, 0.99f);
		int num = Mathf.FloorToInt((transform.eulerAngles.z + 54) / 36);
		if (num == 11) {
			num = 1;
		}
		if (this.rotSpeed <= 0.05 && this.flag) {
			resultLabel.text = num.ToString();
		}
	}
}
