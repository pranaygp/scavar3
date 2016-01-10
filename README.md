# scavar3

##Inspiration

We've had the idea to play a scavenger hunt using all of the cool technology available to us, but we wanted to put a cool twist on it. The multitude of logos at Hackthons and on CS Majors laptops served as a perfect, well-suited medium to play a round of awesome AR semi-virtual hunting!

## What it does

Our program leverages off of the Android version of Unity to create a multiplayer scavenger hunt to be played with the sponsor logos as the targets.

## How we built it

We built it using Vuforia and Unity- the former to render the AR interface, the latter to handle just about all of our actual game code. We also used Azure for hosting the backend server information (which allowed for multiuser support without much additional code), and interfaced it all with JSON-based HTTP requests (and a bit of duct tape, too).

## Challenges we ran into

Vuforia posed a few challenges both in its being something none of us have had experience with, and in some limitations associated with the API itself (i.e., only one model of a single type could be rendered at a given time; the comparative weakness of the Android phones kept our sense of scale in check; etc). Virtual buttons were one major stumbling block, since we were having major problems until we understood fundamentally what was wrong with our code. These issues took the longest to fix, because we could only remedy them when we had a deep intuition as to the way the code actually worked, which by nature isn't something to learn in the span of a few minutes.

## Accomplishments that we're proud of

This was our first venture into AR, and it ended up being a really awesome looking, visually-packed program!

## What I learned
That OnTrackedLost and GPS coordinates can be a replacement for virtual buttons, providing huge potential applications in our future with working with AR.

What's next for ScavAR
Expanding into payment within the app itself, and adding more awesome features like direct player-to-player interactions.
