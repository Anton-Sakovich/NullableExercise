# NullableExercise

**NullableExercise** is a small exercise I came up with when thinking about how nullable types are integrated in .NET and
custom types integration in general.

The exercise is to implement a `struct` `AmateurNullable<T>` which will behave similarly to nullable value types in .NET.
A subtle point here is, of course, handling assignments of the form `AmateurNullable<T> foo = null`.
