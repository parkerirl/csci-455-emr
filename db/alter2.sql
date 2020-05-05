--Alter foreign keys on update

ALTER TABLE `emrs_csci_455`.`accounts` 
DROP FOREIGN KEY `accounts_user_ssn_fk`;
ALTER TABLE `emrs_csci_455`.`accounts` 
ADD CONSTRAINT `accounts_user_ssn_fk`
  FOREIGN KEY (`user_ssn`)
  REFERENCES `emrs_csci_455`.`users` (`ssn`)
  ON DELETE CASCADE
  ON UPDATE CASCADE;

ALTER TABLE `emrs_csci_455`.`allergies` 
DROP FOREIGN KEY `allergies_patient_ssn_fk`;
ALTER TABLE `emrs_csci_455`.`allergies` 
ADD CONSTRAINT `allergies_patient_ssn_fk`
  FOREIGN KEY (`patient_ssn`)
  REFERENCES `emrs_csci_455`.`patients` (`ssn`)
  ON DELETE CASCADE
  ON UPDATE CASCADE;

ALTER TABLE `emrs_csci_455`.`emergency_contact` 
DROP FOREIGN KEY `emergency_contact_patient_ssn_fk`;
ALTER TABLE `emrs_csci_455`.`emergency_contact` 
ADD CONSTRAINT `emergency_contact_patient_ssn_fk`
  FOREIGN KEY (`patient_ssn`)
  REFERENCES `emrs_csci_455`.`patients` (`ssn`)
  ON DELETE CASCADE
  ON UPDATE CASCADE;

ALTER TABLE `emrs_csci_455`.`family_medical_history` 
DROP FOREIGN KEY `fam_med_history_patient_ssn_fk`;
ALTER TABLE `emrs_csci_455`.`family_medical_history` 
ADD CONSTRAINT `fam_med_history_patient_ssn_fk`
  FOREIGN KEY (`patient_ssn`)
  REFERENCES `emrs_csci_455`.`patients` (`ssn`)
  ON DELETE CASCADE
  ON UPDATE CASCADE;

ALTER TABLE `emrs_csci_455`.`medical_history` 
DROP FOREIGN KEY `med_history_patient_ssn_fk`;
ALTER TABLE `emrs_csci_455`.`medical_history` 
ADD CONSTRAINT `med_history_patient_ssn_fk`
  FOREIGN KEY (`patient_ssn`)
  REFERENCES `emrs_csci_455`.`patients` (`ssn`)
  ON DELETE CASCADE
  ON UPDATE CASCADE;

ALTER TABLE `emrs_csci_455`.`prescriptions` 
DROP FOREIGN KEY `prescriptions_patient_ssn_fk`;
ALTER TABLE `emrs_csci_455`.`prescriptions` 
ADD CONSTRAINT `prescriptions_patient_ssn_fk`
  FOREIGN KEY (`patient_ssn`)
  REFERENCES `emrs_csci_455`.`patients` (`ssn`)
  ON DELETE CASCADE
  ON UPDATE CASCADE;
