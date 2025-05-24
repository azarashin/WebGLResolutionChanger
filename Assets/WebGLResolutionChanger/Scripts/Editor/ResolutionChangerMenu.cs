using System.IO;
using UnityEditor;
using UnityEngine;

namespace WebGLResolutionChanger.Editor
{
    public class ResolutionChangerMenu : EditorWindow
    {
        [MenuItem("PIT Creation/WebGL�𑜓x�ύX")]
        public static void ShowWindow()
        {
            var wnd = GetWindow<ResolutionChangerMenu>();
            wnd.titleContent = new GUIContent("WebGL Resolution Changer");
        }

        private void OnGUI()
        {
            if (GUILayout.Button("index.html ���X�V����"))
            {
                string path = EditorUtility.OpenFilePanel("Open index.html", "", "html");
                ModifyIndexHtml(path);
            }
        }

        private void ModifyIndexHtml(string path)
        {
            string targetFile = "index.html"; 
            if (path.ToLower().IndexOf(targetFile) != path.Length - targetFile.Length)
            {
                Debug.LogError($"{targetFile} ��I�����Ă�������. ({path})");
                return; 
            }

            string body = ""; 
            using (StreamReader sr = new StreamReader(path))
            {
                body = sr.ReadToEnd();
            }

            body = body.Replace("// config.matchWebGLToCanvasSize = false;", "config.matchWebGLToCanvasSize = false;");
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(body);
            }
        }
    }
}