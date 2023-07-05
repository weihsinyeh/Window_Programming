/*SELECT*FROM 書目 WHERE 作者 = '蘇珊'
SELECT*FROM 書目 WHERE 定價 < 500 =
SELECT*FROM 書目, 出版者 WHERE 書目.書商 = 出版者.編號
SELECT*FROM 書目, 出版者 WHERE 書目.書商 = 出版者.編號 AND
SELECT 書目.書名 FROM 書目, 出版者 WHERE 書目.書商 = 出版者.編號 
AND 書目.定價<600 AND 出版者.編號 = 'P01'
SELECT DISTINCT 書商 FROM 書目*/
INSERT INTO 書目(書號,書名,作者,書商,定價) VALUES ('A008','Halibote7','J.K.Rowling','P01',799);