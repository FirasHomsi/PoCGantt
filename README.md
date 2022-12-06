• Download DevExpress for VS here: https://docs.devexpress.com/GeneralInformation/15614/installation/download-the-net-products-installer/download-the-trial-version<br />
• Create a new DevExpress ASP.NET Core project<br />
• Install DevExpress to use Gantt and all the other functionalities: npm install devextreme@22.1 --save --save-exact<br />
• Add dx-gantt-min.css and dx-gantt.min.js to our pages (_Layout.cshtml in my case):

	    <link href="~/css/devextreme/dx-gantt.css" rel="stylesheet" /><br />
	    <link href="~/css/devextreme/dx-gantt.min.css" rel="stylesheet" /><br />
	    <script src="https://cdn3.devexpress.com/jslib/21.1.5/js/dx-gantt.min.js"></script><br />
	    <script src="~/js/devextreme/dx-gantt.js"></script><br />
	    <script src="~/js/devextreme/dx-gantt.min.js"></script><br />

<br />
Model de date:<br />
Tasks: <br />
	• ID, Title, ParentId, Start, End, Progress <br />
	• Este singurul model de date care este obligatoriu (resources, dependencies si resource assignments sunt optionale)<br />
	• Astea pot fii proiectele in sine<br />
	• Pentru a avea un proiect ca si child a unui alt proiect, ParentId = ID unui alt task<br /><br />
Dependencies:<br />
	• ID, ProdecessorId, SuccessorId, Type<br />
	• Dependintele dintre task'uri<br /><br />
Resource:<br />
	• ID, Text<br />
	• Textele pe care le punem in coloana de Progress<br /><br />
ResourceAssignment:<br />
	• Leaga Tasks de Resources <br />
	• Cand legi in Resource de un Task, titlul si toate datele lui apare pe coloana de Progress<br />
<br />
	
	
Exemplu 1:<br />
	• In acest exemplu avem doar Tasks si Dependencies<br />
	• In coloana de Subject se afla task titse, cu parents si children.<br />
	• In ultima coloana vedem titlul care se extinde pe StartDate si EndDate<br />
	• Sageata dintre Engineering and Final Blueprint si City Permits inseamna ca au un Dependency intre ele<br />
	• Aici, modelul de date este prezentat in GantData.cs, linia 856 (region Second Example).<br />
	https://github.com/FirasHomsi/PoCGantt/blob/76ba5d8f259cf977baec080df8f6f21e404ccb10/Models/Gantt/GantData.cs#L857 <br /><br />
![alt text](https://github.com/FirasHomsi/PoCGantt/blob/master/wwwroot/images/Example1.PNG?raw=true)

<br />
Exemplu 2:<br />
	• In acest exemplu avem doar Tasks, Dependencies, Resource (gri) si Resource Assignment (Ce Rresource e assigned la care Task)<br />
	• Aici, modelul de date este prezentat in GantData.cs, linia 1048 (region Third Example).<br />
	https://github.com/FirasHomsi/PoCGantt/blob/76ba5d8f259cf977baec080df8f6f21e404ccb10/Models/Gantt/GantData.cs#L1048  <br /> <br />
	
![alt text](https://github.com/FirasHomsi/PoCGantt/blob/master/wwwroot/images/Example2.PNG?raw=true)
