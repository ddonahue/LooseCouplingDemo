# LooseCouplingDemo

This code is part of a demo for my Cohesion and Coupling: They Keys To Changing Your Code With Confidence conference talk.

To play through the demo:
1) Clone the repository.
2) Go back to the first commit.
3) Incrementally move forward by one commit until you're back to latest.

Commit #1: Initial solution
Commit #2: Adds interface to decrease coupling on concrete types.
Commit #3: Splits interface to further decrease coupling on methods which are unused.
Commit #4: Invert dependencies by moving interfaces to consumers' projects rather than implementer's project.
Commit #5: Separate package that is logically cohesive into two functionally cohesive packages.
Commit #6: Adds README file :)