-> main

=== main ===
#name;Harper
The crowds are nice here, aren’t they? Doesn’t it feel freeing to be with people like you?

#you
Harper, I...

#you
I don’t think I can stay for a drink, actually. I forgot I have to head home to help my mom out with some chores.

#name;Harper
Really? I thought you wanted to get away from her for a bit?

#you
Yeah, I think it’s been long enough.

#name;Harper
Ugh, Reyes. You know you don't have to listen to her. You’re an adult, you don’t need to do everything she says.

#name;Harper
I mean, it’s not like she appreciates you anyways. The way she talks about you proves that.

#you
I wouldn’t say that… she’s just complicated.

#name;Harper
 Right.

#narrator
…

#you 
#stress;20
 Do you disagree?

#name;Harper
No, I get it. She makes you feel guilty and that’s why you’re defending her.

#you
 What? No I-

#name;Harper
See? Defending.

#you
I am defending her because she’s my MOM. She can be complicated, but I love her.

#name;Harper
Really? What about everything she’s done up until now? You really don’t think she should be held accountable for that?

#you
Yes, of course! But I’m not going to hate her when I just want her to grow…
-> arg1

===== arg1 =====

#name;Harper
You don’t need to teach her to accept you, Reyes. The people who will understand you are HERE.

#you
No, the people who understand YOU are here.

#name;Harper
What does that even <i>mean?</i>

#you
Seriously, Harper? You don't even realize...
*[that not everyone can spend $10 on a coffee.] -> arg2 
*[how mean that barista was to me.] -> arg1wrong1
*[how bad your taste is.] -> arg1wrong2

===== arg1wrong1 =====
#you
You don't even realize how mean that barista was to me.

#name;Harper
#stress;20
What are you even talking about, Reyes? That doesn't have anything to do with this.

#you
<i>Maybe that wasn't the best way to word that. Let me think about that one again...</i>
-> arg1

===== arg1wrong2 =====
#you
You don't even realize how bad your taste is.

#name;Harper
#stress;20
What are you even talking about, Reyes? That doesn't have anything to do with this.

#you
<i>Maybe that wasn't the best way to word that. Let me think about that one again...</i>
-> arg1

===== arg2 =====
#you
You don't even realize that not everyone can spend $10 on a coffee.

#name;Harper
Okay, but like, not every coffee costs that much! I just got what I wanted. You didn't need to get one if you didn't want one.

#you
Harper, that's not what the problem is. I'm saying that <i>everything</i> here costs that much. You just don't see it.

#name;Harper
It's not even that bad, Reyes. We could have gone to a cheaper cafe. We'll go to a cheaper one next time, or we'll just go somewhere else.

#you
Somewhere else isn't cheaper, either! For example...
*[Every store at the mall is a designer brand!] -> arg3
*[There aren't even any other cafes around here!] -> arg2wrong1
*[I'd have to go back home to buy food!] -> arg2wrong2

===== arg2wrong1 =====
#you
For example--there aren't even any other cafes around here!

#name;Harper
#stress;20
What are you even talking about, Reyes? That doesn't have anything to do with this.

#you
<i>Maybe that wasn't the best way to word that. Let me think about that one again...</i>
-> arg2

===== arg2wrong2 =====
#you
For example--I'd have to go back home to buy food!

#name;Harper
#stress;20
What are you even talking about, Reyes? That doesn't have anything to do with this.

#you
<i>Maybe that wasn't the best way to word that. Let me think about that one again...</i>
-> arg2

===== arg3 =====
#you
For example--every store at the mall is a designer brand!

#you
That "thrift store" you were talking about isn't even a thrift store, it's a secondhand boutique.

#name;Harper
That's like the same thing, Reyes. "Thrift" is secondhand.

#you
No, Harper, it's not. There's questions about financial accessibility, like ...
*[You don't pay $40 at a thrift store.] -> endchunk
*[Thrift stores carry different kinds of clothes.] -> arg3wrong1
*[There just aren't real thrift stores here.] -> arg3wrong2

===== arg3wrong1 =====
#you
There's questions about financial accessibility, like... thrift stores carry different kinds of clothes.

#name;Harper
#stress;20
What are you even talking about, Reyes? That doesn't have anything to do with this.

#you
<i>Maybe that wasn't the best way to word that. Let me think about that one again...</i>
-> arg3

===== arg3wrong2 =====
#you
There's questions about financial accessibility, like... there just aren't real thrift stores here.

#name;Harper
#stress;20
What are you even talking about, Reyes? That doesn't have anything to do with this.

#you
<i>Maybe that wasn't the best way to word that. Let me think about that one again...</i>
-> arg3

===== endchunk =====
#you
There's questions about financial accessibility, like... you just don't pay $40 at a thrift store.

#name;Harper
Reyes, I don't understand what you mean. Can you just calm down a bit and we can talk this over? Maybe over that drink.

#you
#stress;100
Y’know, we can just get that drink another time. I’ll see you around Harper.

#end 
->END