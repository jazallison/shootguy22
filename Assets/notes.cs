/* 01012023
// hello welcome ot notes
put 2DCapsuleCollider on laserlaser sepcifically, not just the laser -- prevents player from shooting up the screen

//now we must figure out how to make the obstacle disappear.... and the projectiles
the projectiles are floating around the map and not despawning
ok . the guy now dies bc i made it so when the obstacle is hit, the renderer disappears. :D yay
now! figuring out how to make the walls absorb bullets lol 
spent two hours giving the gun recoil . it worked. holy shit
made it so the lasers didn't stack -- if they touch, they also destory each other

i am now going to try o kill the obstacle in multiple shots.
i made it so the hitstaken must be greater than 4 in order for him to die. he ricochets across the map like bananas
could be a mechanic . he is bug esque after all



///////////// 01022023
ok next day 
here r the goals for the day:

1. start screen w/ a play button and control menu ///!!!!!! (complete)
2. background music //////!!!! (complete)
3. make the enemy threatening in some way (maybe something to do with his bounciness.. make him hockey puck esque)
4. figure out how to upload it to itch.io
5. finish game 1
6. start on game 2?????? (hopeful)

going to be watching videos abt start screens ... hopefully we ball!!!

OK WE DID IT . here is how .

basically i was figuring out how to switch between scenes .... easier than i thought it was :D

had an issue w figuring out why the script wasn't working for the buttons -- they just had to be attached to the canvas

i watched this video abt it :  https://www.youtube.com/watch?v=8kVeDbuqokU

was very straightforward and helpful . thank u zenva

i figured out how to make the control panel on my own, so am giving myself a pat on the back for that ^^

i'm excited now that i can make levels!!!!! woo hoo!!!!!



##############


up next is background music lol


ok that was easy lol. i put a KFC murder chicks song bc i think their music would work well for top down shooters

had a good gamer time!!! just made it so the music doesn't destroy on load . not too bad ..


##############



up next.... scary enemy!!! :D

ok so .. i made the enemy follow, but now i have run into the issue of the bullets getting stuck to the goal

it kills me instantly. not cool .

also made the bullets darker so i can see them on top of the background

need to make it so hitting the goal brings you to a congrats screen// dying brings you to a retry screen

figuring out a way to keep the mantis' spin while making sure he is an actual threat.

making it also so that shooting the goal may have consequences... or i could just make the bullets
disappear when it is shot

in generall..... the bullets r giving me issue. trying to figure out why i die when i touch the goal.
pretty sure its bc the bullets get stuck to the goal, but even when putting code to fix it, it doesn't work

we shall find a way ....



i also want to find a way to make his hitbox bigger bc it's hard to touch/hit him . same thing w the goal

OK i figured out the box collider, but his hitbox is making it so the bullets bounce back to me

enemy needs to not bounce away, but bounce around like a pinball machine. 

for game two i may make a sequel for the obstacle and the player to be p1 and p2 ... go against the goal?

when sound of the goal is finished playing, id like to take it to a congrats screen:D

testinggithub commit rn


Actuallying testing git changes

OK !
*/ 