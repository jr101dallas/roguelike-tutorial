---
layout: default
---

## Welcome to My Roguelike Tutorial
For a start, this will have to do. 

## Starting the Real Project...
...that I've had on my mind. I'm wanting to do a tutorial that's a little different than most of the ones I've seen. I'm going to emphasize some good habits that I don't see in a lot of tutorials. It's understandable, there's a thing that each tutorial is trying to teach and a narrow focus helps to keep the lesson clear. The point, hopefully also a clear focus in this case, will be to create a long term sustainable project that enables and encourages [momentum](https://projectmanager.com.au/managing-projects-with-momentum/).

## Tools
The following will figure prominently but are not the focus of the tutorial:
  1. [GoRogue](gorogue) 
  2. [SadConsole](sadconsole)  
  3. a bridge to make them work together [nicely](helpers), probably. 

It's important to also point out that there are tutorials out there for GoRogue and SadConsole roguelikes already. 
  1. [ansiware](ansiware)
  2. [roguelike-with-gorogue-sadconsole](mark-james)
I'll need to refresh my memory on these as I go because they've done some important work, but the main point I'm aiming for has a different focus. Yes, still aiming for functional code, but also for business methods and habits that keep code functional and keep development fast and reliable far into the future. In short, a development strategy for a business built around a coding project.

[gorogue]: https://github.com/Chris3606/GoRogue
[sadconsole]: https://sadconsole.com/
[helpers]: https://github.com/thesadrogue/SadConsole.GoRogueHelpers
[ansiware]: https://ansiware.com/
[mark-james]: https://markjames.dev/2020-05-21-making-a-roguelike-in-c-with-gorogue-sadconsole-part-one/

## Project GitHub Pages
What you see here is the product of a GitHub Project Pages repository. The settings were easier than I expected. After I already had my User GitHub Pages set up. I created a new public repository, and in the Settings > Pages section I picked the main branch and the ```/docs/``` subfolder. GitHub railroaded me into the editor with a basic template index.md and that's what I'm working on now. The settings page told me straight up that this should land at assumeforsimplicity.com/roguelike-tutorial/ which is more or less what I was hoping for. I've also added that path to the navigation on my User GitHub Pages so people can get here, but I'm pretty sure I'm going to have to fiddle a bit more to get the same navbar here and make it so you can easily traverse back. We'll see, it's only the first try so far.

UPDATE:
Copying the infrastructure files into the ```/docs``` folder in this repository just about wrapped up the change to the point of matching my User GitHub Pages code. The navbar html in the ```_includes``` folder and the navigation.yml in the data folder were about 90% of it and the paths in the navigation.yml configured with THIS ```/docs``` folder as root and the root of my User page as an external site. Maybe I'll look for a good way to just symlink or something to the infrastructure files to have only one copy but for now it works.