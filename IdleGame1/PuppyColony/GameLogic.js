// JavaScript Document
		
var buildList = [{name:"Colony Hub", value:1, enabled:"false", visible:"true"},
				 {name:"Mine", value:0, enabled:"false", visible:"false"},
				 {name:"Oxygen Generator", value:0, enabled:"false", visible:"false"}];

var messageList = [{ text: "<td>No messages.</td>" }];

var resourceList = [{ name: "Metal", value: 100, enabled: "true" },
                    { name: "Wood", value: 0, enabled: "false" }];

var pause = false;

function BuildClick(type)
{
	"use strict";
	for(var i=0; i< buildList.length;i++)
	{
		if (buildList[i].name === type)
		{
			buildList[i].value++;
			break;
		}
	}
	writeBuildings();
}

function writeBuildings()
{
	"use strict";
	var outputString = "";

	outputString+="<table width=\"100%\">";

	for(var i=0;i<buildList.length; i++)
	{
		outputString += "<tr>";
		outputString += "<td>" + buildList[i].name + "</td>";
		outputString += "<td>" + buildList[i].value + "</td>";
		outputString += "<td>" + "<button name=\"" + buildList[i].name + "Build\"";
		outputString += " onclick=\"BuildClick(\'" + buildList[i].name + "\')\">Build</button>" + "</td>";
		outputString += "</tr>";
	}
	outputString += "</table>";
	document.getElementById("BuildingList").innerHTML = outputString;
}

function writeMessages()
{
    "use strict";
    var outputString = "";

    outputString += "<table width=\"100%\">";

    outputString += "<tr>";
    outputString += messageList[0].text;
    outputString += "</tr>";
    

    //alert("OutputString = " + outputString);

    outputString += "</table>";

	document.getElementById("MessageList").innerHTML = outputString;
}

function writeResources()
{
	"use strict";
	var outputString = "";

	for(var i=0;i<resourceList.length; i++)
	{
		outputString += "<div id=\"" + resourceList[i].name + "\" >" +
			resourceList[i].name + "\t" +
			resourceList[i].value + "</div>";
	}

	document.getElementById("ResourceList").innerHTML = outputString;
}

function tick()
{
    messageList[0].text += "<td> Next Tick </td>";

    writeBuildings();
    writeMessages();
    writeResources();
    // Check if pause is activated, if so skip the loop

    // Check values, increment them if necessary

    // Check tick() again in x milliseconds
}


function initialize()
{
	"use strict";
	writeBuildings();
	writeMessages();
	writeResources();

	//setInterval(tick, 200);
}