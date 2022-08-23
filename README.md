Call Stored Procedure with parameter in Entity Framework
I'm Using Northwind database for the Example:
![image](https://user-images.githubusercontent.com/26320160/186072865-aa0a2439-da01-447c-85cb-76d06252d8be.png)
![image](https://user-images.githubusercontent.com/26320160/186072945-ff9d9d0d-5389-4554-8900-304375120886.png)

//=========  PROCEDURE Script ====//</br>
CREATE PROCEDURE Customers_SearchCustomers
      @ContactName NVARCHAR(30)
AS
BEGIN
      SET NOCOUNT ON;
      SELECT TOP 10 *
      FROM Customers
      WHERE ContactName LIKE '%' + @ContactName + '%'
END
