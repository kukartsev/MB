
CREATE TABLE ITEMS
(
    [ID] INT IDENTITY (1,1) PRIMARY KEY,
    [DESCRIPTION] NVARCHAR(100)
);

CREATE TABLE CATEGORIES
(
    [ID] INT IDENTITY (1,1) PRIMARY KEY,
    [DESCRIPTION] NVARCHAR(100)
);

CREATE TABLE ITEMCATEGORY
(
    ITEMID INT,
    CATEGORYID INT,
    PRIMARY KEY (ITEMID, CATEGORYID)
);

insert into ITEMS values
('Red apple'),
('Green apple'),
('Milk'),
('Yogurt'),
('Cola 0.5L'),
('Still water 0.5L'),
('Still water 1L'),
('Sandwich'),
('Bread')

insert into CATEGORIES values
('Diary'),
('Milk'),
('Cold Drinks'),
('Hot Drinks'),
('Fruits')

insert into ITEMCATEGORY values
(1,5),
(2,5),
(3,1),
(3,2),
(4,1),
(5,3),
(6,3),
(7,3)

SELECT I.DESCRIPTION, C.DESCRIPTION
FROM ITEMS I 
	LEFT JOIN ITEMCATEGORY IC ON I.ID=IC.ITEMID
	LEFT JOIN CATEGORIES C ON IC.CATEGORYID=C.ID