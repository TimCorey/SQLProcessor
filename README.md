# SQL Processor #
An application that takes a SQL statement and creates an insert statement from the data returned.

## Usage ##
To use this application, simply run the EXE file. Once the application loads, it will request your SQL statement (the query that returns a set of data), the table name of the table to insert into, whether you want to include an identity insert, and finally the file you want to output this script to. Fill all of that in, hit the button and your script will be created.

## Roadmap ##
The following features/tasks need to be completed on this project:
 1. Refactor the code to make it efficient and DRY.
 2. Move the code to a class library.
 3. Upgrade the GUI to be something more pleasant.
 4. Add an intermediate step that takes the downloaded data and determines type and allows the user to select or deselect columns.
 5. Add an option to open the folder where the script is located.