[System.Serializable]
public class Net_OnLoginRequest : NetMsg
{
    public Net_OnLoginRequest()
    {
        OP = NetOP.OnLoginRequest;
    }

    public byte Success { set; get; }
    public string Information { set; get; }

    public int ConnectionId { set; get; }
    public string Username { set; get; }
    public string Discriminator { set; get; }
    public string Token { set; get; }
}

