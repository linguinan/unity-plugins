using UnityEditor;

[InitializeOnLoad]
public class PreloadKeystoreSetting {

	static PreloadKeystoreSetting () {
		PlayerSettings.Android.keystorePass = "111111";
		PlayerSettings.Android.keyaliasPass = "111111";
	}
	
}
