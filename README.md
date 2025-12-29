# Catering Contract Calculator (WinForms)

A C# Windows Forms application that calculates the final price of a catering contract
for business events based on the selected catering company, business partner, and
contract length.

This project was built to demonstrate the use of arrays, array searching, loops,
input validation, and event-driven programming using Windows Forms.

---

## Features

- Windows Forms graphical user interface (GUI)
- ComboBox selection for catering companies and businesses
- Array-based storage for:
  - Caterer names and discount rates
  - Business names and contract prices
  - Contract length discount tiers
- Input validation using `int.TryParse`
- Dynamic calculation of percentage-based and fixed discounts
- User-friendly error handling with message boxes

---

## Business Logic Overview

- Each catering company offers a percentage discount
- Each business has a predefined contract price
- An additional fixed discount is applied based on contract length:
  - 0–1 years → $0
  - 2–4 years → $30
  - 5–7 years → $40
  - 8+ years → $50
- The final contract price is calculated as:
Final Price = Base Price − Percentage Discount − Additional Discount

## Technologies Used

- C#
- .NET Framework
- Windows Forms
- Visual Studio

## Screenshots
<img width="400" height="265" alt="Screenshot 2025-12-29 122759" src="https://github.com/user-attachments/assets/1754a953-f557-40e3-8e76-87fe281a2077" />

