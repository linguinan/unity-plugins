/*
 * @Author: lgn 
 * @Date: 2018-05-23 20:15:05 
 * @Last Modified by:   lgn 
 * @Last Modified time: 2018-05-23 20:15:05 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

#if UNITY_ANDROID
    public static Connector conn = new ConnectorToAndroid();
#elif UNITY_IPHONE
	public static Connector conn = new ConnectorToIOS();
#endif

	// Use this for initialization
	void Start () {
		conn.Hello();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
