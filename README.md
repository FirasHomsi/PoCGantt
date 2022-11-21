	• Download DevExpress for VS here: https://docs.devexpress.com/GeneralInformation/15614/installation/download-the-net-products-installer/download-the-trial-version
	• Create a new DevExpress ASP.NET Core project
	• Install DevExpress to use Gantt and all the other functionalities: npm install devextreme@22.1 --save --save-exact
	• Add dx-gantt-min.css and dx-gantt.min.js to our pages: 
	    <link href="~/css/devextreme/dx-gantt.css" rel="stylesheet" />
	    <link href="~/css/devextreme/dx-gantt.min.css" rel="stylesheet" />
	    
	    <script src="https://cdn3.devexpress.com/jslib/21.1.5/js/dx-gantt.min.js"></script>
	    <script src="~/js/devextreme/dx-gantt.js"></script>
	    <script src="~/js/devextreme/dx-gantt.min.js"></script>


Model de date:
Tasks: 
	• ID, Title, ParentId, Start, End, Progress
	• Este singurul model de date care este obligatoriu (resources, dependencies si resource assignments sunt optionale)
	• Astea pot fii proiectele in sine
	• Pentru a avea un proiect ca si child a unui alt proiect, ParentId = ID unui alt task
Dependencies:
	• ID, ProdecessorId, SuccessorId, Type
	• Dependintele dintre task'uri
Resource:
	• 
	• Textele pe care le punem in coloana de Progress
ResourceAssignment:
	• Leaga Tasks de Resources 
	• Cand legi in Resource de un Task, titlul si toate datele lui apare pe coloana de Progress
	
	
	
Exemplu 1:



	• In acest exemplu avem doar Tasks si Dependencies
	• In coloana de Subject se afla task titlse, cu parents si children.
	• In ultima coloana vedem titlul care se extinde pe StartDate si EndDate
	• Sageata dintre Engineering and Final Blueprint si City Permits inseamna ca au un Dependency intre ele
	• Aici, modelul de date este prezentat in GantData.cs, linia 856 (region Second Example).


Exemplu 2:

	• In acest exemplu avem doar Tasks, Dependencies, Resource (gri) si Resource Assignment (Ce Rresource e assigned la care Task)
	• Aici, modelul de date este prezentat in GantData.cs, linia 1048 (region Third Example).
![image](https://user-images.githubusercontent.com/12671922/203118301-16828ad7-23ff-42fd-a23a-c30854164983.png)
