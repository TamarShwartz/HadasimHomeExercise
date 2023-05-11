use CoronaStock

CREATE TABLE  customer (
  ID INTEGER PRIMARY KEY,
  first_name VARCHAR(255),
  last_name VARCHAR(255),
  address VARCHAR(255),
  city VARCHAR(255),
  house_number VARCHAR(10),
  date_of_birth DATE,
  phone VARCHAR(20),
  mobile_phone VARCHAR(20)
);



CREATE TABLE vaccines (
  ID INTEGER PRIMARY KEY,
  production_date DATE,
  manufacturer_name VARCHAR(255)
);

CREATE TABLE client_vaccine (
  ID INTEGER PRIMARY KEY,
  customer_id INTEGER,
  vaccine_id INTEGER,
  date_received DATE,
  FOREIGN KEY (customer_id) REFERENCES customer(ID),
  FOREIGN KEY (vaccine_id) REFERENCES vaccines(ID)
);

CREATE TABLE corona_tests (
  ID INTEGER PRIMARY KEY,
  customer_id INTEGER,
  vaccine_id INTEGER,
  test_date DATE,
  test_answer BIT,
  FOREIGN KEY (customer_id) REFERENCES customer(ID),
  FOREIGN KEY (vaccine_id) REFERENCES customer(ID)
);
