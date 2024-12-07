Desktop Application Development Overview

In this project, our objective is to develop a Windows Platform Desktop Application centered around the sale of tea beverages for employee use. The application simulates the operations of a tea drinks café named 'SLAY TEA', facilitating the process of receiving orders from customers. Employees are assigned the role of interacting with the on-screen interface, allowing them to edit, add, and delete items in accordance with customer orders. Once the order is finalized, the relevant information is stored in the database. Furthermore, the application provides employees with the ability to review order records, enabling them to track the number of orders sold each day. 

Development tools  
•	Visual Studio 2022: will be utilized to develop a Windows Platform Desktop Application with a graphical user interface (GUI) intended to run on the Windows platform. This application will incorporate various forms, including a login form, a main form (featuring the drink selection page), a confirmation form, and an order record form. 
•	SQL Server Management Studio (SSMS): was employed to establish an SQL database integral to this project, housing two pivotal tables: 'tb_orderDetail' and 
'tb_userLogin'. The creation of this SQL database was facilitated through Microsoft Azure, adopting the Free - General Purpose - Serverless: Gen5, 2 vCores plan, with the designated server named 'np341.database.windows.net. 
 
Programming Language and Frameworks 
This project has been developed using Visual Studio 2022 to create a Windows Platform Desktop Application, employing .NET Framework 4.7.2 and the C# programming language. The project is built upon the Windows Forms App .NET Framework template. 

Application Logic and Functionality 
Firstly, this project begins by executing the program.cs class, which, in turn, launches the login page form (frmLogin). Users are prompted to select a username from a combo box populated with values retrieved from the 'user' table in the database (tb_userLogin). Subsequently, users input a six-digit PIN by clicking number buttons. Each button press triggers the CheckPIN() function to verify the entered PIN. Upon completing the six digits, the Login() function is invoked to validate the username and password. If the credentials are correct, the main form (frmMain) becomes visible. 
Next, the user proceeds to select options within the main form, such as tea, topping, ice, sugar, and discount. Each option reveal additional sub-options. For instance, selecting the "Tea" option may unveil sub-options like Milk Tea, Thai Tea, Lemon Tea, etc. Upon choosing sub-options, they are displayed in the data grid view on the screen, representing stored data in a data table. Users can utilize the "Add" button to append a new drink, invoking the AddOrderDetail() function to generate a new row in the data table. Conversely, clicking the "Remove" button will removing the last row in the data table. The "Clear" button resets the data table, returning to the first row. Subsequently, clicking the "Confirm" button transitions the user to the confirmation form (frmConfirm). 
Thirdly, within the confirmation form, the data table from the main form is presented once again in a data grid view. Any rows not featuring the selection of the 'Tea' option will be removed from the data table. Additionally, the Calculation() function is employed to compute the price and total for each row. This function calculates the price by combining the tea price with the topping price, and then determines the total by factoring in any applicable discount. Subsequently, upon clicking the "Confirm" button, a call is made to the SQL Database to insert these data entries. A dialog box is displayed to inform the user that the data has been successfully inserted into the database. 
Finally, clicking the    button in the main form will open the order record form (frmRecord), presenting the order details stored in the database. This information is retrieved from the view table (v_orderDetail) through the Search() function. Furthermore, the order record form includes search criteria to enable the user to filter the data table as needed.  

Security and Data Protection 
The security protocol implemented in this project revolves around the login page, ensuring that only users with existing usernames in the database can gain access to the main form. 
 
Case Studies and Examples 
This project is designed for use by both employees and managers of the Slay Tea café. 
Employees, for instance, utilize the application to input customer orders received at the café. Their role involves entering the orders into the application for the calculation of the total price and subsequent recording in the database. Subsequently, managers can log in to access the order records and track the total number of orders sold. 
 
Conclusion 
The Slay Tea project has been developed as a Windows Platform Desktop Application designed to run seamlessly on the Windows platform. It utilizes SQL Server to manage and store the database. The application serves the tea café, providing functionality for employees and managers to efficiently manage and calculate total prices. Additionally, users can access and view order records within the application. 
 
Future Trends and Challenges 
In the future, this project has the potential for additional features. For instance, users may have the ability to add more sub-options for tea and toppings. Furthermore, there could be an option to edit orders within the order record. 
