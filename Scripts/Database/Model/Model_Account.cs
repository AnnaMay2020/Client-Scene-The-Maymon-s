using MongoDB.Bson;
using System;

public class Model_Account 
{
    public ObjectId _id;
    
    public int ActiveConnection { set; get; }
    public string Username { set; get; }
    public string Discriminator { set; get; }
    public string Email { set; get; }
    public string ShaPassword { set; get; }

    public byte Status { set; get; }
    public string Token { set; get; }
    public DateTime LastLogin { set; get; }
}
