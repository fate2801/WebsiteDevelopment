# Renting a Supercar

## Project Summary

**Renting a Supercar** is a web-based application developed using ASP.NET Razor Pages, designed to simulate a supercar rental service with optional add-ons and validation logic. This project was completed in two stages as part of an Object-Oriented Programming module.

---

## Stage 1 Highlights

- Basic rental form that captures user name, contact number, and driving licence status.
- Optional add-ons like insurance and an additional driver.
- Simple cost calculation based on user selections.
- Displays customer and order details with the total rental cost.
- UI elements used: TextBox, Button, RadioButton, CheckBox.

---

## Stage 2 Enhancements

- Extended form to include:
  - Selection of supercar model with images.
  - Color selection from a dropdown list.
  - Pick-up date and time input with validation (must be at least 2 days in advance).
  - Additional add-on: Collision Damage Waiver (CDW).
  - Display of rental rules (e.g., no pets, no smoking).
- Full form validation with error messages for missing or invalid inputs.
- Detailed cost breakdown based on selected car and add-ons.
- UI features used: TextBox, Button, RadioButton, CheckBox, Image, DateTime input, Table, Validation, Razor Syntax.

---

## Technologies Used

- ASP.NET Razor Pages (C#)
- HTML/CSS
- Basic client-side validation

---

## How It Works

1. Users navigate to the home page and select "Rent A Supercar."
2. They fill in personal details, choose a car, pick a color, and select any optional add-ons.
3. The system validates the form, calculates the cost, and displays a summary of the order.
4. Validation ensures all required information is filled, and that the pick-up time meets the policy requirement.
