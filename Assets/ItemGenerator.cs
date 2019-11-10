using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
	//carPrefabを入れる
	public GameObject carPrefab;
	//coinPrefabを入れる
	public GameObject coinPrefab;
	//cornPrefabを入れる
	public GameObject conePrefab;
	//スタート地点
	private float startPos = -200;
    //ゴール地点
	private float goalPos = 120;
	//アイテムを出すｘ方向の範囲
	private float posRange = 3.4f;

	//Unityちゃんのオブジェクトを取得
	private GameObject unitychan;
	//Unityちゃんとアイテムの生成される距離
	private float Itemfac;
	//アイテムの設置される場所
	private float Setti = -200;


	// Use this for initialization
	void Start () {
		//unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find ("unitychan");


		}

	
	// Update is called once per frame
	void Update () {
		//unityちゃんの位置から４０ｍの距離を取得
		this.Itemfac = unitychan.transform.position.z + 40f;
		Debug.Log (this.Itemfac);
		//Unityちゃん.zとの４０ｍの距離とアイテムを置く場所が重なったらアイテムを生成
		if(this.Itemfac >= this.startPos && this.startPos < this.goalPos-10  ) {
		this.startPos += 15;

			
			//どのアイテムを出すのかをランダムに設定
			int num = Random.Range (1, 11);
			if (num <= 2) {
				//コーンをｘ軸方向に一直線に生成
				for (float j = -1; j <= 1; j += 0.4f) {
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, this.startPos);
				}
			} else {
				//レーンごとにアイテムを生成
				for (int j = -1; j <= 1; j++) {
					//アイテムの種類を決める
					int item = Random.Range (1, 11);
					//アイテムを置くｚ座標のオフセットをランダムに設定
					int offsetZ = Random.Range (-5, 6);
					//６０％コイン配置：３０％車配置：１０％何もなし
					if (1 <= item && item <= 6) {
						//コインを生成
						GameObject coin = Instantiate (coinPrefab) as GameObject;
						coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, this.startPos + offsetZ);
					} else if (7 <= item && item <= 9) {
						//車を生成
						GameObject car = Instantiate (carPrefab)as GameObject;
						car.transform.position = new Vector3 (posRange * j, car.transform.position.y, this.startPos + offsetZ);
					}
				}
			}
		}
		
	}

}
