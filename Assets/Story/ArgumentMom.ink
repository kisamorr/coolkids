
-> main

=== main ===
#you
Mom! I’m back!

#them
 ...
 
#them
 Oh, you're back. Already?

#them
 Did you talk to them or just deliver the food like a delivery boy?
 
 *[Yes] -> firstChoice
 
=== firstChoice ===

#you
I talked to them, Mom. I’m not rude.

#them
 Huff! To me you are.

*[...] -> secondChoice


=== secondChoice ===
#them
You never help me around the house, never ask me how I’m doing, you don’t even have a job and you complain to me about not having money. Now I have to worry about how you dress like when you were 5.

*[That's not fair.] -> thirdChoice

=== thirdChoice ===
#you
I don’t complain about money! I told you about my student loans so I can get advice on how to pay them off.
*[Continue] -> YouTalkAboutMe

=== YouTalkAboutMe ===
#you
You don’t even worry about me, you just want things to say about me to others.

#them
What?!

*[Tita Andrea and Tita Angela] -> Titas

*[The guys in the street] -> ThoseGuys

*[Tia Maria] -> Tia

*[Exit] -> END

=== Titas ===
#you
I was talking to Tita Andrea and Tita Angela earlier. They told me that you told them about how I felt about clothes to embarrass me.

#you
I told you about that so that you’d keep it to yourself, but instead you tell the whole neighborhood and I have kids in the street calling me names!

#them
I did not tell them, they asked me about you! And you mean the teens? Why are you letting them hurt your feelings?

#them
You’re always making me out to be bad when I’m just talking about MY child. You don’t appreciate me at all! And those Tita’s are good friends of mine, it's not like they’re strangers.

#you
Mom, none of that matters. You crossed the line, how am I supposed to trust you now?!

#them
Reyes, I am your mother. You can’t be mad at me for talking about you.

*[But there's more...] -> YouTalkAboutMe

=== ThoseGuys ===
#you
What about what you told those guys in the street?

#you
I am NOT looking for a boyfriend, and I am NOT trying to get anyone’s attention with my appearance. Do you know how that makes me feel when I hear all that?

#them
I understand if those men made you uncomfortable, but you are single mija! One of them mentioned their grandson coming to town soon and I mentioned you in case you wanted to meet him. 

#you
Mom, I’ve told you before I am not looking for anyone right now. Why can’t you respect that? 

#them
 Don’t talk to me like that, Reyes. After you got those terrible clothes, you dared to ask me to cut your hair, and I said no.
 
#them
Those clothes were enough for me. I need you to have standards for what you look like Reyes. Such terrible things you put on…

#you
 Again, with my hair...
 
 ->YouTalkAboutMe
 
 === Tia ===
#you
  Tia Maria told me you told her I want to cut it all off.
  
#you
  I said I wanted to go mid length, not SHORT!
  
#you 
  You made me seem like a sellout! Tia even begged me not to cut it all off!

-> Continue

=== Continue ===
#them
And she’s right, you’ll look terrible with short hair! You never listen to me when I tell you the truth!

#them
And your feelings get hurt too easily, mija, it's ridiculous! We’re only trying to  take care of you!

*[Storm out] -> END
