using System.Collections;
using System.Collections.Generic;
using UnityEngine;
------------------------------------++

//lyjlyjlyjylyjylyjylyjylyjylyljyjyljyljyljyljyljyljy
public class PrefabText : MonoBehaviour {
//	预设体的对象
	public GameObject myPrefab;
//	需要创建的数目
	public int totalNum = 5;

//	创建一个空对象作为目标点，在该目标点的具体位置创建对象
	public Transform desTransform;
	// Use this for initialization
	void Start () {
		for(int i=0;i<totalNum;i++)
		{
//			预设图中x、y、z具体的位置
			float x = desTransform.position.x;
			float y = desTransform.position.y;
			float z = desTransform.position.z;

//			使用Instantiate（该预设体，动态加载预设体的三维坐标位置，四元数）函数，动态加载预设体
			GameObject obj = Instantiate (myPrefab,new Vector3(x+i*2,y,z),desTransform.rotation)as GameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
