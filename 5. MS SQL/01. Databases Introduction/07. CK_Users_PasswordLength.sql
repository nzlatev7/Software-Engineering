ALTER TABLE Users
ADD CONSTRAINT CK_Users_PasswordLength CHECK(LEN([Password]) >= 5)

--DATALENGTH -> GET THE BYTES
--LEN -> GET THE SYMBOLS

--THE DIFFERENCE IS COMMING FROM THE ENCODING