<div id="top"></div>

<p align="center">
  <img src="https://drive.google.com/uc?id=1L00sKMFfUUAtHrH9yGR09kqQf0reIthe">
</p>

## Desktop Application Development Overview

In this project, our objective is to develop a Windows Platform Desktop Application centered around the sale of tea beverages for employee use. The application simulates the operations of a tea drinks café named 'SLAY TEA', facilitating the process of receiving orders from customers. Employees are assigned the role of interacting with the on-screen interface, allowing them to edit, add, and delete items in accordance with customer orders. Once the order is finalized, the relevant information is stored in the database. Furthermore, the application provides employees with the ability to review order records, enabling them to track the number of orders sold each day. 

## Development tools  
- ### Visual Studio 2022:
  will be utilized to develop a Windows Platform Desktop Application with a graphical user interface (GUI) intended to run on the Windows platform. This application will incorporate various forms, including a login form, a main form (featuring the drink selection page), a confirmation form, and an order record form. 
- ### SQL Server Management Studio (SSMS):
  was employed to establish an SQL database integral to this project, housing two pivotal tables: 'tb_orderDetail' and 
'tb_userLogin'. The creation of this SQL database was facilitated through Microsoft Azure, adopting the Free - General Purpose - Serverless: Gen5, 2 vCores plan, with the designated server named 'np341.database.windows.net. 
 
## Programming Language and Frameworks 
This project has been developed using Visual Studio 2022 to create a Windows Platform Desktop Application, employing .NET Framework 4.7.2 and the C# programming language. The project is built upon the Windows Forms App .NET Framework template. 

## Application Logic and Functionality 
Firstly, this project begins by executing the program.cs class, which, in turn, launches the login page form (frmLogin). Users are prompted to select a username from a combo box populated with values retrieved from the 'user' table in the database (tb_userLogin). Subsequently, users input a six-digit PIN by clicking number buttons. Each button press triggers the CheckPIN() function to verify the entered PIN. Upon completing the six digits, the Login() function is invoked to validate the username and password. If the credentials are correct, the main form (frmMain) becomes visible. 

Next, the user proceeds to select options within the main form, such as tea, topping, ice, sugar, and discount. Each option reveal additional sub-options. For instance, selecting the "Tea" option may unveil sub-options like Milk Tea, Thai Tea, Lemon Tea, etc. Upon choosing sub-options, they are displayed in the data grid view on the screen, representing stored data in a data table. Users can utilize the "Add" button to append a new drink, invoking the AddOrderDetail() function to generate a new row in the data table. Conversely, clicking the "Remove" button will removing the last row in the data table. The "Clear" button resets the data table, returning to the first row. Subsequently, clicking the "Confirm" button transitions the user to the confirmation form (frmConfirm). 

Thirdly, within the confirmation form, the data table from the main form is presented once again in a data grid view. Any rows not featuring the selection of the 'Tea' option will be removed from the data table. Additionally, the Calculation() function is employed to compute the price and total for each row. This function calculates the price by combining the tea price with the topping price, and then determines the total by factoring in any applicable discount. Subsequently, upon clicking the "Confirm" button, a call is made to the SQL Database to insert these data entries. A dialog box is displayed to inform the user that the data has been successfully inserted into the database. 

Finally, clicking the  <img src="https://drive.google.com/uc?id=1qPgmgOiLcOmbwsGLyd0v7usPZzKC-673" width="30" height="30">  button in the main form will open the order record form (frmRecord), presenting the order details stored in the database. This information is retrieved from the view table (v_orderDetail) through the Search() function. Furthermore, the order record form includes search criteria to enable the user to filter the data table as needed.  

## Testing and Quality Assurance 
When the application is launched, the initial step involves opening the login page. Users are prompted to select a username and enter a PIN to proceed to the subsequent form.

<p align="center"><img src="https://drive.google.com/uc?id=1Bvf9KeBmRD1INyYccl14vOAem-wRK41K" width="300" height="400"><img src="https://drive.google.com/uc?id=1XbL1BRCfH9MCrBxKkDTLMuBqT2CT1Drl" width="300" height="400"><br />
<b>Figure 1:</b> Login page  &  <b>Figure 2:</b>Login page (choose user)
</p>

If the user enters an incorrect PIN, a message box will appear, and the system will reset,
prompting the user to re-enter the correct PIN.

<p align="center"><img src="https://drive.google.com/uc?id=1RnOqB2kMJseerie34R24ZULLPKUuutTR" width="300" height="400"><br /> 
<b>Figure 3:</b> Login page (enters an incorrect PIN)</p>

If the user enters the correct PIN, the application will proceed to the tea selection page. On
the right side, various options are presented, each displaying available choices. Users can
select their preferences, and the chosen options will be added to the data table.

