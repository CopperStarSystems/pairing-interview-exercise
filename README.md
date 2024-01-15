# Overview

There exists a simple calculator application that accepts a delimited string argument and returns the sum of the values
as an integer.
The goal of this exercise is to enhance the application by adding some features, while reinforcing best practices such
as:

- Incremental implementation
- Test-driven development
- Clean coding

During this exercise we will work through the enhancements **sequentially**. In the interest of time, we will not focus
on input validation.

## Current State

- The application accepts input in the form of delimited strings
- Input can contain any arbitrary number of delimited fields
    - Input is formatted like so: `"1,2,3"`
    - If the input is null or an empty string, the method returns `0`
    - If the input contains only one item, the item is returned - for example, given `"4"`, the return value will be `4`
- Default supported delimiters are `,` and `\n`
- Delimiters can be combined - for example `"1,2\n3"` is valid input

## Future State

1. Enable the user to override the default delimiters
    - To override the delimiter, the user would prepend the custom delimiter to the input in this
      format: `//[custom delimiter]\n[delimited list of operands]`, for example:
      `//%\n1%2%3` overrides the default delimiter to `%` and would add the numbers 1,2, and 3
2. Throw an exception when the input contains a negative number(s)
    - The exception message should be "Negatives not allowed."
3. Include the negative number(s) in the exception message when throwing the exception
4. Track how many times the `Add()` method is called
    - Expose a `GetCalledCount()` method on the Calculator class that returns the number of times the `Add()` method was
      called
5. Raise an event when the `Add()` method is called
    - The event payload should indicate the input to the call and the result of the operation
7. Ignore inputs greater than 1000
    - Exclude any input values that are greater than 1000 when calculating the sum, for example `"1,2,1001,3"` would
      return `6`
7. Add support for multi-character custom delimiters
    - Allow the user to specify a multi-character custom delimiter, for example `//[***]\n1***2***3` would set the
      delimiter to `***` and return the sum of 1,2, and 3
8. Add support for multiple single-character custom delimiters
    - Allow the user to specify multiple single-character delimiters, for example `//[%][&]\n1&2%3` sets the delimiters
      to `%` and/or `&` and returns the sum of 1,2, and 3
9. Add support for multiple multiple-character custom delimiters
    - Depending upon how the implementation evolves, this may already be supported but the tests will need to be
      enhanced to cover this scenario
    - Also consider cases such as combinations of custom single and multiple-character delimiters, for
      example `//[***][$][DELIMITER]\n1DELIMITER2***3$4`