CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_register DATE NULL,
)

SELECT * FROM users

INSERT INTO users(username, password, role, status, date_register) VALUES('admin', 'admin123', 'Admin', 'Active', '2025-04-24')

CREATE TABLE rooms
(
	id INT PRIMARY KEY IDENTITY(1,1),
	room_id VARCHAR(MAX) NULL,
	type VARCHAR(MAX) NULL,
	room_name VARCHAR(MAX) NULL,
	price FLOAT NULL,
	image_path VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_register DATE NULL,
	date_update DATE NULL,
	date_delete DATE NULL,	

)

SELECT * FROM rooms

SELECT * FROM rooms WHERE date_delete  IS NULL

CREATE TABLE customer
(
	id INT PRIMARY KEY IDENTITY(1,1),
	book_id VARCHAR(MAX) NULL,
	full_name VARCHAR(MAX) NULL,
	email VARCHAR(MAX) NULL,
	contact VARCHAR(MAX) NULL,
	gender VARCHAR(MAX) NULL,
	address VARCHAR(MAX) NULL,
	room_id VARCHAR(MAX) NULL,
	price DECIMAL NULL,
	status_payment VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_from DATE NULL,
	date_to DATE NULL,
	date_book DATE NULL,
)

SELECT * FROM customer

DROP TABLE customer

SELECT COUNT(id) FROM users WHERE role = 'staff'

SELECT COUNT(id) FROM rooms WHERE status = 'Active' OR status = 'Available'

SELECT SUM(price) FROM customer