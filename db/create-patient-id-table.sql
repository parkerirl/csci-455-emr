-- Add new table to store user IDs with their SSNs.
CREATE TABLE patient_ids (id VARCHAR(7), ssn VARCHAR(11), FOREIGN KEY(ssn) REFERENCES patients(ssn) ON DELETE CASCADE);