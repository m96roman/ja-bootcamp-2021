Use BootcampTraining

SELECT SUM(Price) AS TotalProductSum FROM Payment 

SELECT COUNT(PaymentProduct.productid) AS CountOfProductsPerPaiment, Payment.price AS PaymentPrice, payment.id AS PaymentID
FROM Product
INNER JOIN PaymentProduct ON Product.id = PaymentProduct.productid
INNER JOIN Payment ON PaymentProduct.paymentid = payment.id
GROUP BY Payment.id, Payment.price;

SELECT COUNT(PaymentProduct.productid) AS CountOfProductsPerPaiment, Payment.price AS PaymentPrice, payment.id AS PaymentID
FROM Product
INNER JOIN PaymentProduct ON Product.id = PaymentProduct.productid
INNER JOIN Payment ON PaymentProduct.paymentid = payment.id
GROUP BY Payment.id, Payment.price
HAVING COUNT(PaymentProduct.productid) >= 2;

SELECT id, name from customer
UNION ALL
SELECT id, name from product;

SELECT Customer.id AS CustomerId, Payment.price AS PaymentPrise 
FROM Customer
LEFT JOIN Payment ON Customer.id = Payment.CustomerID
WHERE Payment.price > 10 OR Payment.price IS NULL;

