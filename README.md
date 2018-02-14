# A10NetClient
A10 aXAPI .Net Client

# How to use:
Add a refferance to your .Net project the A10NetClient.dll
Now you can build a new instane of A10Client


# Example
Senario: To Get a List of Servers behind a virutal server address.

First we will initial an A10ClientBuilder class, by filling user name, password and A10 Ip address.

	A10ClientBuilder A10Client = new A10ClientBuilder();
	A10Client.Authentication("[USERNAME]", "[PASSWORD]");
	A10Client.IpAddress("[IPADDRRESS]");
	Session clientSession = A10Client.Build().Session;
	
Next, we will get a virtual server object by enter an virtual Server Ip address,

	var vserver = VirtualServers.FromJson(
	clientSession.VirtualServer.GETexecute(GETActionType.search, 
	new Dictionary<string, string> { { "address", "[VIRTUAL SERVER IP ADDRESS]" } }));
	
Next, from a previous step we will use a service Group name and with it we will return an object of service Group,
	
	var servGrp = ServicesGroup.FromJson(
	clientSession.ServiceGroup.GETexecute(
	GETActionType.search, new Dictionary<string, string>{ { "name", vserver.VirtualServer.VportList[0].Name } }));

Final step, from a previous step we will use memeber servers and return for each an object of server 

	foreach (MemberList member in servGrp.ServiceGroup.MemberList)
	{
		Console.WriteLine(Servers.FromJson(
			clientSession.Server.GETexecute(GETActionType.search, new Dictionary<string, string>
			{ { "name",member.Server } })).Server.Host);
	}

Not forget to close the session
	
	clientSession.Close();
	
Full Eaxmple:

	A10ClientBuilder A10Client = new A10ClientBuilder();
	A10Client.Authentication("[USERNAME]", "[PASSWORD]");
	A10Client.IpAddress("[IPADDRRESS]");
	Session clientSession = A10Client.Build().Session;
	var vserver = VirtualServers.FromJson(clientSession.VirtualServer.GETexecute(GETActionType.search, new Dictionary<string, string> { 		{ "address", "[VIRTUAL SERVER IP ADDRESS]" } }));
	var servGrp = ServicesGroup.FromJson(clientSession
	 .ServiceGroup.GETexecute(GETActionType.search, new Dictionary<string, string>
		 { { "name", vserver.VirtualServer.VportList[0].Name } }));
	foreach (MemberList member in servGrp.ServiceGroup.MemberList)
	{
			Console.WriteLine(Servers.FromJson(
					clientSession.Server.GETexecute(GETActionType.search, new Dictionary<string, string>
					{ { "name",member.Server } })).Server.Host);
	}

	clientSession.Close();
