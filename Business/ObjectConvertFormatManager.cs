using Abstract;
using Newtonsoft.Json;
using System.Text;

namespace Business
{
    public class ObjectConvertFormatManager : IObjectConvertFormat
    {
        public T JsonToObject<T>(string jsonString) where T : class, new()
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public string ObjectToJson<T>(T entityObject) where T : class, new()
        {
            return JsonConvert.SerializeObject(entityObject);
        }

        public T ParseObjectDataArrat<T>(byte[] rawBytes) where T : class, new()
        {
            return JsonToObject<T>(Encoding.UTF8.GetString(rawBytes));
        }
    }
}
