
-> main

=== main ===
#you
Mom! I’m back!
 
#name;Carmen
 Oh, you're back. Already?

#you
Yeah, I'm not feeling that great right now.

#name;Carmen
 Did you talk to them or just deliver the food like a delivery boy?
 
 -> firstChoice
 
=== firstChoice ===

#you
I talked to them, Mom. I’m not rude.

#name;Carmen
 Mm-hm.
 
 #name;Carmen
 What's wrong with you? Why do you have that face?
 
 #you 
 I just said I'm not feeling great right now.
 
 #name;Carmen
 From what? You haven't done anything all day, hija. All you did was bring the supplies.
 
 #you
 Ugh.
 
 #name;Carmen
 Don't get an attitude with me.
 
#name;Carmen
I swear, all you know how to do is complain.

-> secondChoice

=== secondChoice ===
#name;Carmen
You never help me around the house, never ask me how I’m doing, you don’t even have a job and you complain to me about not having money. And now, I have to worry about how you dress like when you were five.

#you
That's not fair.
-> thirdChoice

=== thirdChoice ===
#you
I don’t complain about money! I told you about my student loans so I can get advice on how to pay them off.

#you
You don't even worry about me, you just want things to say about me to others.

#name;Carmen
<i>What?</i> What are you even talking about?

#you
<b>I should check my phone with the escape key if I need to remember what happened...</b>

#you
I'm saying you told Tita Andrea and Tita Angela...
*[that you think I dress horribly!] -> Titas
*[that you think I hate you!] -> initialWrong1
*[that I dropped out to spite you!] -> initialWrong2

=== initialWrong1 ===
#you
I'm saying you told Tita Andrea and Tita Angela that you think I hate you!

#name;Carmen
What are you even talking about, Reyes? I never said anything like that.

#you
#stress;20
<i>Shit, I was wrong. I need to think that one over again...</i>
-> thirdChoice

=== initialWrong2 ===
#you
I'm saying you told Tita Andrea and Tita Angela that I dropped out to spite you!

#name;Carmen
What are you even talking about, Reyes? I never said anything like that.

#you
#stress;20
<i>Shit, I was wrong. I need to think that one over again...</i>
-> thirdChoice

=== Titas ===
#you
I'm saying you told Tita Andrea and Tita Angela that you think I dress horribly!

#you
I was talking to them earlier. They told me that you told them about how I felt about clothes to embarrass me.

#you
I told you about that so that you’d keep it to yourself, but instead you tell the whole neighborhood.

#name;Carmen
I did not tell them, they asked me about you!

#name;Carmen
You’re always making me out to be bad when I’m just talking about MY child. You don’t appreciate me at all! And those Tita’s are good friends of mine, it's not like they’re strangers.

#you
Mom, none of that matters. You crossed the line, how am I supposed to trust you now?!

#name;Carmen
Reyes, I am your mother. You can’t be mad at me for talking about you.

#you
But it's more than that! You also...
*[told Don Luis I was on the market!] -> ThoseGuys
*[told Don Luis I want to move out!] -> TitasWrong1
*[told Don Luis that I'm <i>depressed!</i>] -> TitasWrong2

=== TitasWrong1 ===
#you
You also told Don Luis I want to move out!

#name;Carmen
What are you even talking about, Reyes? I never said anything like that.

#you
#stress;20
<i>Shit, I was wrong. I need to think that one over again...</i>
-> Titas

=== TitasWrong2 ===
#you
You also told Don Luis that I'm <i>depressed!</i>

#name;Carmen
What are you even talking about, Reyes? I never said anything like that.

#you
#stress;20
<i>Shit, I was wrong. I need to think that one over again...</i>
-> Titas

=== ThoseGuys ===
#you
You also told Don Luis I was on the market!

#you
I'm NOT looking for a boyfriend, and I'm NOT trying to get anyone’s attention with my appearance. Do you know how that makes me feel when I hear that?

#name;Carmen
I understand if those men made you uncomfortable, but you're <i>single</i>, mija! One of them mentioned their grandson coming to town soon, and I mentioned you <i>just in case</i> you wanted to meet him. 

#you
Mom, I’ve told you before I'm not looking for anyone right now! Why can’t you respect that? 

#name;Carmen
 Don’t talk to me like that, Reyes. After you got those terrible clothes, you dared to ask me to cut your hair, and I said no.
 
#name;Carmen
Those clothes were enough for me. I need you to have standards for what you look like, Reyes. Such terrible things you put on…

#you
 Again with my appearance! You never leave me alone! You even told Tia Maria...
 *[that I wanted to chop all my hair off!] -> Tia
 *[that I look bad without makeup!] -> ThoseGuysWrong1
 *[that I'm not skinny enough!] -> ThoseGuysWrong2
 
 === ThoseGuysWrong1 ===
 #you
 You even told Tia Maria that I look bad without makeup!
 
 #name;Carmen
What are you even talking about, Reyes? I never said anything like that.

#you
#stress;20
<i>Shit, I was wrong. I need to think that one over again...</i>
-> ThoseGuys

 === ThoseGuysWrong2 ===
 #you
 You even told Tia Maria that I'm not skinny enough!
 
 #name;Carmen
What are you even talking about, Reyes? I never said anything like that.

#you
#stress;20
<i>Shit, I was wrong. I need to think that one over again...</i>
-> ThoseGuys
 
 === Tia ===
#you
  You even told Tia Maria that I wanted to chop all my hair off!
  
#you
  I said I wanted to go mid length, not SHORT!
  
#you 
  You made me seem like a sellout! Tia even begged me not to cut it all off!

-> Continue

=== Continue ===
#name;Carmen
And she’s right, you’ll look terrible with short hair! You never listen to me when I tell you the truth!

#name;Carmen
And your feelings get hurt too easily, mija, it's ridiculous! We’re only trying to take care of you!
#end
-> END
