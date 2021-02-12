using UnityEngine;
using System.Collections;

public class InstantiateTest : MonoBehaviour {

	//生成するゲームオブジェクト
	public GameObject discharge_obj;
	public GameObject lumos_obj;
	public GameObject food_obj;

	public void discharge(){
		int n=0;
		while (n<100) {
			//Instantiate( 生成するオブジェクト,  場所, 回転 );  回転はそのままなら↓
			Instantiate (discharge_obj, new Vector3 (Random.Range(-10.0f, 10.0f),Random.Range(-10.0f, 10.0f),Random.Range(-10.0f, 10.0f)), Quaternion.identity);
			n++;
		}

	}
		
	public void lumos(){
		Instantiate (lumos_obj);
	}

	public void GenerateFood(){
		Instantiate (food_obj);
	}
}