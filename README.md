# LittleAlchemy
 The set of C# scripts for Brandon's Little Alchemy Unity project.

## Notes

Canvas > Scroll > Content > Content [4 buttons]

Q: ButtonActivation.cs:7 field initialized to Content (see above)

Errors coming from:
When string returned from `OnCollisionEnter2D()`:

"NO RETURN TAG PROVIDED" = Not touching anything
"EMPTY STRING" = Touching but not combining (reasons unknown)

### Thu Apr 25

Starting with all buttons enabled: 

1. In GameManager.cs, add an instance field for the row of buttons and set to disabled on `Start()`

2. We could try to gather all the buttons from their container (again on `Start()`)
