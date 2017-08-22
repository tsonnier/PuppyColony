// JavaScript Document

<!-- Variables containing lists of game data -->

var buildList = [{name:"Colony Hub", value:1, enabled:"false", visible:"true"},
				 {name:"Mine", value:0, enabled:"false", visible:"false"},
				 {name:"Oxygen Generator", value:0, enabled:"false", visible:"false"}]

var messageList = "No messages.";

var resourceList = [{name:"Metal", value:100, enabled:"true"}]

function writeBuildings()
{
	var outputString = "";
	
	outputString+="<table width=\"100%\">"
	
	for(i=0;i<buildList.length; i++)
		{
			outputString += "<tr>";
			outputString += "<td>" + buildList[i].name + "</td>";
			outputString += "<td>" + buildList[i].value + "</td>";
			outputString += "<td>" + "<button name=\"" + buildList[i].name + "Build\" onclick=\"BuildClick(" + buildList[i].name + ")\">Build</button>" + "</td>";
			outputString += "</tr>";
		}
	outputString += "</table>";
	document.getElementById("BuildingList").innerHTML = outputString;
}

function writeMessages()
{
	document.getElementById("MessageList").innerHTML = messageList;
}

function writeResources()
{
	var outputString = "";
	
	for(i=0;i<resourceList.length; i++)
		{
			outputString += "<div id=\"" + resourceList[i].name + "\" >" 
				+ resourceList[i].name + "\t" 
				+ resourceList[i].value + "</div>";
		}
	
	document.getElementById("ResourceList").innerHTML = outputString;
}

function BuildClick(itemName)
{
	for(i=0;i<buildList.length; i++)
	{
		if(itemName == buildList[i].name)
		{
			buildList[i].value++;
			break;
		}
		
	}
	writeBuildings();
}
	
function initialize()
{
	writeBuildings();
	writeMessages();
	writeResources();
}
