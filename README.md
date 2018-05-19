# LooseCouplingDemo

This code is part of a demo for conference talk titled "Cohesion and Coupling: They Keys To Changing Your Code With Confidence.

What follows is the list of relevant git commit hashes to follow each step of the demo, along with notes briefly explaining the changes and how they improved the solution.

* 4f1e8b70b8165bf44e8a3a70cd225807630d4206: Initial solution
* 72a5dd029e0c2678cdacf5e6c66600d7921d2e3a: Adds IInstrument interface to decrease coupling on concrete types in RockBand and Roadie.
* 045d07f233214e90bbf92ec700d7655af586608e: Following the Interface Segregation Principle, splits IInstrument interface into two - IPlayable and IMaintainable - to further decrease coupling on methods which are unused.
* 14f348c71f8cfc3e265438eecc2c96e82aa21b68: Following Dependency Inversion Principle, moves IPlayable and IMaintainable interfaces to consumers' projects rather than implementer's project.
* f2afb58b7214cfd23f0d09a74d3afba9605d60b5: Separate Instruments package that is logically cohesive into two functionally cohesive packages - one for Guitar and one for SnareDrum.

Sorry for the git commit hashes. I had a few commits between the demo commits fixing things, so you can't just advanced through the changes incrementally :/
