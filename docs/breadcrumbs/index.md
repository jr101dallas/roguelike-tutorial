---
layout: default
---

# Plan
Pulling together breadcrumbs blathered about in the blog and other places.

## Roguelike Repo Location
The GitHub repository for this project is [here](https://github.com/jr101dallas/roguelike-tutorial)

## Skip
SadConsole and display and look  
GoRogue and location and proximity  

### Code Targets
1. combat interaction (when to attack can be filled in when proximity exists)  
   1. base attack stats and bonuses
   1. temporary bonuses
   1. <s>targeting</s>
   1. <s>misses</s> and evasion
   1. damage and damage types
   1. damage ablation and item wear
   1. fatigue, burst activity
1. <s>inventory</s> (for now I won't "show" wearing armor in the display)
  1. inventory management system for effects that happen to all items
  1. item theft
1. dialog (again, proximity later)  
   1. factions and individual reactions
   1. continuing relationships
1. skills and non-combat fun
1. locomotion
   1. type and terrain effects
   1. speed
   1. defense
   1. visibility
1. shopping (proximity later)  
1. enemies and merchants to fight and bargain with  
1. heads-up display
1. Entity stats and achievements
1. messages for lots of things that would show in Watcher
1. magic string eliminiation
1. refactoring to single purpose, etc.
1. summary component or system
1. setting random seed at startup
  1. research games that allow setting the random seed

#### Architecture Notes
* aim to deliver value, user functionality, admin functionality, think customers  
* little bites, micro stories  
* C#, mstest  
* .NET core .dlls where possible, command line to start  
* test projects for each code project  
* planning to wrap libraries in a separate project in order to keep my architecture clean, the wrapper may be ugly as a result  
* entity, component, system  
