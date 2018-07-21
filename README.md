# Runner
This is a simple Windows User Mode Installer Exploit.

It's the first version and depends on .NET 4.6.1 (I intend to remove that dependency in future versions).

At this version what it does is:
  1) Unzip a file named prog_c.min (just zipped file renamed with .min extension) deep inside the user's profile;
  2) Creates a Scheduled Task to trigger an executable thats suppose to be inside your "prog_c.min" that was extracted in the       user's profile.
  
Both steps don't need elevation and must be run in user's context.  

The original version of this installer was to run a cryptominer software when the user was idle for more than 20 minutes, that's why the scheduled task is configured that way.

The executable itself is 

I removed the original cryptominer since the intension here is just hold the installer and study how Window's User Mode can be explored by creating scheduled tasks and moving files.
