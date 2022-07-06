# Use Jobs System to Check for Line of Sight

Learn how you can implement the jobs system to improve the performance of Line of Sight checking for your AI! 
In [this tutorial video](https://youtu.be/dHLNqbKrJdg) you'll see the comparisons of the typical ways you might see this implemented:
1. EnemyLineOfSightChecker.cs attached to each Enemy (worst performance, most likely this is what you'd start with)
2. EnemyLineOfSightManager.cs - Checking Line of Sight for all Enemies in a single Update() loop (better performance, but can be improved)
3. EnemyLineOfSightManager.cs - Checking Line of Sight via the Jobs system (best performance for large numbers of enemies!)

In this tutorial repository, all 3 methods are available for you to compare on your hardware.
You'll see that the jobs system is not a magic bullet, it solves specific problems such as tasks that can be highly parallelized. You can also use this to determine at which points the parallelization is more helpful than harmful (or just unnecessarily adds code complexity)!

[![Youtube Tutorial](./Video%20Screenshot.png)](https://youtu.be/dHLNqbKrJdg)

## Patreon Supporters
Have you been getting value out of these tutorials? Do you believe in LlamAcademy's mission of helping everyone make their game dev dream become a reality? Consider becoming a Patreon supporter and get your name added to this list, as well as other cool perks.
Head over to https://patreon.com/llamacademy to show your support.

### Phenomenal Supporter Tier
* YOUR NAME HERE!

### Tremendous Supporter Tier
* YOUR NAME HERE!

### Awesome Supporter Tier
* Andrew Bowen
* Gerald Anderson
* AudemKay
* Matt Parkin
* Ivan
* YOUR NAME HERE!

### Supporters
* Bastian
* Trey Briggs
* YOUR NAME HERE!

## Other Projects
Interested in other AI Topics in Unity, or other tutorials on Unity in general? 

* [Check out the LlamAcademy YouTube Channel](https://youtube.com/c/LlamAcademy)!
* [Check out the LlamAcademy GitHub for more projects](https://github.com/llamacademy)

## Socials
* [YouTube](https://youtube.com/c/LlamAcademy)
* [Facebook](https://facebook.com/LlamAcademyOfficial)
* [TikTok](https://www.tiktok.com/@llamacademy)
* [Twitter](https://twitter.com/TheLlamAcademy)
* [Instagram](https://www.instagram.com/llamacademy/)
* [Reddit](https://www.reddit.com/user/LlamAcademyOfficial)

## Requirements
* Requires Unity 2020.3 LTS or higher.
* [NavMesh Components](https://docs.unity3d.com/Manual/NavMesh-BuildingComponents.html). How to install this is discussed [here](https://youtu.be/aHFSDcEQuzQ).