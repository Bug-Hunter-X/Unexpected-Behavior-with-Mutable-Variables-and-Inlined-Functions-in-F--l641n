# F# Mutable Variable Bug

This repository demonstrates a potential source of confusion when working with mutable variables and inlined functions in F#.

The `bug.fs` file contains code that showcases unexpected behavior.  The `bugSolution.fs` file provides a corrected approach.

The core issue lies in the understanding of how mutability affects function parameters, especially when inlining is involved.

## How to Reproduce

1. Clone this repository.
2. Open `bug.fs` in an F# environment.
3. Run the code. Observe the unexpected output.
4. Compare the output with the expected behavior outlined in the comments.
5. Review `bugSolution.fs` to see a corrected version and improved understanding of mutable parameters within functions.

## Learning Points

This example highlights the importance of careful consideration when using mutable variables in F#.  Understanding how parameter passing works with mutable values helps prevent subtle errors and ensures more predictable code behavior.