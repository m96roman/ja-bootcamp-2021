--Get total price from Payment table for all payments
SELECT SUM (Price) as PriceSum FROM Payment


--Get payment Price and count of products per payment from Payment table for all payments
SELECT pr.Price, COUNT(p.Id) as CountOfProducts FROM Payment as p
INNER JOIN Product as pr ON pr.Price = p.Price
GROUP BY pr.Price

--Get payment Price and count of products per payment from Payment table, for payments that have more than 2 products
SELECT p.Price, COUNT(pr.ProductId) as ProductCount from Payment as p
INNER JOIN Product as pr ON pr.Price = p.Price
GROUP BY p.Price
HAVING COUNT(p.Id) > 2
ORDER BY ProductCount DESC

--Union Customer and Product with result have two columns Id and Name
SELECT CustomerId, CustomerName from Customer
UNION
SELECT ProductId, Name from Product


--Get a Customer name and Payment price where there no payments or payment price is less than 10
SELECT CustomerName, p.Price from Customer
INNER JOIN Payment as p ON p.CustomerId = Customer.CustomerId
INNER JOIN PaymentProducts as pr ON pr.PaymentId = p.Id
WHERE p.Price <= 10 OR p.Id != pr.PaymentId
