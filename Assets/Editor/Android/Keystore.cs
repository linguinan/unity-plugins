/*
 * @Author: lgn 
 * @Date: 2018-05-23 20:15:09 
 * @Last Modified by:   lgn 
 * @Last Modified time: 2018-05-23 20:15:09 
 */
using UnityEditor;

[InitializeOnLoad]
public class PreloadKeystoreSetting {

	static PreloadKeystoreSetting () {
		PlayerSettings.Android.keystorePass = "111111";
		PlayerSettings.Android.keyaliasPass = "111111";
	}
	
}
