# LittleAlchemy
 The set of C# scripts for Brandon's Little Alchemy Unity project.

## Notes

Canvas > Scroll > Content > Content [4 buttons]

Q: ButtonActivation.cs:7 field initialized to Content (see above)

Errors coming from:
When string returned from `OnCollisionEnter2D()`:

"NO RETURN TAG PROVIDED" = Not touching anything
"EMPTY STRING" = Touching but not combining (reasons unknown)