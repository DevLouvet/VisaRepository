# Card Validation API

Configuration :

Sql :
- Execute all sql scripts

Api :
- Modify the connectionstring in appsettings.json

Test :
- Modify the connectionstring in CardTest

Input :
- CardNumber
- ExpirationDate

Output :
- Card Type
- Result

Rules :

1. Card Number (Numeric 15 or 16 digits)
2. Expiry date (MMYYYY)
Validate Result
1. Result (Valid, Invalid, Does not exist)
2. Card Type (Visa, Master, Amex, JCB or Unknown)
Validation Rule
1. Visa is a card number starting with 4.
2. MasterCard is a card number starting with 5.
3. Amex is a card number starting with 34, 37.
4. JCB is a card number starting with 3528–3589.
5. The card starting with any other numbers is “Unknown”.
6. Only Amex card number has 15 digits, the rest of card types have 16 digits.
7. A valid Visa card is the card number where expiry year is a leap year.
8. A valid MasterCard card is the card number where expiry year is a prime number.
9. Every JCB card is valid.
10. If a card number does not exist in the database, it should return “Does not exist".
11. The rest case is “Invalid” card.
