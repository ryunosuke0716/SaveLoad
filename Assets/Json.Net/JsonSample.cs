using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEditor;  //AssetDatabaseを使うために追加
using System.IO;  //StreamWriterなどを使うために追加
using System.Linq;  //Selectを使うために追加

public class JsonSample : MonoBehaviour
{
  private JsonType jsonType = new JsonType();

  //保存先
  string datapath;

  void Awake()
  {
    //保存先の計算をする
    //これはAssets直下を指定. /以降にファイル名
    datapath = "./Assets/Json.Net/TestJson02.json";
  }

  private void Start()
  {
    JsonType jsonData = new JsonType();

    //JSONファイルがあればロード, なければ初期化関数へ
    if(FindJsonfile())
    {
      jsonData = loadJsonData();
      Debug.Log(jsonData.Key1);
    }
    else
    {
      Initialize();
    }
  }

  //セーブするための関数
  public void saveJsonData(string text)
  {
    StreamWriter writer;

    //JSONファイルに書き込み
    writer = new StreamWriter(datapath, false);
    writer.Write (text);
    writer.Flush ();
    writer.Close ();
  }

  //JSONファイルを読み込み, ロードするための関数
  public JsonType loadJsonData()
  {
    string datastr = "";
    StreamReader reader;
    reader = new StreamReader (datapath);
    datastr = reader.ReadToEnd ();
    reader.Close ();

    return JsonConvert.DeserializeObject<JsonType>(datastr);
  }

  //JSONファイルがない場合に呼び出す初期化関数
  //初期値をセーブし, JSONファイルを生成する
  public void Initialize()
  {
    jsonType.Key1 = "test01";
    jsonType.Key2 = 2;
    jsonType.Key3 = new List<string>();
    jsonType.Key3.Add("aaa");
    jsonType.Key3.Add("bbb");
    float[] numbers = new float[]{0.1f, 0.2f};
    jsonType.Key4 = new List<float[]>();
    jsonType.Key4.Add(numbers);

    var jsonBody = JsonConvert.SerializeObject(jsonType);

    saveJsonData(jsonBody);
  }

  //JSONファイルの有無を判定するための関数
  public bool FindJsonfile()
  {
    //TestJson02はファイル名
    string[] assets = AssetDatabase.FindAssets("TestJson02");
    Debug.Log(assets.Length);
    if(assets.Length != 0)
    {
      string[] paths = assets.Select(guid => AssetDatabase.GUIDToAssetPath(guid)).ToArray();
      Debug.Log($"検索結果:\n{string.Join("\n", paths)}");
      return true;
    }
    else
    {
      Debug.Log("Jsonファイルがなかった");
      return false;
    }
  }
}

[JsonObject]
public class JsonType
{
    [JsonProperty("Key1")]
    public string Key1 { get; set; }

    [JsonProperty("Key2")]
    public int Key2 { get; set; }

    [JsonProperty("Key3")]
    public List<string> Key3 { get; set; }

    [JsonProperty("Key4")]
    public List<float[]> Key4 { get; set; }
}