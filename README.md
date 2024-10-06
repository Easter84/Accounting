# Accounting

This application is a simple to use accounting application, it has three tabs one for tracking bills, one for income and
the last one is a ledger to keep a running balance. It will be more involved as I add new features to it. The database
schema I am using is found below.

CREATE TABLE income(
income_id INTEGER PRIMARY KEY,
income_source TEXT NOT NULL,
pay_date TEXT NOT NULL
, income_amount REAL NOT NULL);

CREATE TABLE IF NOT EXISTS "debtors" (
debtor_id INTEGER PRIMARY KEY AUTOINCREMENT,
debtor_name TEXT NOT NULL,
amount_due REAL NOT NULL,
is_paid BOOLEAN DEFAULT 0, due_date TEXT);


CREATE TABLE ledger (
id INTEGER PRIMARY KEY AUTOINCREMENT,
trans_date TEXT NOT NULL,
payment REAL NOT NULL,
balance REAL NOT NULL,
debtor_id INTEGER,
income_id INTEGER,
FOREIGN KEY (debtor_id) REFERENCES debtors(debtor_id),
FOREIGN KEY (income_id) REFERENCES income(income_id)
);