<p align="center"><img src="https://drive.google.com/uc?id=1IuctWpxxEW8GMO125OBnsYPDAGmWhRhp" width="500" height="350"><br /> 
<b>Figure 4:</b> Main page</p>
<p align="center"><img src="https://drive.google.com/uc?id=1aNTgGvJufLfxAzJFKa3pyIbc_2uMkc57" width="500" height="350"><br /> 
<b>Figure 5:</b> Main page (Tea option)</p>
<p align="center"><img src="https://drive.google.com/uc?id=1-b6xV4NoEezK3pilm0BK4dCUoKG4El8B" width="500" height="350"><br /> 
<b>Figure 6:</b> Main page (Topping option)</p>
<p align="center"><img src="https://drive.google.com/uc?id=1XqIV7XRT8GswsLDcXj0T8lywUq_6zYi5" width="500" height="350"><br /> 
<b>Figure 7:</b> Main page (Ice option)</p>
<p align="center"><img src="https://drive.google.com/uc?id=1f0NnwNDNjf7tMtpPVRLEtpw6Y4NYBVuK" width="500" height="350"><br /> 
<b>Figure 8:</b> Main page (Sugar option)</p>
<p align="center"><img src="https://drive.google.com/uc?id=12HhtRMhcv89LyS5Ymiqjaz--L8BXvTAv" width="500" height="350"><br /> 
<b>Figure 9:</b> Main page (Discount option)</p>

This page can also add, delete, and clear the order by click Add, Remove, and Cancel button.

<p align="center"><img src="https://drive.google.com/uc?id=1c9bKHQA_NnOjQYGlmr9yNmzlMvsVrJIT" width="500" height="350"><br /> 
<b>Figure 10:</b> Main page (click ‘Add’ button)</p>

<p align="center"><img src="https://drive.google.com/uc?id=1vYKfK7P55GUoLGdxdFYTjMmYgypfVFhE" width="500" height="350"><br /> 
<b>Figure 11:</b> Main page (click ‘Remove’ button)</p>

<p align="center"><img src="https://drive.google.com/uc?id=1uYVfRQSiHu2tpuUaSk7sMHMo66qO2ZcX" width="500" height="350"><br /> 
<b>Figure 12:</b> Main page (click ‘Cancel’ button)</p>

If the user wishes to confirm the order, they can simply click on the 'Confirm' button on the
screen. This action will open the confirmation form, where the application will calculate the
price and total for the specified orders.

<p align="center"><img src="https://drive.google.com/uc?id=1ny-ckzWPQoFm_0pM2MoVf2tX0pFnJuIv" width="500" height="350"><br /> 
<b>Figure 13:</b> Confirmation page</p>

When user already check the order, just click to confirm button, and the order will insert in
database. Then this form will be close and refresh the order again.

<p align="center"><img src="https://drive.google.com/uc?id=1nUmloU_GxyHJaxz69YZMcDBqiBnVyR_9" width="500" height="350"><br /> 
<b>Figure 14:</b> Confirmation page (click ‘Confirm’ button)</p>

User can click <img src="https://drive.google.com/uc?id=1qPgmgOiLcOmbwsGLyd0v7usPZzKC-673" width="30" height="30"> button on the main form to open order record. There are show the orders
in per day, and user can fill into the search criteria to filter the order and click to “Search”
button.

<p align="center"><img src="https://drive.google.com/uc?id=1egtZqx-z3ap0XQWljrnLma5mC0lVXTgi" width="500" height="350"><br /> 
<b>Figure 15:</b> Order record page</p>

If user would like to logout, they can close the main form, then there will come back to login
page again.

<p align="center"><img src="https://drive.google.com/uc?id=1S86jAZKz92cygVW5ieRgKTdrMom-_2eI" width="150" height="100"><br /> 
<b>Figure 16:</b> Close the program to logout</p>

## Deployment and Distribution
This project has been published into a setup file. Users can install the application from the
setup file, and it will run seamlessly on the Windows platform.

## Security and Data Protection 
The security protocol implemented in this project revolves around the login page, ensuring that only users with existing usernames in the database can gain access to the main form. 
 
## Case Studies and Examples 
This project is designed for use by both employees and managers of the Slay Tea café. 
Employees, for instance, utilize the application to input customer orders received at the café. Their role involves entering the orders into the application for the calculation of the total price and subsequent recording in the database. Subsequently, managers can log in to access the order records and track the total number of orders sold. 
 
## Conclusion 
The Slay Tea project has been developed as a Windows Platform Desktop Application designed to run seamlessly on the Windows platform. It utilizes SQL Server to manage and store the database. The application serves the tea café, providing functionality for employees and managers to efficiently manage and calculate total prices. Additionally, users can access and view order records within the application. 
 
## Future Trends and Challenges 
In the future, this project has the potential for additional features. For instance, users may have the ability to add more sub-options for tea and toppings. Furthermore, there could be an option to edit orders within the order record. 
