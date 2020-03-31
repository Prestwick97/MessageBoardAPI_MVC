using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MessageBoardClient.Models
{
  public class Message
  {
    public int AnimalId { get; set; }
    public string NCont{ get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public static List<AMessage GetAMessage()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<AMessage amessageist = JsonConvert.DeserializeObject<List<AMessage>(jsonResponse.ToString());

      return amessageist;
    }
  }
}