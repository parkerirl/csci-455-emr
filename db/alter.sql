-- Alter Primary Keys
-- Allergies
ALTER TABLE `emrs_csci_455`.`allergies` 
DROP FOREIGN KEY `allergies_patient_ssn_fk`;
ALTER TABLE `emrs_csci_455`.`allergies` 
ADD COLUMN `id` INT NOT NULL AUTO_INCREMENT AFTER `date_discovered`,
DROP PRIMARY KEY,
ADD PRIMARY KEY (`id`);
;

ALTER TABLE `emrs_csci_455`.`allergies` 
ADD INDEX `allergies_patient_ssn_fk_idx` (`patient_ssn` ASC) VISIBLE;
;
ALTER TABLE `emrs_csci_455`.`allergies` 
ADD CONSTRAINT `allergies_patient_ssn_fk`
  FOREIGN KEY (`patient_ssn`)
  REFERENCES `emrs_csci_455`.`patients` (`ssn`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION;

-- Emergency Contacts
ALTER TABLE `emrs_csci_455`.`emergency_contact` 
DROP FOREIGN KEY `emer_contact_patient_ssn_fk`;
ALTER TABLE `emrs_csci_455`.`emergency_contact` 
ADD COLUMN `id` INT NOT NULL AUTO_INCREMENT AFTER `phone`,
DROP PRIMARY KEY,
ADD PRIMARY KEY (`id`);
;

ALTER TABLE `emrs_csci_455`.`emergency_contact` 
ADD INDEX `emergency_contact_patient_ssn_fk_idx` (`patient_ssn` ASC) VISIBLE;
;
ALTER TABLE `emrs_csci_455`.`emergency_contact` 
ADD CONSTRAINT `emergency_contact_patient_ssn_fk`
  FOREIGN KEY (`patient_ssn`)
  REFERENCES `emrs_csci_455`.`patients` (`ssn`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION;

-- Family Medical History
ALTER TABLE `emrs_csci_455`.`family_medical_history` 
DROP FOREIGN KEY `fam_med_history_patient_ssn_fk`;
ALTER TABLE `emrs_csci_455`.`family_medical_history` 
ADD COLUMN `id` INT NOT NULL AUTO_INCREMENT AFTER `age`,
DROP PRIMARY KEY,
ADD PRIMARY KEY (`id`);
;

ALTER TABLE `emrs_csci_455`.`emergency_contact` 
ADD INDEX `fam_med_history_patient_ssn_fk_idx` (`patient_ssn` ASC) VISIBLE;
;
ALTER TABLE `emrs_csci_455`.`emergency_contact` 
ADD CONSTRAINT `fam_med_history_patient_ssn_fk`
  FOREIGN KEY (`patient_ssn`)
  REFERENCES `emrs_csci_455`.`patients` (`ssn`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION;

-- Med History
ALTER TABLE `emrs_csci_455`.`medical_history` 
DROP FOREIGN KEY `med_history_patient_ssn_fk`;
ALTER TABLE `emrs_csci_455`.`medical_history` 
ADD COLUMN `id` INT NOT NULL AUTO_INCREMENT AFTER `date`,
DROP PRIMARY KEY,
ADD PRIMARY KEY (`id`);
;

ALTER TABLE `emrs_csci_455`.`medical_history` 
ADD INDEX `med_history_patient_ssn_fk_idx` (`patient_ssn` ASC) VISIBLE;
;
ALTER TABLE `emrs_csci_455`.`medical_history` 
ADD CONSTRAINT `med_history_patient_ssn_fk`
  FOREIGN KEY (`patient_ssn`)
  REFERENCES `emrs_csci_455`.`patients` (`ssn`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION;

-- Prescriptions
ALTER TABLE `emrs_csci_455`.`prescriptions` 
DROP FOREIGN KEY `prescriptions_patient_ssn_fk`;
ALTER TABLE `emrs_csci_455`.`prescriptions` 
ADD COLUMN `id` INT NOT NULL AUTO_INCREMENT AFTER `expiration`,
DROP PRIMARY KEY,
ADD PRIMARY KEY (`id`);
;

ALTER TABLE `emrs_csci_455`.`prescriptions` 
ADD INDEX `prescriptions_patient_ssn_fk_idx` (`patient_ssn` ASC) VISIBLE;
;
ALTER TABLE `emrs_csci_455`.`prescriptions` 
ADD CONSTRAINT `prescriptions_patient_ssn_fk`
  FOREIGN KEY (`patient_ssn`)
  REFERENCES `emrs_csci_455`.`patients` (`ssn`)
  ON DELETE CASCADE
  ON UPDATE NO ACTION;

