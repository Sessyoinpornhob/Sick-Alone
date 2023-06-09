using System.Collections;
using System.Collections.Generic;
using System.IO;
using Bright.Serialization;
using UnityEngine;
using SimpleJSON;

namespace Luban
{
    public class Test : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var tables = new cfg.Tables(Loader);
            var item = tables.TbItem.Get(100011);
            // 通过上面的方式获取到了表格的信息。
            Debug.Log($"{item.Name}  {item.Desc}");
        }

        private JSONNode Loader(string fileName)
        {
            return JSON.Parse(File.ReadAllText(Application.dataPath + "/../GenerateDatas/json/" + fileName + ".json", System.Text.Encoding.UTF8));
        }
    }
}