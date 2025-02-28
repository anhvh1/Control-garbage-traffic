using Com.Gosol.BUS.DanhMuc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Threading.Tasks;

public class MapHub : Hub
{
    private readonly IMemoryCache _cache;
    private readonly string _cacheKey = "ConnectedClients";
    private readonly DM_CameraBUS dM_CameraBUS;

    public MapHub(IMemoryCache cache)
    {
        _cache = cache;
        dM_CameraBUS = new DM_CameraBUS();
    }

    //public override async Task OnConnectedAsync()
    //{
    //    string connectionId = Context.ConnectionId;
    //    RegisterClient(connectionId);
    //    var cameraData = dM_CameraBUS.GetAll();
    //    var data = new
    //    {
    //        connectionId = connectionId,
    //        data = cameraData
    //    };

    //    await Clients.Caller.SendAsync("ReceiveConnectionInfo", data);
    //}


    public async Task Connection()
    {
        string connectionId = Context.ConnectionId;
        RegisterClient(connectionId);
        var cameraData = dM_CameraBUS.GetAll();
        var data = new
        {
            connectionId = connectionId,
            data = cameraData
        };

        await Clients.Caller.SendAsync("ReceiveConnectionInfo", data);
    }

    public override async Task OnDisconnectedAsync(System.Exception exception)
    {
        string connectionId = Context.ConnectionId;
        RemoveClient(connectionId);
        await base.OnDisconnectedAsync(exception);
    }

    private void RegisterClient(string connectionId)
    {
        var connectedClients = _cache.GetOrCreate(_cacheKey, entry => new HashSet<string>());
        connectedClients.Add(connectionId);
        _cache.Set(_cacheKey, connectedClients);
    }

    private void RemoveClient(string connectionId)
    {
        if (_cache.TryGetValue(_cacheKey, out HashSet<string> connectedClients))
        {
            connectedClients.Remove(connectionId);
            _cache.Set(_cacheKey, connectedClients);
        }
    }

    // Gửi cập nhật trạng thái thùng rác đến tất cả clients
    public async Task UpdateTrashStatus(object trashStatus)
    {
        await Clients.All.SendAsync("ReceiveTrashUpdate", trashStatus);
        //if (_cache.TryGetValue(_cacheKey, out HashSet<string> connectedClients))
        //{
        //    foreach (var connectionId in connectedClients)
        //    {
        //        await Clients.Client(connectionId).SendAsync("ReceiveTrashUpdate", trashStatus);
        //    }
        //}
    }
}
