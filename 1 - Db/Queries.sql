USE CartaSur;

SELECT TOP 1 CONVERT(DATE, Fecha_venta) as Fecha
FROM Ventas
GROUP BY CONVERT(DATE, Fecha_venta)
ORDER BY SUM(Cantidad) DESC;
