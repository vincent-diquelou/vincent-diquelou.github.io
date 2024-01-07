using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Tools.Editor
{
    public class PreBuildAddBuildID : IPreprocessBuildWithReport
    {
        public int callbackOrder { get; }
        public void OnPreprocessBuild(BuildReport report)
        {
            // add the build version code in /Resources/runtime-config.json
            TextAsset targetFile = Resources.Load<TextAsset>("runtime-config");
            string buildNumber = Application.platform == RuntimePlatform.IPhonePlayer ? PlayerSettings.iOS.buildNumber : PlayerSettings.Android.bundleVersionCode.ToString();
            // save the file
            File.WriteAllText(AssetDatabase.GetAssetPath(targetFile), buildNumber);
            EditorUtility.SetDirty(targetFile);
        }
    
    
    /* Use this code to read build ID at runtime
     
    private string _buildVersion;     
    #if UNITY_EDITOR
                _buildVersion = Application.platform == RuntimePlatform.IPhonePlayer ? UnityEditor.PlayerSettings.iOS.buildNumber : UnityEditor.PlayerSettings.Android.bundleVersionCode.ToString();
    #else
                TextAsset targetFile = Resources.Load<TextAsset>("runtime-config");
                if (targetFile) _buildVersion = targetFile.text;
    #endif
    
     */
    }
}
