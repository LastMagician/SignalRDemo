using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace MoveShapeDemo
{
    public class MoveShapeHub : Hub
    {
        public void UpdateModel(ShapeModel clientModel)
        {
            clientModel.LastUpdatedBy = Context.ConnectionId;
            Clients.AllExcept(clientModel.LastUpdatedBy).UpdateShape(clientModel);
        }
    }

    public class ShapeModel
    {
        [JsonProperty("left")]
        public double Left { get; set; }

        [JsonProperty("top")]
        public double Top { get; set; }

        [JsonIgnore]
        public string LastUpdatedBy { get; set; }
    }
}