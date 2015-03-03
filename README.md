# BBDN-CSharp-WS-Sample
This project contains sample code for interacting with the Blackboard Learn SOAP Web Services in C#. This sample uses the library built from the Sample code available with for download directly from Blackboard Learn. The code demonstrates the code necessary to register a Proxy Tool, login as a tool or user, and retrieve a list of courses a specified user is enrolled in and the role that user has in those courses.

###Project at a glance:
- Target: Blackboard Learn 9.1 SP 11 minimum
- Source Release: v1.0
- Release Date  2015-02-25
- Author: shurrey
- Tested on Blackboard Learn 9.1 April 2014 release

###Requirements:
- Visual Studio - This sample was built with Microsoft Visual Studio 2010 Express Edition
- Requires the BbWsClient.dll. See <a href="https://help.blackboard.com/en-us/Developer_Resources/010_Learn/Develop/Web_Services/Getting_Started/020-About_Web_Services_Sample_Code/010-Build_The_.NET_Web_Services_Library" target="_blank">Blackboard Help</a> for more information. 

### Setting Up Your Project
Open Microsoft Visual Studio. Click File->Open and navigate to the directory you cloned this project in. Select BbCSharpSample.sln and open it. Your project workspace is now ready to go.

You may need to add a few references. To accomplish this, you will need to right click on 'References' in the Solution Explorer and then select 'Add Reference...'. From the browse tab, navigate to the BbWsClient.dll file you built from the .NET sample code downloaded from the Blackboard Learn interface. Repeat the process to access the 'Add Reference..' section, and in the .NET tab, you may need to add System.Web, System.Web.Services, and System.Security.

### Using the Code Sample
This code sample starts as a web form that gathers information. This web form allows you to:
- Register a proxy tool
- login as a proxy tool
- login as a user
- retrieve a list of courses a specified user is enrolled in and their role in that course.

The web form asks for a URL. This URL must contain the protocol at the beginning:
	https://localhost:9877
	
If registering a tool, you must approve the tool on the Blackboard Learn side before you can login as a tool or a user. 

If logging in as a user, the user must have administrator rights in order to successfully query the Web Services and retrieve the desired data.

### Developer Virtual Machine and SSL Certificate Checking
If you decide to use the Blackboard Developer virtual machine, it is important to note that this VM contains a self-signed certificate, which will cause this code to fail. Because the Blackboard Learn 9.1 April and newer releases require you to use SSL, there is a constant in program.cs called IGNORE\_CERT\_ERRORS. Setting this constant to true WILL BYPASS SSL CERTIFICATE CHECKING, so be sure to undo this change when rolling out to production.

### Gradebook.WS WSDL and Learn October 2014
There is a bug in the Blackboard Learn 9.1 October 2014 release with the WSDL for gradebook.ws. This will cause SUDS to fail when trying to ingest the WSDL. 

For more information and work-arounds for this bug, see the article <a href="https://blackboard.secure.force.com/btbb_articleview?id=kA370000000H5Fc" target="_blank">here</a>.

- If you follow workaround 1, simply change the initial gradebookWS call:<br/>
  <pre>
    url = url_header + 'Gradebook.WS?wsdl'
  </pre>
with this:<br/>
<pre>
    url = 'file:///Users/shurrey/wsdl/Gradebook.xml'
</pre>

Just be sure to replace my absolute path to the absolute path on your file system.

- If you follow workaround 2, the code should work as-is.

### Conclusion
This code will give you the base knowledge you need to interact with the Blackboard Learn SOAP services using the .NET sample code library provided with Learn. A ful walkthrough of this code will be documented at https://help.blackboard.com. Once this is complete, a link to that document will be added here.

<!-- For a thorough walkthrough of this code, visit the corresponding Blackboard Help page <a href="http://help.blackboard.com/en-us/Learn/9.1_2014_04/Administrator/080_Developer_Resources/020_Develop/020_Web_Services/010_Examples/Get_Course_Announcements_With_Python" target="_blank">here</a>. -->
