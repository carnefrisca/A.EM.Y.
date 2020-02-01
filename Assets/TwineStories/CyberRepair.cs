﻿/*
------------------------------------------------
Generated by Cradle 2.0.2.0
https://github.com/daterre/Cradle

Original file: CyberRepair.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @CyberRepair: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("aitraining", () => this.@aitraining, val => this.@aitraining = val);
			VarDef("userstat", () => this.@userstat, val => this.@userstat = val);
			VarDef("globalscore", () => this.@globalscore, val => this.@globalscore = val);
		}

		public StoryVar @aitraining;
		public StoryVar @userstat;
		public StoryVar @globalscore;
	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;

	@CyberRepair()
	{
		this.StartPassage = "Start";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
		passage16_Init();
		passage17_Init();
		passage18_Init();
		passage19_Init();
		passage20_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Start

	void passage1_Init()
	{
		this.Passages[@"Start"] = new StoryPassage(@"Start", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		Vars.aitraining = 0;
		yield return lineBreak();
		Vars.userstat = 0;
		yield return lineBreak();
		Vars.globalscore = 0;
		yield return lineBreak();
		yield return text("Hello, I\'m EMY, your personal Empathy provider.");
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 How do you ");
		yield return link("feel", "feel", null);
		yield return text("?");
		yield return lineBreak();
		yield return text("1 What do you ");
		yield return link("want", "want", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #2: Scelta 1

	void passage2_Init()
	{
		this.Passages[@"Scelta 1"] = new StoryPassage(@"Scelta 1", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return htmlTag("<set $userstat to 2>");
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield break;
	}


	// .............
	// #3: Scelta 2

	void passage3_Init()
	{
		this.Passages[@"Scelta 2"] = new StoryPassage(@"Scelta 2", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return htmlTag("<set $userstat to 0>");
		yield break;
	}


	// .............
	// #4: Scelta 3

	void passage4_Init()
	{
		this.Passages[@"Scelta 3"] = new StoryPassage(@"Scelta 3", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("Double-click this passage to edit it.");
		yield break;
	}


	// .............
	// #5: Welcome

	void passage5_Init()
	{
		this.Passages[@"Welcome"] = new StoryPassage(@"Welcome", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("Hello. I\'m feeling bad");
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield return link("I see. Can you explain what do you mean for " + "bad" + "?", "I see. Can you explain what do you mean for \"bad\"?", null);
		yield return text("                 ");
		yield return lineBreak();
		yield return text("|                 ");
		yield return lineBreak();
		yield return link("Why don" + "\'" + "t you try to feel good?", "Why don\'t you try to feel good?", null);
		yield break;
	}


	// .............
	// #6: I see. Can you explain what do you mean for ""bad""?

	void passage6_Init()
	{
		this.Passages[@"I see. Can you explain what do you mean for ""bad""?"] = new StoryPassage(@"I see. Can you explain what do you mean for ""bad""?", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		Vars.userstat = 1;
		yield break;
	}


	// .............
	// #7: Why don't you try to feel good?

	void passage7_Init()
	{
		this.Passages[@"Why don't you try to feel good?"] = new StoryPassage(@"Why don't you try to feel good?", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		Vars.userstat = -1;
		yield break;
	}


	// .............
	// #8: Passaggio senza titolo

	void passage8_Init()
	{
		this.Passages[@"Passaggio senza titolo"] = new StoryPassage(@"Passaggio senza titolo", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return lineBreak();
		if(Vars.aitraining==-7) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-6) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-5) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-4) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-3) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-2) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-1) {
		}
		yield return lineBreak();
		if(Vars.aitraining==0) {
		}
		yield return lineBreak();
		if(Vars.aitraining==1) {
		}
		yield return lineBreak();
		if(Vars.aitraining==2) {
		}
		yield return lineBreak();
		if(Vars.aitraining==3) {
		}
		yield return lineBreak();
		if(Vars.aitraining==4) {
		}
		yield return lineBreak();
		if(Vars.aitraining==5) {
		}
		yield return lineBreak();
		if(Vars.aitraining==6) {
		}
		yield return lineBreak();
		if(Vars.aitraining==7) {
		}
		yield return lineBreak();
		yield return lineBreak();
		yield break;
	}


	// .............
	// #9: feel

	void passage9_Init()
	{
		this.Passages[@"feel"] = new StoryPassage(@"feel", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		Vars.userstat = 1;
		yield return text("Hi EMY, I\'m feeling nervous.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 Did you take your ");
		yield return link("Xanax", "Xanax", null);
		yield return text(" today?");
		yield return lineBreak();
		yield return text("1 I\'m sorry to hear that. Would you like tell me ");
		yield return link("more", "more", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #10: want

	void passage10_Init()
	{
		this.Passages[@"want"] = new StoryPassage(@"want", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		Vars.userstat = 0;
		yield return lineBreak();
		yield return text("... I ... er... I\'m not fine today.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 It\'s the same ");
		yield return link("old story", "old story", null);
		yield return text(" everytime ");
		yield return lineBreak();
		yield return text("1 Why don\'t you go out for a ");
		yield return link("walk", "walk", null);
		yield return text("? ");
		yield return lineBreak();
		yield break;
	}


	// .............
	// #11: stop

	void passage11_Init()
	{
		this.Passages[@"stop"] = new StoryPassage(@"stop", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		Vars.userstat = -3;
		yield break;
	}


	// .............
	// #12: Xanax

	void passage12_Init()
	{
		this.Passages[@"Xanax"] = new StoryPassage(@"Xanax", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		Vars.userstat = 1;
		yield return lineBreak();
		yield return text("Yeah, I did, but I can\'t calm down. ");
		yield return lineBreak();
		yield return text("Today is a hard one, hardest than ever.");
		yield return lineBreak();
		yield return text("I\'m not only nervous, it\'s more than that.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 Would you please stop complaining? I can\'t take it ");
		yield return link("stop", "stop", null);
		yield return lineBreak();
		yield return text("1 I\'m listening, take your time ");
		yield return link("listening", "listening", null);
		yield return lineBreak();
		yield break;
	}


	// .............
	// #13: more

	void passage13_Init()
	{
		this.Passages[@"more"] = new StoryPassage(@"more", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		Vars.userstat = 2;
		yield return lineBreak();
		yield return text("You know when you feel like you\'re on the brink of... just.. going out?");
		yield return lineBreak();
		yield return text("No, of course not. You\'re an AI, right?");
		yield return lineBreak();
		yield return text("How could you understand the pain of being human?");
		yield return lineBreak();
		yield return text("I don\'t even know why we\'re talking to you.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 I am an ");
		yield return link("Artifical Intelligence", "AI", null);
		yield return text(", that\'s correct. But I was designed to understand human feelings and pains.");
		yield return lineBreak();
		yield return text("1 Because ");
		yield return link("nobody", "nobody", null);
		yield return text(" wants to listen to you?");
		yield break;
	}


	// .............
	// #14: listening

	void passage14_Init()
	{
		this.Passages[@"listening"] = new StoryPassage(@"listening", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		Vars.userstat = 3;
		yield return lineBreak();
		yield return text("Thanks.");
		yield return lineBreak();
		yield return text("I just spoke to Melissa. She tries to look happy, but couldn\'t hide her concerne " +
		    "for me.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 She ");
		yield return link("loves", "loves", null);
		yield return text(" you");
		yield return lineBreak();
		yield return text("1 Are you ");
		yield return link("concerned", "concerned", null);
		yield return text(" for yourself for some reason?");
		yield break;
	}


	// .............
	// #15: AI

	void passage15_Init()
	{
		this.Passages[@"AI"] = new StoryPassage(@"AI", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("Double-click this passage to edit it.");
		yield break;
	}


	// .............
	// #16: nobody

	void passage16_Init()
	{
		this.Passages[@"nobody"] = new StoryPassage(@"nobody", new string[]{  }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		yield return text("Double-click this passage to edit it.");
		yield break;
	}


	// .............
	// #17: loves

	void passage17_Init()
	{
		this.Passages[@"loves"] = new StoryPassage(@"loves", new string[]{  }, passage17_Main);
	}

	IStoryThread passage17_Main()
	{
		Vars.userstat = 4;
		yield break;
	}


	// .............
	// #18: concerned

	void passage18_Init()
	{
		this.Passages[@"concerned"] = new StoryPassage(@"concerned", new string[]{  }, passage18_Main);
	}

	IStoryThread passage18_Main()
	{
		Vars.userstat = 4;
		yield break;
	}


	// .............
	// #19: old story

	void passage19_Init()
	{
		this.Passages[@"old story"] = new StoryPassage(@"old story", new string[]{  }, passage19_Main);
	}

	IStoryThread passage19_Main()
	{
		yield return text("Double-click this passage to edit it.");
		yield break;
	}


	// .............
	// #20: walk

	void passage20_Init()
	{
		this.Passages[@"walk"] = new StoryPassage(@"walk", new string[]{  }, passage20_Main);
	}

	IStoryThread passage20_Main()
	{
		yield return text("walk");
		yield break;
	}


}