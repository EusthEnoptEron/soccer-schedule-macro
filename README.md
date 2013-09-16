soccer-schedule-macro
=====================

Macro for creating a soccer schedule in Excel.

Installation
--------------
To build your own version of the package, just switch into the `macro` folder, run `npm install` and then `node build.js`. The compilated `*.wsc` file will be created in `build`.

Use
-----
The `*.xlsm` file has two special worksheets:

1. `Konfiguration`, which allows you to set up teams, categories, and days to play on.
2. `Template`, which allows you to design the resulting spreadsheet, using placeholder variables.
